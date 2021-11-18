package model;

import javax.persistence.*;
import java.util.*;

@Entity(name = "group")
@Table(name = "group_table")
public class Group
{
  @Id
  @Column(name = "name", nullable = false)
  private String nameOfGroup;
  @ManyToMany(cascade = { CascadeType.ALL })
  @JoinTable(
      name = "Group_Pet",
      joinColumns = { @JoinColumn(name = "group_name") },
      inverseJoinColumns = { @JoinColumn(name = "pet_id") }
  )
  public Set<Pet> pets;
  public List<Pet> petList;

  public Group(){
    pets = new HashSet<>();
    petList = new ArrayList<>(pets);
  }
  public void addPet(Pet pet){
    pets.add(pet);
    petList.add(pet);
  }

  public List<Pet> getPets()
  {
    return petList;
  }
}
