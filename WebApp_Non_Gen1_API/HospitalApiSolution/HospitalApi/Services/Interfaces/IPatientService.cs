using HospitalApi.Models;

namespace HospitalApi.Services.Interfaces;

public interface IPatientService
{
    List<Patient> GetAll();
    Patient GetById(int id);
    Patient Add(Patient p);
    Patient Update(Patient p);
    bool Delete(int id);
}