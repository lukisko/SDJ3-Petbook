package model;

import javax.persistence.*;

@Entity(name = "message")
@Table(name = "message_table")
public class Message
{
  @Id
  @Column(name = "id")
  @GeneratedValue(strategy = GenerationType.AUTO)
  private int id;
  @ManyToOne
  @JoinColumn(name="sender_id"/*, nullable = false*/)
  private Pet sender;
  @ManyToOne
  @JoinColumn(name="receiver_id"/*, nullable = false*/)
  private Pet receiver;
  @Column(name = "text")
  private String message;
  @Column(name = "dateTime")
  private String dateTime;

  public Message(){//TODO put this into resources
  }

  public int getId()
  {
    return id;
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

  public void setId(int id)
  {
    this.id = id;
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

  public void clear(){
    if(sender != null) sender.clear();
    if(receiver != null) receiver.clear();
  }
}
