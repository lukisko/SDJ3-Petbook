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
    Pet pet = petPersistance.loadPet(34);
    System.out.println(pet);
    String send = gson.toJson(pet);
    System.out.println(send);
    byte[] toSendBytes = send.getBytes();
    System.out.println(toSendBytes);

  }
}
