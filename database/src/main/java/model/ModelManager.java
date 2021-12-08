package model;

import DatabasePersistence.*;

import java.util.List;

public class ModelManager implements Model
{

  private UserPersistence userPersistence;
  private PetPersistance petPersistance;
  private CityPersistence cityPersistence;
  private CountryPersistence countryPersistence;
  private StatusPersistence statusPersistence;


  public ModelManager(){
    userPersistence = new UserDatabase();
    petPersistance = new PetDatabase();
    cityPersistence = new CityDatabase();
    countryPersistence = new CountryDatabase();
    statusPersistence = new StatusDatabase();
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

  @Override public int addPet(Pet pet) {
    return petPersistance.save(pet);
  }
  @Override public void removePet(Pet pet)
  {
    petPersistance.delete(pet);
  }

  @Override public Pet updatePet(Pet pet)
  {
    Pet toUpdate = petPersistance.loadPet(pet.getId());
    toUpdate.setPet(pet);
    return petPersistance.update(toUpdate);
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

  @Override public Status getStatus(int id)
  {
    return statusPersistence.loadStatus(id);
  }

  @Override public List<Status> getStatusList(int id)
  {
    return statusPersistence.loadStatusOfPet(id);
  }

  @Override public List<Status> getAllStatuses()
  {
    return statusPersistence.loadAll();
  }

  @Override public int addStatus(Status status)
  {
    status.setPet(getPet(status.getPet().getId()));
    return statusPersistence.save(status);
  }

  @Override public void removeStatus(Status status)
  {
    statusPersistence.delete(status);
  }

  @Override public Status updateStatus(Status status)
  {
    Status toUpdate = statusPersistence.loadStatus(status.getId());
    toUpdate.setStatus(status);
    return statusPersistence.update(toUpdate);
  }
}
