using NakedObjects;
using System;
using System.Linq;

namespace Template.Model
{
    public class Rental
	{
        #region Injected Services
        //An implementation of this interface is injected automatically by the framework
        public IDomainObjectContainer Container { set; protected get; }
        #endregion

        #region LifeCycleMethods
        public void Persisting()
        {
            DateOfExpire = DateOfRental.AddDays(7);
        }
        #endregion

        [NakedObjectsIgnore]
        virtual public int RentalID { get; set; }

        [Title]
		virtual public Film Film { get; set; }

        public IQueryable<Film> AutoCompleteFilm(string matching)
        {
            return Container.Instances<Film>();
        }

        virtual public Customer Customer { get; set; }

        public IQueryable<Customer> AutoCompleteCustomer(string matching)
        {
            return Container.Instances<Customer>();
        }

        virtual public DateTime DateOfRental { get; set; }

        [Disabled][Hidden(WhenTo.UntilPersisted)]
		virtual public DateTime DateOfExpire { get; set; }

		[Disabled][Hidden(WhenTo.UntilPersisted)]
		public virtual RentalStatus Status { get { return DateOfExpire < DateTime.Today ? RentalStatus.Expired : RentalStatus.NotExpired; } }
	}
}