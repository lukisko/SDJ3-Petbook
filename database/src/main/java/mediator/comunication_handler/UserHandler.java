package mediator.comunication_handler;

import DatabasePersistence.UserDatabase;
import DatabasePersistence.UserPersistence;
import com.google.gson.Gson;
import mediator.Comunication;
import model.User;

import java.util.List;

public class UserHandler
{

  private Gson gson;
  private String response;
  private UserPersistence userPersistence;


  public UserHandler(){
    gson = new Gson();
    response = "";
    this.userPersistence = new UserDatabase();
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
      case "Add":
        response = add(value);
        break;
    }
  }

  private String get(User value){
    try
    {
      return gson.toJson(new Comunication<User>("user", "Get",
          userPersistence.loadUser(value.getEmail())));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String getAll(){
    try
    {
      return gson.toJson(new Comunication<List<User>>("user", "GetAll", userPersistence.loadAll()));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String add(User value){
    try
    {
      userPersistence.save(value);
      return gson.toJson(new Comunication<User>("user", "Add",
          userPersistence.loadUser(value.getEmail())));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }

  public String getResponse(String method, User value)
  {
    findMethod(method, value);
    return response;
  }
}
