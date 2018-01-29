using NakedObjects;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Template.Model
{
    public class Film
    {
        [NakedObjectsIgnore]
        public virtual int FilmId { get; set; }

        [Title]
        public virtual string FilmName { get; set; }

		public virtual string Category { get; set; }

		public virtual string FilmMaker { get; set; }

		public virtual DateTime YearOfRelease { get; set; }

		public virtual double Price { get; set; }

		public virtual int AgeRating { get; set; }
	}
}
