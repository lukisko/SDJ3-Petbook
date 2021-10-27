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
    gson = new Gson();
  }

  @Override public void run()
  {
    running = true;
    while (running)
    {
      try
      {
        byte[] lenBytes = new byte[100];
        is.read(lenBytes, 0 ,100);
        String received = new String(lenBytes, 0, 100);
        Comunication request = gson.fromJson(received.trim(), Comunication.class);

        switch (request.getMethod())
        {
          case "Get":
            try
            {
                String stringToSend = gson.toJson(new Comunication<PetList>("PetList","Get", database.getPetList()));
                byte[] toSendBytes = stringToSend.getBytes();
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
