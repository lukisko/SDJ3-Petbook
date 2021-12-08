package mediator.comunication_handler;

import com.google.gson.Gson;
import mediator.Comunication;
import model.City;
import model.Model;
import model.Pet;
import model.Status;

import java.util.List;

public class StatusHandler
{
  private Model model;
  private Gson gson;
  private String response;

  public StatusHandler(Model model){
    gson = new Gson();
    this.model = model;
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
      case "Update":
        response = update(value);
        break;
    }
  }
  private String get(Status value){
    try
    {
      return gson.toJson(new Comunication<Status>("status", "Get",
          model.getStatus(value.getId())));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String getAll(){
    try
    {
      return gson.toJson(new Comunication<List<Status>>("status", "GetAll", model.getAllStatuses()));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String add(Status value){
    try
    {
      int id = model.addStatus(value);
      return gson.toJson(new Comunication<Status>("status", "Add",
          model.getStatus(id)));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String remove(Status value){
    try
    {
      model.removeStatus(value);
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
          model.getAllStatusesWithName(value.getName())));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String update(Status value){
    try
    {
      return gson.toJson(new Comunication<Status>("status", "Update",
          model.updateStatus(value)));
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
