using HospitalApi.Models;
using HospitalApi.Repositories.Interfaces;

namespace HospitalApi.Repositories.Implementation;

public class PatientRepository : IPatientRepository
{
    private static List<Patient> data = new();

    public List<Patient> GetAll() => data;

    public Patient GetById(int id) => data.FirstOrDefault(x => x.Id == id);

    public Patient Add(Patient p)
    {
        p.Id = data.Count + 1;
        data.Add(p);
        return p;
    }

    public Patient Update(Patient p)
    {
        var d = data.FirstOrDefault(x => x.Id == p.Id);
        if (d == null) return null;

        d.Name = p.Name;
        d.Age = p.Age;
        return d;
    }

    public bool Delete(int id)
    {
        var d = data.FirstOrDefault(x => x.Id == id);
        if (d == null) return false;

        data.Remove(d);
        return true;
    }
}