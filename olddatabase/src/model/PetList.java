package model;

import java.util.ArrayList;

public class PetList
{
  private ArrayList<Pet> pets;

  public PetList(){
    pets = new ArrayList<>();
  }

  public void addPet(Pet pet){
    pets.add(pet);
  }

  public void setPets(ArrayList<Pet> pets)
  {
     this.pets = pets;
  }

  public ArrayList<Pet> getPets()
  {
    return pets;
  }
}
