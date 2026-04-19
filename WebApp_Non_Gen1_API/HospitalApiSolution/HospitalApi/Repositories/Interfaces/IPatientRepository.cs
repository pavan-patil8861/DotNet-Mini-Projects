using HospitalApi.Models;

namespace HospitalApi.Repositories.Interfaces;

public interface IPatientRepository
{
    List<Patient> GetAll();
    Patient GetById(int id);
    Patient Add(Patient p);
    Patient Update(Patient p);
    bool Delete(int id);
}