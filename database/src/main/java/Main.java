import DatabasePersistence.Database;
import mediator.T3Server;

public class Main
{
  public static void main(String[] args)
  {
    Database database = Database.getInstance();
    T3Server server = new T3Server();
    server.run();
  }
}
