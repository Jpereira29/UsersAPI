using System.ComponentModel.DataAnnotations;

namespace UsersAPI.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string matricula { get; set; }
    }
}
