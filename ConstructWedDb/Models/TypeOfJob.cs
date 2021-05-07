using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace ConstructWedDb.Models
{
    public class TypeOfJob
    {
        public long ID { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Цена")]
        public string Price { get; set; }
        public long? Material1ID { get; set; }
        [Display(Name = "ID_Материал1")]
       
        public Material Material1 { get; set; }
        public long? Material2ID { get; set; }
        [Display(Name = "ID_Материал2")]
       
        public Material Material2 { get; set; }
        public long? Material3ID { get; set; }
        [Display(Name = "ID_Материал3")]
    
        public Material Material3 { get; set; }
        public IList<Order> Order { get; set; }
    }
}
