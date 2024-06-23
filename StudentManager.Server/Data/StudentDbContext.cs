using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models.Entity;

namespace StudentManager.Server.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var data = new List<Student>()
            {


 new Student
 {
    Id = Guid.NewGuid(),
    Name = "Alice Dupont",
    Class = "4A",
    Email = "alice.dupont@collegesjb.com",
},

new Student
{
    Id = Guid.NewGuid(),
    Name = "Marc Durand",
    Class = "5B",
    Email = "marc.durand@collegesjb.com",
},

new Student
{
    Id = Guid.NewGuid(),
    Name = "Julie Martin",
    Class = "3C",
    Email = "julie.martin@collegesjb.com",
},

new Student
{
    Id = Guid.NewGuid(),
    Name = "Pierre Dubois",
    Class = "2D",
    Email = "pierre.dubois@collegesjb.com",
},

new Student
{
    Id = Guid.NewGuid(),
    Name = "Sophie Lefevre",
    Class = "1A",
    Email = "sophie.lefevre@collegesjb.com",
},

new Student
{
    Id = Guid.NewGuid(),
    Name = "Paul Moreau",
    Class = "4B",
    Email = "paul.moreau@collegesjb.com",
},

new Student
{
    Id = Guid.NewGuid(),
    Name = "Lucie Petit",
    Class = "5C",
    Email = "lucie.petit@collegesjb.com",
},

new Student
{
    Id = Guid.NewGuid(),
    Name = "Thomas Richard",
    Class = "3A",
    Email = "thomas.richard@collegesjb.com",
},

new Student
{
    Id = Guid.NewGuid(),
    Name = "Emma Michel",
    Class = "2B",
    Email = "emma.michel@collegesjb.com",
},

new Student
{
    Id = Guid.NewGuid(),
    Name = "Antoine Leroy",
    Class = "1C",
    Email = "antoine.leroy@collegesjb.com",
},

new Student
{
    Id = Guid.NewGuid(),
    Name = "Claire Roux",
    Class = "4C",
    Email = "claire.roux@collegesjb.com",
},

new Student
{
    Id = Guid.NewGuid(),
    Name = "Julien Vincent",
    Class = "5A",
    Email = "julien.vincent@collegesjb.com",
},

new Student
{
    Id = Guid.NewGuid(),
    Name = "Manon Garnier",
    Class = "3B",
    Email = "manon.garnier@collegesjb.com",
},

new Student
{
    Id = Guid.NewGuid(),
    Name = "Nicolas Lambert",
    Class = "2C",
    Email = "nicolas.lambert@collegesjb.com",
},

new Student
{
    Id = Guid.NewGuid(),
    Name = "Elodie Fournier",
    Class = "1B",
    Email = "elodie.fournier@collegesjb.com",
},

new Student
{
    Id = Guid.NewGuid(),
    Name = "Mathieu Chevalier",
    Class = "4D",
    Email = "mathieu.chevalier@collegesjb.com",
},

new Student
{
    Id = Guid.NewGuid(),
    Name = "Isabelle Francois",
    Class = "5D",
    Email = "isabelle.francois@collegesjb.com",
},

new Student
{
    Id = Guid.NewGuid(),
    Name = "Hugo Dupuis",
    Class = "3D",
    Email = "hugo.dupuis@collegesjb.com",
},

new Student
{
    Id = Guid.NewGuid(),
    Name = "Camille Fontaine",
    Class = "2A",
    Email = "camille.fontaine@collegesjb.com",
},

new Student
{
    Id = Guid.NewGuid(),
    Name = "Victor Leger",
    Class = "1D",
    Email = "victor.leger@collegesjb.com",
}


              };

            modelBuilder.Entity<Student>().HasData(data);


        }
    }
}
