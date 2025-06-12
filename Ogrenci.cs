using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CAR.ADMIN.Models
{
    [Table("Ogrenci")]
    public class Ogrenci
    {
        public int Id { get; set; }
        public string adSoyad { get; set; }
        public string Adres { get; set; }
        public string eMail { get; set; }
    }
}