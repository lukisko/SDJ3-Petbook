package DatabasePersistence;

import model.Pet;
import model.User;

import javax.persistence.Query;
import java.util.List;

public class PetDatabase implements PetPersistance
{
  private Database database;

  public PetDatabase(){
    database = Database.getInstance();
  }

  @Override public Pet loadPet(String email)
  {
    return null;
  }

  @Override public List<Pet> loadAll()
  {
    Query query = database.getEntityManager().createQuery("SELECT c FROM pet_table c");
    List<Pet> petList = query.getResultList();
    return petList;
  }

  @Override public void save(Pet pet)
  {

  }
}
