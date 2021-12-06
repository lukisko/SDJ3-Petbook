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
  public void findMethod(String method, User value){
    switch (method)
    {
      case "Get":
        response = get(value);
        break;
      case "GetAll":
        response = getAll(value);
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

  public String get(User value){
    return gson.toJson(new Comunication<User>("user", "Get",
        model.getUser(value.getEmail())));
  }
  public String getAll(User value){
    return gson.toJson(
        new Comunication<List<User>>("user", "GetAll",
            model.getAllUsers()));
  }
  public String getAllOf(User value){
    return gson.toJson(new Comunication<List<Pet>>("pet", "GetAllOf",
        model.getPetList(value.getEmail())));
  }
  public String add(User value){
    model.addUser(value);
    return gson.toJson(new Comunication<User>("user", "Add",
        model.getUser(value.getEmail())));
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
