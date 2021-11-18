package DatabasePersistence;

import model.Pet;
import model.User;

import java.util.List;

public interface PetPersistance
{
  Pet loadPet(String email);
  List<Pet> loadAll();
  void save(Pet pet);
}
