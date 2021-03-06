﻿using NakedObjects;
using System;

namespace Template.Model
{
    public class Customer
    {
		#region Injected Services
		public IDomainObjectContainer Container { protected get; set; }
		#endregion

		[NakedObjectsIgnore]
        virtual public int CustomerId { get; set; }

        [Title]
        virtual public string FirstName { get; set; }
        virtual public string LastName { get; set; }
        virtual public DateTime DateOfBirth { get; set; }

		public Rental CreateNewRental()
		{
			var rental = Container.NewTransientInstance<Rental>();
			rental.Customer = this;
			return rental;
		}
	}
}