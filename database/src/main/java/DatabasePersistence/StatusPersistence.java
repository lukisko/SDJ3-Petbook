package DatabasePersistence;

import model.Pet;
import model.Status;

import java.util.List;

public interface StatusPersistence
{
  /**
   * loads status from database
   * @param id id of status
   * @return status object
   */
  Status loadStatus(int id);
  /**
   * loads statuses of specific pet from database
   * @param id of pet
   * @return list of status objects
   */
  List<Status>  loadStatusOfPet(int id);
  /**
   * loads all statuses of given name
   * @param statusName name of status
   * @return list of status objects
   * @throws IllegalArgumentException if statusName is null
   */
  List<Status>  getAllOf(String statusName);
  /**
   * loads all statuses from database
   * @return list of status objects
   */
  List<Status> loadAll();
  /**
   * saves status into database
   * @param status status object to be saved
   * @return id of saved status
   * @throws IllegalArgumentException if status is null
   */
  int save(Status status);
  /**
   * deletes status from database
   * @param status status to be deleted
   * @throws IllegalArgumentException if status is null or not existing in database
   */
  void delete(Status status);
  /**
   * updates status in database
   * @param status status object with id of status that is wanted to be changed
   * @return updated status object
   * @throws IllegalArgumentException if status is null or not existing in database
   */
  Status update(Status status);
}
