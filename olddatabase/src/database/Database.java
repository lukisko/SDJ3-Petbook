package database;

import model.Pet;
import model.PetList;

import java.rmi.RemoteException;
import java.sql.SQLException;

public interface Database
{
  PetList getPetList() throws SQLException, RemoteException;
  void addPet(Pet pet) throws SQLException, RemoteException;
}
