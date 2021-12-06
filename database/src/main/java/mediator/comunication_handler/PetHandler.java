package mediator.comunication_handler;

import com.google.gson.Gson;
import mediator.Comunication;
import model.*;

import java.util.List;

public class PetHandler
{
  private Model model;
  private Gson gson;
  private String response;

  public PetHandler(Model model){
    gson = new Gson();
    this.model = model;
  }

  private void findMethod(String method, Pet value){
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
    }
  }
  private String get(Pet value){
    try
    {
      return gson.toJson(new Comunication<Pet>("pet", "Get",
          model.getPet(value.getId())));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String getAll(){
    try
    {
      return gson.toJson(new Comunication<List<Pet>>("pet", "GetAll", model.getAllPets()));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String getAllOf(Pet value){
    try
    {
      return gson.toJson(new Comunication<List<Status>>("status", "GetAllOf",
          model.getStatusList(value.getId())));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String add(Pet value){
    try
    {
      int id = model.addPet(value);
      return gson.toJson(new Comunication<Pet>("pet", "Add",
          model.getPet(id)));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String remove(Pet value){
      try
      {
        model.removePet(value);
        return gson.toJson(new Comunication<String>("pet", "Add",
            "OK"));
      }
      catch (Exception e){
        System.out.println(e.getMessage());
        return e.getMessage();
      }
    }

  public String getResponse(String method, Pet value)
  {
    findMethod(method, value);
    return response;
  }
}
