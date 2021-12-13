package mediator.comunication_handler;

import DatabasePersistence.CountryDatabase;
import DatabasePersistence.CountryPersistence;
import com.google.gson.Gson;
import mediator.Comunication;
import model.Country;

import java.util.List;

public class CountryHandler
{
  private CountryPersistence countryPersistence;
  private Gson gson;
  private String response;

  public CountryHandler(){
    gson = new Gson();
    this.countryPersistence = new CountryDatabase();
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
          countryPersistence.loadCountry(value.getName())));
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
      return gson.toJson(new Comunication<List<Country>>("country", "GetAll", countryPersistence.loadAll()));
    }
    catch (Exception e){
      System.out.println(e.getMessage());
      return e.getMessage();
    }
  }
  private String add(Country value){
    try
    {
      countryPersistence.save(value);
      return gson.toJson(new Comunication<Country>("country", "Add",
          countryPersistence.loadCountry(value.getName())));
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
