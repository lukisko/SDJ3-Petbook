import model.Model;
import model.ModelManager;
import model.Pet;
import model.User;

public class Testing {
  public static void main(String[] args) {
    Model model = new ModelManager();
    User user = new User();
    user.setName("asd");
    user.setEmail("asd");
    user.addPet(new Pet());

    model.addUser(user);
  }
}
