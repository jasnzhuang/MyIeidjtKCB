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
	/// 实体类ExpReport 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("ExpReport")]
	[Serializable]
	public partial class ExpReport : Entity 
	{
		#region Model
		private int _ExpRID;
		private DateTime? _LogDate;
		private int? _AtyID;
		private int? _StdID;
		private int? _CCID;
		private int? _ExpItemID;
		private int? _EDID;
		private string _Report;
		private string _State;
		private string _Memo;
		/// <summary>
		/// 
		/// </summary>
		public int ExpRID
		{
			get{ return _ExpRID; }
			set
			{
				this.OnPropertyValueChange(_.ExpRID,_ExpRID,value);
				this._ExpRID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LogDate
		{
			get{ return _LogDate; }
			set
			{
				this.OnPropertyValueChange(_.LogDate,_LogDate,value);
				this._LogDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AtyID
		{
			get{ return _AtyID; }
			set
			{
				this.OnPropertyValueChange(_.AtyID,_AtyID,value);
				this._AtyID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StdID
		{
			get{ return _StdID; }
			set
			{
				this.OnPropertyValueChange(_.StdID,_StdID,value);
				this._StdID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CCID
		{
			get{ return _CCID; }
			set
			{
				this.OnPropertyValueChange(_.CCID,_CCID,value);
				this._CCID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExpItemID
		{
			get{ return _ExpItemID; }
			set
			{
				this.OnPropertyValueChange(_.ExpItemID,_ExpItemID,value);
				this._ExpItemID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EDID
		{
			get{ return _EDID; }
			set
			{
				this.OnPropertyValueChange(_.EDID,_EDID,value);
				this._EDID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Report
		{
			get{ return _Report; }
			set
			{
				this.OnPropertyValueChange(_.Report,_Report,value);
				this._Report=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string State
		{
			get{ return _State; }
			set
			{
				this.OnPropertyValueChange(_.State,_State,value);
				this._State=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Memo
		{
			get{ return _Memo; }
			set
			{
				this.OnPropertyValueChange(_.Memo,_Memo,value);
				this._Memo=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.ExpRID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.ExpRID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ExpRID,
				_.LogDate,
				_.AtyID,
				_.StdID,
				_.CCID,
				_.ExpItemID,
				_.EDID,
				_.Report,
				_.State,
				_.Memo};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ExpRID,
				this._LogDate,
				this._AtyID,
				this._StdID,
				this._CCID,
				this._ExpItemID,
				this._EDID,
				this._Report,
				this._State,
				this._Memo};
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
			public readonly static Field All = new Field("*","ExpReport");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExpRID = new Field("ExpRID","ExpReport","ExpRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LogDate = new Field("LogDate","ExpReport","LogDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AtyID = new Field("AtyID","ExpReport","AtyID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdID = new Field("stdID","ExpReport","stdID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","ExpReport","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExpItemID = new Field("ExpItemID","ExpReport","ExpItemID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EDID = new Field("EDID","ExpReport","EDID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Report = new Field("Report","ExpReport","Report");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","ExpReport","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","ExpReport","Memo");
		}
		#endregion


	}
}
