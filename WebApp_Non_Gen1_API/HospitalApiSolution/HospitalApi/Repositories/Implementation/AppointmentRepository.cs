using HospitalApi.Models;
using HospitalApi.Repositories.Interfaces;

public class AppointmentRepository : IAppointmentRepository
{
    private static List<Appointment> data = new List<Appointment>();

    public List<Appointment> GetAll() => data;

    public Appointment GetById(int id) => data.FirstOrDefault(x => x.Id == id);

    public Appointment Add(Appointment a)
    {
        a.Id = data.Count + 1;
        data.Add(a);
        return a;
    }

    public Appointment Update(Appointment a)
    {
        var x = data.FirstOrDefault(i => i.Id == a.Id);
        if (x == null) return null;

        x.PatientId = a.PatientId;
        x.DoctorId = a.DoctorId;
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