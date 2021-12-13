package mediator;

import com.google.gson.Gson;
import com.google.gson.internal.LinkedTreeMap;
import mediator.comunication_handler.CommunicationHandler;
import mediator.comunication_handler.Handler;
import model.*;

import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.Socket;
import java.util.List;

public class T2Handler implements Runnable
{

  private InputStream is;
  private OutputStream os;
  private boolean running;
  private Gson gson;
  private CommunicationHandler handler;

  public T2Handler(Socket socket) throws IOException
  {
    handler = new Handler();
    is = socket.getInputStream();
    os = socket.getOutputStream();
    this.running = true;
    gson = new Gson();
  }

  @Override public void run()
  {
    while (running)
    {
      String stringToSend = "";
      try
      {

        byte[] lenBytes = new byte[4000];
        is.read(lenBytes, 0, 4000);
        String received = new String(lenBytes, 0, 4000);
        received.trim();
        System.out.println();
        System.out.println("*********************************************************************************************************************");
        System.out.println("THE REQUEST:  " + received);
        Comunication request = gson
            .fromJson(received.trim(), Comunication.class);

        switch (request.getType())
        {
          case "user":
            User user = new Gson()
                .fromJson(new Gson().toJson(request.getValue()), User.class);
            stringToSend = handler.typeUser(request.getMethod(), user);
            break;
          case "pet":
            Pet pet = new Gson()
                .fromJson(new Gson().toJson(request.getValue()), Pet.class);
            stringToSend = handler.typePet(request.getMethod(), pet);
            break;
          case "country":
            Country country = new Gson()
                .fromJson(new Gson().toJson(request.getValue()), Country.class);
            stringToSend = handler.typeCountry(request.getMethod(), country);
            break;
          case "city":
            City city = new Gson()
                .fromJson(new Gson().toJson(request.getValue()), City.class);
            stringToSend = handler.typeCity(request.getMethod(), city);
            break;
          case "status":
            Status status = new Gson()
                .fromJson(new Gson().toJson(request.getValue()), Status.class);
            stringToSend = handler.typeStatus(request.getMethod(), status);
            break;
        }

        System.out.println("Response: " + stringToSend);
        System.out.println("*********************************************************************************************************************");
        byte[] toSendBytes = stringToSend.getBytes();
        os.write(toSendBytes);
      }
      catch (Exception e)
      {
        e.printStackTrace();
      }
    }

  }
}
