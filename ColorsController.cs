using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Apstract;
using Business.Concrete;
using Entities.concrete;

namespace rantacarWebApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorservice _colorservice;
        public ColorsController(IColorservice colorservice )
        {
            _colorservice = colorservice;
        }
        [HttpGet ("getall")]
        public IActionResult Getall() {
            _colorservice.Getall(); 
              }
        [HttpPost ("add")]
        public IActionResult Add (Color c) { _colorservice.Add(c); }
        [HttpPost("delete")]
        public IActionResult Delete(Color c) { _colorservice.Delete(c); }
        [HttpPost("Update")]
        public IActionResult Update(Color c) { _colorservice.Update(c); }
    }
}
