package model;

import javax.persistence.Entity;
import javax.persistence.Table;

@Entity(name = "message")
@Table(name = "message_table")
public class Message
{
  private int id;
  private Pet sender;
  private Pet receiver;
  private String message;
  private String dateTime;

  public Message(){

  }

  public Pet getReceiver()
  {
    return receiver;
  }

  public Pet getSender()
  {
    return sender;
  }

  public String getDateTime()
  {
    return dateTime;
  }

  public String getMessage()
  {
    return message;
  }

  public void setReceiver(Pet receiver)
  {
    this.receiver = receiver;
  }

  public void setSender(Pet sender)
  {
    this.sender = sender;
  }

  public void setDateTime(String dateTime)
  {
    this.dateTime = dateTime;
  }

  public void setMessage(String message)
  {
    this.message = message;
  }
}
