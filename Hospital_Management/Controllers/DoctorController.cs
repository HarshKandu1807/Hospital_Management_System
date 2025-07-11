using Hospital_Management.Models.DTOS;
using Hospital_Management.Services.Iservice;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctor Doctor;
        public DoctorController(IDoctor Doctor)
        {
            this.Doctor = Doctor;
        }
        [HttpGet("Get/Doctors")]
        public async Task<IActionResult> GetDoctors()
        {
            var data = await Doctor.GetDoctors();
            if (data == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(data);
            }
        }

        [HttpGet("Get/Doctor")]
        public async Task<IActionResult> GetDoctorById(int id)
        {
            var data = await Doctor.GetDoctorById(id);
            if (data == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(data);
            }
        }

        [HttpPost("doctor")]
        public async Task<IActionResult> AddDoctor(DoctorDTO doctorDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var data = await Doctor.AddDoctor(doctorDTO);
            if (data == null)
            {
                return BadRequest("Data Already Exist");
            }
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> AddPrescription(PrescriptionDTO prescriptionDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var data = await Doctor.AddPrescription(prescriptionDTO);
            return Ok(data);
        }

        [HttpPost("doctor/leave")]
        public async Task<IActionResult> AddDoctorLeave(DoctorLeaveDTO doctorLeaveDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var data = await Doctor.AddDoctorLeave(doctorLeaveDTO);
            return Ok(data);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDoctor(DoctorDTO DoctorDTO, int id)
        {
            var data = await Doctor.UpdateDoctor(DoctorDTO, id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            var data = await Doctor.DeleteDoctor(id);
            if (!data)
            {
                return NotFound();
            }
            return Ok(data);
        }
    }
}
