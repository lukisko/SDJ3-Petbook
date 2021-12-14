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
      status.clear();
    }
    return status;
  }
  @Override public List<Status> loadStatusOfPet(int id){
    database.beginSession();
    Query query = database.getSession().createQuery("SELECT c FROM status c WHERE pet_id = :petId");
    query.setParameter("petId",id);
    List<Status> statusList = query.getResultList();
    if(statusList != null){
      statusList.forEach(Status::clear);
    }
    return statusList;
  }

  @Override public List<Status> getAllOf(String statusName)
  {
    if(statusName == null) throw new IllegalArgumentException();
    database.beginSession();
    Query query = database.getSession().createQuery("SELECT c FROM status c WHERE name = :name");
    query.setParameter("name",statusName);
    List<Status> statusList = query.getResultList();
    if(statusList != null){
      statusList.forEach(Status::clear);
    }
    return statusList;
  }

  @Override public List<Status> loadAll()
  {
    database.beginSession();
    CriteriaQuery<Status> criteria = database.getBuilder().createQuery(Status.class);
    criteria.from(Status.class);
    List<Status> data = database.getSession().createQuery(criteria).getResultList();
    if(data != null){
      data.forEach(Status::clear);
    }
    return data;
  }

  @Override public int save(Status status)
  {
    if(status == null) throw new IllegalArgumentException();
    database.beginSession();
    database.getSession().save(status);
    database.getSession().getTransaction().commit();
    database.getSession().close();
    return status.getId();
  }

  @Override public void delete(Status status)
  {
    if(status == null || status != loadStatus(status.getId())) throw new IllegalArgumentException();
    database.beginSession();
    database.getSession().delete(status);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }

  @Override public Status update(Status status)
  {
    if(status == null || status != loadStatus(status.getId())) throw new IllegalArgumentException();
    database.beginSession();
    database.getSession().update(status);
    database.getSession().getTransaction().commit();
    database.getSession().close();
    return loadStatus(status.getId());
  }
}
