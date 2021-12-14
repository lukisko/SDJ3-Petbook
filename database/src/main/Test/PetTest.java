import DatabasePersistence.*;
import model.*;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

public class PetTest
{
  private PetPersistance petPersistance;
  private CityPersistence cityPersistence;
  private UserPersistence userPersistence;
  private Pet pet1;
  private Pet pet2;
  private User user;

  @BeforeEach void setUp()
  {
    petPersistance = new PetDatabase();
    cityPersistence = new CityDatabase();
    userPersistence = new UserDatabase();
    user = userPersistence.loadUser("asd");
    pet1 = new Pet("test1",cityPersistence.loadCity("asd"), user);
    pet1.setGender('M');
    pet2 = new Pet("test2",cityPersistence.loadCity("asd"), user);
    pet2.setGender('F');
  }


  @Test void getPetZero()
  {
    Pet result = petPersistance.loadPet(3);

    assertNull(result);
  }
  @Test void getPetOne()
  {
    int id = petPersistance.save(pet1);
    Pet result = petPersistance.loadPet(id);
    petPersistance.delete(result);

    assertNotNull(result);
    assertEquals(result.getName(),pet1.getName());
  }
  @Test void getPetMany()
  {
    int id1 = petPersistance.save(pet1);
    int id2 = petPersistance.save(pet2);
    Pet result1 = petPersistance.loadPet(id1);
    Pet result2 = petPersistance.loadPet(id2);
    petPersistance.delete(result1);
    petPersistance.delete(result2);

    assertNotNull(result1);
    assertNotNull(result2);
    assertEquals(result1.getName(),pet1.getName());
    assertEquals(result2.getName(),pet2.getName());
  }
  @Test void getPetBoundary()
  {

  }
  @Test void getPetException()
  {

  }



  @Test void addPetZero()
  {
    Pet result = petPersistance.loadPet(3);

    assertNull(result);
  }
  @Test void addPetOne()
  {
    int id = petPersistance.save(pet1);
    Pet result = petPersistance.loadPet(id);
    petPersistance.delete(result);

    assertNotNull(result);
    assertEquals(result.getName(),pet1.getName());
  }
  @Test void addPetMany()
  {
    int id1 = petPersistance.save(pet1);
    int id2 = petPersistance.save(pet2);
    Pet result1 = petPersistance.loadPet(id1);
    Pet result2 = petPersistance.loadPet(id2);
    petPersistance.delete(result1);
    petPersistance.delete(result2);

    assertNotNull(result1);
    assertNotNull(result2);
    assertEquals(result1.getName(),pet1.getName());
    assertEquals(result2.getName(),pet2.getName());
  }
  @Test void addPetBoundary()
  {

  }
  @Test void addPetException()
  {
    assertThrows(IllegalArgumentException.class,() -> petPersistance.save(null));
  }


  @Test void removePetZero()
  {
    int id = petPersistance.save(pet1);
    Pet result = petPersistance.loadPet(id);

    assertNotNull(result);

    petPersistance.delete(result);

    assertNull(petPersistance.loadPet(id));
  }
  @Test void removePetOne()
  {
    int id = petPersistance.save(pet1);
    Pet result = petPersistance.loadPet(id);

    assertNotNull(result);

    petPersistance.delete(result);

    assertNull(petPersistance.loadPet(id));
  }
  @Test void removePetMany()
  {
    int id1 = petPersistance.save(pet1);
    int id2 = petPersistance.save(pet2);
    Pet result1 = petPersistance.loadPet(id1);
    Pet result2 = petPersistance.loadPet(id2);

    assertNotNull(result1);
    assertNotNull(result2);
    assertEquals(result1.getName(),pet1.getName());

    petPersistance.delete(result1);
    petPersistance.delete(result2);

    assertNull(petPersistance.loadPet(id1));
    assertNull(petPersistance.loadPet(id2));
  }
  @Test void removePetBoundary()
  {

  }
  @Test void removePetException()
  {
    assertThrows(IllegalArgumentException.class,() -> petPersistance.delete(null));
  }



  @Test void getAllPetsZero()
  {
    List<Pet> result = petPersistance.loadAll();
    result.removeIf(x -> !x.getName().equals(pet1.getName()) && !x.getName()
        .equals(pet2.getName()));
    assertEquals(result.size(), 0);
  }
  @Test void getAllPetsOne()
  {
    int id1 = petPersistance.save(pet1);
    List<Pet> result = petPersistance.loadAll();
    result.removeIf(x -> !x.getName().equals(pet1.getName()) && !x.getName()
        .equals(pet2.getName()));
    petPersistance.delete(petPersistance.loadPet(id1));
    assertEquals(result.size(), 1);
  }
  @Test void getAllPetsMany()
  {
    int id1 = petPersistance.save(pet1);
    int id2 = petPersistance.save(pet2);
    List<Pet> result = petPersistance.loadAll();
    result.removeIf(x -> !x.getName().equals(pet1.getName()) && !x.getName()
        .equals(pet2.getName()));
    petPersistance.delete(petPersistance.loadPet(id1));
    petPersistance.delete(petPersistance.loadPet(id2));
    assertEquals(result.size(), 2);
  }
  @Test void getAllPetsBoundary()
  {

  }
  @Test void getAllPetsException()
  {

  }


  @Test void getAllPetsOfUserZero()
  {
    List<Pet> result = petPersistance.loadListOfUser(user.getEmail());

    assertEquals(0,result.size());
  }
  @Test void getAllPetsOfUserOne()
  {
    int id1 = petPersistance.save(pet1);
    List<Pet> result = petPersistance.loadListOfUser(user.getEmail());
    petPersistance.delete(petPersistance.loadPet(id1));

    assertEquals(1,result.size());
    assertEquals(user.getEmail(),result.get(0).getUser().getEmail());
  }
  @Test void getAllPetsOfUserMany()
  {
    int id1 = petPersistance.save(pet1);
    int id2 = petPersistance.save(pet2);
    List<Pet> result = petPersistance.loadListOfUser(user.getEmail());
    petPersistance.delete(petPersistance.loadPet(id1));
    petPersistance.delete(petPersistance.loadPet(id2));

    assertEquals(2,result.size());
    assertEquals(user.getEmail(),result.get(0).getUser().getEmail());
    assertEquals(user.getEmail(),result.get(1).getUser().getEmail());
  }
  @Test void getAllPetsOfUserBoundary()
  {

  }
  @Test void getAllPetsOfUserException()
  {
    assertThrows(IllegalArgumentException.class,() -> petPersistance.delete(null));
  }




  @Test void updatePet(){

  }





}
