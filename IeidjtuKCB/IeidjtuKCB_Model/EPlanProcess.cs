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
	/// 实体类EPlanProcess 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("EPlanProcess")]
	[Serializable]
	public partial class EPlanProcess : Entity 
	{
		#region Model
		private int _EPPID;
		private int? _EMID;
		private int? _SPID;
		private int? _GRID;
		private int? _TermID;
		private int? _WeekNo;
		private int? _PMID;
		private string _Memo;
		/// <summary>
		/// 
		/// </summary>
		public int EPPID
		{
			get{ return _EPPID; }
			set
			{
				this.OnPropertyValueChange(_.EPPID,_EPPID,value);
				this._EPPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EMID
		{
			get{ return _EMID; }
			set
			{
				this.OnPropertyValueChange(_.EMID,_EMID,value);
				this._EMID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SPID
		{
			get{ return _SPID; }
			set
			{
				this.OnPropertyValueChange(_.SPID,_SPID,value);
				this._SPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GRID
		{
			get{ return _GRID; }
			set
			{
				this.OnPropertyValueChange(_.GRID,_GRID,value);
				this._GRID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TermID
		{
			get{ return _TermID; }
			set
			{
				this.OnPropertyValueChange(_.TermID,_TermID,value);
				this._TermID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? WeekNo
		{
			get{ return _WeekNo; }
			set
			{
				this.OnPropertyValueChange(_.WeekNo,_WeekNo,value);
				this._WeekNo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PMID
		{
			get{ return _PMID; }
			set
			{
				this.OnPropertyValueChange(_.PMID,_PMID,value);
				this._PMID=value;
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
			return _.EPPID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.EPPID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.EPPID,
				_.EMID,
				_.SPID,
				_.GRID,
				_.TermID,
				_.WeekNo,
				_.PMID,
				_.Memo};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._EPPID,
				this._EMID,
				this._SPID,
				this._GRID,
				this._TermID,
				this._WeekNo,
				this._PMID,
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
			public readonly static Field All = new Field("*","EPlanProcess");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EPPID = new Field("EPPID","EPlanProcess","EPPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMID = new Field("EMID","EPlanProcess","EMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","EPlanProcess","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","EPlanProcess","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TermID = new Field("TermID","EPlanProcess","TermID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field WeekNo = new Field("WeekNo","EPlanProcess","WeekNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PMID = new Field("PMID","EPlanProcess","PMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","EPlanProcess","Memo");
		}
		#endregion


	}
}

