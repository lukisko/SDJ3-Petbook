import DatabasePersistence.*;
import com.google.gson.Gson;
import mediator.Comunication;
import mediator.comunication_handler.CommunicationHandler;
import mediator.comunication_handler.Handler;
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

    System.out.println(messagePersisence.LoadMessagesOfPets(72,15).get(0).getId());

  }
}
