package mediator;

import com.google.gson.Gson;
import com.google.gson.internal.LinkedTreeMap;
import model.Model;
import model.Pet;
import model.User;

import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.Socket;

public class T2Handler implements Runnable {

  private InputStream is;
  private OutputStream os;
  private boolean running;
  private Gson gson;
  private Model model;

  public T2Handler(Socket socket, Model model) throws IOException {
    this.model = model;
    is = socket.getInputStream();
    os = socket.getOutputStream();
    this.running = true;
    gson = new Gson();
  }

  private void user(String method, User value) {
    switch (method) {
      case "Get":
        get("user", value);
        break;
      case "Add":
        add("user", value);
        break;
    }
  }

  private void pet(String method, Pet value) {
    switch (method) {
      case "Get":
        get("pet",value);
        break;
      case "Add":
        add("pet", value);
        break;
    }
  }

  private void add(String object, Object value) {
    String stringToSend = "";
    switch (object) {
      case "user":
        model.addUser((User) value);
        stringToSend = gson.toJson(new Comunication<User>("user", "Add",
            model.getUser(((User) value).getEmail())));
        break;
      case "pet":
        model.addUser((User) value);
        stringToSend = gson.toJson(new Comunication<Pet>("pet", "Add",
            model.getPet(((Pet) value).getId())));
        break;
    }
    System.out.println("ADD " + stringToSend);
    byte[] toSendBytes = stringToSend.getBytes();
    try {
      os.write(toSendBytes);
    }
    catch (IOException e) {
      e.printStackTrace();
    }
  }

  private void get(String object, Object value) {
    String stringToSend = "";
    switch (object) {
      case "user":
        stringToSend = gson.toJson(new Comunication<User>("user", "Get",
            model.getUser(((User) value).getEmail())));
        break;
      case "pet":
        stringToSend = gson.toJson(new Comunication<Pet>("pet", "Get",
            model.getPet(((Pet) value).getId())));
        break;
    }
    System.out.println("GET " + stringToSend);
    byte[] toSendBytes = stringToSend.getBytes();
    try {
      os.write(toSendBytes);
    }
    catch (IOException e) {
      e.printStackTrace();
    }
  }

  @Override public void run() {
    while (running) {
      try {

        byte[] lenBytes = new byte[500];
        is.read(lenBytes, 0, 500);
        String received = new String(lenBytes, 0, 500);
        received.trim();
        System.out.println("THE REQUEST:  " + received);
        Comunication request = gson
            .fromJson(received.trim(), Comunication.class);

        switch (request.getType()) {
          case "user":
            User user = new Gson()
                .fromJson(new Gson().toJson(request.getValue()), User.class);
            user(request.getMethod(), user);
            break;
          case "pet":
            Pet pet = new Gson()
                .fromJson(new Gson().toJson(request.getValue()), Pet.class);
            pet(request.getMethod(), pet);
            break;
        }
        System.out.println();
      }

      catch (Exception e) {
        e.printStackTrace();
      }
    }

  }
}
