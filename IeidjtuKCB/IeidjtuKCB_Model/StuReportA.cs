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
	/// 实体类StuReportA 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("StuReportA")]
	[Serializable]
	public partial class StuReportA : Entity 
	{
		#region Model
		private int _SRID;
		private int? _TCID;
		private int? _ECID;
		private int? _EPID;
		private int? _CCID;
		private int? _ATYID;
		private int? _CLID;
		private int? _SPID;
		private int? _StuID;
		private decimal? _BasSource;
		private decimal? _Source;
		private decimal? _Point;
		private decimal? _TruePoint;
		private string _TrueResult;
		private string _Examine;
		private string _Exam;
		private string _Experiment;
		private string _Normal;
		private string _Memo;
		private string _State;
		private string _Discipline;
		private string _Minor;
		private string _Again;
		private int? _SequID;
		private int? _Lev;
		private int? _IFOK;
		private string _Oper;
		private int? _TotalNum;
		private string _IsMain;
		private string _MState;
		private DateTime? _SelectDate;
		private string _PJState;
		/// <summary>
		/// 
		/// </summary>
		public int SRID
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
		public int? ECID
		{
			get{ return _ECID; }
			set
			{
				this.OnPropertyValueChange(_.ECID,_ECID,value);
				this._ECID=value;
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
		public int? ATYID
		{
			get{ return _ATYID; }
			set
			{
				this.OnPropertyValueChange(_.ATYID,_ATYID,value);
				this._ATYID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CLID
		{
			get{ return _CLID; }
			set
			{
				this.OnPropertyValueChange(_.CLID,_CLID,value);
				this._CLID=value;
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
		public int? StuID
		{
			get{ return _StuID; }
			set
			{
				this.OnPropertyValueChange(_.StuID,_StuID,value);
				this._StuID=value;
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
		public decimal? Point
		{
			get{ return _Point; }
			set
			{
				this.OnPropertyValueChange(_.Point,_Point,value);
				this._Point=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TruePoint
		{
			get{ return _TruePoint; }
			set
			{
				this.OnPropertyValueChange(_.TruePoint,_TruePoint,value);
				this._TruePoint=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TrueResult
		{
			get{ return _TrueResult; }
			set
			{
				this.OnPropertyValueChange(_.TrueResult,_TrueResult,value);
				this._TrueResult=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Examine
		{
			get{ return _Examine; }
			set
			{
				this.OnPropertyValueChange(_.Examine,_Examine,value);
				this._Examine=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Exam
		{
			get{ return _Exam; }
			set
			{
				this.OnPropertyValueChange(_.Exam,_Exam,value);
				this._Exam=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Experiment
		{
			get{ return _Experiment; }
			set
			{
				this.OnPropertyValueChange(_.Experiment,_Experiment,value);
				this._Experiment=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Normal
		{
			get{ return _Normal; }
			set
			{
				this.OnPropertyValueChange(_.Normal,_Normal,value);
				this._Normal=value;
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
		public string Discipline
		{
			get{ return _Discipline; }
			set
			{
				this.OnPropertyValueChange(_.Discipline,_Discipline,value);
				this._Discipline=value;
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
		public string Again
		{
			get{ return _Again; }
			set
			{
				this.OnPropertyValueChange(_.Again,_Again,value);
				this._Again=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SequID
		{
			get{ return _SequID; }
			set
			{
				this.OnPropertyValueChange(_.SequID,_SequID,value);
				this._SequID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Lev
		{
			get{ return _Lev; }
			set
			{
				this.OnPropertyValueChange(_.Lev,_Lev,value);
				this._Lev=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IFOK
		{
			get{ return _IFOK; }
			set
			{
				this.OnPropertyValueChange(_.IFOK,_IFOK,value);
				this._IFOK=value;
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
		public int? TotalNum
		{
			get{ return _TotalNum; }
			set
			{
				this.OnPropertyValueChange(_.TotalNum,_TotalNum,value);
				this._TotalNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsMain
		{
			get{ return _IsMain; }
			set
			{
				this.OnPropertyValueChange(_.IsMain,_IsMain,value);
				this._IsMain=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MState
		{
			get{ return _MState; }
			set
			{
				this.OnPropertyValueChange(_.MState,_MState,value);
				this._MState=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SelectDate
		{
			get{ return _SelectDate; }
			set
			{
				this.OnPropertyValueChange(_.SelectDate,_SelectDate,value);
				this._SelectDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PJState
		{
			get{ return _PJState; }
			set
			{
				this.OnPropertyValueChange(_.PJState,_PJState,value);
				this._PJState=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.SRID,
				_.TCID,
				_.ECID,
				_.EPID,
				_.CCID,
				_.ATYID,
				_.CLID,
				_.SPID,
				_.StuID,
				_.BasSource,
				_.Source,
				_.Point,
				_.TruePoint,
				_.TrueResult,
				_.Examine,
				_.Exam,
				_.Experiment,
				_.Normal,
				_.Memo,
				_.State,
				_.Discipline,
				_.Minor,
				_.Again,
				_.SequID,
				_.Lev,
				_.IFOK,
				_.Oper,
				_.TotalNum,
				_.IsMain,
				_.MState,
				_.SelectDate,
				_.PJState};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SRID,
				this._TCID,
				this._ECID,
				this._EPID,
				this._CCID,
				this._ATYID,
				this._CLID,
				this._SPID,
				this._StuID,
				this._BasSource,
				this._Source,
				this._Point,
				this._TruePoint,
				this._TrueResult,
				this._Examine,
				this._Exam,
				this._Experiment,
				this._Normal,
				this._Memo,
				this._State,
				this._Discipline,
				this._Minor,
				this._Again,
				this._SequID,
				this._Lev,
				this._IFOK,
				this._Oper,
				this._TotalNum,
				this._IsMain,
				this._MState,
				this._SelectDate,
				this._PJState};
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
			public readonly static Field All = new Field("*","StuReportA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SRID = new Field("SRID","StuReportA","SRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","StuReportA","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ECID = new Field("ECID","StuReportA","ECID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EPID = new Field("EPID","StuReportA","EPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","StuReportA","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATYID = new Field("ATYID","StuReportA","ATYID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLID = new Field("CLID","StuReportA","CLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","StuReportA","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StuID = new Field("StuID","StuReportA","StuID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BasSource = new Field("BasSource","StuReportA","BasSource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Source = new Field("Source","StuReportA","Source");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Point = new Field("Point","StuReportA","Point");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TruePoint = new Field("TruePoint","StuReportA","TruePoint");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TrueResult = new Field("TrueResult","StuReportA","TrueResult");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Examine = new Field("Examine","StuReportA","Examine");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Exam = new Field("Exam","StuReportA","Exam");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Experiment = new Field("Experiment","StuReportA","Experiment");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Normal = new Field("Normal","StuReportA","Normal");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","StuReportA","Memo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","StuReportA","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Discipline = new Field("Discipline","StuReportA","Discipline");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Minor = new Field("Minor","StuReportA","Minor");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Again = new Field("Again","StuReportA","Again");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SequID = new Field("SequID","StuReportA","SequID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Lev = new Field("Lev","StuReportA","Lev");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IFOK = new Field("IFOK","StuReportA","IFOK");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oper = new Field("Oper","StuReportA","Oper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TotalNum = new Field("TotalNum","StuReportA","TotalNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IsMain = new Field("IsMain","StuReportA","IsMain");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MState = new Field("MState","StuReportA","MState");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SelectDate = new Field("SelectDate","StuReportA","SelectDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PJState = new Field("PJState","StuReportA","PJState");
		}
		#endregion


	}
}

