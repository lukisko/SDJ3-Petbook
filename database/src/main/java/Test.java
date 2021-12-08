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
    Pet pet = model.getPet(1000);
    Status statusAdd = new Status();
    statusAdd.setPet(pet);
    statusAdd.setName("sas");


//    model.addStatus(statusAdd);
    String send = gson.toJson(statusAdd);
    Status remove = gson.fromJson(send, Status.class);
    remove.setId(91);
    model.removeStatus(remove);



  }
}
