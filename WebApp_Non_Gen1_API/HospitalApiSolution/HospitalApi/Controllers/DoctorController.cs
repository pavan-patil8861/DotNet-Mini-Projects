using HospitalApi.Models;
using HospitalApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DoctorController : ControllerBase
{
    private readonly IDoctorService _service;

    public DoctorController(IDoctorService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_service.GetAll());

    [HttpGet("{id}")]
    public IActionResult Get(int id) => Ok(_service.GetById(id));

    [HttpPost]
    public IActionResult Add(Doctor d) => Ok(_service.Add(d));

    [HttpPut("{id}")]
    public IActionResult Update(int id, Doctor d)
    {
        d.Id = id;
        return Ok(_service.Update(d));
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id) => Ok(_service.Delete(id));
}