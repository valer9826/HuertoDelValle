using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HuertoDelValle.Models
{
    [Table("T_Orden")]
    public class Orden
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        public Proforma ProfId { get; set; }

        public String Direccion { get; set; }

        public String Estado { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechProc { get; set; }

        public Orden() {  
            FechProc = DateTime.Now;
        }
        

        public Decimal Total { get; set; }
    }
}