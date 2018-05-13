using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public virtual ICollection<Players> Players { get; set; }

    }
}