package mediator.comunication_handler;

import DatabasePersistence.StatusDatabase;
import DatabasePersistence.StatusPersistence;
import com.google.gson.Gson;
import mediator.Comunication;
import model.Status;

import java.util.List;

public class StatusHandler
{
  private StatusPersistence statusPersistence;
  private Gson gson;
  private String response;

  public StatusHandler(){
    gson = new Gson();
    this.statusPersistence = new StatusDatabase();
  }
  private void findMethod(String method, Status value)
  {
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
      case "Remove":
        response = remove(value);
        break;
      case "GetAllOf":
        response = getAllOf(value);
        break;
      case "GetAllOfPet":
        response = getAllOfPet(value);
        break;
      case "Update":
        response = update(value);
        break;
    }
  }
  private String get(Status value){
    try
    {
      return gson.toJson(new Comunication<Status>("status", "Get",
          statusPersistence.loadStatus(value.getId())));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String getAll(){
    try
    {
      return gson.toJson(new Comunication<List<Status>>("status", "GetAll", statusPersistence.loadAll()));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String add(Status value){
    try
    {
      int id = statusPersistence.save(value);
      return gson.toJson(new Comunication<Status>("status", "Add",
          statusPersistence.loadStatus(id)));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String remove(Status value){
    try
    {
      statusPersistence.delete(statusPersistence.loadStatus(value.getId()));
      return gson.toJson(new Comunication<String>("status", "Remove",
          "OK"));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String getAllOf(Status value){
    try
    {

      return gson.toJson(new Comunication<List<Status>>("status", "GetAllOf",
          statusPersistence.getAllOf(value.getName())));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String getAllOfPet(Status value){

    return gson.toJson(new Comunication<List<Status>>("status", "GetAllOfPet",
        statusPersistence.loadStatusOfPet(value.getPet().getId())));
  }
  private String update(Status value){
    try
    {
      return gson.toJson(new Comunication<Status>("status", "Update",
          statusPersistence.update(value)));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }

  public String getResponse(String method, Status value)
  {
    findMethod(method, value);
    return response;
  }
}
