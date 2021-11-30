package model;

public class Pet
{
  private int id;
  private String name;
  private String type;
  private String bread;
  private String description;

  public Pet(int id, String name, String type, String bread, String description){
    this.id = id;
    this.name = name;
    this.type = type;
    this.bread = bread;
    this.description = description;
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

  public String getDescription()
  {
    return description;
  }
}
