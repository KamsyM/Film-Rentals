using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Template.DataBase;
using Template.Model;

namespace Template.SeedData
{
    public class ExampleDbInitializer : DropCreateDatabaseIfModelChanges<ExampleDbContext>
    {
        private ExampleDbContext Context;
        protected override void Seed(ExampleDbContext context)
        {
            this.Context = context;
            AddNewFilm("Alie Algol");
            AddNewFilm("Forrest Fortran");
            AddNewFilm("James Java");
        }

        private void AddNewFilm(string name)
        {
            var st = new Film() { FilmName = name };
            Context.Films.Add(st);
        }

        private void AddNewCustomer(string FirstName, string LastName)
        {
            var st = new Customer() { FirstName = FirstName, LastName = LastName };
            Context.Customers.Add(st);
        }

        private void AddNewRental(Film name)
        {
            var st = new Rental() { Film = name };
            Context.Rentals.Add(st);
        }
    }
}
