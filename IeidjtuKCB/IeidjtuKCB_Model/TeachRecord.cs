﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://ITdos.com/Dos/ORM/Index.html
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace IeidjtuKCB.Model
{

	/// <summary>
	/// 实体类TeachRecord 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("TeachRecord")]
	[Serializable]
	public partial class TeachRecord : Entity 
	{
		#region Model
		private int _TRID;
		private int? _PSID;
		private string _Operation;
		private string _OpDate;
		private string _Oper;
		private string _IPaddress;
		private string _UID;
		/// <summary>
		/// 
		/// </summary>
		public int TRID
		{
			get{ return _TRID; }
			set
			{
				this.OnPropertyValueChange(_.TRID,_TRID,value);
				this._TRID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PSID
		{
			get{ return _PSID; }
			set
			{
				this.OnPropertyValueChange(_.PSID,_PSID,value);
				this._PSID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Operation
		{
			get{ return _Operation; }
			set
			{
				this.OnPropertyValueChange(_.Operation,_Operation,value);
				this._Operation=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OpDate
		{
			get{ return _OpDate; }
			set
			{
				this.OnPropertyValueChange(_.OpDate,_OpDate,value);
				this._OpDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Oper
		{
			get{ return _Oper; }
			set
			{
				this.OnPropertyValueChange(_.Oper,_Oper,value);
				this._Oper=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IPaddress
		{
			get{ return _IPaddress; }
			set
			{
				this.OnPropertyValueChange(_.IPaddress,_IPaddress,value);
				this._IPaddress=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UID
		{
			get{ return _UID; }
			set
			{
				this.OnPropertyValueChange(_.UID,_UID,value);
				this._UID=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.TRID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.TRID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.TRID,
				_.PSID,
				_.Operation,
				_.OpDate,
				_.Oper,
				_.IPaddress,
				_.UID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TRID,
				this._PSID,
				this._Operation,
				this._OpDate,
				this._Oper,
				this._IPaddress,
				this._UID};
		}
		#endregion

		#region _Field
		/// <summary>
		/// 字段信息
		/// </summary>
		public class _
		{
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*","TeachRecord");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TRID = new Field("TRID","TeachRecord","TRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","TeachRecord","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Operation = new Field("Operation","TeachRecord","Operation");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OpDate = new Field("OpDate","TeachRecord","OpDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oper = new Field("Oper","TeachRecord","Oper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IPaddress = new Field("IPaddress","TeachRecord","IPaddress");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UID = new Field("UID","TeachRecord","UID");
		}
		#endregion


	}
}

