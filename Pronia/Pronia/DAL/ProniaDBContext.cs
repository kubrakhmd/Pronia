using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Pronia.Models;

namespace Pronia.DAL
{

    public class ProniaDBContext : DbContext

    {

        public ProniaDBContext(DbContextOptions<ProniaDBContext> options) : base(options) { }
        
           public DbSet<Slide>Slides { get; set; }  
        



        }





    }
