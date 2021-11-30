package DatabasePersistence;

import model.User;
import org.hibernate.Session;

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
      if(!database.getSession().isOpen()){
        database.getSession().beginTransaction();
      }
      return database.getSession().get(User.class,email);
    }
    catch (Exception e){
      System.out.println("UserDatabase_Exception: " + e.getMessage());
      return null;
    }
  }

  @Override public List<User> loadAll()
  {
    try {
      Query query = database.getSession().createQuery("SELECT c FROM user c");
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
    if(!database.getSession().isOpen()){
      database.getSession().beginTransaction();
    }
    database.getSession().persist(customer);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }
}
