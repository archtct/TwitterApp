namespace TwTwitter.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TwTwitter.Data.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TwTwitter.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TwTwitter.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Users.AddOrUpdate(
                u => u.Id,
                new User { Id = 1, UserName = "MoMoney" },
                new User { Id = 2, UserName = "LuvsPuppies" },
                new User { Id = 3, UserName = "Food4Thought" },
                new User { Id = 4, UserName = "CleanNrG" }
                );
            context.SaveChanges();

            context.Tweets.AddOrUpdate(
                t => t.MessageId,
                new Tweet { Author = "LuvsPuppies", Message = "Just finished volunteering at the animal shelter today. 3 dogs and 2 cats were adopted today. Yay!", MessageId = 1 },
                new Tweet { Author = "CleanNrG", Message = "START reducing your carbon footprint TODAY!!", MessageId = 2 },
                new Tweet { Author = "MoMoney", Message = "Just bought me a shiny new Porshe :)", MessageId = 3 },
                new Tweet { Author = "LuvsPuppies", Message = "The shelter just took in a dog who was neglected and abused. So sad.", MessageId = 4 },
                new Tweet { Author = "Food4Thought", Message = "Goat meat is leaner than beef. Yum.", MessageId = 5 },
                new Tweet { Author = "Food4Thought", Message = "Did you know that some kids nowadays do not know how to tell time by looking at an analog clock?", MessageId = 6 }
                );
            context.SaveChanges();
        }
    }
}
