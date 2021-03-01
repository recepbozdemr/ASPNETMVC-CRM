using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace HERASOFTCRM.Models.Siniflar
{
    public class Kullanici
    {
        [Key]
        public int kullaniciId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string kullaniciadi { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Sifre { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string Yetki { get; set; }
    }
}