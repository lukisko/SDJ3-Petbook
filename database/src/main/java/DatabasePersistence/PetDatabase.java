package DatabasePersistence;

import model.Pet;

import java.util.List;

public class PetDatabase implements PetPersistance
{
  @Override public Pet loadPet(String email)
  {
    return null;
  }

  @Override public List<Pet> loadAll()
  {
    return null;
  }

  @Override public void save(Pet pet)
  {

  }
}
