package mediator;

public class Comunication<T>
{
  private String type;
  private String method;
  private T value;

  public Comunication(String type, String method, T value)
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

  public void setValue(T value)
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

  public T getValue()
  {
    return value;
  }

}
