import com.google.gson.Gson;
import mediator.Comunication;
import model.*;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;

import javax.imageio.spi.ServiceRegistry;
import java.util.List;
import java.util.Random;

public class Test {


  public static void main(String[] args) {

//    Gson gson = new Gson();
//    Model model = new ModelManager();
//    Pet pet = model.getPet(6);
//    pet.setName("working");
//    String received = gson.toJson(pet);
//
//    Pet thepet = gson.fromJson(received, Pet.class);
//    Pet pet2 = model.getPet(6);
//    pet2.setPet(thepet);
//    model.updatePet(pet2);
    Model model = new ModelManager();
    //System.out.println(model.getAllUsers());
    System.out.println(model.getAllPets());
    System.out.println(model.getAllPets());
  }
}
