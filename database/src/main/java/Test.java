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
    Country country = model.getCountry("string");
    City city1 = new City("a");
    city1.setCountry(country);
    City city2 = new City("b");
    city2.setCountry(country);
    model.addCity(city1);
    model.addCity(city2);

  }
}
