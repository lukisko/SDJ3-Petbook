package mediator.comunication_handler;

import DatabasePersistence.CityDatabase;
import DatabasePersistence.CityPersistence;
import com.google.gson.Gson;
import mediator.Comunication;
import model.City;

import java.util.List;

public class CityHandler
{
  private CityPersistence cityPersistence;
  private Gson gson;
  private String response;

  public CityHandler(){
    gson = new Gson();
    this.cityPersistence = new CityDatabase();
  }

  private void findMethod(String method, City value){
    switch (method)
    {
      case "Get":
        response = get( value);
        break;
      case "GetAll":
        response = getAll();
        break;
      case "Add":
        response = add( value);
        break;
    }
  }

  private String get(City value){
    try
    {
      return gson.toJson(new Comunication<City>("city", "Get",
          cityPersistence.loadCity(value.getName())));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String getAll(){
    try
    {
      return gson.toJson(new Comunication<List<City>>("city", "GetAll", cityPersistence.loadAll()));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String add(City value){
    try
    {
      cityPersistence.save(value);
      return gson.toJson(new Comunication<City>("city", "Add",
          cityPersistence.loadCity(value.getName())));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }

  public String getResponse(String method, City value)
  {
    findMethod(method, value);
    return response;
  }
}
