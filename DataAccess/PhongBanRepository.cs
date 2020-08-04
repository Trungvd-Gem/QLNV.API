using Dapper;
using DataAccess.Interface;
using Domain;
using Domain.Request;
using Domain.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;

namespace DataAccess
{
    public class PhongBanRepository : BaseRepository, IPhongBanRepository
    {
        public IList<PhongBan> DanhSachPhongBan()
        {
            IList<PhongBan> danhSachPhongBan = SqlMapper.Query<PhongBan>(con, "DanhSachPhongBan", commandType: CommandType.StoredProcedure).ToList();
            return danhSachPhongBan;
        }

        public PhongBan LayPhongBanID(int Id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", Id);
            PhongBan phongBan = SqlMapper.Query<PhongBan>(con, "LayPhongBanID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return phongBan;
        }

        public int SuaPhongBan(SuaPhongBan request)
        {
           try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", request.ID);
                parameters.Add("@MaPhongBan", request.MaPhongBan);
                parameters.Add("@TenPhongBan", request.TenPhongBan);
                var id = SqlMapper.ExecuteScalar<int>(con, "SuaPhongBan", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            } catch (Exception ex)
            {
                return 0;
            }
        }

        public int TaoPhongBan(TaoPhongBan request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaPhongBan", request.MaPhongBan);
                parameters.Add("@TenPhongBan", request.TenPhongBan);
                var id = SqlMapper.ExecuteScalar<int>(con, "TaoPhongBan", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaPhongBan(int Id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);
                var result = SqlMapper.ExecuteScalar<bool>(con, "XoaPhongBan", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
