namespace MeetingApp.Models;

public class MeetingInfo{
   
   public int id { get; set; }
   public string? location { get; set; }
   public DateTime Date { get; set; }
   public int NumberOfPeople { get; set; }
}