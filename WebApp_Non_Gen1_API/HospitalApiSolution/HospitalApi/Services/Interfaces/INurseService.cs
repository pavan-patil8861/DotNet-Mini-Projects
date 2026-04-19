using HospitalApi.Models;

namespace HospitalApi.Services.Interfaces;

public interface INurseService
{
    List<Nurse> GetAll();
    Nurse GetById(int id);
    Nurse Add(Nurse n);
    Nurse Update(Nurse n);
    bool Delete(int id);
}