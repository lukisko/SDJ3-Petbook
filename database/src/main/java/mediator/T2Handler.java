package mediator;

import com.google.gson.Gson;
import model.Model;
import model.User;

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
              System.out.println(1);
              User user = model.getUser("cernicern@gmail.com");
              System.out.println(user);
              String stringToSend = null;
              try {
                 stringToSend = gson.toJson(new ComunicationUser("user","Get", user ));
              }
             catch (Exception e){
               System.out.println(3);
             }

              System.out.println("GET " + stringToSend);
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
              ComunicationUser requestAdd = gson.fromJson(received.trim(), ComunicationUser.class);
              model.addUser(requestAdd.getValue());
              String stringToSend = gson.toJson(new ComunicationUser("user","Add", model.getUser(request.getValue().getEmail())));
              System.out.println("ADD " + stringToSend);
              byte[] toSendBytes = stringToSend.getBytes();
              os.write(toSendBytes);
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
