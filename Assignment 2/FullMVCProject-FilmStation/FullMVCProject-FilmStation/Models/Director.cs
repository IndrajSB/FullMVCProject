using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullMVCProject_FilmStation.Models
{
    public class Director
    {
        public virtual int DirectorId { get; set; }
        public virtual string DirectorName { get; set; }
        public virtual DateTime DirectorDateOfBirth { get; set; }
        public virtual string DirectorPlaceOfBirth { get; set; }
        public virtual int DirectorAwardCount { get; set; }
        
        //public virtual string Biography { get; set; }
        //
    }
}