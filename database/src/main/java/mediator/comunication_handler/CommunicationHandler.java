package mediator.comunication_handler;

import model.*;

public interface CommunicationHandler
{
  String typeUser(String method, User value);
  String typeCountry(String method, Country value);
  String typeCity(String method, City value);
  String typePet(String method, Pet value);
  String typeStatus(String method, Status value);
  String typeMessage(String method, Message value);
}
