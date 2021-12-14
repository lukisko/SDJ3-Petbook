package DatabasePersistence;

import model.Pet;

import javax.persistence.Query;
import javax.persistence.criteria.CriteriaQuery;
import java.util.List;

public class  PetDatabase implements PetPersistance
{
  private Database database;



  public PetDatabase(){
    database = Database.getInstance();
  }



  @Override public Pet loadPet(int id)
  {
    database.beginSession();
    Pet pet = database.getSession().get(Pet.class,id);
    if(pet != null)
    {
      pet.clear();
    }
    return pet;
  }

  @Override public List<Pet> loadAll()
  {
    database.beginSession();
    CriteriaQuery<Pet> criteria = database.getBuilder().createQuery(Pet.class);
    criteria.from(Pet.class);
    List<Pet> data = database.getSession().createQuery(criteria).getResultList();
    if(data != null)
    {
      data.forEach(Pet::clear);
    }
    return data;
  }

  @Override public List<Pet> loadListOfUser(String email) {
    if(email == null) throw new IllegalArgumentException();
    database.beginSession();
    Query query = database.getSession().createQuery("SELECT c FROM pet c WHERE user_email = :emailValue");
    query.setParameter("emailValue",email);
    List<Pet> petList = query.getResultList();
    if(petList != null){
      petList.forEach(Pet::clear);
    }
    return petList;
  }

  @Override public int save(Pet pet)
  {
    if(pet == null) throw new IllegalArgumentException();
    database.beginSession();
    database.getSession().save(pet);
    database.getSession().getTransaction().commit();
    database.getSession().close();
    return pet.getId();
  }

  @Override public void delete(Pet pet)
  {
    if(pet == null) throw new IllegalArgumentException();
    database.beginSession();
    database.getSession().delete(pet);
    database.getSession().getTransaction().commit();
    database.getSession().close();
  }
  @Override public Pet update(Pet pet)
  {
    if(pet == null) throw new IllegalArgumentException();

    Pet petToUpdate = loadPet(pet.getId());
    petToUpdate.setPet(pet);

    database.beginSession();
    database.getSession().update(petToUpdate);
    database.getSession().getTransaction().commit();
    database.getSession().close();
    return loadPet(pet.getId());
  }
}
