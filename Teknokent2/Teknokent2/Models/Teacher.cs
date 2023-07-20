using System.ComponentModel.DataAnnotations;

namespace Teknokent2.Models
{
    public class Teacher
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int No  { get; set; }


       
    }
}
