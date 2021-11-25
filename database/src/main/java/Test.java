import com.google.gson.Gson;
import mediator.Comunication;
import mediator.ComunicationUser;
import model.*;

public class Test {
  public static void main(String[] args) {
    Model model = new ModelManager();
//    User user = new User();
//    user.setEmail("d");
//    model.addUser(user);
//    User user = model.getUser("asd");
//    System.out.println(user);

//    User user = new User();
//    user.setEmail("asd");
//    City city = new City();
//    city.setName("AS");
//
//    Pet pet = new Pet();
//    pet.setId(1);
//    pet.setCity(city);
//    model.addPet("asd",pet);

//    model.addCity(city);

    User user = new User();
    user.setEmail("pleva@usa.com");
    ComunicationUser comunicationUser = new ComunicationUser("user","Get", user);
    System.out.println(model.getUser(comunicationUser.getValue().getEmail()));
  }
}
