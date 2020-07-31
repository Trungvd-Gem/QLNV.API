using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessAccess.Interface;
using Domain.Request;
using Domain.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QLNV.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private readonly INhanVienService _nhanVienService;

        public NhanVienController(INhanVienService nhanVienService)
        {
            _nhanVienService = nhanVienService;
        }

        [HttpGet]
        [Route("api/nhanvien/danhsachnhanvientheophongban/{id}")]
        public IEnumerable<NhanVien> DanhSachNhanVienTheoPhongBan(int id)
        {
            return _nhanVienService.DanhSachNhanVienTheoPhongBan(id);
        }

        [HttpGet]
        [Route("api/nhanvien/laynhanvien/{id}")]
        public NhanVien LayNhanVien(int id)
        {
            return _nhanVienService.LayNhanVienTheoID(id);
        }

        [HttpPost]
        [Route("api/nhanvien/taonhanvien")]
        public int TaoNhanVien([FromBody] TaoNhanVien request)
        {
            return _nhanVienService.TaoNhanVien(request);
        }

        [HttpPut]
        [Route("api/nhanvien/suanhanvien")]
        public int SuaNhanVien([FromBody] SuaNhanVien request)
        {
            return _nhanVienService.SuaNhanVien(request);
        }

        [HttpDelete]
        [Route("api/nhanvien/xoanhanvien/{id}")]

        public bool XoaNhanVien(int id)
        {
            return _nhanVienService.XoaNhanVien(id);
        }
    }
}
