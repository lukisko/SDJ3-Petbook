package model;

import javax.persistence.*;

@Entity(name = "pet")
//@Inheritance(strategy = InheritanceType.TABLE_PER_CLASS)
@Table(name = "pet_table")
public class Pet
{
  @Id
  @Column(name = "id")
  @GeneratedValue(strategy = GenerationType.AUTO)
  private int id;
  @Column(name = "name")
  private String name;
  @Column(name = "type")
  private String type;
  @Column(name = "bread")
  private String bread;
  @Column(name = "description")
  private String description;
  @ManyToOne
  @JoinColumn(name="user_email", nullable = false)
  private User user;
  @ManyToOne
  @JoinColumn(name="city_name", nullable = false)
  private City city;



  public Pet(){}
  public Pet(String name, String type, String bread, String description){
    this.name = name;
    this.type = type;
    this.bread = bread;
    this.description = description;
  }

  public int getId()
  {
    return id;
  }

  public void setId(int id) {
    this.id = id;
  }

  public void setUser(User user) {
    this.user = user;
  }

  public String getName()
  {
    return name;
  }

  public void setName(String name)
  {
    this.name = name;
  }

  public String getType()
  {
    return type;
  }

  public void setType(String type)
  {
    this.type = type;
  }

  public String getBread()
  {
    return bread;
  }

  public City getCity() {
    return city;
  }

  public User getUser() {
    return user;
  }

  public void setBread(String bread)
  {
    this.bread = bread;
  }

  public String getDescription()
  {
    return description;
  }

  public void setDescription(String description)
  {
    this.description = description;
  }

  public void setCity(City city) {
    this.city = city;
  }

  @Override public String toString()
  {
    return "Pet{" + "id=" + id + ", name='" + name + '\'' + ", type='" + type
        + '\'' + ", bread='" + bread + '\'' + ", description='" + description
        + '\'' + '}';
  }
}
