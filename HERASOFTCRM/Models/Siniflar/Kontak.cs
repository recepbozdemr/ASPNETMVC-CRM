using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HERASOFTCRM.Models.Siniflar
{
    public class Kontak
    {
        [Key]
        public int KontakID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string KontakAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string KontakSoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string KontakTelefon { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string KontakMail { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string KontakIl { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string KontakIlce { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string KontakAdres { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(255)]
        public string KontakNot { get; set; }


    }
}