using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mundial2018.Models
{
    public class Nations
    {


        public Nations()
        {
            Players = new HashSet<Players>();
        }

        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Flag { get; set; }

        [ForeignKey("Group")]
        public int GroupFK { get; set; }
        public virtual Groups Group { get; set; }

        public virtual ICollection<Players> Players { get; set; }

    }
}