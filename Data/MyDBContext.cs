using Microsoft.EntityFrameworkCore;
using PetShop.Models;
using System;
using System.ComponentModel;

namespace PetShop.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }

        public DbSet<Animal>? animals { get; set; }
        public DbSet<Category>? categories { get; set; }
        public DbSet<Comment>? comments { get; set; }

        protected override void
            OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<Animal>().HasData

                (new Animal{
                    Id = 1,
                    Name = "lobster",
                    Age = 5,
                    Description = "A rare blue and pink pigmented lobster — referred to as a “cotton candy lobster” only 1 in 100 million lobsters are cotton candy-colored, making lobsterman Coppersmith’s catch off the coast of Portland an extremely rare find.",
                    Picture = "https://bdc2020.o0bc.com/wp-content/uploads/2021/11/blue-lobster-618af4d323eb6-768x432.jpeg?width=900",
                    CategoryId= 1
                },
                new Animal{
                     Id = 2,
                     Name = "nemo",
                     Age = 20,
                     Description = "its actuuly a clown fish",
                     Picture = "https://cdn.shrek-movies.com/1665225772570.png",
                     CategoryId = 1
                },
                new Animal{
                     Id = 3,
                     Name = "platipus",
                     Age = 20,
                     Description = "The platypus is among nature's most unlikely animals. In fact, the first scientists to examine a specimen believed they were the victims of a hoax.",
                     Picture = "https://akcdn.detik.net.id/visual/2020/11/27/platypus_169.jpeg?w=650",
                     CategoryId = 2
                },
                new Animal{
                     Id = 4,
                     Name = "dodo",
                     Age = 20,
                     Description = "an extinct bird that dosnt fly",
                     Picture = "https://render.fineartamerica.com/images/rendered/default/poster/8/10/break/images/artworkimages/medium/3/dodo-bird-spencer-sutton.jpg",
                     CategoryId = 3},
                 new Animal
                 {
                     Id = 5,
                     Name = "Sea turtle",
                     Age = 20,
                     Description = "The seven existing species of sea turtles are the flatback, green, hawksbill, leatherback, loggerhead, Kemp's ridley, and olive ridley sea turtles. All six of the sea turtle species present in US waters (all of those listed above except the flatback) are listed as endangered and/or threatened under the Endangered Species Act.",
                     Picture = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/Green_Sea_Turtle_swimming.jpg/1280px-Green_Sea_Turtle_swimming.jpg",
                     CategoryId = 4
                 },
                 new Animal
                 {
                     Id = 6,
                     Name = "kangaroo",
                     Age = 20,
                     Description = "Kangaroos are four marsupials from the family Macropodidae (macropods, meaning \"large foot\"). In common use the term is used to describe the largest species from this family, the red kangaroo, as well as the antilopine kangaroo, eastern grey kangaroo, and western grey kangaroo. Kangaroos are indigenous to Australia and New Guinea. The Australian government estimates that 42.8 million kangaroos lived within the commercial harvest areas of Australia in 2019, down from 53.2 million in 2013",
                     Picture = "https://upload.wikimedia.org/wikipedia/commons/5/5d/RedRoo.JPG",
                     CategoryId = 2
                 },
                 new Animal
                 {
                     Id = 7,
                     Name = "shark",
                     Age = 12,
                     Description = "Sharks are a really cool they have a lot of teeth and they replace them every coupe of months. they also smell blood from really far away",
                     Picture = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/Negaprion_acutidens_sydney2.jpg/360px-Negaprion_acutidens_sydney2.jpg",
                     CategoryId = 1
                 },
                  new Animal
                  {
                      Id = 8,
                      Name = "gorrila",
                      Age = 36,
                      Description = "Gorillas are herbivorous, predominantly ground-dwelling great apes that inhabit the tropical forests of equatorial Africa. The genus Gorilla is divided into two species: the eastern gorilla and the western gorilla, and either four or five subspecies. The DNA of gorillas is highly similar to that of humans, from 95 to 99% depending on what is included, and they are the next closest living relatives to humans after chimpanzees and bonobos.",
                      Picture = "https://upload.wikimedia.org/wikipedia/commons/b/bb/Gorille_des_plaines_de_l%27ouest_%C3%A0_l%27Espace_Zoologique.jpg",
                      CategoryId = 2
                  }



                 );

            modelBuilder.Entity<Category>().HasData
                
                (new Category { CategoryId=1,Name="Fish"},
                 new Category { CategoryId=2,Name="Mammals"},
                 new Category { CategoryId=3,Name="Birds"},
                 new Category { CategoryId=4,Name ="Reptiles"});

            modelBuilder.Entity<Comment>().HasData

                (new Comment { CommentId = 1, AnimalId = 1, CommentText = "this is my first comment"},
                 new Comment { CommentId = 2, AnimalId = 1, CommentText = "this is my second comment"},
                 new Comment { CommentId = 3, AnimalId = 2, CommentText = "no its nemo"},
                 new Comment { CommentId = 4, AnimalId = 3, CommentText = "PERRYY THE PLATIPUSS" },
                 new Comment { CommentId = 5, AnimalId = 3, CommentText = "lol" }
                );
        
        
        }
    }

            
    
}
