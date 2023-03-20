using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSolution.ViewModels.Models.ConveyResults
{
    [Table("Results")]
    public class Results
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [StringLength(250)]
        [Required]
        [Column(TypeName = "varchar")]
        public string PatientID { set; get; }
        [StringLength(250)]
        [Required]
        [Column(TypeName = "nvarchar")]

        public string Name { set; get; }

        [StringLength(250)]
        public string Email { set; get; }

        [StringLength(250)]
        public string TelephoneNumber { set; get; }

        public int QuestionNumbers { set; get; }
        [StringLength(500)]
        public string Result { set; get; }
        public DateTime CreatedDate { set; get; }


    }
}
