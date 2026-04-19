using HospitalApi.Models;

namespace HospitalApi.Repositories.Interfaces;

public interface IRoomRepository
{
    List<Room> GetAll();
    Room GetById(int id);
    Room Add(Room r);
    Room Update(Room r);
    bool Delete(int id);
}