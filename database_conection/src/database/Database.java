package database;

import model.PetList;

import java.rmi.RemoteException;
import java.sql.SQLException;

public interface Database
{
  PetList getPetList() throws SQLException, RemoteException;
}
