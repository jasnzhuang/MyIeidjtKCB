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
	/// 实体类Studytrack 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Studytrack")]
	[Serializable]
	public partial class Studytrack : Entity 
	{
		#region Model
		private int _STKID;
		private int? _Atyid;
		private int? _STUID;
		private int? _CCID;
		private string _CHPNO;
		private int? _CHPID;
		private string _STKDate;
		private string _StartTime;
		private string _TestTime;
		private string _AnswerTime;
		private string _Sturesult;
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
		public string Sturesult
		{
			get{ return _Sturesult; }
			set
			{
				this.OnPropertyValueChange(_.Sturesult,_Sturesult,value);
				this._Sturesult=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.STKID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.STKID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.STKID,
				_.Atyid,
				_.STUID,
				_.CCID,
				_.CHPNO,
				_.CHPID,
				_.STKDate,
				_.StartTime,
				_.TestTime,
				_.AnswerTime,
				_.Sturesult};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._STKID,
				this._Atyid,
				this._STUID,
				this._CCID,
				this._CHPNO,
				this._CHPID,
				this._STKDate,
				this._StartTime,
				this._TestTime,
				this._AnswerTime,
				this._Sturesult};
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
			public readonly static Field All = new Field("*","Studytrack");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STKID = new Field("STKID","Studytrack","STKID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("atyid","Studytrack","atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STUID = new Field("STUID","Studytrack","STUID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","Studytrack","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CHPNO = new Field("CHPNO","Studytrack","CHPNO");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CHPID = new Field("CHPID","Studytrack","CHPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STKDate = new Field("STKDate","Studytrack","STKDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StartTime = new Field("StartTime","Studytrack","StartTime");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TestTime = new Field("TestTime","Studytrack","TestTime");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AnswerTime = new Field("AnswerTime","Studytrack","AnswerTime");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sturesult = new Field("sturesult","Studytrack","sturesult");
		}
		#endregion


	}
}

