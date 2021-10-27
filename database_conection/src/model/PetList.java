package model;

import java.util.ArrayList;

public class PetList
{
  private ArrayList<Pet> list;

  public PetList(){
    list = new ArrayList<>();
  }

  public void addPet(Pet pet){
    list.add(pet);
  }

  public ArrayList<Pet> getList()
  {
    return list;
  }
}
