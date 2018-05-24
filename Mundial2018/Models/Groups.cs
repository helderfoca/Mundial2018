using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mundial2018.Models {
    public class Groups {

        public Groups()
        {
            Nations = new HashSet<Nations>();
        }

        [Key]
        public int ID { get; set; }

        public string GroupLetter { get; set; }

        public virtual ICollection<Nations> Nations { get; set; }
    }
}