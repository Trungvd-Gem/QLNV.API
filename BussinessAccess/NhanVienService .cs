using BusinessAccess.Interface;
using DataAccess;
using DataAccess.Interface;
using Domain;
using Domain.Request;
using Domain.Response;
using System;
using System.Collections.Generic;

namespace BussinessAccess
{
    public class NhanVienService : INhanVienService
    {
        private INhanVienRepository _nhanVienRepository;

        public NhanVienService(INhanVienRepository nhanVienRepository)
        {
            _nhanVienRepository = nhanVienRepository;
        }
        public IList<NhanVien> DanhSachNhanVienTheoPhongBan(int phongBanId)
        {
            return _nhanVienRepository.DanhSachNhanVienTheoPhongBan(phongBanId);
        }

        public NhanVien LayNhanVienTheoID(int Id)
        {
            return _nhanVienRepository.LayNhanVienTheoID(Id);
        }

        public int SuaNhanVien(SuaNhanVien request)
        {
            return _nhanVienRepository.SuaNhanVien(request);
        }

        public int TaoNhanVien(TaoNhanVien request)
        {
            return _nhanVienRepository.TaoNhanVien(request);
        }

        public bool XoaNhanVien(int maNV)
        {
            return _nhanVienRepository.XoaNhanVien(maNV);
        }
    }
}
