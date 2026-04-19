using HospitalApi.Models;

namespace HospitalApi.Services.Interfaces;

public interface IDepartmentService
{
    List<Department> GetAll();
    Department GetById(int id);
    Department Add(Department d);
    Department Update(Department d);
    bool Delete(int id);
}