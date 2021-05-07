using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;


namespace ConstructWedDb.Models
{
    public class Staff
    {
        public long ID { get; set; }
        [Display(Name = "ФИО")]
        public string FullName { get; set; }
        [Display(Name = "Возраст")]
        public int Age { get; set; }
        [Display(Name = "Пол")]
        public string Sex { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Display(Name = "Телефон")]
        public string Phone { get; set; }
        [Display(Name = "Паспортные данные")]
        public string PassportData { get; set; }

        [Display(Name = "Код должности")]
        public long? PositionID { get; set; }

        [Display(Name = "ID_Должности")]
        public Position Position { get; set; }
        public IList<Order> Order { get; set; }
    }
}
