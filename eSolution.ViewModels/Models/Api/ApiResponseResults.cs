using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSolution.ViewModels.Models.Api
{
    [Table("ApiResponseResults")]
    public class ApiResponseResults
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public int ResultID { set; get; }

        [StringLength(250)]
        [Required]
        [Column(TypeName = "varchar")]
        public string PatientID { set; get; }
        [StringLength(500)]
        [Required]
        [Column(TypeName = "nvarchar")]      
        public string Result { set; get; }

        [StringLength(500)]
        [Required]
        [Column(TypeName = "nvarchar")]
        public string Str1 { set; get; }

        [StringLength(500)]
        [Required]
        [Column(TypeName = "nvarchar")]
        public string Str2 { set; get; }

        [StringLength(500)]
        [Required]
        [Column(TypeName = "nvarchar")]
        public string Str3 { set; get; }

        public DateTime CreatedDate { set; get; }
    }
}
