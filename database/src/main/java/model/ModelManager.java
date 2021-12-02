package model;

import DatabasePersistence.*;

import java.util.List;

public class ModelManager implements Model
{

  private UserPersistence userPersistence;
  private PetPersistance petPersistance;
  private CityPersistence cityPersistence;
  private CountryPersistence countryPersistence;


  public ModelManager(){
    userPersistence = new UserDatabase();
    petPersistance = new PetDatabase();
    cityPersistence = new CityDatabase();
    countryPersistence = new CountryDatabase();
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
    User user = userPersistence.loadUser(email);
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

  @Override public void addCity(String name, City city) {
    Country country = countryPersistence.loadCountry(name);
    cityPersistence.save(country, city);
  }

  @Override public void removeCity(City city)
  {
    cityPersistence.delete(city);
  }

  @Override public Country getCountry(String name)
  {
    return countryPersistence.loadCountry(name);
  }

  @Override public List<Country> getAllCountries()
  {
    return countryPersistence.loadAll();
  }

  @Override public void addCountry(Country country)
  {
    countryPersistence.save(country);
  }

  @Override public void removeCountry(Country country)
  {
    countryPersistence.delete(country);
  }
}
