package model;

import javax.persistence.*;
import java.util.List;

@Entity(name = "city")
@Table(name = "city_table")
public class City {
  @Id
  @Column(name = "name" , nullable = false)
  private String name;
  @OneToMany(mappedBy="city")
  private List<Pet> pets;

  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public void setPets(List<Pet> pets) {
    this.pets = pets;
  }
}
