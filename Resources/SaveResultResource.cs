using System.ComponentModel.DataAnnotations;

namespace Stream.API.Resources
{
    public class SaveResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
   