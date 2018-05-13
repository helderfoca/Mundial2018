using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mundial2018.Models
{
    public class Players
    {


        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }
        
        public string Position { get; set; }



        [ForeignKey("Nation")]
        public int NationFK { get; set; }
        public virtual Nations Nation { get; set; }


    }
}