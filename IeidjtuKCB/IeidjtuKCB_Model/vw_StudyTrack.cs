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
	/// 实体类vw_StudyTrack 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_StudyTrack")]
	[Serializable]
	public partial class vw_StudyTrack : Entity 
	{
		#region Model
		private int _STKID;
		private int? _STUID;
		private int? _CCID;
		private string _CHPNO;
		private int? _CHPID;
		private string _StartTime;
		private string _TestTime;
		private string _AnswerTime;
		private string _StdName;
		private string _STKDate;
		private string _CCode;
		private string _CCname;
		private string _ChpName;
		private int? _atyid;
		private string _StdCode;
		private string _sturesult;
		/// <summary>
		/// 
		/// </summary>
		public int STKID
		{
			get{ return _STKID; }
			set
			{
				this.OnPropertyValueChange(_.STKID,_STKID,value);
				this._STKID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? STUID
		{
			get{ return _STUID; }
			set
			{
				this.OnPropertyValueChange(_.STUID,_STUID,value);
				this._STUID=value;
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
		public string CHPNO
		{
			get{ return _CHPNO; }
			set
			{
				this.OnPropertyValueChange(_.CHPNO,_CHPNO,value);
				this._CHPNO=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CHPID
		{
			get{ return _CHPID; }
			set
			{
				this.OnPropertyValueChange(_.CHPID,_CHPID,value);
				this._CHPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StartTime
		{
			get{ return _StartTime; }
			set
			{
				this.OnPropertyValueChange(_.StartTime,_StartTime,value);
				this._StartTime=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TestTime
		{
			get{ return _TestTime; }
			set
			{
				this.OnPropertyValueChange(_.TestTime,_TestTime,value);
				this._TestTime=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AnswerTime
		{
			get{ return _AnswerTime; }
			set
			{
				this.OnPropertyValueChange(_.AnswerTime,_AnswerTime,value);
				this._AnswerTime=value;
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
		public string STKDate
		{
			get{ return _STKDate; }
			set
			{
				this.OnPropertyValueChange(_.STKDate,_STKDate,value);
				this._STKDate=value;
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
		public string ChpName
		{
			get{ return _ChpName; }
			set
			{
				this.OnPropertyValueChange(_.ChpName,_ChpName,value);
				this._ChpName=value;
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
		public string sturesult
		{
			get{ return _sturesult; }
			set
			{
				this.OnPropertyValueChange(_.sturesult,_sturesult,value);
				this._sturesult=value;
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
				_.STKID,
				_.STUID,
				_.CCID,
				_.CHPNO,
				_.CHPID,
				_.StartTime,
				_.TestTime,
				_.AnswerTime,
				_.StdName,
				_.STKDate,
				_.CCode,
				_.CCname,
				_.ChpName,
				_.atyid,
				_.StdCode,
				_.sturesult};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._STKID,
				this._STUID,
				this._CCID,
				this._CHPNO,
				this._CHPID,
				this._StartTime,
				this._TestTime,
				this._AnswerTime,
				this._StdName,
				this._STKDate,
				this._CCode,
				this._CCname,
				this._ChpName,
				this._atyid,
				this._StdCode,
				this._sturesult};
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
			public readonly static Field All = new Field("*","vw_StudyTrack");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STKID = new Field("STKID","vw_StudyTrack","STKID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STUID = new Field("STUID","vw_StudyTrack","STUID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_StudyTrack","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CHPNO = new Field("CHPNO","vw_StudyTrack","CHPNO");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CHPID = new Field("CHPID","vw_StudyTrack","CHPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StartTime = new Field("StartTime","vw_StudyTrack","StartTime");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TestTime = new Field("TestTime","vw_StudyTrack","TestTime");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AnswerTime = new Field("AnswerTime","vw_StudyTrack","AnswerTime");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdName = new Field("StdName","vw_StudyTrack","StdName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STKDate = new Field("STKDate","vw_StudyTrack","STKDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCode = new Field("CCode","vw_StudyTrack","CCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCname = new Field("CCname","vw_StudyTrack","CCname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ChpName = new Field("ChpName","vw_StudyTrack","ChpName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field atyid = new Field("atyid","vw_StudyTrack","atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdCode = new Field("StdCode","vw_StudyTrack","StdCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field sturesult = new Field("sturesult","vw_StudyTrack","sturesult");
		}
		#endregion


	}
}
