using NakedObjects;
using System.Linq;

namespace Template.Model
{
    public class FilmService
    {
        #region Injected Services
        public IDomainObjectContainer Container { set; protected get; }
        #endregion

        public Film CreateNewFilm()
        {
            return Container.NewTransientInstance<Film>();
        }

        public IQueryable<Film> AllFilms()
        {
            return Container.Instances<Film>();
        }

        public IQueryable<Film> FindFilmByName(string name)
        {
            return AllFilms().Where(c => c.FilmName.ToUpper().Contains(name.ToUpper()));
        }

        public IQueryable<Film> FindFilmByCategory(Categories category)
        {
            return AllFilms().Where(c => c.Category==category);
        }

		public IQueryable<Film> FindFilmByYearOfRelease(int year)
		{
			return AllFilms().Where(c => c.DateOfRelease.Year==year);
		}

		public IQueryable<Film> FindFilmByAgeRating(AgeRating ageRating)
		{
			return AllFilms().Where(c => c.AgeRating == ageRating);
		}

		public IQueryable<Film> FindFilmByFilmMaker(string filmMaker)
		{
			return AllFilms().Where(c => c.FilmMaker.ToUpper().Contains(filmMaker.ToUpper()));
		}

		public IQueryable<Film> FindFilmByPrice(PriceComparator compare, double cost)
		{
			return PriceComparator.Equal == compare ? AllFilms().Where(c => c.Price==cost)
				: PriceComparator.HigherThan == compare ? AllFilms().Where(c => c.Price>cost)
				: AllFilms().Where(c => c.Price<cost);
		}
	}
}