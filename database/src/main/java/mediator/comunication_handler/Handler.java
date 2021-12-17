package mediator.comunication_handler;

import DatabasePersistence.*;
import model.*;

public class Handler implements CommunicationHandler
{

  private UserHandler userHandler;
  private CountryHandler countryHandler;
  private CityHandler cityHandler;
  private PetHandler petHandler;
  private StatusHandler statusHandler;
  private MessageHandler messageHandler;



  public Handler(){

    userHandler = new UserHandler();
    countryHandler = new CountryHandler();
    cityHandler = new CityHandler();
    petHandler = new PetHandler();
    statusHandler = new StatusHandler();
    messageHandler = new MessageHandler();

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
  @Override public String typeMessage(String method, Message value){
    return messageHandler.getResponse(method,value);
  }
}
