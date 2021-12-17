package model;

import javax.persistence.*;
import java.util.Collection;
import java.util.List;

@Entity(name = "city")
@Table(name = "city_table")
public class City {
  @Id
  @Column(name = "name" , nullable = false)
  private String name;

  @OneToMany(mappedBy="city")
  private List<Pet> pets;

  @ManyToOne(fetch = FetchType.EAGER,cascade=CascadeType.MERGE)
  @JoinColumn(name="country_name", nullable = false)
  private Country country;

  public City(){

  }
  public City(String name){
    this.name = name;
  }
  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public Country getCountry()
  {
    return country;
  }

  public void setCountry(Country country)
  {
    this.country = country;
  }

  public void setPets(List<Pet> pets) {
    this.pets = pets;
  }

  public List<Pet> getPets()
  {
    return pets;
  }

  public void clear(){
    if(pets != null) pets.clear();
    if(country != null) country.clear();
  }

  @Override public String toString()
  {
    return "City{" + "name='" + name + '\'' + ", pets=" + pets + ", country="
        + country + '}';
  }
}
