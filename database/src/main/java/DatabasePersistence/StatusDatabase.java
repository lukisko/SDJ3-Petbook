package DatabasePersistence;

import model.Pet;
import model.Status;

import javax.persistence.Query;
import javax.persistence.criteria.CriteriaQuery;
import java.util.List;

public class StatusDatabase implements StatusPersistence
{
  private Database database;

  public StatusDatabase(){
    database = Database.getInstance();
  }
  @Override public Status loadStatus(int id)
  {
    database.beginSession();
    Status status = database.getSession().get(Status.class,id);
    if(status != null)
    {
      status.getPet().getUser().getPets().clear();
      status.getPet().getCity().getCountry().getCities().clear();
    }
    return status;
  }
  @Override public List<Status> loadStatusOfPet(int id){
    database.beginSession();
    Query query = database.getSession().createQuery("SELECT c FROM status c WHERE pet_id = :petId");
    query.setParameter("petId",id);
    List<Status> statusList = query.getResultList();
    return statusList;
  }

  @Override public List<Status> loadAll()
  {
    database.beginSession();
    CriteriaQuery<Status> criteria = database.getBuilder().createQuery(Status.class);
    criteria.from(Status.class);
    List<Status> data = database.getSession().createQuery(criteria).getResultList();
    if(data != null){
      data.forEach(n -> n.getPet().getUser().getPets().clear());
      data.forEach(n -> n.getPet().getCity().getCountry().getCities().clear());
    }
    return data;
  }

  @Override public int save(Status status)
  {
    database.beginSession();
    database.getSession().persist(status);
    database.getSession().getTransaction().commit();
    database.getSession().close();
    return status.getId();
  }

  @Override public void delete(Status status)
  {
    database.beginSession();
    database.getSession().delete(status);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }
}
