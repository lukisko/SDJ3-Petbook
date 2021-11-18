package model;

import java.util.List;

public interface Model
{
  void AddUser(User user);
  User getUser(String email);
  List<User> getUserList();
}
