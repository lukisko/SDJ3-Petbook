package DatabasePersistence;

import model.Pet;
import model.Status;

import java.util.List;

public interface StatusPersistence
{
  Status loadStatus(int id);
  List<Status>  loadStatusOfPet(int id);
  List<Status>  getAllOf(String statusName);
  List<Status> loadAll();
  int save(Status status);
  void delete(Status status);
  Status update(Status status);
}
