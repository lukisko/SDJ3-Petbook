package mediator.comunication_handler;

import model.*;

public interface CommunicationHandler
{
  /**
   * gets response from given request of object user
   * @param method type of method to be used by UserHandler
   * @param value user object to be used
   * @return string of CommunicationClass of type User with answer of asked method
   * @throws Exception if CommunicationClass cannot be converted to string
   */
  String typeUser(String method, User value);
  /**
   * gets response from given request of object country
   * @param method type of method to be used by CountryHandler
   * @param value country object to be used
   * @return string of CommunicationClass of type Country with answer of asked method
   * @throws Exception if CommunicationClass cannot be converted to string
   */
  String typeCountry(String method, Country value);
  /**
   * gets response from given request of object city
   * @param method type of method to be used by CityHandler
   * @param value city object to be used
   * @return string of CommunicationClass of type City with answer of asked method
   * @throws Exception if CommunicationClass cannot be converted to string
   */
  String typeCity(String method, City value);
  /**
   * gets response from given request of object pet
   * @param method type of method to be used by PetHandler
   * @param value pet object to be used
   * @return string of CommunicationClass of type Pet/String with answer of asked method
   * @throws Exception if CommunicationClass cannot be converted to string
   */
  String typePet(String method, Pet value);
  /**
   * gets response from given request of object status
   * @param method type of method to be used by StatusHandler
   * @param value status object to be used
   * @return string of CommunicationClass of type Status/String with answer of asked method
   * @throws Exception if CommunicationClass cannot be converted to string
   */
  String typeStatus(String method, Status value);
  /**
   * gets response from given request of object Message
   * @param method type of method to be used by MessageHandler
   * @param value message object to be used
   * @return string of CommunicationClass of type Message/String with answer of asked method
   * @throws Exception if CommunicationClass cannot be converted to string
   */
  String typeMessage(String method, Message value);
}
