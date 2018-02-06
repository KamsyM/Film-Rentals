using NakedObjects;
using System;

namespace Template.Model
{
    public class Rental
	{
		[NakedObjectsIgnore]
		virtual public int RentalID { get; set; }

		virtual public Film FilmOfRental { get; set; }
		virtual public Customer CustomerOfRental { get; set; } 
		virtual public DateTime DateOfRental { get; set; }
		virtual public DateTime DateOfExpire { get; set; }
	}
}