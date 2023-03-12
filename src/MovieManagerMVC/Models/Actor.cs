using System.ComponentModel.DataAnnotations;

namespace MovieManagerMVC.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string ProfilePicture { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}
