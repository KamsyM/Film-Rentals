using NakedObjects;
using System.Linq;


namespace Template.Model
{
    //This example service acts as both a 'repository' (with methods for
    //retrieving objects from the database) and as a 'factory' i.e. providing
    //one or more methods for creating new object(s) from scratch.
    public class CustomerService
    {
        #region Injected Services
        //An implementation of this interface is injected automatically by the framework
        public IDomainObjectContainer Container { set; protected get; }
        #endregion
        public Customer CreateNewCustomer()
        {
            return Container.NewTransientInstance<Customer>();
        }

        public IQueryable<Customer> AllCustomers()
        {
            return Container.Instances<Customer>();
        }

        public IQueryable<Customer> FindCustomerByName(string name)
        {
            return AllCustomers().Where(c => c.FirstName.ToUpper().Contains(name.ToUpper()) || c.LastName.ToUpper().Contains(name.ToUpper()));
        }

		public IQueryable<Customer> FindFilmByYearOfBirth(int year)
		{
			return AllCustomers().Where(c => c.DateOfBirth.Year == year);
		}
	}
}
