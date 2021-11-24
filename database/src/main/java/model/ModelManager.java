package model;

import DatabasePersistence.UserDatabase;
import DatabasePersistence.UserPersistence;

import java.util.List;

public class ModelManager implements Model
{

  private UserPersistence userPersistence;


  public ModelManager(){
    userPersistence = UserDatabase.getInstance();
  }

  @Override public void addUser(User user)
  {
    userPersistence.save(user);
  }

  @Override public User getUser(String email)
  {
    return userPersistence.loadUser(email);
  }

  @Override public List<User> getUserList()
  {
    return userPersistence.loadAll();
  }
}
