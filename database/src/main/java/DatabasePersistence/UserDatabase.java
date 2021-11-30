package DatabasePersistence;

import model.User;
import org.hibernate.Criteria;
import org.hibernate.Session;

import javax.persistence.Query;
import javax.persistence.criteria.CriteriaBuilder;
import javax.persistence.criteria.CriteriaQuery;
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
      database.beginSession();
      User user = database.getSession().get(User.class,email);
      user.getPets().clear();
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
      CriteriaQuery<User> criteria = database.getBuilder().createQuery(User.class);
      criteria.from(User.class);
      List<User> data = database.getSession().createQuery(criteria).getResultList();
      return data;
    }
    catch (Exception e){
      System.out.println("UserDatabase_Exception: " + e.getMessage());
      return null;
    }
  }

  @Override public void save(User customer)
  {
    database.beginSession();
    database.getSession().persist(customer);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }
}
