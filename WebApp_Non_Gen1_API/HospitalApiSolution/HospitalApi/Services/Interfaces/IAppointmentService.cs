using HospitalApi.Models;

namespace HospitalApi.Services.Interfaces;

public interface IAppointmentService
{
    List<Appointment> GetAll();
    Appointment GetById(int id);
    Appointment Add(Appointment a);
    Appointment Update(Appointment a);
    bool Delete(int id);
}