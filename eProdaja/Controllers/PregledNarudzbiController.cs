using eProdaja.Model.Requests;
using eProdaja.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class PregledNarudzbiController : ControllerBase
    {
        private readonly IPregledNarudzbiService _service;
        public PregledNarudzbiController(IPregledNarudzbiService service)
        {
            _service = service;
        }
        [HttpGet]
       public  IList<Model.PregledNarudzbi> GetAll([FromQuery]PregledNarudzbiSearchRequest search)
        {
            return _service.GetAll(search);
        }
        [HttpPost]
       public  Model.PregledNarudzbi Insert([FromBody]PregledNarudzbiInsertRequest request)
        {
            return _service.Insert(request);
        }

    }
}
