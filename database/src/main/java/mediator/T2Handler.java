package mediator;

import com.google.gson.Gson;
import com.google.gson.internal.LinkedTreeMap;
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
  private Model model;

  public T2Handler(Socket socket, Model model) throws IOException
  {
    this.model = model;
    is = socket.getInputStream();
    os = socket.getOutputStream();
    this.running = true;
    gson = new Gson();
  }

  private void user(String method, User value)
  {
    switch (method)
    {
      case "Get":
        get("user", value);
        break;
      case "GetAll":
        getAll("user", value);
        break;
      case "GetAllOf":
        getAllOf(value);
        break;
      case "Add":
        add("user", value);
        break;
    }
  }

  private void pet(String method, Pet value)
  {
    switch (method)
    {
      case "Get":
        get("pet", value);
        break;
      case "GetAll":
        getAll("pet", value);
        break;
      case "Add":
        add("pet", value);
        break;
      case "Remove":
        remove("pet", value);
        break;
    }
  }
  private void country(String method, Country value)
  {
    switch (method)
    {
      case "Get":
        get("country", value);
        break;
      case "GetAll":
        getAll("country", value);
        break;
      case "Add":
        add("country", value);
        break;
    }
  }
  private void city(String method, City value)
  {
    switch (method)
    {
      case "Get":
        get("city", value);
        break;
      case "GetAll":
        getAll("city", value);
        break;
      case "Add":
        add("city", value);
        break;
    }
  }

  private void add(String object, Object value)
  {
    String stringToSend = "";
    try
    {
      switch (object)
      {
        case "user":
          model.addUser((User) value);
          stringToSend = gson.toJson(new Comunication<User>("user", "Add",
              model.getUser(((User) value).getEmail())));
          break;
        case "pet":
          int id = model.addPet((Pet) value);
          stringToSend = gson.toJson(new Comunication<Pet>("pet", "Add",
              model.getPet(id)));
          break;
        case "country":
          model.addCountry((Country) value);
          stringToSend = gson.toJson(new Comunication<Country>("country", "Add",
              model.getCountry(((Country) value).getName())));
          break;
        case "city":
          model.addCity((City) value);
          stringToSend = gson.toJson(new Comunication<City>("country", "Add",
              model.getCity(((City) value).getName())));
          break;
      }
    }
    catch (Exception e)
    {
      stringToSend = e.toString();
    }
    System.out.println("ADD " + stringToSend);
    byte[] toSendBytes = stringToSend.getBytes();
    try
    {
      os.write(toSendBytes);
    }
    catch (IOException e)
    {
      e.printStackTrace();
    }
  }

  private void remove(String object, Object value)
  {
    String stringToSend = "";
    try
    {
      switch (object)
      {
        case "user":
          //for future
          break;
        case "pet":
          model.removePet((Pet) value);
          stringToSend = gson
              .toJson(new Comunication<String>("pet", "Remove", "OK"));
          break;
        case "city":
          model.removeCity((City) value);
          stringToSend = gson
              .toJson(new Comunication<String>("pet", "Remove", "OK"));
          break;
        case "country":
          model.removeCountry((Country) value);
          stringToSend = gson
              .toJson(new Comunication<String>("pet", "Remove", "OK"));
          break;
      }
    }
    catch (Exception e)
    {
      stringToSend = e.toString();
    }
    System.out.println("REMOVE " + stringToSend);
    byte[] toSendBytes = stringToSend.getBytes();
    try
    {
      os.write(toSendBytes);
    }
    catch (IOException e)
    {
      e.printStackTrace();
    }
  }

  private void get(String object, Object value)
  {
    String stringToSend = "";
    try
    {
      switch (object)
      {
        case "user":
          stringToSend = gson.toJson(new Comunication<User>("user", "Get",
              model.getUser(((User) value).getEmail())));
          break;
        case "pet":
          stringToSend = gson.toJson(new Comunication<Pet>("pet", "Get",
              model.getPet(((Pet) value).getId())));
          break;
        case "city":
          stringToSend = gson.toJson(new Comunication<City>("pet", "Get",
              model.getCity(((City) value).getName())));
          break;
        case "country":
          stringToSend = gson.toJson(new Comunication<Country>("pet", "Get",
              model.getCountry(((Country) value).getName())));
          break;
      }
    }
    catch (Exception e)
    {
      stringToSend = e.toString();
    }
    System.out.println("GET " + stringToSend);
    byte[] toSendBytes = stringToSend.getBytes();
    try
    {
      os.write(toSendBytes);
    }
    catch (IOException e)
    {
      e.printStackTrace();
    }
  }

  private void getAll(String object, Object value)
  {
    String stringToSend = "";
    try
    {
      switch (object)
      {
        case "user":
          stringToSend = gson.toJson(
              new Comunication<List<User>>("user", "GetAll",
                  model.getAllUsers()));
          break;
        case "pet":
          stringToSend = gson.toJson(
              new Comunication<List<Pet>>("pet", "GetAll", model.getAllPets()));
          break;
        case "city":
          stringToSend = gson.toJson(
              new Comunication<List<City>>("pet", "GetAll", model.getAllCities()));
          break;
        case "country":
          stringToSend = gson.toJson(
              new Comunication<List<Country>>("pet", "GetAll", model.getAllCountries()));
          break;
      }
    }
    catch (Exception e)
    {
      stringToSend = e.toString();
    }
    System.out.println("GET_ALL " + stringToSend);
    byte[] toSendBytes = stringToSend.getBytes();
    try
    {
      os.write(toSendBytes);
    }
    catch (IOException e)
    {
      e.printStackTrace();
    }
  }

  private void getAllOf(Object value)
  {
    String stringToSend = "";
    try
    {
      stringToSend = gson.toJson(new Comunication<List<Pet>>("pet", "GetAllOf",
          model.getPetList(((User) value).getEmail())));
    }
    catch (Exception e)
    {
      stringToSend = e.toString();
    }
    System.out.println("GET_ALL_OF " + stringToSend);
    byte[] toSendBytes = stringToSend.getBytes();
    try
    {
      os.write(toSendBytes);
    }
    catch (IOException e)
    {
      e.printStackTrace();
    }
  }

  @Override public void run()
  {
    while (running)
    {
      try
      {

        byte[] lenBytes = new byte[500];
        is.read(lenBytes, 0, 500);
        String received = new String(lenBytes, 0, 500);
        received.trim();
        System.out.println("THE REQUEST:  " + received);
        Comunication request = gson
            .fromJson(received.trim(), Comunication.class);

        switch (request.getType())
        {
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
          case "country":
            Country country = new Gson()
                .fromJson(new Gson().toJson(request.getValue()), Country.class);
            country(request.getMethod(), country);
            break;
          case "city":
            City city = new Gson()
                .fromJson(new Gson().toJson(request.getValue()), City.class);
            city(request.getMethod(), city);
            break;
        }
        System.out.println();
      }

      catch (Exception e)
      {
        e.printStackTrace();
      }
    }

  }
}
