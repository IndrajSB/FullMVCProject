using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullMVCProject_FilmStation.Models
{
    public class Actor
    {
        public virtual int ActorId { get; set; }
        public virtual string ActorName { get; set; }
        public virtual DateTime ActorDateOfBirth { get; set; }

        public virtual string ActorPlaceOfBirth { get; set; }

        public virtual string ActorAwardCount { get; set; }



    }
}