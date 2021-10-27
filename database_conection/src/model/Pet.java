package model;

public class Pet
{
  private int id;
  private String name;
  private String type;
  private String bread;

  public Pet(int id, String name, String type, String bread){
    this.id = id;
    this.name = name;
    this.type = type;
    this.bread = bread;
  }

  public int getId()
  {
    return id;
  }

  public String getName()
  {
    return name;
  }

  public String getType()
  {
    return type;
  }

  public String getBread()
  {
    return bread;
  }
}
