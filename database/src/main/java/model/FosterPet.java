package model;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Table;

@Entity(name = "fosterPet")
@Table(name = "fosterPet_table")
public class FosterPet extends Pet
{
  //  @Column(name = "datesTimeForWalk")
  //  private List<Date> datesTimeForFoster;
  @Column(name = "foster")
  private User foster;

  public FosterPet(String name, String type, String bread, String description){
    super(name, type, bread, description);
  }
  //  public WalkPet(){
  //    datesTimeForWalk = new ArrayList<>();
  //  }
  //
  //
  //
  //  public List<Date> getDatesTimeForFoster()
  //  {
  //    return datesTimeForFoster;
  //  }
  //
  //  public void addDate(String data){
  //    datesTimeForFoster.add(data);
  //  }

  public User getFoster()
  {
    return foster;
  }

  public void setFoster(User foster)
  {
    this.foster = foster;
  }
}
