package DatabasePersistence;

import model.Pet;
import model.User;

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
      Query query = database.getEntityManager().createQuery("SELECT c FROM pet c WHERE id = :idValue");
      query.setParameter("idValue",id);
      Pet pet = (Pet)query.getSingleResult();
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
      Query query = database.getEntityManager().createQuery("SELECT c FROM pet c");
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
      Query query = database.getEntityManager().createQuery("SELECT c FROM pet c WHERE user_email = :emailValue");
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
    if(!database.getEntityManager().getTransaction().isActive()) {
      database.getEntityManager().getTransaction().begin();
    }
    System.out.println(user);
//    User ss = new User();
//
//    ss.setEmail("asd");
    user.addPet(pet);
    pet.setUser(user);
    user.addPet(pet);
    database.getEntityManager().persist(pet);
    database.getEntityManager().getTransaction().commit();
  }
}
