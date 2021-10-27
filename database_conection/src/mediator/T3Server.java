package mediator;

import database.Database;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class T3Server implements Runnable
{
  private final static int PORT = 5123;
  private boolean running;
  private ServerSocket welcomeSocket;
  private Database database;

  public T3Server(Database database){
    this.database = database;
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
        T2Handler t2Handler = new T2Handler(socket, database);
        Thread clientHandler = new Thread(t2Handler);
        clientHandler.setDaemon(true);
        clientHandler.start();
      }
    }
    catch (Exception e){
      //
    }
  }
}
