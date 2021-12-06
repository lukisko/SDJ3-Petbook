package mediator.comunication_handler;

import com.google.gson.Gson;
import mediator.Comunication;
import model.City;
import model.Country;
import model.Model;

import java.util.List;

public class CityHandler
{
  private Model model;
  private Gson gson;
  private String response;

  public CityHandler(Model model){
    gson = new Gson();
    this.model = model;
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
          model.getCity(value.getName())));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String getAll(){
    try
    {
      return gson.toJson(new Comunication<List<City>>("city", "GetAll", model.getAllCities()));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String add(City value){
    try
    {
      model.addCity(value);
      return gson.toJson(new Comunication<City>("city", "Add",
          model.getCity(value.getName())));
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
