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

  @BeforeEach void setUp()
  {
    petPersistance = new PetDatabase();
    cityPersistence = new CityDatabase();
    userPersistence = new UserDatabase();
    pet1 = new Pet("test1",cityPersistence.loadCity("asd"),userPersistence.loadUser("asd"));
    pet1.setGender('M');
    pet2 = new Pet("test2",cityPersistence.loadCity("asd"),userPersistence.loadUser("asd"));
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



  @Test void addPet()
  {

  }
  @Test void removePet()
  {

  }
  @Test void getAllPets()
  {

  }
  @Test void getAllPetsOfUser()
  {

  }









}
