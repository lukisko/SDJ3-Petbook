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
      status.getPet().getUser().getStatuses().clear();
      status.getPet().getCity().getCountry().getCities().clear();
      status.getPet().getCity().getPets().clear();
      status.getPet().getStatuses().clear();
      if(status.getUser() != null)
      {
        status.getUser().getStatuses().clear();
        status.getUser().getPets().clear();
      }
    }
    return status;
  }
  @Override public List<Status> loadStatusOfPet(int id){
    database.beginSession();
    Query query = database.getSession().createQuery("SELECT c FROM status c WHERE pet_id = :petId");
    query.setParameter("petId",id);
    List<Status> statusList = query.getResultList();
    if(statusList != null){
      statusList.forEach(status -> status.getPet().getUser().getPets().clear());
      statusList.forEach(status -> status.getPet().getUser().getStatuses().clear());
      statusList.forEach(status -> status.getPet().getCity().getCountry().getCities().clear());
      statusList.forEach(status -> status.getPet().getCity().getPets().clear());
      statusList.forEach(status -> status.getPet().getStatuses().clear());
      statusList.forEach(status -> {
        if(status.getUser() != null)
        {
          status.getUser().getStatuses().clear();
        }});
      statusList.forEach(status -> {
        if (status.getUser() != null)
        {
          status.getUser().getPets().clear();
        }});
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
      data.forEach(status -> status.getPet().getUser().getPets().clear());
      data.forEach(status -> status.getPet().getCity().getCountry().getCities().clear());
      data.forEach(status-> status.getPet().getCity().getCountry().getCities().clear());
      data.forEach(status -> status.getPet().getCity().getPets().clear());
      data.forEach(status -> status.getPet().getStatuses().clear());
      data.forEach(status -> {
        if(status.getUser() != null)
        {
          status.getUser().getStatuses().clear();
        }});
      data.forEach(status -> {
        if (status.getUser() != null)
        {
          status.getUser().getPets().clear();
        }});
    }
    return data;
  }

  @Override public int save(Status status)
  {
    database.beginSession();
    database.getSession().save(status);
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

  @Override public Status update(Status status)
  {
    database.beginSession();
    database.getSession().update(status);
    database.getSession().getTransaction().commit();
    database.getSession().close();
    return status;
  }
}
