package model;

import javax.persistence.*;
import java.io.Serializable;
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
  @OneToMany(mappedBy="user")
  private List<Pet> pets;

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

  @Override public String toString()
  {
    return "User{" + "email='" + email + '\'' + ", name='" + name + '\''
        + ", pets=" + pets + '}';
  }
}
