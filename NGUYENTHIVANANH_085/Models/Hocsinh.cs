using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NGUYENTHIVANANH_085.Models;
public class Hocsinh
{
    [Key]
    public string? PersonID { get; set; }
    [ForeignKey("PersonID")]
    public Person? Person { get; set; }
    public string Fullname { get; set; }
    public string Address { get; set; }


}