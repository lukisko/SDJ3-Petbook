import mediator.T3Server;
import model.Model;
import model.ModelManager;
import model.User;

import java.time.LocalDate;
import java.util.Date;

public class Main
{
  public static void main(String[] args)
  {
    Model model = new ModelManager();
    T3Server server = new T3Server(model);
    server.run();
  }
}
