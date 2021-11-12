package model;

import javax.persistence.*;
import java.io.Serializable;

@Entity(name = "customer")
@Table(name = "customer_table")
public class Customer implements Serializable
{
  @Id
  @Column(name = "id")
  @GeneratedValue(strategy = GenerationType.IDENTITY)
  private int id;
  @Column(name = "email")
  private String email;

  public void setEmail(String email)
  {
    this.email = email;
  }

  public String getEmail()
  {
    return email;
  }

  public int getId()
  {
    return id;
  }

  @Override public String toString()
  {
    return "Customer{" + "id=" + id + ", email='" + email + '\'' + '}';
  }
}
