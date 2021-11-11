package DatabasePersistence;

import model.Customer;

public interface UserPersistence
{
  Customer load(String email);
  void save(Customer customer);
}
