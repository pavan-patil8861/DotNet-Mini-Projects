using HospitalApi.Models;
using HospitalApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PatientController : ControllerBase
{
    private readonly IPatientService _service;

    public PatientController(IPatientService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_service.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(_service.GetById(id));
    }

    [HttpPost]
    public IActionResult Create(Patient p)
    {
        return Ok(_service.Add(p));
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Patient p)
    {
        p.Id = id;
        return Ok(_service.Update(p));
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return Ok(_service.Delete(id));
    }
}