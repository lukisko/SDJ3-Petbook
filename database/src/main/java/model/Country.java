package model;

import javax.persistence.*;
import java.util.List;

@Entity(name = "country")
@Table(name = "country_table")
public class Country
{
  @Id
  @Column(name = "name", nullable = false)
  private String name;
  @OneToMany(mappedBy="country")
  private List<City> cityList;
}
