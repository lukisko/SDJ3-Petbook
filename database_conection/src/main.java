import mediator.T3Server;

import java.io.IOException;

public class main
{
  public static void main(String[] args) throws IOException
  {
    T3Server server = new T3Server();
    server.run();
  }
}
