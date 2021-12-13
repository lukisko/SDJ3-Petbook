package mediator.comunication_handler;

import com.google.gson.Gson;
import mediator.Comunication;
import model.Model;
import model.Pet;
import model.User;

import java.util.List;

public class UserHandler
{
  private Model model;
  private Gson gson;
  private String response;

  public UserHandler(Model model){
    gson = new Gson();
    this.model = model;
  }
  private void findMethod(String method, User value){
    switch (method)
    {
      case "Get":
        response = get(value);
        break;
      case "GetAll":
        response = getAll();
        break;
      case "GetAllOf":
        response = getAllOf(value);
        break;
      case "Add":
        response = add(value);
        break;
//      case "Remove":
//        response = remove(value);
//        break;
    }
  }

  private String get(User value){
    try
    {
      return gson.toJson(new Comunication<User>("user", "Get",
          model.getUser(value.getEmail())));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String getAll(){
    try
    {
      return gson.toJson(new Comunication<List<User>>("user", "GetAll", model.getAllUsers()));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String getAllOf(User value){
    try
    {
      return gson.toJson(new Comunication<List<Pet>>("pet", "GetAllOf",
          model.getPetList(value.getEmail())));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String add(User value){
    try
    {
      model.addUser(value);
      return gson.toJson(new Comunication<User>("user", "Add",
          model.getUser(value.getEmail())));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
//  public String remove(User value){
//    return null; // for future
//  }

  public String getResponse(String method, User value)
  {
    findMethod(method, value);
    return response;
  }
}
