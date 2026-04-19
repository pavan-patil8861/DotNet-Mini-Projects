using HospitalApi.Models;

namespace HospitalApi.Repositories.Interfaces;

public interface INurseRepository
{
    List<Nurse> GetAll();
    Nurse GetById(int id);
    Nurse Add(Nurse n);
    Nurse Update(Nurse n);
    bool Delete(int id);
}