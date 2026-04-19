using HospitalApi.Models;
using HospitalApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NurseController : ControllerBase
{
    private readonly INurseService _service;

    public NurseController(INurseService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_service.GetAll());

    [HttpPost]
    public IActionResult Add(Nurse n) => Ok(_service.Add(n));
}