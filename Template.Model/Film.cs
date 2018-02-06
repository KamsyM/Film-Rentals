using NakedObjects;
using System;

using System.Collections.Generic;

namespace Template.Model
{
    public class Film
    {
		#region Injected Services
		public IDomainObjectContainer Container { protected get; set; }
		#endregion

		[NakedObjectsIgnore]
        public virtual int FilmId { get; set; }

        [Title]
        public virtual string FilmName { get; set; }

		public virtual Categories Category { get; set; }

		public virtual int AgeRating { get; set; }

		public virtual string FilmMaker { get; set; }

		public virtual int YearOfRelease { get; set; }

        [Mask("c")]
		public virtual double Price { get; set; }

		private ICollection<Rental> filmRentals = new List<Rental>();

		public virtual ICollection<Rental> Rentals
		{
			get
			{
				return filmRentals;
			}
			set
			{
				filmRentals = value;
			}
		}

		public Rental CreateNewRental()
		{
			var rental = Container.NewTransientInstance<Rental>();
			rental.Film = this;
			return rental;
		}
	}
}