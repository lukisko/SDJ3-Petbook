package model;

import javax.persistence.*;
import java.util.List;

@Entity(name = "city")
@Table(name = "city_table")
public class City
{
  @Id
  @Column(name = "name", nullable = false)
  private String name;
  @ManyToOne
  @JoinColumn(name="country_name")
  private Country country;
  @OneToMany(mappedBy="city")
  private List<Pet> pets;
}
