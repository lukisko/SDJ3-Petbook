import database.Database;
import database.DatabaseHandler;
import mediator.T3Server;

import java.io.IOException;
import java.sql.SQLException;

public class main
{
  public static void main(String[] args) throws IOException, SQLException
  {
    Database database = new DatabaseHandler();
    T3Server server = new T3Server(database);
    server.run();


  }
}
