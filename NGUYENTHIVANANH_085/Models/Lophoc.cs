using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NGUYENTHIVANANH_085.Models
{
    [Table("Lophocs")]
    public class Lophoc{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Malop { get; set; }
        [StringLength(50)]
        public string Tenlop { get; set; }

    }
    
}