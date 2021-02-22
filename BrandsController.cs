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
    public class BrandsController : ControllerBase
    {

        IBrandservice _bs;
        public BrandsController(IBrandservice b )
        {
            _bs = b;
                
        }
[HttpGet("getall")]        
public IActionResult Getall()
        {
            var result = _bs.Getall();return result;

           [HttpPost ("add")]
IActionResult Add (Brand b)
            {
                var result = _bs.Add(b);return result; 
            }
            [HttpPost("delete")]
         IActionResult delete (Brand b)
            { _bs.Delete(b); }
            [HttpPost("update")]
            IActionResult Update (Brand b)
            {
                _bs.Update(b);
            }

    }
}
