using System.ComponentModel.DataAnnotations;

namespace new1.Models
{
    public class StudentSearch
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string? Keyword { get; set; }   // حقل بحث عن (حر نص)

        [StringLength(100)]
        public string? Area { get; set; }     // منطقة

        [StringLength(20)]
        public string? CarNumber { get; set; }// رقم سيارة

        [StringLength(100)]
        public string? DriverName { get; set; }// اسم سائق

        [StringLength(20)]
        public string? DriverCode { get; set; } // رمز خاص بالسائق
    }
}