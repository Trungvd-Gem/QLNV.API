    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessAccess.Interface;
using Domain;
using Domain.Request;
using Domain.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace QLNV.API.Controllers
{
    [ApiController]

    public class PhongBanController : ControllerBase
    {


        private readonly IPhongBanService _phongBanService;

        public PhongBanController(IPhongBanService phongBanService)
        {
            _phongBanService = phongBanService;
        }

        [HttpGet]
        [Route("api/phongban/danhsachphongban")]
        public IEnumerable<PhongBan> DanhSachPhongBan()
        {
            return _phongBanService.DanhSachPhongBan();
        }

        [HttpGet]
        [Route("api/phongban/danhsachphongban/{id}")]
        public PhongBan LayPhongBanID(int id)
        {
            return _phongBanService.LayPhongBanID(id);
        }

        [HttpPost]
        [Route("api/phongban/taophongban")]
        public int TaoPhongBan([FromBody] TaoPhongBan request)
        {
            return _phongBanService.TaoPhongBan(request);
        }

        [HttpPut]
        [Route("api/phongban/suaphongban")]
        public int SuaPhongBan([FromBody] SuaPhongBan request)
        {
            return _phongBanService.SuaPhongBan(request);
        }

        [HttpDelete]
        [Route("api/phongban/xoaphongban/{id}")]

        public bool XoaPhongBan(int id)
        {
            return _phongBanService.XoaPhongBan(id);
        }
    }
}
