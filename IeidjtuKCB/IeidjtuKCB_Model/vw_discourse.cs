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
	/// 实体类vw_discourse 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_discourse")]
	[Serializable]
	public partial class vw_discourse : Entity 
	{
		#region Model
		private int _DSID;
		private int? _AtyID;
		private int? _stdid;
		private int? _SPID;
		private int? _GRID;
		private string _PSname;
		private string _Title;
		private string _Content;
		private string _GradeResult;
		private string _Oper;
		private DateTime? _indate;
		private string _ATName;
		private string _StdCode;
		private string _StdName;
		private string _GRName;
		private string _SPName;
		private string _DeptCode;
		private string _SPNo;
		private string _DSort;
		/// <summary>
		/// 
		/// </summary>
		public int DSID
		{
			get{ return _DSID; }
			set
			{
				this.OnPropertyValueChange(_.DSID,_DSID,value);
				this._DSID=value;
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
		public int? stdid
		{
			get{ return _stdid; }
			set
			{
				this.OnPropertyValueChange(_.stdid,_stdid,value);
				this._stdid=value;
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
		public string PSname
		{
			get{ return _PSname; }
			set
			{
				this.OnPropertyValueChange(_.PSname,_PSname,value);
				this._PSname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			get{ return _Title; }
			set
			{
				this.OnPropertyValueChange(_.Title,_Title,value);
				this._Title=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Content
		{
			get{ return _Content; }
			set
			{
				this.OnPropertyValueChange(_.Content,_Content,value);
				this._Content=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GradeResult
		{
			get{ return _GradeResult; }
			set
			{
				this.OnPropertyValueChange(_.GradeResult,_GradeResult,value);
				this._GradeResult=value;
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
		public DateTime? indate
		{
			get{ return _indate; }
			set
			{
				this.OnPropertyValueChange(_.indate,_indate,value);
				this._indate=value;
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
		public string SPNo
		{
			get{ return _SPNo; }
			set
			{
				this.OnPropertyValueChange(_.SPNo,_SPNo,value);
				this._SPNo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DSort
		{
			get{ return _DSort; }
			set
			{
				this.OnPropertyValueChange(_.DSort,_DSort,value);
				this._DSort=value;
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
				_.DSID,
				_.AtyID,
				_.stdid,
				_.SPID,
				_.GRID,
				_.PSname,
				_.Title,
				_.Content,
				_.GradeResult,
				_.Oper,
				_.indate,
				_.ATName,
				_.StdCode,
				_.StdName,
				_.GRName,
				_.SPName,
				_.DeptCode,
				_.SPNo,
				_.DSort};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._DSID,
				this._AtyID,
				this._stdid,
				this._SPID,
				this._GRID,
				this._PSname,
				this._Title,
				this._Content,
				this._GradeResult,
				this._Oper,
				this._indate,
				this._ATName,
				this._StdCode,
				this._StdName,
				this._GRName,
				this._SPName,
				this._DeptCode,
				this._SPNo,
				this._DSort};
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
			public readonly static Field All = new Field("*","vw_discourse");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DSID = new Field("DSID","vw_discourse","DSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AtyID = new Field("AtyID","vw_discourse","AtyID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field stdid = new Field("stdid","vw_discourse","stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_discourse","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","vw_discourse","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSname = new Field("PSname","vw_discourse","PSname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Title = new Field("Title","vw_discourse","Title");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","vw_discourse","Content");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GradeResult = new Field("GradeResult","vw_discourse","GradeResult");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oper = new Field("Oper","vw_discourse","Oper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field indate = new Field("indate","vw_discourse","indate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATName = new Field("ATName","vw_discourse","ATName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdCode = new Field("StdCode","vw_discourse","StdCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdName = new Field("StdName","vw_discourse","StdName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRName = new Field("GRName","vw_discourse","GRName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPName = new Field("SPName","vw_discourse","SPName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCode = new Field("DeptCode","vw_discourse","DeptCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPNo = new Field("SPNo","vw_discourse","SPNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DSort = new Field("DSort","vw_discourse","DSort");
		}
		#endregion


	}
}

