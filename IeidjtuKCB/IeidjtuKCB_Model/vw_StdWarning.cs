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
	/// 实体类vw_StdWarning 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_StdWarning")]
	[Serializable]
	public partial class vw_StdWarning : Entity 
	{
		#region Model
		private int _SWID;
		private string _YearName;
		private int? _Stdid;
		private string _StdCode;
		private string _StdName;
		private string _SPName;
		private decimal? _Source;
		private decimal? _BasSource;
		private string _state;
		private string _GRName;
		private int? _SPID;
		private string _DeptCode;
		private string _DeptName;
		private decimal? _BadSource;
		private string _stdstate;
		private string _ClassName;
		private int? _GRID;
		private int? _atyid;
		private int? _TMID;
		private decimal? _CXbad;
		private string _Sort;
		private string _ATName;
		/// <summary>
		/// 
		/// </summary>
		public int SWID
		{
			get{ return _SWID; }
			set
			{
				this.OnPropertyValueChange(_.SWID,_SWID,value);
				this._SWID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YearName
		{
			get{ return _YearName; }
			set
			{
				this.OnPropertyValueChange(_.YearName,_YearName,value);
				this._YearName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Stdid
		{
			get{ return _Stdid; }
			set
			{
				this.OnPropertyValueChange(_.Stdid,_Stdid,value);
				this._Stdid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StdCode
		{
			get{ return _StdCode; }
			set
			{
				this.OnPropertyValueChange(_.StdCode,_StdCode,value);
				this._StdCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StdName
		{
			get{ return _StdName; }
			set
			{
				this.OnPropertyValueChange(_.StdName,_StdName,value);
				this._StdName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SPName
		{
			get{ return _SPName; }
			set
			{
				this.OnPropertyValueChange(_.SPName,_SPName,value);
				this._SPName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Source
		{
			get{ return _Source; }
			set
			{
				this.OnPropertyValueChange(_.Source,_Source,value);
				this._Source=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BasSource
		{
			get{ return _BasSource; }
			set
			{
				this.OnPropertyValueChange(_.BasSource,_BasSource,value);
				this._BasSource=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string state
		{
			get{ return _state; }
			set
			{
				this.OnPropertyValueChange(_.state,_state,value);
				this._state=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GRName
		{
			get{ return _GRName; }
			set
			{
				this.OnPropertyValueChange(_.GRName,_GRName,value);
				this._GRName=value;
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
		public string DeptCode
		{
			get{ return _DeptCode; }
			set
			{
				this.OnPropertyValueChange(_.DeptCode,_DeptCode,value);
				this._DeptCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeptName
		{
			get{ return _DeptName; }
			set
			{
				this.OnPropertyValueChange(_.DeptName,_DeptName,value);
				this._DeptName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BadSource
		{
			get{ return _BadSource; }
			set
			{
				this.OnPropertyValueChange(_.BadSource,_BadSource,value);
				this._BadSource=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string stdstate
		{
			get{ return _stdstate; }
			set
			{
				this.OnPropertyValueChange(_.stdstate,_stdstate,value);
				this._stdstate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClassName
		{
			get{ return _ClassName; }
			set
			{
				this.OnPropertyValueChange(_.ClassName,_ClassName,value);
				this._ClassName=value;
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
		public int? atyid
		{
			get{ return _atyid; }
			set
			{
				this.OnPropertyValueChange(_.atyid,_atyid,value);
				this._atyid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TMID
		{
			get{ return _TMID; }
			set
			{
				this.OnPropertyValueChange(_.TMID,_TMID,value);
				this._TMID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CXbad
		{
			get{ return _CXbad; }
			set
			{
				this.OnPropertyValueChange(_.CXbad,_CXbad,value);
				this._CXbad=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sort
		{
			get{ return _Sort; }
			set
			{
				this.OnPropertyValueChange(_.Sort,_Sort,value);
				this._Sort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ATName
		{
			get{ return _ATName; }
			set
			{
				this.OnPropertyValueChange(_.ATName,_ATName,value);
				this._ATName=value;
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
				_.SWID,
				_.YearName,
				_.Stdid,
				_.StdCode,
				_.StdName,
				_.SPName,
				_.Source,
				_.BasSource,
				_.state,
				_.GRName,
				_.SPID,
				_.DeptCode,
				_.DeptName,
				_.BadSource,
				_.stdstate,
				_.ClassName,
				_.GRID,
				_.atyid,
				_.TMID,
				_.CXbad,
				_.Sort,
				_.ATName};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SWID,
				this._YearName,
				this._Stdid,
				this._StdCode,
				this._StdName,
				this._SPName,
				this._Source,
				this._BasSource,
				this._state,
				this._GRName,
				this._SPID,
				this._DeptCode,
				this._DeptName,
				this._BadSource,
				this._stdstate,
				this._ClassName,
				this._GRID,
				this._atyid,
				this._TMID,
				this._CXbad,
				this._Sort,
				this._ATName};
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
			public readonly static Field All = new Field("*","vw_StdWarning");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SWID = new Field("SWID","vw_StdWarning","SWID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field YearName = new Field("YearName","vw_StdWarning","YearName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdid = new Field("Stdid","vw_StdWarning","Stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdCode = new Field("StdCode","vw_StdWarning","StdCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdName = new Field("StdName","vw_StdWarning","StdName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPName = new Field("SPName","vw_StdWarning","SPName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Source = new Field("Source","vw_StdWarning","Source");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BasSource = new Field("BasSource","vw_StdWarning","BasSource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field state = new Field("state","vw_StdWarning","state");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRName = new Field("GRName","vw_StdWarning","GRName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_StdWarning","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCode = new Field("DeptCode","vw_StdWarning","DeptCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptName = new Field("DeptName","vw_StdWarning","DeptName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BadSource = new Field("BadSource","vw_StdWarning","BadSource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field stdstate = new Field("stdstate","vw_StdWarning","stdstate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassName = new Field("ClassName","vw_StdWarning","ClassName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","vw_StdWarning","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field atyid = new Field("atyid","vw_StdWarning","atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TMID = new Field("TMID","vw_StdWarning","TMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CXbad = new Field("CXbad","vw_StdWarning","CXbad");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sort = new Field("Sort","vw_StdWarning","Sort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATName = new Field("ATName","vw_StdWarning","ATName");
		}
		#endregion


	}
}
