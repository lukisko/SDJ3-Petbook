package model;

import javax.persistence.*;

@Entity(name = "status")
@Table(name = "status_table")
public class Status
{
  @Id
  @Column(name = "id")
  @GeneratedValue(strategy = GenerationType.AUTO)
  private int id;
  @Column(name = "name")
  private String name;
  @ManyToOne(fetch = FetchType.EAGER,cascade=CascadeType.MERGE)
  @JoinColumn(name="pet_id")
  private Pet pet;
  @ManyToOne(fetch = FetchType.EAGER,cascade=CascadeType.MERGE)
  @JoinColumn(name="user_email")
  private User user;

  public Pet getPet()
  {
    return pet;
  }

  public void setPet(Pet pet)
  {
    this.pet = pet;
  }
}
