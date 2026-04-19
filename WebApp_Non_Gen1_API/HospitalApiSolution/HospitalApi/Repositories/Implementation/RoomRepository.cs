using HospitalApi.Models;
using HospitalApi.Repositories.Interfaces;

public class RoomRepository : IRoomRepository
{
    private static List<Room> data = new List<Room>();

    public List<Room> GetAll() => data;

    public Room GetById(int id) => data.FirstOrDefault(x => x.Id == id);

    public Room Add(Room r)
    {
        r.Id = data.Count + 1;
        data.Add(r);
        return r;
    }

    public Room Update(Room r)
    {
        var x = data.FirstOrDefault(i => i.Id == r.Id);
        if (x == null) return null;

        x.RoomNumber = r.RoomNumber;
        return x;
    }

    public bool Delete(int id)
    {
        var x = data.FirstOrDefault(i => i.Id == id);
        if (x == null) return false;

        data.Remove(x);
        return true;
    }
}