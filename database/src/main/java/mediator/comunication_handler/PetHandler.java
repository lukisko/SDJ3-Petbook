package mediator.comunication_handler;

import DatabasePersistence.PetDatabase;
import DatabasePersistence.PetPersistance;
import com.google.gson.Gson;
import mediator.Comunication;
import model.*;

import java.util.List;

public class PetHandler
{
  private PetPersistance petPersistance;
  private Gson gson;
  private String response;

  public PetHandler(){
    gson = new Gson();
    petPersistance = new PetDatabase();
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
      case "Update":
        response = update(value);
        break;
    }
  }
  private String get(Pet value){
    try
    {
      return gson.toJson(new Comunication<Pet>("pet", "Get",
          petPersistance.loadPet(value.getId())));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String getAll(){
    try
    {
      return gson.toJson(new Comunication<List<Pet>>("pet", "GetAll", petPersistance.loadAll()));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String getAllOf(Pet value){
    try
    {
      return gson.toJson(new Comunication<List<Pet>>("pet", "GetAllOf",
          petPersistance.loadListOfUser(value.getUser().getEmail())));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String add(Pet value){
    try
    {
      int id = petPersistance.save(value);
      return gson.toJson(new Comunication<Pet>("pet", "Add",
          petPersistance.loadPet(id)));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String remove(Pet value){
      try
      {
        petPersistance.delete(petPersistance.loadPet(value.getId()));
        return gson.toJson(new Comunication<String>("pet", "Remove",
            "OK"));
      }
      catch (Exception e){
        System.out.println(e.getMessage());
        return e.getMessage();
      }
    }
  private String update(Pet value){
    try
    {
      return gson.toJson(new Comunication<Pet>("pet", "Update",
          petPersistance.update(petPersistance.loadPet(value.getId()))));
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
