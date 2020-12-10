using MyProject.Core.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities.Tables
{
    [Table("KULLANICI")]
    public class Kullanici: CoreEntity
    {
        [Column("ID")]
        public int ID { get; set; }
        [Column("ADI")]
        public string Adi { get; set; }
        [Column("SEHIR")]
        public string Sehir { get; set; }

    }
}
