package model;

import javax.persistence.*;
import java.io.Serializable;
import java.util.List;

@Entity(name = "pet")
//@Inheritance(strategy = InheritanceType.TABLE_PER_CLASS)
@Table(name = "pet_table")
public class Pet implements Serializable
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
  @Column(name = "birthday")
  private String birthday;
  @OneToMany(mappedBy="pet", fetch = FetchType.EAGER,cascade=CascadeType.MERGE)
  private List<Status> statuses;
  @ManyToOne(fetch = FetchType.EAGER,cascade=CascadeType.MERGE)
  @JoinColumn(name="user_email", nullable = false)
  private User user;
  @ManyToOne
  @JoinColumn(name="city_name", nullable = false)
  private City city;



  public Pet(){}
  public Pet(String name, City city){
    this.name = name;
    this.city = city;
  }

  public int getId()
  {
    return id;
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

  public City getCity() {
    return city;
  }

  public User getUser() {
    return user;
  }

  public String getDescription()
  {
    return description;
  }

  public void setDescription(String description)
  {
    this.description = description;
  }

  public List<Status> getStatuses()
  {
    return statuses;
  }

  public void setCity(City city) {
    this.city = city;
  }

  @Override public String toString()
  {
    return "Pet{" + "id=" + id + ", name='" + name + '\'' + ", type='" + type
        + '\'' + ", bread='" + bread + '\'' + ", description='" + description
        + '\'' + ", birthday='" + birthday + '\'' + ", statuses=" + statuses
        + ", user=" + user + ", city=" + city + '}';
  }
}
