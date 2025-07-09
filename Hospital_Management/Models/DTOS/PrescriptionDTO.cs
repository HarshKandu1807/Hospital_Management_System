namespace Hospital_Management.Models.DTOS
{
    public class PrescriptionDTO
    {
        public string PrescriptionName { get; set; }

        public int AppointmentId { get; set; }

        public int PatientId { get; set; }

        public int DoctorId { get; set; }
    }
}
