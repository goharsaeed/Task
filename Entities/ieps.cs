namespace NewHireTask.Entities
{
   public class Iep
   {
    public Guid Id { get; set; }

    public bool Active { get; set; }

    public DateTimeOffset StartDate { get; set; }

    public int? StudentNumber { get; set; }

   } 
}