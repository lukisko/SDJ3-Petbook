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
      return data;
    }
    catch (Exception e){
      System.out.println("PetDatabase_Exception: " + e.getMessage());
      return null;
    }
  }

  @Override public List<Pet> LoadListOf(String email) {
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
    System.out.println(user);
    System.out.println(pet);
    database.beginSession();
    pet.setUser(user);
    database.getSession().merge(pet);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }
}
