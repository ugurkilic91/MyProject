using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.BusinessLayer.Interfaces;

namespace MyProject.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        private readonly IKullaniciService _kullaniciService;
        public KullaniciController(IKullaniciService kullaniciService)
        {
            _kullaniciService = kullaniciService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
           await _kullaniciService.AddAsync(new Entities.Tables.Kullanici { Adi = "Deneme", Sehir = "Şehir Deneme" });
            return Ok("Ok");
        }
    }
}
