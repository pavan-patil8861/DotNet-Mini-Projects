using HospitalApi.Models;
using HospitalApi.Repositories.Interfaces;
using HospitalApi.Services.Interfaces;

namespace HospitalApi.Services.Implementation;

public class DoctorService : IDoctorService   // ✅ IMPORTANT
{
    private readonly IDoctorRepository _repo;

    public DoctorService(IDoctorRepository repo)
    {
        _repo = repo;
    }

    public List<Doctor> GetAll() => _repo.GetAll();

    public Doctor GetById(int id) => _repo.GetById(id);

    public Doctor Add(Doctor d) => _repo.Add(d);

    public Doctor Update(Doctor d) => _repo.Update(d);

    public bool Delete(int id) => _repo.Delete(id);
}