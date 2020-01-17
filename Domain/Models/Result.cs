namespace Stream.API.Domain.Models
{
    public class Result
    {
        public int Id { get; set; }
        public double score {get;set;}
        
        public int stdID {get;set;}
        public Student Student {get;set;}
   
    }
}