using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademy.Models
{
    public class Teachers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public short teacher_id { get; set; }
        [Required]
        public string last_name { get; set; }
        [Required]
        public string first_name { get; set; }
        [Required]
        public string middle_name { get; set; }
        [Required]
        public DateTime birth_date { get; set; }
        [Required]
        public DateTime work_since { get; set; }
        [Required]
        public decimal rate { get; set; }
    }
}
