using HospitalApi.Models;
using HospitalApi.Repositories.Interfaces;
using HospitalApi.Services.Interfaces;

namespace HospitalApi.Services.Implementation;

public class DepartmentService : IDepartmentService
{
    private readonly IDepartmentRepository _repo;

    public DepartmentService(IDepartmentRepository repo)
    {
        _repo = repo;
    }

    public List<Department> GetAll() => _repo.GetAll();

    public Department GetById(int id) => _repo.GetById(id);

    public Department Add(Department d) => _repo.Add(d);

    public Department Update(Department d) => _repo.Update(d);

    public bool Delete(int id) => _repo.Delete(id);
}