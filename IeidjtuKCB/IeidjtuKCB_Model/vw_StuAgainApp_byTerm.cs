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
	/// 实体类vw_StuAgainApp_byTerm 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_StuAgainApp_byTerm")]
	[Serializable]
	public partial class vw_StuAgainApp_byTerm : Entity 
	{
		#region Model
		private string _StdCode;
		private string _StdName;
		private int? _AtyID;
		private int? _EPID;
		private int? _StdID;
		private string _CCode;
		private string _CCname;
		private int? _TermID;
		private string _GRName;
		private string _FSort;
		private DateTime? _AppDate;
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
		public int? EPID
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
		public string CCname
		{
			get{ return _CCname; }
			set
			{
				this.OnPropertyValueChange(_.CCname,_CCname,value);
				this._CCname=value;
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
		public string FSort
		{
			get{ return _FSort; }
			set
			{
				this.OnPropertyValueChange(_.FSort,_FSort,value);
				this._FSort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AppDate
		{
			get{ return _AppDate; }
			set
			{
				this.OnPropertyValueChange(_.AppDate,_AppDate,value);
				this._AppDate=value;
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
				_.StdCode,
				_.StdName,
				_.AtyID,
				_.EPID,
				_.StdID,
				_.CCode,
				_.CCname,
				_.TermID,
				_.GRName,
				_.FSort,
				_.AppDate};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._StdCode,
				this._StdName,
				this._AtyID,
				this._EPID,
				this._StdID,
				this._CCode,
				this._CCname,
				this._TermID,
				this._GRName,
				this._FSort,
				this._AppDate};
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
			public readonly static Field All = new Field("*","vw_StuAgainApp_byTerm");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdCode = new Field("StdCode","vw_StuAgainApp_byTerm","StdCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdName = new Field("StdName","vw_StuAgainApp_byTerm","StdName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AtyID = new Field("AtyID","vw_StuAgainApp_byTerm","AtyID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EPID = new Field("EPID","vw_StuAgainApp_byTerm","EPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdID = new Field("StdID","vw_StuAgainApp_byTerm","StdID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCode = new Field("CCode","vw_StuAgainApp_byTerm","CCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCname = new Field("CCname","vw_StuAgainApp_byTerm","CCname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TermID = new Field("TermID","vw_StuAgainApp_byTerm","TermID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRName = new Field("GRName","vw_StuAgainApp_byTerm","GRName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FSort = new Field("FSort","vw_StuAgainApp_byTerm","FSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AppDate = new Field("AppDate","vw_StuAgainApp_byTerm","AppDate");
		}
		#endregion


	}
}

