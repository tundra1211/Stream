namespace Stream.API.Resources
{
public class ResultResource
    {
        public int Id { get; set; }
        public double score {get;set;}
        
        public StudentResource Student {get;set;}
    }
}