import model.Customer;
import model.Model;
import model.ModelManager;

public class Main
{
  public static void main(String[] args)
  {
    Model model = new ModelManager();
    Customer customer = new Customer();
    customer.setEmail("asd");
    //model.AddUser(customer);
    System.out.println(model.getUser("asd"));
  }
}
