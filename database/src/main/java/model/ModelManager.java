package model;

import DatabasePersistence.PetDatabase;
import DatabasePersistence.PetPersistance;
import DatabasePersistence.UserDatabase;
import DatabasePersistence.UserPersistence;

import java.util.List;

public class ModelManager implements Model
{

  private UserPersistence userPersistence;
  private PetPersistance petPersistance;


  public ModelManager(){
    userPersistence = UserDatabase.getInstance();
    petPersistance = PetDatabase.getInstance();
  }

  @Override public void addUser(User user)
  {
    System.out.println("model add");
    userPersistence.save(user);
  }

  @Override public User getUser(String email)
  {
    return userPersistence.loadUser(email);
  }

  @Override public List<User> getAllUsers()
  {
    return userPersistence.loadAll();
  }

  @Override public Pet getPet(int id) {
    return petPersistance.loadPet(id);
  }

  @Override public List<Pet> getAllPets() {
    return petPersistance.loadAll();
  }

  @Override public List<Pet> getPetList(String email) {
    return petPersistance.LoadListOf(email);
  }

  @Override public void addPet(String email, Pet pet) {
    User user = userPersistence.loadUser(email);
    petPersistance.save(user, pet);
  }
}
