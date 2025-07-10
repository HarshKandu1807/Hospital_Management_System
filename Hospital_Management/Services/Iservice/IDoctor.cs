using Hospital_Management.Models.DTOS;

namespace Hospital_Management.Services.Iservice
{
    public interface IDoctor
    {
        Task<List<DoctorDTO>?> GetDoctors();
        Task<DoctorDTO?> GetDoctorById(int id);
        Task<DoctorDTO?> AddDoctor(DoctorDTO DoctorDTO);
        Task<DoctorDTO?> UpdateDoctor(DoctorDTO DoctorDTO, int id);
        Task<bool> DeleteDoctor(int id);
    }
}
