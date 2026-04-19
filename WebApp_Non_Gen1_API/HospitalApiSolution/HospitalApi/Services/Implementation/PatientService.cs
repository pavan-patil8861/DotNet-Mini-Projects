using HospitalApi.Models;
using HospitalApi.Repositories.Interfaces;
using HospitalApi.Services.Interfaces;

namespace HospitalApi.Services.Implementation;

public class PatientService : IPatientService
{
    private readonly IPatientRepository _repo;

    public PatientService(IPatientRepository repo)
    {
        _repo = repo;
    }

    public List<Patient> GetAll() => _repo.GetAll();

    public Patient GetById(int id) => _repo.GetById(id);

    public Patient Add(Patient p) => _repo.Add(p);

    public Patient Update(Patient p) => _repo.Update(p);

    public bool Delete(int id) => _repo.Delete(id);
}