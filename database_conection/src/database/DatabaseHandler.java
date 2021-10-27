package database;

import model.Pet;
import model.PetList;

import java.rmi.Naming;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class DatabaseHandler implements Database
{
  @Override
  public PetList getPetList() throws SQLException, RemoteException {
    PetList list = new PetList();
    try (Connection connection = DatabaseConnection.getConnection()) {
      PreparedStatement statement = connection.prepareStatement("select * from Pet");
      ResultSet resultSet = statement.executeQuery();

      while (resultSet.next()){
        int id = resultSet.getInt("id");
        String name = resultSet.getString("name");
        String type = resultSet.getString("type");
        String breed = resultSet.getString("breed");
        String description = resultSet.getString("description");
        list.addPet(new Pet(id, name, type, breed));
      }

    }

    return list;
  }
}
