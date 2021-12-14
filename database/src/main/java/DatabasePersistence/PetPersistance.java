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
   *loads pets owned by specific user from database
   * @param email email of user
   * @return list of pets owned by given user
   */
  List<Pet> loadListOfUser(String email);
  /**
   * saves pet to database
   * @param pet pet object to be saved
   * @return id of saved pet
   * @throws IllegalArgumentException if pet is null
   */
  int save(Pet pet);
  /**
   * deletes pet from database
   * @param pet pet to be deleted
   * @throws IllegalArgumentException if pet is null or not existing in database
   */
  void delete(Pet pet);
  /**
   * changes pet that is all ready existing in database
   * @param pet pet object with id of pet that is wanted to be changed
   * @return updated pet object
   * @throws IllegalArgumentException if pet is null or there is no pet in database with same id as has given one
   */
  Pet update(Pet pet);
}
