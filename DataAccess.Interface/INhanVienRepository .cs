using Domain;
using Domain.Request;
using Domain.Response;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DataAccess.Interface
{
    public interface INhanVienRepository
    {
        IList<NhanVien> DanhSachNhanVienTheoPhongBan(int phongBanId);

        NhanVien LayNhanVienTheoID(int maNV);
        int TaoNhanVien(TaoNhanVien request);
        int SuaNhanVien(SuaNhanVien request);
        bool XoaNhanVien(int Id);
    }
}
