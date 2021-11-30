package mediator;

/**
 * Communication class used as communication protocol
 * @param <T>
 */
public class Comunication<T>
{
  private String type;
  private String method;
  private T value;

  /**
   * Constructor initialising all instant variables
   * @param type type of object
   * @param method type of method
   * @param value object
   */
  public Comunication(String type, String method, T value)
  {
    this.type = type;
    this.method = method;
    this.value = value;
  }

  /**
   * setting type of object
   * @param type type of object
   */
  public void setType(String type)
  {
    this.type = type;
  }

  /**
   * setting type of method
   * @param method method type
   */
  public void setMethod(String method)
  {
    this.method = method;
  }

  /**
   * setting object
   * @param value object
   */
  public void setValue(T value)
  {
    this.value = value;
  }

  /**
   * getting type of object
   * @return type of object
   */
  public String getType()
  {
    return type;
  }

  /**
   * getting type of method
   * @return method type
   */
  public String getMethod()
  {
    return method;
  }

  /**
   * getting object
   * @return object
   */
  public T getValue()
  {
    return value;
  }

}
