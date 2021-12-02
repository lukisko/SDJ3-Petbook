package model;

import java.util.List;

public interface Model
{
  void addUser(User user);
  void removeUser(User user);
  User getUser(String email);
  List<User> getAllUsers();

  Pet getPet(int id);
  List<Pet> getAllPets();
  List<Pet> getPetList(String email);
  void addPet(String email,Pet pet);
  void removePet(Pet pet);

  City getCity(String name);
  List<City> getAllCities();
  void addCity(String name, City city);
  void removeCity(City city);

  Country getCountry(String name);
  List<Country> getAllCountries();
  void addCountry(Country country);
  void removeCountry(Country country);
}
