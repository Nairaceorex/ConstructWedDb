using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace ConstructWedDb.Models
{
    public class Brigade
    {
        public long ID { get; set; }
        public long? Staff1ID { get; set; }
        [Display(Name = "ID_Сотрудник1")]

        public Staff Staff1 { get; set; }

        public long? Staff2ID { get; set; }
        [Display(Name = "ID_Сотрудник2")]
        
        public Staff Staff2 { get; set; }

        public long? Staff3ID { get; set; }
        [Display(Name = "ID_Сотрудник3")]
     
        public Staff Staff3 { get; set; }
        public IList<Order> Order { get; set; }
    }
}
