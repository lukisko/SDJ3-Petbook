package DatabasePersistence;

import model.Pet;
import model.User;
import org.hibernate.Session;

import javax.persistence.Query;
import javax.persistence.criteria.CriteriaBuilder;
import javax.persistence.criteria.CriteriaQuery;
import java.util.ArrayList;
import java.util.List;

public class PetDatabase implements PetPersistance
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
      pet.getUser().getPets().clear();
      return pet;
    }
    catch (Exception e){
      System.out.println("PetDatabase_Exception: " + e.getMessage());
      return null;
    }
  }

  @Override public List<Pet> loadAll()
  {
    try {
      CriteriaQuery<Pet> criteria = database.getBuilder().createQuery(Pet.class);
      criteria.from(Pet.class);
      List<Pet> data = database.getSession().createQuery(criteria).getResultList();
      data.forEach((n) -> n.getUser().getPets().clear());
      return data;
    }
    catch (Exception e){
      System.out.println("PetDatabase_Exception: " + e.getMessage());
      return null;
    }
  }

  @Override public List<Pet> LoadListOfUser(String email) {
    try {
      database.beginSession();
      Query query = database.getSession().createQuery("SELECT c FROM pet c WHERE user_email = :emailValue");
      query.setParameter("emailValue",email);
      List<Pet> petList = query.getResultList();
      return petList;
    }
    catch (Exception e){
      System.out.println("PetDatabase_Exception: " + e.getMessage());
      return null;
    }
  }

  @Override public void save(User user,Pet pet)
  {
    System.out.println();
    pet.setUser(user);
    user.addPet(pet);
    System.out.println(user + "" + user.getPets());
    System.out.println(pet);
    System.out.println();
    database.beginSession();
    database.getSession().save(pet);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }

  @Override public void delete(Pet pet)
  {
    database.beginSession();
    database.getSession().delete(pet);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }
}
