package mediator.comunication_handler;

import com.google.gson.Gson;
import mediator.Comunication;
import model.Country;
import model.Model;


import java.util.List;

public class CountryHandler
{
  private Model model;
  private Gson gson;
  private String response;

  public CountryHandler(Model model){
    gson = new Gson();
    this.model = model;
  }

  private void findMethod(String method, Country value){
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

  private String get(Country value){
    try
    {
      String string = gson.toJson(new Comunication<Country>("country", "Get",
          model.getCountry(value.getName())));
      return string;
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String getAll(){
    try
    {
      return gson.toJson(new Comunication<List<Country>>("country", "GetAll", model.getAllCountries()));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String add(Country value){
    try
    {
      model.addCountry(value);
      return gson.toJson(new Comunication<Country>("country", "Add",
          model.getCountry(value.getName())));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }


  public String getResponse(String method, Country value)
  {
    findMethod(method, value);
    return response;
  }
}
