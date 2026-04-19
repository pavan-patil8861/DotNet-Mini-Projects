using HospitalApi.Models;
using HospitalApi.Repositories.Interfaces;
using HospitalApi.Services.Interfaces;

namespace HospitalApi.Services.Implementation;

public class RoomService : IRoomService
{
    private readonly IRoomRepository _repo;

    public RoomService(IRoomRepository repo)
    {
        _repo = repo;
    }

    public List<Room> GetAll() => _repo.GetAll();

    public Room GetById(int id) => _repo.GetById(id);

    public Room Add(Room r) => _repo.Add(r);

    public Room Update(Room r) => _repo.Update(r);

    public bool Delete(int id) => _repo.Delete(id);
}