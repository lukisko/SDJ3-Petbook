package mediator;

import com.google.gson.Gson;
import database.Database;
import model.Pet;
import model.PetList;

import java.io.*;
import java.net.Socket;

public class T2Handler implements Runnable
{

  private InputStream is;
  private OutputStream os;
  private boolean running;
  private Gson gson;
  private Database database;

  public T2Handler(Socket socket, Database database) throws IOException
  {
    this.database = database;
    is = socket.getInputStream();
    os = socket.getOutputStream();
    this.running = true;
    gson = new Gson();
  }

  @Override public void run()
  {
    while (running){
      try
      {
        System.out.println("getting data");
        byte[] lenBytes = new byte[500];
        is.read(lenBytes, 0 ,500);
        String received = new String(lenBytes, 0, 500);
        //System.out.println(received);
        Comunication request = gson.fromJson(received.trim(), Comunication.class);
        if (request == null){
          return;
        }
        switch (request.getMethod())
        {
          case "Get":
            try
            {
              String stringToSend = gson.toJson(new Comunication<PetList>("PetList","Get", database.getPetList()));
              byte[] toSendBytes = stringToSend.getBytes();
              System.out.println("sending data");
              os.write(toSendBytes);
            }
            catch (Exception e)
            {
              e.printStackTrace();
            }
            break;
          case "Add":
            try
            {
              ComunicationPet requestAdd = gson.fromJson(received.trim(), ComunicationPet.class);
              System.out.println(requestAdd.getValue());
              database.addPet((Pet)requestAdd.getValue());
            }
            catch (Exception e)
            {
              e.printStackTrace();
            }
            break;
        }
      }
      catch (Exception e)
      {
        e.printStackTrace();
      }
    }
    }
}
