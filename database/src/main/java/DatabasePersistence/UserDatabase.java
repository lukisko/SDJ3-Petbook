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

      database.beginSession();
      User user = database.getSession().get(User.class,email);
      if(user != null)
      {
        user.getPets().clear();
        user.getStatuses().clear();
      }
      return user;
  }

  @Override public List<User> loadAll()
  {
      database.beginSession();
      CriteriaQuery<User> criteria = database.getBuilder().createQuery(User.class);
      criteria.from(User.class);
      List<User> data = database.getSession().createQuery(criteria).getResultList();
      return data;
  }

  @Override public void save(User customer)
  {
    database.beginSession();
    database.getSession().persist(customer);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }

  @Override public void delete(User customer)
  {
    database.beginSession();
    database.getSession().delete(customer);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }
}
