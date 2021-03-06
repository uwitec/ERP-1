﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ERP.DAL
{
	/// <summary>
	/// 数据访问类:Records
	/// </summary>
	public partial class Records
	{
		public Records()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("RID", "Records"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int RID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Records");
			strSql.Append(" where RID=@RID ");
			SqlParameter[] parameters = {
					new SqlParameter("@RID", SqlDbType.Int,4)			};
			parameters[0].Value = RID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ERP.Model.Records model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Records(");
			strSql.Append("RMCode,RMName,RQuantity,RType,RHander,RTime)");
			strSql.Append(" values (");
			strSql.Append("@RMCode,@RMName,@RQuantity,@RType,@RHander,@RTime)");
			SqlParameter[] parameters = {
					//new SqlParameter("@RID", SqlDbType.Int,4),
					new SqlParameter("@RMCode", SqlDbType.Int,4),
					new SqlParameter("@RMName", SqlDbType.NVarChar,50),
					new SqlParameter("@RQuantity", SqlDbType.Int,4),
					new SqlParameter("@RType", SqlDbType.Int,4),
					new SqlParameter("@RHander", SqlDbType.NVarChar,50),
					new SqlParameter("@RTime", SqlDbType.DateTime)};
			//parameters[0].Value = model.RID;
			parameters[0].Value = model.RMCode;
			parameters[1].Value = model.RMName;
			parameters[2].Value = model.RQuantity;
			parameters[3].Value = model.RType;
			parameters[4].Value = model.RHander;
			parameters[5].Value = model.RTime;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ERP.Model.Records model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Records set ");
			strSql.Append("RMCode=@RMCode,");
			strSql.Append("RMName=@RMName,");
			strSql.Append("RQuantity=@RQuantity,");
			strSql.Append("RType=@RType,");
			strSql.Append("RHander=@RHander,");
			strSql.Append("RTime=@RTime");
			strSql.Append(" where RID=@RID ");
			SqlParameter[] parameters = {
					new SqlParameter("@RMCode", SqlDbType.Int,4),
					new SqlParameter("@RMName", SqlDbType.NVarChar,50),
					new SqlParameter("@RQuantity", SqlDbType.Int,4),
					new SqlParameter("@RType", SqlDbType.Int,4),
					new SqlParameter("@RHander", SqlDbType.NVarChar,50),
					new SqlParameter("@RTime", SqlDbType.DateTime),
					new SqlParameter("@RID", SqlDbType.Int,4)};
			parameters[0].Value = model.RMCode;
			parameters[1].Value = model.RMName;
			parameters[2].Value = model.RQuantity;
			parameters[3].Value = model.RType;
			parameters[4].Value = model.RHander;
			parameters[5].Value = model.RTime;
			parameters[6].Value = model.RID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int RID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Records ");
			strSql.Append(" where RID=@RID ");
			SqlParameter[] parameters = {
					new SqlParameter("@RID", SqlDbType.Int,4)			};
			parameters[0].Value = RID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string RIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Records ");
			strSql.Append(" where RID in ("+RIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERP.Model.Records GetModel(int RID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 RID,RMCode,RMName,RQuantity,RType,RHander,RTime from Records ");
			strSql.Append(" where RID=@RID ");
			SqlParameter[] parameters = {
					new SqlParameter("@RID", SqlDbType.Int,4)			};
			parameters[0].Value = RID;

			ERP.Model.Records model=new ERP.Model.Records();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERP.Model.Records DataRowToModel(DataRow row)
		{
			ERP.Model.Records model=new ERP.Model.Records();
			if (row != null)
			{
				if(row["RID"]!=null && row["RID"].ToString()!="")
				{
					model.RID=int.Parse(row["RID"].ToString());
				}
				if(row["RMCode"]!=null && row["RMCode"].ToString()!="")
				{
					model.RMCode=int.Parse(row["RMCode"].ToString());
				}
				if(row["RMName"]!=null)
				{
					model.RMName=row["RMName"].ToString();
				}
				if(row["RQuantity"]!=null && row["RQuantity"].ToString()!="")
				{
					model.RQuantity=int.Parse(row["RQuantity"].ToString());
				}
				if(row["RType"]!=null && row["RType"].ToString()!="")
				{
					model.RType=int.Parse(row["RType"].ToString());
				}
				if(row["RHander"]!=null)
				{
					model.RHander=row["RHander"].ToString();
				}
				if(row["RTime"]!=null && row["RTime"].ToString()!="")
				{
					model.RTime=DateTime.Parse(row["RTime"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select RID,RMCode,RMName,RQuantity,RType,RHander,RTime ");
			strSql.Append(" FROM Records ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" RID,RMCode,RMName,RQuantity,RType,RHander,RTime ");
			strSql.Append(" FROM Records ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Records ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.RID desc");
			}
			strSql.Append(")AS Row, T.*  from Records T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Records";
			parameters[1].Value = "RID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

