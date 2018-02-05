using NakedObjects;
using System;

namespace Template.Model
{
    public class Rental
	{
		virtual public int RentalID { get; set; }
		virtual public int FilmOfRental { get; set; }
		virtual public int CustomerOfRental { get; set; } 
		virtual public DateTime DateOfRental { get; set; }
		virtual public DateTime DateOfExpire { get; set; }
	}
}