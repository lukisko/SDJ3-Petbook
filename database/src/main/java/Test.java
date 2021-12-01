import model.*;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;

import javax.imageio.spi.ServiceRegistry;
import java.util.List;
import java.util.Random;

public class Test {


  public static void main(String[] args) {

    Model model = new ModelManager();
    User user = new User();
    user.setEmail("jurco10510@gmail.com");
    City city = new City();
    city.setName("BA");
    Pet pet = new Pet();
    pet.setCity(city);

    //System.out.println(model.getUser("asd"));

    //model.addUser(user);

    model.addPet(user.getEmail(),pet);

    //System.out.println(model.getAllUsers());

    //System.out.println(model.getAllPets());

//    Configuration cfg = new Configuration().addAnnotatedClass(User.class).addAnnotatedClass(Pet.class).addAnnotatedClass(City.class);
//    cfg.configure();
//    SessionFactory factory = cfg.buildSessionFactory();
//    Session session = factory.getCurrentSession();
//    session.beginTransaction();
//
//    System.out.println(session.get(User.class, "asd"));
//
//
//    City city = new City();
//    city.setName("BA");
//
//    User user = new User();
//    user.setEmail("asd");
//
//    Pet pet = new Pet();
//    pet.setCity(city);
//    pet.setUser(session.get(User.class, "asd"));
//
//    session.persist(pet);
//    session.getTransaction().commit();
//
//    session = session.getSessionFactory().openSession();
//    session.beginTransaction();
//    //session.beginTransaction();
//    Pet pet2 = new Pet();
//    pet2.setCity(city);
//    pet2.setUser(session.get(User.class, "asd"));
//    session.persist(pet2);
//    session.getTransaction().commit();
//    session.close();

  }
}
