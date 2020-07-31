using Domain;
using Domain.Request;
using Domain.Response;
using System;
using System.Collections.Generic;

namespace BusinessAccess.Interface
{
    public interface IPhongBanService
    {
        IList<PhongBan> DanhSachPhongBan();

        PhongBan LayPhongBanID(int Id);
        int TaoPhongBan(TaoPhongBan request);
        int SuaPhongBan(SuaPhongBan request);
        bool XoaPhongBan(int Id);
    }
}
