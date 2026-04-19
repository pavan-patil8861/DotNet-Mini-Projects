using HospitalApi.Models;

namespace HospitalApi.Services.Interfaces;

public interface IDoctorService
{
    List<Doctor> GetAll();
    Doctor GetById(int id);
    Doctor Add(Doctor d);
    Doctor Update(Doctor d);
    bool Delete(int id);
}