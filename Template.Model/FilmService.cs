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
    }

}
