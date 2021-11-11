package model;

public interface Model
{
  void AddUser(Customer customer);
  Customer getUser(String email);
}
