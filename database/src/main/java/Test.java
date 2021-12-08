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
    Pet pet = model.getPet(6);
    Status status = new Status();
    status.setName("fostering");
    status.setPet(pet);
    String toSend = gson.toJson(status);
    Status status1 = gson.fromJson(toSend, Status.class);


    String asd = gson.toJson(model.addStatus(status1));

    System.out.println(gson.fromJson(asd, Pet.class));
    //System.out.println(model.getAllStatuses());


  }
}
