import com.google.gson.Gson;
import mediator.Comunication;
import model.*;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;

import javax.imageio.spi.ServiceRegistry;
import java.util.List;
import java.util.Random;

public class Test {


  public static void main(String[] args) {

    Gson gson = new Gson();
    Model model = new ModelManager();
    Pet pet = new Pet();
    pet.setId(6);
    Status status = new Status();
    status.setName("fostering");


    status.setPet(pet);

    model.addStatus(status);


  }
}
