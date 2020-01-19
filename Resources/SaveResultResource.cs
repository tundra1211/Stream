using System.ComponentModel.DataAnnotations;

namespace Stream.API.Resources
{
    public class SaveResultResource
    {       
        [Required]       
        public int stdID {get;set;}
        [Required]
        [Range (0,100)]
        public double score {get;set;}
    }
}