using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Apstract;
using Business.Concrete;
using Entities;
namespace rantacarWebApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        ICarservice _cs;
        public CarController(ICarservice carservice )
        {
            _cs = carservice;
        }
        [HttpGet("getall")]
        IActionResult getall()
        {
            _cs.Getall();
         
                }
        [HttpPost("add")]
        IActionResult Add() { _cs.Add(); }
        [HttpPost("delete")]
        IActionResult Delete() { _cs.Delete(); }
        [HttpPost("update")]
        IActionResult Update() { _cs.Update(); }
    }
}
