using HospitalApi.Models;
using HospitalApi.Repositories.Interfaces;
using HospitalApi.Services.Interfaces;

namespace HospitalApi.Services.Implementation;

public class AppointmentService : IAppointmentService
{
    private readonly IAppointmentRepository _repo;

    public AppointmentService(IAppointmentRepository repo)
    {
        _repo = repo;
    }

    public List<Appointment> GetAll() => _repo.GetAll();

    public Appointment GetById(int id) => _repo.GetById(id);

    public Appointment Add(Appointment a) => _repo.Add(a);

    public Appointment Update(Appointment a) => _repo.Update(a);

    public bool Delete(int id) => _repo.Delete(id);
}