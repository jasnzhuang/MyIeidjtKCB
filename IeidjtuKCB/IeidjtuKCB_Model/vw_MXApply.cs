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
	/// 实体类vw_MXApply 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_MXApply")]
	[Serializable]
	public partial class vw_MXApply : Entity 
	{
		#region Model
		private int _MXID;
		private int? _Stdid;
		private string _StdCode;
		private string _StdName;
		private string _ClassName;
		private string _TCName;
		private int? _SRID;
		private int? _TCID;
		private int? _CCID;
		private int? _Atyid;
		private string _ATName;
		private string _Content;
		private string _MaxExamine;
		private DateTime? _Makedate;
		private string _CheckOper;
		private string _CheckResult;
		private DateTime? _CheckDate;
		private string _LastOper;
		private string _LastResult;
		private DateTime? _LastDate;
		private string _State;
		private string _CCode;
		private string _CCname;
		private decimal? _Source;
		private int? _DeptID;
		private int? _GradeID;
		private string _DeptCode;
		private string _DeptName;
		private string _Mark;
		private string _Minor;
		private string _教学班级名称;
		private string _任课教师;
		private string _DeptCodeA;
		/// <summary>
		/// 
		/// </summary>
		public int MXID
		{
			get{ return _MXID; }
			set
			{
				this.OnPropertyValueChange(_.MXID,_MXID,value);
				this._MXID=value;
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
		public string TCName
		{
			get{ return _TCName; }
			set
			{
				this.OnPropertyValueChange(_.TCName,_TCName,value);
				this._TCName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SRID
		{
			get{ return _SRID; }
			set
			{
				this.OnPropertyValueChange(_.SRID,_SRID,value);
				this._SRID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TCID
		{
			get{ return _TCID; }
			set
			{
				this.OnPropertyValueChange(_.TCID,_TCID,value);
				this._TCID=value;
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
		public int? Atyid
		{
			get{ return _Atyid; }
			set
			{
				this.OnPropertyValueChange(_.Atyid,_Atyid,value);
				this._Atyid=value;
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
		public string MaxExamine
		{
			get{ return _MaxExamine; }
			set
			{
				this.OnPropertyValueChange(_.MaxExamine,_MaxExamine,value);
				this._MaxExamine=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Makedate
		{
			get{ return _Makedate; }
			set
			{
				this.OnPropertyValueChange(_.Makedate,_Makedate,value);
				this._Makedate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CheckOper
		{
			get{ return _CheckOper; }
			set
			{
				this.OnPropertyValueChange(_.CheckOper,_CheckOper,value);
				this._CheckOper=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CheckResult
		{
			get{ return _CheckResult; }
			set
			{
				this.OnPropertyValueChange(_.CheckResult,_CheckResult,value);
				this._CheckResult=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CheckDate
		{
			get{ return _CheckDate; }
			set
			{
				this.OnPropertyValueChange(_.CheckDate,_CheckDate,value);
				this._CheckDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LastOper
		{
			get{ return _LastOper; }
			set
			{
				this.OnPropertyValueChange(_.LastOper,_LastOper,value);
				this._LastOper=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LastResult
		{
			get{ return _LastResult; }
			set
			{
				this.OnPropertyValueChange(_.LastResult,_LastResult,value);
				this._LastResult=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LastDate
		{
			get{ return _LastDate; }
			set
			{
				this.OnPropertyValueChange(_.LastDate,_LastDate,value);
				this._LastDate=value;
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
		public int? DeptID
		{
			get{ return _DeptID; }
			set
			{
				this.OnPropertyValueChange(_.DeptID,_DeptID,value);
				this._DeptID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GradeID
		{
			get{ return _GradeID; }
			set
			{
				this.OnPropertyValueChange(_.GradeID,_GradeID,value);
				this._GradeID=value;
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
		public string Mark
		{
			get{ return _Mark; }
			set
			{
				this.OnPropertyValueChange(_.Mark,_Mark,value);
				this._Mark=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Minor
		{
			get{ return _Minor; }
			set
			{
				this.OnPropertyValueChange(_.Minor,_Minor,value);
				this._Minor=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 教学班级名称
		{
			get{ return _教学班级名称; }
			set
			{
				this.OnPropertyValueChange(_.教学班级名称,_教学班级名称,value);
				this._教学班级名称=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 任课教师
		{
			get{ return _任课教师; }
			set
			{
				this.OnPropertyValueChange(_.任课教师,_任课教师,value);
				this._任课教师=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeptCodeA
		{
			get{ return _DeptCodeA; }
			set
			{
				this.OnPropertyValueChange(_.DeptCodeA,_DeptCodeA,value);
				this._DeptCodeA=value;
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
				_.MXID,
				_.Stdid,
				_.StdCode,
				_.StdName,
				_.ClassName,
				_.TCName,
				_.SRID,
				_.TCID,
				_.CCID,
				_.Atyid,
				_.ATName,
				_.Content,
				_.MaxExamine,
				_.Makedate,
				_.CheckOper,
				_.CheckResult,
				_.CheckDate,
				_.LastOper,
				_.LastResult,
				_.LastDate,
				_.State,
				_.CCode,
				_.CCname,
				_.Source,
				_.DeptID,
				_.GradeID,
				_.DeptCode,
				_.DeptName,
				_.Mark,
				_.Minor,
				_.教学班级名称,
				_.任课教师,
				_.DeptCodeA};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._MXID,
				this._Stdid,
				this._StdCode,
				this._StdName,
				this._ClassName,
				this._TCName,
				this._SRID,
				this._TCID,
				this._CCID,
				this._Atyid,
				this._ATName,
				this._Content,
				this._MaxExamine,
				this._Makedate,
				this._CheckOper,
				this._CheckResult,
				this._CheckDate,
				this._LastOper,
				this._LastResult,
				this._LastDate,
				this._State,
				this._CCode,
				this._CCname,
				this._Source,
				this._DeptID,
				this._GradeID,
				this._DeptCode,
				this._DeptName,
				this._Mark,
				this._Minor,
				this._教学班级名称,
				this._任课教师,
				this._DeptCodeA};
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
			public readonly static Field All = new Field("*","vw_MXApply");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MXID = new Field("MXID","vw_MXApply","MXID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdid = new Field("Stdid","vw_MXApply","Stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdCode = new Field("StdCode","vw_MXApply","StdCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdName = new Field("StdName","vw_MXApply","StdName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassName = new Field("ClassName","vw_MXApply","ClassName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCName = new Field("TCName","vw_MXApply","TCName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SRID = new Field("SRID","vw_MXApply","SRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","vw_MXApply","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_MXApply","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("Atyid","vw_MXApply","Atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATName = new Field("ATName","vw_MXApply","ATName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","vw_MXApply","Content");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MaxExamine = new Field("MaxExamine","vw_MXApply","MaxExamine");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Makedate = new Field("Makedate","vw_MXApply","Makedate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CheckOper = new Field("CheckOper","vw_MXApply","CheckOper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CheckResult = new Field("CheckResult","vw_MXApply","CheckResult");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CheckDate = new Field("CheckDate","vw_MXApply","CheckDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LastOper = new Field("LastOper","vw_MXApply","LastOper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LastResult = new Field("LastResult","vw_MXApply","LastResult");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LastDate = new Field("LastDate","vw_MXApply","LastDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","vw_MXApply","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCode = new Field("CCode","vw_MXApply","CCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCname = new Field("CCname","vw_MXApply","CCname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Source = new Field("Source","vw_MXApply","Source");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptID = new Field("DeptID","vw_MXApply","DeptID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GradeID = new Field("GradeID","vw_MXApply","GradeID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCode = new Field("DeptCode","vw_MXApply","DeptCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptName = new Field("DeptName","vw_MXApply","DeptName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Mark = new Field("Mark","vw_MXApply","Mark");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Minor = new Field("Minor","vw_MXApply","Minor");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 教学班级名称 = new Field("教学班级名称","vw_MXApply","教学班级名称");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 任课教师 = new Field("任课教师","vw_MXApply","任课教师");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCodeA = new Field("DeptCodeA","vw_MXApply","DeptCodeA");
		}
		#endregion


	}
}
