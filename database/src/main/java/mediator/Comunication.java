package mediator;

/**
 * Communication class used as communication protocol
 * @param <T> type of class thats used in this protocol class
 */
public class Comunication<T>
{
  private String type;
  private String method;
  private T value;

  /**
   * Constructor which initialize all instant variables
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
   * setts type of object
   * @param type type of object
   */
  public void setType(String type)
  {
    this.type = type;
  }

  /**
   * setts type of method
   * @param method method type
   */
  public void setMethod(String method)
  {
    this.method = method;
  }

  /**
   * setts object
   * @param value object
   */
  public void setValue(T value)
  {
    this.value = value;
  }

  /**
   * gets type of object
   * @return type of object
   */
  public String getType()
  {
    return type;
  }

  /**
   * gets type of method
   * @return method type
   */
  public String getMethod()
  {
    return method;
  }

  /**
   * gets object
   * @return object
   */
  public T getValue()
  {
    return value;
  }

}
