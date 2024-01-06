using System.ComponentModel.DataAnnotations;

namespace NGUYENTHIVANANH_085.Models;
public class Person 
{
    [Key]
    public string PersonID { get; set; }
    public int Age { get; set; }
    public DateTime NgaySinh { get; set; }

}