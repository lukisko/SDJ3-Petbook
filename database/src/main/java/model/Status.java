package model;

import javax.persistence.*;

@Entity(name = "status")
@Table(name = "status_table")
public class Status
{
  @Id
  @Column(name = "id")
  @GeneratedValue(strategy = GenerationType.AUTO)
  private int id;
  @Column(name = "name")
  private String name;
  @ManyToOne(fetch = FetchType.EAGER,cascade=CascadeType.MERGE)
  @JoinColumn(name="pet_id", nullable = false)
  private Pet pet;
  @ManyToOne(fetch = FetchType.EAGER,cascade=CascadeType.MERGE)
  @JoinColumn(name="user_email")
  private User user;

  public void setId(int id)
  {
    this.id = id;
  }
  public Pet getPet()
  {
    return pet;
  }

  public void setPet(Pet pet)
  {
    this.pet = pet;
  }

  public int getId()
  {
    return id;
  }

  public void setUser(User user)
  {
    this.user = user;
  }

  public User getUser()
  {
    return user;
  }

  public void setName(String name)
  {
    this.name = name;
  }

  public String getName()
  {
    return name;
  }

  public void clear(){
    pet.clear();
    user.clear();
  }

  public void setStatus(Status status){
    this.name = status.name;
    this.user = status.user;
    this.pet = status.pet;
  }

  @Override public String toString()
  {
    return "Status{" + "id=" + id + ", name='" + name + '\'' + ", pet=" + pet
        + ", user=" + user + '}';
  }
}
