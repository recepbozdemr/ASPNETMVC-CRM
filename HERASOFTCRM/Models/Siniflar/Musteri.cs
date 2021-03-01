using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HERASOFTCRM.Models.Siniflar
{
    public class Musteri
    {
        [Key]
        public int musteriID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string musteriUnvan { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string musteriTelefon { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string  musteriMail { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(17)]
        public string musteriIl { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string musteriIlce { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string musteriAdres { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(12)]
        public string musteriVergino { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string musteriVergiDairesi { get; set; }
   
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string webAdres { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string musteriIlgili { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string musteriIlgilino { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(750)]
        public string musteriNot { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string musteriSozlesmeTutar { get; set; }
        public int KategoriID { get; set; }
        public virtual Kategori Kategoris { get; set; }


    }
}