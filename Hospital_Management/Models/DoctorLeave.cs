using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_Management.Models
{
    public class DoctorLeave
    {
        [Key]
        public int LeaveId { get; set; }
        public int DoctorId { get; set; }
        [ForeignKey("DocterId")]
        public Doctor Doctor { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
    }
}
