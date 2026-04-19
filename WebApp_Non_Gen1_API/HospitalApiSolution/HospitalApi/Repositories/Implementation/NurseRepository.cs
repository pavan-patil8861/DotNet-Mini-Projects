using HospitalApi.Models;
using HospitalApi.Repositories.Interfaces;

public class NurseRepository : INurseRepository
{
    private static List<Nurse> data = new List<Nurse>();

    public List<Nurse> GetAll() => data;

    public Nurse GetById(int id) => data.FirstOrDefault(x => x.Id == id);

    public Nurse Add(Nurse n)
    {
        n.Id = data.Count + 1;
        data.Add(n);
        return n;
    }

    public Nurse Update(Nurse n)
    {
        var x = data.FirstOrDefault(i => i.Id == n.Id);
        if (x == null) return null;

        x.Name = n.Name;
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