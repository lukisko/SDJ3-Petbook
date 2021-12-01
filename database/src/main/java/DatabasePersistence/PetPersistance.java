package DatabasePersistence;

import model.Pet;
import model.User;

import java.util.List;

public interface PetPersistance
{
  Pet loadPet(int id);
  List<Pet> loadAll();
  List<Pet> LoadListOfUser(String email);
  void save(User user,Pet pet);
  void delete(Pet pet);
}
