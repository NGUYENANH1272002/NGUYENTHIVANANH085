using Microsoft.EntityFrameworkCore;
using NGUYENTHIVANANH_085.Models;

namespace NGUYENTHIVANANH_085.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
       
    }
}