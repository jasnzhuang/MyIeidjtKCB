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
	/// 实体类EPlanTotal 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("EPlanTotal")]
	[Serializable]
	public partial class EPlanTotal : Entity 
	{
		#region Model
		private int _EFID;
		private int? _EMID;
		private int? _SPID;
		private int? _GRID;
		private int _TermID;
		private int? _PSMID;
		private decimal? _Period;
		private decimal? _OtherP;
		private decimal? _WeekPeriod;
		private decimal? _Total;
		/// <summary>
		/// 
		/// </summary>
		public int EFID
		{
			get{ return _EFID; }
			set
			{
				this.OnPropertyValueChange(_.EFID,_EFID,value);
				this._EFID=value;
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
		public int TermID
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
		public int? PSMID
		{
			get{ return _PSMID; }
			set
			{
				this.OnPropertyValueChange(_.PSMID,_PSMID,value);
				this._PSMID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Period
		{
			get{ return _Period; }
			set
			{
				this.OnPropertyValueChange(_.Period,_Period,value);
				this._Period=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OtherP
		{
			get{ return _OtherP; }
			set
			{
				this.OnPropertyValueChange(_.OtherP,_OtherP,value);
				this._OtherP=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WeekPeriod
		{
			get{ return _WeekPeriod; }
			set
			{
				this.OnPropertyValueChange(_.WeekPeriod,_WeekPeriod,value);
				this._WeekPeriod=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Total
		{
			get{ return _Total; }
			set
			{
				this.OnPropertyValueChange(_.Total,_Total,value);
				this._Total=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.EFID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.EFID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.EFID,
				_.EMID,
				_.SPID,
				_.GRID,
				_.TermID,
				_.PSMID,
				_.Period,
				_.OtherP,
				_.WeekPeriod,
				_.Total};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._EFID,
				this._EMID,
				this._SPID,
				this._GRID,
				this._TermID,
				this._PSMID,
				this._Period,
				this._OtherP,
				this._WeekPeriod,
				this._Total};
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
			public readonly static Field All = new Field("*","EPlanTotal");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EFID = new Field("EFID","EPlanTotal","EFID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMID = new Field("EMID","EPlanTotal","EMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","EPlanTotal","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","EPlanTotal","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TermID = new Field("TermID","EPlanTotal","TermID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSMID = new Field("PSMID","EPlanTotal","PSMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Period = new Field("Period","EPlanTotal","Period");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OtherP = new Field("OtherP","EPlanTotal","OtherP");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field WeekPeriod = new Field("WeekPeriod","EPlanTotal","WeekPeriod");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Total = new Field("Total","EPlanTotal","Total");
		}
		#endregion


	}
}

