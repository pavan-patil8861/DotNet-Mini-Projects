using HospitalApi.Models;

namespace HospitalApi.Repositories.Interfaces;

public interface IDepartmentRepository
{
    List<Department> GetAll();
    Department GetById(int id);
    Department Add(Department d);
    Department Update(Department d);
    bool Delete(int id);
}