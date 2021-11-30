package DatabasePersistence;

import model.Pet;
import model.User;

import java.util.List;

public interface PetPersistance
{
  Pet loadPet(int id);
  List<Pet> loadAll();
  List<Pet> LoadListOf(String email);
  void save(User user,Pet pet);
}
