package DatabasePersistence;

import model.User;

import javax.persistence.Query;
import java.util.List;

public class UserDatabase implements UserPersistence
{

  private Database database;


  public UserDatabase(){
    database = Database.getInstance();
  }


  @Override public User loadUser(String email)
  {
    try {
      Query query = database.getEntityManager().createQuery("SELECT c FROM user c WHERE email = :value");
      query.setParameter("value",email);
      User user = (User) query.getSingleResult();
      if(user.getPets().size() > 0) {
        user.getPets().forEach((n) -> n.setUser(null));
        user.getPets().forEach((n) -> n.getCity().setPets(null));
      }
      return user;
    }
    catch (Exception e){
      System.out.println("UserDatabase_Exception: " + e.getMessage());
      return null;
    }
  }

  @Override public List<User> loadAll()
  {
    try {
      Query query = database.getEntityManager().createQuery("SELECT c FROM user c");
      List<User> customerList = query.getResultList();
      return customerList;
    }
    catch (Exception e){
      System.out.println("UserDatabase_Exception: " + e.getMessage());
      return null;
    }
  }

  @Override public void save(User customer)
  {
    if(!database.getEntityManager().getTransaction().isActive()) {
      database.getEntityManager().getTransaction().begin();
    }
    database.getEntityManager().persist(customer);
    database.getEntityManager().getTransaction().commit();

  }
}
