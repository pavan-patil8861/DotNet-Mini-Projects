using HospitalApi.Models;

namespace HospitalApi.Repositories.Interfaces;

public interface IAppointmentRepository
{
    List<Appointment> GetAll();
    Appointment GetById(int id);
    Appointment Add(Appointment a);
    Appointment Update(Appointment a);
    bool Delete(int id);
}