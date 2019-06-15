using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullMVCProject_FilmStation.Models
{
    public class Film
    {

        public virtual int FilmId { get; set; }
        public virtual string FilmName { get; set; }

        public virtual int FilmLength { get; set; }

        public virtual string Language { get; set; }

        public virtual DateTime ReleaseDate { get; set; }

        public virtual string AgeRating { get; set; }

        public virtual int FilmRating { get; set; }

    }
}