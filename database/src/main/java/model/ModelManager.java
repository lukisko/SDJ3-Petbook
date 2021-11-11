package model;

import DatabasePersistence.UserDatabase;
import DatabasePersistence.UserPersistence;

public class ModelManager implements Model
{

  private UserPersistence userPersistence;


  public ModelManager(){
    userPersistence = UserDatabase.getInstance();
  }

  @Override public void AddUser(Customer customer)
  {
    userPersistence.save(customer);
  }

  @Override public Customer getUser(String email)
  {
    return userPersistence.load(email);
  }
}
