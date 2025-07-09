using Hospital_Management.Models;

public class Prescription
{
    public int PrescriptionId { get; set; }

    public string PrescriptionName { get; set; }

    public int AppointmentId { get; set; }
    public Appointment Appointment { get; set; }

    public int PatientId { get; set; }
    public Patient Patient { get; set; }

    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; }
}
