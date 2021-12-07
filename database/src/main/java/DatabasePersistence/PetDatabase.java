package DatabasePersistence;

import model.Pet;

import javax.persistence.Query;
import javax.persistence.criteria.CriteriaQuery;
import java.util.List;

public class  PetDatabase implements PetPersistance
{
  private Database database;



  public PetDatabase(){
    database = Database.getInstance();
  }



  @Override public Pet loadPet(int id)
  {
    try {
      database.beginSession();
      Pet pet = database.getSession().get(Pet.class,id);
      if(pet != null)
      {
        pet.getUser().getPets().clear();
        pet.getUser().getStatuses().clear();
        pet.getCity().getPets().clear();
        pet.getCity().getCountry().getCities().clear();
        pet.getStatuses().forEach(n -> n.setPet(null));
        pet.getStatuses().forEach(n -> n.getUser().getStatuses().clear());
        pet.getStatuses().forEach(n -> n.getUser().getPets().clear());
      }
      System.out.println(pet);
      return pet;
    }
    catch (Exception e){
      System.out.println("PetDatabase_Exception: " + e.getMessage());
      return null;
    }
  }

  @Override public List<Pet> loadAll()
  {
    database.beginSession();
    CriteriaQuery<Pet> criteria = database.getBuilder().createQuery(Pet.class);
    criteria.from(Pet.class);
    List<Pet> data = database.getSession().createQuery(criteria).getResultList();
    if(data != null)
    {
      data.forEach((n) -> n.getUser().getPets().clear());
      data.forEach((n) -> n.getUser().getStatuses().clear());
      data.forEach((n) -> n.getCity().getPets().clear());
      data.forEach((n) -> n.getCity().getCountry().getCities().clear());
      data.forEach((n) -> n.getStatuses().forEach((a) -> a.setPet(null)));
      data.forEach((n) -> n.getStatuses().forEach(a -> a.getUser().getStatuses().clear()));
      data.forEach((n) -> n.getStatuses().forEach(a -> a.getUser().getPets().clear()));
    }
    database.getSession().flush();
    return data;
  }

  @Override public List<Pet> LoadListOfUser(String email) {
    database.beginSession();
    Query query = database.getSession().createQuery("SELECT c FROM pet c WHERE user_email = :emailValue");
    query.setParameter("emailValue",email);
    List<Pet> petList = query.getResultList();
    return petList;
  }

  @Override public int save(Pet pet)
  {
    database.beginSession();
    database.getSession().save(pet);
    database.getSession().getTransaction().commit();
    database.getSession().close();
    return pet.getId();
  }

  @Override public void delete(Pet pet)
  {
    database.beginSession();
    database.getSession().delete(pet);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }
  @Override public Pet update(Pet pet)
  {
    database.beginSession();
    database.getSession().update(pet);
    database.getSession().getTransaction().commit();
    database.getSession().close();
    return pet;
  }
}
