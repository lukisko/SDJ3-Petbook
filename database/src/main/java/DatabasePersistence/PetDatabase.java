package DatabasePersistence;

import model.Pet;
import model.User;
import org.hibernate.Session;

import javax.persistence.Query;
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
      if(!database.getSession().isOpen()){
        database.getSession().beginTransaction();
      }
      return database.getSession().get(Pet.class,id);
    }
    catch (Exception e){
      System.out.println("PetDatabase_Exception: " + e.getMessage());
      return null;
    }
  }

  @Override public List<Pet> loadAll()
  {
    try {
      Query query = database.getSession().createQuery("SELECT c FROM pet c");
      List<Pet> petList = query.getResultList();
      return petList;
    }
    catch (Exception e){
      System.out.println("PetDatabase_Exception: " + e.getMessage());
      return null;
    }
  }

  @Override public List<Pet> LoadListOf(String email) {
    try {
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
    if(!database.getSession().isOpen()){
      database.getSession().beginTransaction();
    }

    pet.setUser(user);

    database.getSession().persist(pet);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }
}
