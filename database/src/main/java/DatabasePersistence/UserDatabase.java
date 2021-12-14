package DatabasePersistence;

import model.Pet;
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
      if(email == null) throw new IllegalArgumentException();

      database.beginSession();
      User user = database.getSession().get(User.class,email);
      if(user != null)
      {
        user.clear();
      }
      return user;
  }

  @Override public List<User> loadAll()
  {
      database.beginSession();
      CriteriaQuery<User> criteria = database.getBuilder().createQuery(User.class);
      criteria.from(User.class);
      List<User> data = database.getSession().createQuery(criteria).getResultList();
      if (data != null){
        data.forEach(User::clear);
      }
      return data;
  }

  @Override public void save(User user)
  {
    if(user == null) throw new IllegalArgumentException();

    database.beginSession();
    database.getSession().persist(user);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }

  @Override public void delete(User user)
  {
    database.beginSession();
    database.getSession().delete(user);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }

}
