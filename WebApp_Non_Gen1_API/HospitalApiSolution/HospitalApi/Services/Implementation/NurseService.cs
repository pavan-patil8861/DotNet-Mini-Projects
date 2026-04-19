using HospitalApi.Models;
using HospitalApi.Repositories.Interfaces;
using HospitalApi.Services.Interfaces;

namespace HospitalApi.Services.Implementation;

public class NurseService : INurseService
{
    private readonly INurseRepository _repo;

    public NurseService(INurseRepository repo)
    {
        _repo = repo;
    }

    public List<Nurse> GetAll() => _repo.GetAll();

    public Nurse GetById(int id) => _repo.GetById(id);

    public Nurse Add(Nurse n) => _repo.Add(n);

    public Nurse Update(Nurse n) => _repo.Update(n);

    public bool Delete(int id) => _repo.Delete(id);
}