using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace new1.Models
{
    public class Driver
    {
        public int Id { get; set; }                      

        [Required, StringLength(100)]
        [DisplayName ("الاسم")]
        public string Name { get; set; } = string.Empty; 

        [Phone, StringLength(20)]
        [DisplayName("رقم السائق")]
        public string Phone { get; set; } = string.Empty;

        [StringLength(50)]
        [DisplayName("نوع السيارة")]
        public string CarType { get; set; } = string.Empty;

        [StringLength(20)]
        [DisplayName("رقم السيارة")]
        public string CarNumber { get; set; } = string.Empty;

        [Range(0, 99)]
        [DisplayName("سعة السيارة")]
        public int Capacity { get; set; }              

        [Range(0, 99)]
        [DisplayName("المتبقي")]
        public int Remaining { get; set; }              

        [StringLength(250)]
        [DisplayName("المنطقة")]
        public string Areas { get; set; } = string.Empty;

        [StringLength(500)]
        [DisplayName("الملاحظات")]
        public string? Notes { get; set; }               

        [Range(0, 5)]
        public double Rating { get; set; }              
        [DisplayName("التبريد")]
        public bool HasAC { get; set; }                 
        [DisplayName("سنة الصنع")]
        public int Year { get; set; }                  
        [DisplayName("الجنس")]
        public string GenderType { get; set; }     
    }

  
}