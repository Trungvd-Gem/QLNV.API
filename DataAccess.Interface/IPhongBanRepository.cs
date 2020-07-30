using Domain;
using Domain.Request;
using Domain.Response;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DataAccess.Interface
{
    public interface IPhongBanRepository
    {
        IList<PhongBan> DanhSachPhongBan();

        PhongBan LayPhongBanID(int Id);
        int TaoPhongBan(TaoPhongBan request);
        int SuaPhongBan(SuaPhongBan request);
        bool XoaPhongBan(int Id);
    }
}
