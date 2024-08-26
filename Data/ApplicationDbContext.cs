using GameZone.Models;
using Microsoft.EntityFrameworkCore;

namespace GameZone.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) :base(dbContextOptions)
        {
            
        }
        public DbSet<Game> Games { get; set; }

        public DbSet<Catogory> Categories { get; set; }

        public DbSet<Device>  Devices { get; set; }

        public DbSet<GameDevice> GameDevices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Catogory>().HasData(new List<Catogory>
            {
            
                new Catogory {Id= 1 ,Name ="Sport" }
              , new Catogory {Id=2 ,Name ="Action" }
              , new Catogory {Id =3 ,Name ="Adventure" }
              , new Catogory {Id =4 ,Name ="Racing" }
              , new Catogory {Id =5 ,Name ="Fighting" }
              , new Catogory {Id =6 ,Name ="Film" }

            
            
            });
            modelBuilder.Entity<Device>().HasData(new List<Device> 
            {
                new Device {Id=1 ,Name="PlayStation",Icon="bi bi_PlayStation" }
              , new Device {Id=2 , Name="Xbox"      ,Icon="bi bi_Xbox" }
              , new Device {Id=3 , Name="Nintendo"  ,Icon="bi bi_Nintendo" }
              , new Device {Id=4 ,Name="Pc"         ,Icon ="bi bi_Pc_display" }



            });
            

            
              modelBuilder.Entity<GameDevice>().HasKey(e=> new {e.DeviceId ,e.GameId}); // Composite Key as primary Key
            base.OnModelCreating(modelBuilder);
        }
    }
}
