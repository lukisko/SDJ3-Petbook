package model;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

@Entity(name = "walkPet")
@Table(name = "walkPet_table")
public class WalkPet extends Pet
{
//  @Column(name = "datesTimeForWalk")
//  private List<Date> datesTimeForWalk;
  @Column(name = "walker")
  private User walker;

  public WalkPet(String name, String type, String bread, String description){
    super(name, type, bread, description);
  }
//  public WalkPet(){
//    datesTimeForWalk = new ArrayList<>();
//  }
//
//
//
//  public List<Date> getDatesTimeForWalk()
//  {
//    return datesTimeForWalk;
//  }
//
//  public void addDate(String data){
//    datesTimeForWalk.add(data);
//  }

  public User getWalker()
  {
    return walker;
  }

  public void setWalker(User walker)
  {
    this.walker = walker;
  }
}
