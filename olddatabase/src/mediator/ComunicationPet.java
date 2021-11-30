package mediator;

import model.Pet;

public class ComunicationPet
{private String type;
  private String method;
  private Pet value;

  public ComunicationPet(String type, String method, Pet value)
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

  public void setValue(Pet value)
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

  public Pet getValue()
  {
    return value;
  }
}
