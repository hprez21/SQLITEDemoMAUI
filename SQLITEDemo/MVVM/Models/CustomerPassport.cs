using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLITEDemo.MVVM.Models
{
     public class CustomerPassport
     {
          [ForeignKey(typeof(Customer))]
          public int CustomerId { get; set; }
          [ForeignKey(typeof(Passport))]
          public int PassportId { get; set; }
     }
}
