using HospitalApi.Models;
using HospitalApi.Repositories.Interfaces;

public class DepartmentRepository : IDepartmentRepository
{
    private static List<Department> data = new List<Department>();

    public List<Department> GetAll() => data;

    public Department GetById(int id) => data.FirstOrDefault(x => x.Id == id);

    public Department Add(Department d)
    {
        d.Id = data.Count + 1;
        data.Add(d);
        return d;
    }

    public Department Update(Department d)
    {
        var x = data.FirstOrDefault(i => i.Id == d.Id);
        if (x == null) return null;

        x.Name = d.Name;
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