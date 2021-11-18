package model;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.Collection;
import java.util.List;
import java.util.Set;

@Entity(name = "pet")
@Inheritance(strategy = InheritanceType.TABLE_PER_CLASS)
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
  @JoinColumn(name="user_email")
  private User user;
  @ManyToOne
  @JoinColumn(name="city_name")
  private City city;
  @ManyToMany(mappedBy = "pets")
  private Set<Group> groups;

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

  @Override public String toString()
  {
    return "Pet{" + "id=" + id + ", name='" + name + '\'' + ", type='" + type
        + '\'' + ", bread='" + bread + '\'' + ", description='" + description
        + '\'' + '}';
  }
}
