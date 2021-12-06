package model;

import javax.persistence.*;
import java.io.Serializable;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

@Entity(name = "user")
@Table(name = "user_table")
public class User implements Serializable
{
  @Id
  @Column(name = "email" , nullable = false)
  private String email;
  @Column(name = "name")
  private String name;
  @OneToMany(mappedBy="user", fetch = FetchType.EAGER,cascade=CascadeType.MERGE)
  private List<Pet> pets;
  @OneToMany(mappedBy="user", fetch = FetchType.EAGER,cascade=CascadeType.MERGE)
  private List<Status> statuses;

  public User(){
    pets = new ArrayList<>();
    statuses = new ArrayList<>();
  }
  public User(String email){
    this.email = email;
    pets = new ArrayList<>();
  }
  public void setEmail(String email)
  {
    this.email = email;
  }

  public String getEmail()
  {
    return email;
  }

  public String getName()
  {
    return name;
  }

  public void setName(String name)
  {
    this.name = name;
  }

  public List<Pet> getPets()
  {
    return pets;
  }

  public List<Status> getStatuses()
  {
    return statuses;
  }

  @Override public String toString()
  {
    return "User{" + "email='" + email + '\'' + ", name='" + name + '\''
        + ", pets=" + pets + ", statuses=" + statuses + '}';
  }
}
