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
	/// 实体类vw_CCTemp 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_CCTemp")]
	[Serializable]
	public partial class vw_CCTemp : Entity 
	{
		#region Model
		private string _CCode;
		private int _EPID;
		private int _GRDID;
		private int? _StartWeek;
		private int? _Endweek;
		private decimal? _PerOfWeek;
		private int? _StartB;
		private int? _EndB;
		private decimal? _PerWB;
		private int _SPID;
		private int _CCID;
		/// <summary>
		/// 
		/// </summary>
		public string CCode
		{
			get{ return _CCode; }
			set
			{
				this.OnPropertyValueChange(_.CCode,_CCode,value);
				this._CCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int EPID
		{
			get{ return _EPID; }
			set
			{
				this.OnPropertyValueChange(_.EPID,_EPID,value);
				this._EPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int GRDID
		{
			get{ return _GRDID; }
			set
			{
				this.OnPropertyValueChange(_.GRDID,_GRDID,value);
				this._GRDID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StartWeek
		{
			get{ return _StartWeek; }
			set
			{
				this.OnPropertyValueChange(_.StartWeek,_StartWeek,value);
				this._StartWeek=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Endweek
		{
			get{ return _Endweek; }
			set
			{
				this.OnPropertyValueChange(_.Endweek,_Endweek,value);
				this._Endweek=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PerOfWeek
		{
			get{ return _PerOfWeek; }
			set
			{
				this.OnPropertyValueChange(_.PerOfWeek,_PerOfWeek,value);
				this._PerOfWeek=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StartB
		{
			get{ return _StartB; }
			set
			{
				this.OnPropertyValueChange(_.StartB,_StartB,value);
				this._StartB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EndB
		{
			get{ return _EndB; }
			set
			{
				this.OnPropertyValueChange(_.EndB,_EndB,value);
				this._EndB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PerWB
		{
			get{ return _PerWB; }
			set
			{
				this.OnPropertyValueChange(_.PerWB,_PerWB,value);
				this._PerWB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SPID
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
		public int CCID
		{
			get{ return _CCID; }
			set
			{
				this.OnPropertyValueChange(_.CCID,_CCID,value);
				this._CCID=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 是否只读
		/// </summary>
		public override bool IsReadOnly()
		{
			return true;
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.CCode,
				_.EPID,
				_.GRDID,
				_.StartWeek,
				_.Endweek,
				_.PerOfWeek,
				_.StartB,
				_.EndB,
				_.PerWB,
				_.SPID,
				_.CCID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._CCode,
				this._EPID,
				this._GRDID,
				this._StartWeek,
				this._Endweek,
				this._PerOfWeek,
				this._StartB,
				this._EndB,
				this._PerWB,
				this._SPID,
				this._CCID};
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
			public readonly static Field All = new Field("*","vw_CCTemp");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCode = new Field("CCode","vw_CCTemp","CCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EPID = new Field("EPID","vw_CCTemp","EPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRDID = new Field("GRDID","vw_CCTemp","GRDID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StartWeek = new Field("StartWeek","vw_CCTemp","StartWeek");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Endweek = new Field("Endweek","vw_CCTemp","Endweek");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PerOfWeek = new Field("PerOfWeek","vw_CCTemp","PerOfWeek");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StartB = new Field("StartB","vw_CCTemp","StartB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EndB = new Field("EndB","vw_CCTemp","EndB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PerWB = new Field("PerWB","vw_CCTemp","PerWB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_CCTemp","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_CCTemp","CCID");
		}
		#endregion


	}
}

