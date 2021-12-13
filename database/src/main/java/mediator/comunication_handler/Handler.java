package mediator.comunication_handler;

import model.*;

public class Handler implements CommunicationHandler
{

  private UserHandler userHandler;
  private CountryHandler countryHandler;
  private CityHandler cityHandler;
  private PetHandler petHandler;
  private StatusHandler statusHandler;

  public Handler(Model model){
    userHandler = new UserHandler(model);
    countryHandler = new CountryHandler(model);
    cityHandler = new CityHandler(model);
    petHandler = new PetHandler(model);
    statusHandler = new StatusHandler(model);
  }
  @Override public String typeUser(String method, User value)
  {
    return userHandler.getResponse(method, value);
  }

  @Override public String typeCountry(String method, Country value)
  {
    return countryHandler.getResponse(method, value);
  }

  @Override public String typeCity(String method, City value)
  {
    return cityHandler.getResponse(method, value);
  }

  @Override public String typePet(String method, Pet value)
  {
    return petHandler.getResponse(method, value);
  }

  @Override public String typeStatus(String method, Status value)
  {
    return statusHandler.getResponse(method, value);
  }
}
