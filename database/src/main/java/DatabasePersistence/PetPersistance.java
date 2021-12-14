package DatabasePersistence;

import model.Pet;
import model.User;

import java.util.List;

public interface PetPersistance
{
  /**
   * loads pet from database
   * @param id id of pet
   * @return pet object
   */
  Pet loadPet(int id);
  /**
   * loads all pets from database
   * @return list of pet objects
   */
  List<Pet> loadAll();
  /**
   *
   * @param email
   * @return
   */
  List<Pet> loadListOfUser(String email);
  int save(Pet pet);
  void delete(Pet pet);
  Pet update(Pet pet);
}
