package model;

import java.util.List;

public interface Model
{
  void addUser(User user);
  User getUser(String email);
  List<User> getAllUsers();
  Pet getPet(int id);
  List<Pet> getAllPets();
  List<Pet> getPetList(String email);
  void addPet(String email,Pet pet);
  City getCity(String name);
  List<City> getAllCities();
  void addCity(City city);
}