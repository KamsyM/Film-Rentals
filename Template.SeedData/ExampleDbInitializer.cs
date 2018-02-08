using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Template.DataBase;
using Template.Model;

namespace Template.SeedData
{
    public class ExampleDbInitializer : DropCreateDatabaseIfModelChanges<ExampleDbContext> //DropCreateDatabaseAlways , DropCreateDatabaseIfModelChanges
    {
        private ExampleDbContext Context;
        protected override void Seed(ExampleDbContext context)
        {
            this.Context = context;
            AddNewCustomer("Alie", "Algol", new DateTime(1993,12,25));
            AddNewCustomer("Forrest", "Fortran", new DateTime(1990,05,10));
            AddNewCustomer("James", "Java", new DateTime(2000,02,16));
			AddNewFilm("Hello World", Categories.Drama, "World", new DateTime(2018, 12, 25), 5.00, AgeRating.NC17);
			AddNewFilm("MOON", Categories.Comedy, "SUN", new DateTime(2000, 11, 25), 5.00, AgeRating.PG13);
			AddNewFilm("Goodbye", Categories.Adventure, "Hello", new DateTime(2015, 09, 01), 5.00, AgeRating.PG);
		}

        private void AddNewFilm(string name, Categories category, string filmmaker, DateTime dateofrelease, double price, AgeRating agerating)
        {
            var st = new Film() { FilmName = name , Category = category, FilmMaker = filmmaker, DateOfRelease = dateofrelease, Price = price, AgeRating = agerating};
            Context.Films.Add(st);
            Context.SaveChanges();
        }

        private void AddNewCustomer(string FirstName, string LastName, DateTime dob)
        {
            var st = new Customer() { FirstName = FirstName, LastName = LastName, DateOfBirth = dob };
            Context.Customers.Add(st);
            Context.SaveChanges();
        }

        private void AddNewRental(Film name, Customer customerofrental, DateTime dateofrental)
        {
            var st = new Rental() { Film = name, Customer = customerofrental, DateOfRental = dateofrental};
            Context.Rentals.Add(st);
            Context.SaveChanges();
        }
    }
}
