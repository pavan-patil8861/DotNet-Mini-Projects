using HospitalApi.Models;
using HospitalApi.Repositories.Interfaces;

public class DoctorRepository : IDoctorRepository
{
    private static List<Doctor> data = new List<Doctor>
    {
        new Doctor{ Id=1, Name="Dr Raj", Specialization="Cardio" }
    };

    public List<Doctor> GetAll() => data;

    public Doctor GetById(int id) => data.FirstOrDefault(x => x.Id == id);

    public Doctor Add(Doctor d)
    {
        d.Id = data.Count + 1;
        data.Add(d);
        return d;
    }

    public Doctor Update(Doctor d)
    {
        var x = data.FirstOrDefault(i => i.Id == d.Id);
        if (x == null) return null;

        x.Name = d.Name;
        x.Specialization = d.Specialization;
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