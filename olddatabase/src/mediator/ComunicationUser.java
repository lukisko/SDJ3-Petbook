package mediator;

import model.Pet;
import model.User;

public class ComunicationUser
{
  private String type;
  private String method;
  private User value;

  public ComunicationUser(String type, String method, User value)
  {
    this.type = type;
    this.method = method;
    this.value = value;
  }

  public void setType(String type)
  {
    this.type = type;
  }

  public void setMethod(String method)
  {
    this.method = method;
  }

  public void setValue(User value)
  {
    this.value = value;
  }

  public String getType()
  {
    return type;
  }

  public String getMethod()
  {
    return method;
  }

  public User getValue()
  {
    return value;
  }
}

