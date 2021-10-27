package mediator;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class T3Server implements Runnable
{
  private final static int PORT = 5123;
  private boolean running;
  private ServerSocket welcomeSocket;

  public void close() throws IOException
  {
    running = false;
    welcomeSocket.close();
  }

  @Override public void run()
  {
    try {
      System.out.println("Starting server");
      welcomeSocket = new ServerSocket(PORT);
      running = true;

      while (running){
        System.out.println("Waiting for client");
        Socket socket = welcomeSocket.accept();
        System.out.println("Client connected");
      }
    }
    catch (Exception e){
      //
    }
  }
}
