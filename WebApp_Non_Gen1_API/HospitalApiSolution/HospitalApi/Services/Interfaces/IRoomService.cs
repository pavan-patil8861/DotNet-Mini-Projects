using HospitalApi.Models;

namespace HospitalApi.Services.Interfaces;

public interface IRoomService
{
    List<Room> GetAll();
    Room GetById(int id);
    Room Add(Room r);
    Room Update(Room r);
    bool Delete(int id);
}