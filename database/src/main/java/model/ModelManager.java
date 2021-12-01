package model;

import DatabasePersistence.*;

import java.util.List;

public class ModelManager implements Model
{

  private UserPersistence userPersistence;
  private PetPersistance petPersistance;
  private CityPersistence cityPersistence;


  public ModelManager(){
    userPersistence = new UserDatabase();
    petPersistance = new PetDatabase();
    cityPersistence = new CityDatabase();
  }

  @Override public void addUser(User user)
  {
    userPersistence.save(user);
  }

  @Override public void removeUser(User user)
  {
    userPersistence.delete(user);
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
    return petPersistance.LoadListOfUser(email);
  }

  @Override public void addPet(String email, Pet pet) {
    if(cityPersistence.loadCity(pet.getCity().getName()) == null){
      addCity(pet.getCity());
    }
    User user = userPersistence.loadUser(email);
    System.out.println(user);
    petPersistance.save(user, pet);
  }
  @Override public void removePet(Pet pet)
  {
    petPersistance.delete(pet);
  }

  @Override public City getCity(String name) {
    return cityPersistence.loadCity(name);
  }

  @Override public List<City> getAllCities() {
    return cityPersistence.loadAll();
  }

  @Override public void addCity(City city) {
    cityPersistence.save(city);
  }

  @Override public void removeCity(City city)
  {
    cityPersistence.delete(city);
  }
}
