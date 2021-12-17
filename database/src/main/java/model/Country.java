package model;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

@Entity(name = "country")
@Table(name = "country_table")
public class Country
{
  @Id
  @Column(name = "name" , nullable = false)
  private String name;
  @OneToMany(mappedBy="country", fetch = FetchType.EAGER,cascade= CascadeType.MERGE)
  private List<City> cities;

  public Country(){
    cities = new ArrayList<>();
  }
  public Country(String name){
    this.name = name;
  }
  public String getName()
  {
    return name;
  }

  public List<City> getCities()
  {
    return cities;
  }

  public void setName(String name)
  {
    this.name = name;
  }

  public void clear(){
    if(cities != null) cities.clear();
  }

  public void setCities(List<City> cities)
  {
    this.cities = cities;
  }

  @Override public String toString()
  {
    return "Country{" + "name='" + name + '\'' + ", cities=" + cities + '}';
  }
}
