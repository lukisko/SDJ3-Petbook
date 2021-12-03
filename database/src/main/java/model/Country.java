package model;

import javax.persistence.*;
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
}