package model;

import javax.persistence.*;
import java.io.Serializable;
import java.util.ArrayList;
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
  private String breed;
  @Column(name = "description")
  private String description;
  @Column(name = "birthday")
  private String birthdate;
  @Column(name = "gender")
  private char gender;
  @OneToMany(mappedBy="pet", fetch = FetchType.EAGER,cascade=CascadeType.MERGE)
  private List<Status> statuses;
  @ManyToOne(fetch = FetchType.EAGER,cascade=CascadeType.MERGE)
  @JoinColumn(name="user_email", nullable = false)
  private User user;
  @ManyToOne
  @JoinColumn(name="city_name", nullable = false)
  private City city;
  @OneToMany(mappedBy = "receiver")
  private List<Message> receiverMessages;
  @OneToMany(mappedBy = "sender")
  private List<Message> senderMessages;



  public Pet(){
    statuses = new ArrayList<>();
    receiverMessages = new ArrayList<>();
    senderMessages = new ArrayList<>();
  }
  public Pet(String name, City city, User user){
    this.name = name;
    this.city = city;
    this.user = user;
    statuses = new ArrayList<>();
    receiverMessages = new ArrayList<>();
    senderMessages = new ArrayList<>();
  }

  public int getId()
  {
    return id;
  }

  public void setId(int id)
  {
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

  public City getCity() {
    return city;
  }

  public User getUser() {
    return user;
  }

  public String getType()
  {
    return type;
  }

  public char getGender()
  {
    return gender;
  }

  public String getBirthdate()
  {
    return birthdate;
  }

  public String getBreed()
  {
    return breed;
  }

  public String getDescription()
  {
    return description;
  }

  public void setDescription(String description)
  {
    this.description = description;
  }

  public List<Message> getReceiverMessages()
  {
    return receiverMessages;
  }

  public List<Message> getSenderMessages()
  {
    return senderMessages;
  }

  public void setGender(char gender)
  {
    this.gender = gender;
  }

  public void clear(){
    statuses.clear();
    senderMessages.clear();
    receiverMessages.clear();
    if(city != null)
    {
      city.clear();
    }
    user.clear();
  }

  public void setPet(Pet pet){
    this.name = pet.getName();
    this.city = pet.getCity();
    this.user = pet.getUser();
    this.type = pet.getType();
    this.breed = pet.getBreed();
    this.gender = pet.getGender();
    this.statuses = pet.getStatuses();
    this.receiverMessages = pet.getReceiverMessages();
    this.senderMessages = pet.getSenderMessages();
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
        + '\'' + ", breed='" + breed + '\'' + ", description='" + description
        + '\'' + ", birthdate='" + birthdate + '\'' + ", gender=" + gender
        + ", statuses=" + statuses + ", user=" + user + ", city=" + city + '}';
  }
}
