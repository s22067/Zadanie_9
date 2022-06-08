
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadanie8.DTOs;
using Zadanie8.Models;

namespace Zadanie8.Repositories.Interfaces
{
    public interface IHospitalDbRepository
    {
        Task<IEnumerable<DoctorDto>> GetDoctorsAsync();
        Task<string> AddDoctorAsync(DoctorDto dto);
        Task<string> ChangeDoctorAsync(int id, DoctorDto dto);
        Task<string> DeleteDoctorAsync(int id);
        Task<PrescriptionDto> GetPrescriptionAsync(int id);
    }
}