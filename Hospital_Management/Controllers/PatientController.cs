using Hospital_Management.Models.DTOS;
using Hospital_Management.Services.Iservice;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatient patient;
        public PatientController(IPatient patient)
        {
            this.patient = patient;
        }
        [HttpGet("Get/Patients")]
        public async Task<IActionResult> GetPatients()
        {
            var data = await patient.GetPatients();
            if (data == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(data);
            }
        }

        [HttpGet("Get/Patient")]
        public async Task<IActionResult> GetPatientById(int id)
        {
            var data = await patient.GetPatientById(id);
            if (data == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(data);
;            }
        }

        [HttpPost]
        public async Task<IActionResult> AddPatient(PatientDTO patientDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var data = await patient.AddPatient(patientDTO);
            if (data == null)
            {
                return BadRequest("Data Already Exist");
            }
            return Ok(data);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePatient(PatientDTO patientDTO,int id)
        {
            var data = await patient.UpdatePatient(patientDTO, id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePatient(int id)
        {
            var data = await patient.DeletePatient(id);
            if (!data)
            {
                return NotFound();
            }
            return Ok(data);
        }
    }
}
