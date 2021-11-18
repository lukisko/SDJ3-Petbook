package mediator;

import com.google.gson.Gson;
import model.Model;

import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.Socket;

public class T2Handler implements Runnable
{

  private InputStream is;
  private OutputStream os;
  private boolean running;
  private Gson gson;
  private Model model;

  public T2Handler(Socket socket, Model model) throws IOException
  {
    this.model = model;
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
        System.out.println(received);
        ComunicationUser request = gson.fromJson(received.trim(), ComunicationUser.class);
        if (request == null){
          return;
        }
        switch (request.getMethod())
        {
          case "Get":
            try
            {

              String stringToSend = gson.toJson(new ComunicationUser("PetList","Get",
                  model.getUser(request.getValue().getEmail())));
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
              ComunicationUser requestAdd = gson.fromJson(received.trim(), ComunicationUser.class);
              System.out.println(requestAdd.getValue());
              model.AddUser(requestAdd.getValue());
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
