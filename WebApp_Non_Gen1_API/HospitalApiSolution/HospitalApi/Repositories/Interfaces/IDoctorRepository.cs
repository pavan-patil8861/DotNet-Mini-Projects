using HospitalApi.Models;

namespace HospitalApi.Repositories.Interfaces;

public interface IDoctorRepository
{
    List<Doctor> GetAll();
    Doctor GetById(int id);
    Doctor Add(Doctor d);
    Doctor Update(Doctor d);
    bool Delete(int id);
}