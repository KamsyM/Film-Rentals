using NakedObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
