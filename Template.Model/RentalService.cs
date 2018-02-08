using NakedObjects;
using System.Linq;

namespace Template.Model
{
    public class RentalService
    {
        #region Injected Services
        public IDomainObjectContainer Container { set; protected get; }
        #endregion

        public Rental CreateNewRental()
        {
            return Container.NewTransientInstance<Rental>();
        }

        public IQueryable<Rental> AllRentals()
        {
            return Container.Instances<Rental>();
        }

		public IQueryable<Rental> FindRentalByCustomerName(string name)
		{
			return AllRentals().Where(c => c.Customer.FirstName.ToUpper().Contains(name.ToUpper()) || c.Customer.LastName.ToUpper().Contains(name.ToUpper()));
		}

		public IQueryable<Rental> FindRentalByFilmName(string name)
		{
			return AllRentals().Where(c => c.Film.FilmName.ToUpper().Contains(name.ToUpper()));
		}

		public IQueryable<Rental> FindRentalByRentalStatus(RentalStatus status)
		{
            
		}
	}
}
