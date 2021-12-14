import DatabasePersistence.*;
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
    MessagePersisence messagePersisence = new MessageDatabase();
    PetPersistance petPersistance = new PetDatabase();
    Message message = new Message();
    Pet pet1 = petPersistance.loadPet(9);
    message.setMessage("asd");
    message.setReceiver(pet1);
    message.setSender(pet1);
    messagePersisence.save(message);


  }
}
