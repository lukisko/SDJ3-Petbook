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
    Pet pet = new Pet();
    City city = new City();
    User user = new User("asd");
    Country country = new Country("asd");

    model.addCountry(country);
    model.addUser(user);

    city.setName("asd");
    city.setCountry(model.getCountry("asd"));

    pet.setUser(user);
    pet.setCity(city);

    model.addCity(city);
    model.addPet(pet);
  }
}
