using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace ConstructWedDb.Models
{
    public class Order
    {
        public long ID { get; set; }
        [Display(Name = "Цена")]
        public int Price { get; set; }
        [Display(Name = "Дата начала")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Дата оканчания")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Отметка завершения")]
        public bool CompletionMark { get; set; }
        [Display(Name = "Об оплате")]
        public bool AboutPayment { get; set; }
        public long? CustomerID { get; set; }
        [Display(Name = "ID_Заказчик")]
        public Customer Customer { get; set; }
        public long? TypeOfJobID { get; set; }
        [Display(Name = "ID_Вид работы")]
        public TypeOfJob TypeOfJob { get; set; }
        public long? BrigadeID { get; set; }
        [Display(Name = "ID_Бригада")]
        public Brigade Brigade { get; set; }
        public long? StaffID { get; set; }
        [Display(Name = "ID_Сотрудник")]
        public Staff Staff { get; set; }
    }
}
