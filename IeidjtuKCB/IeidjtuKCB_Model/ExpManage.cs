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
	/// 实体类ExpManage 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("ExpManage")]
	[Serializable]
	public partial class ExpManage : Entity 
	{
		#region Model
		private int _EMID;
		private int? _PSID;
		private int? _AtyID;
		private int? _DeptID;
		private string _Content;
		private int? _PeopleNum;
		private int? _ClassNum;
		private int? _TotalSorce;
		private int? _Period;
		private string _PMDate;
		private string _Oper;
		private string _ChkOper;
		private string _RtufileOper;
		private string _State;
		private string _Memo;
		private string _X21A0;
		private string _X21B0;
		private string _X21B1;
		private string _X21B2;
		private string _X21H2;
		private string _X22A0;
		private string _X22B1;
		private string _X22B3;
		private string _X22H3;
		private string _X23A0;
		private string _X23Z;
		private string _X23B4;
		private string _X24;
		private string _X25A0;
		private string _X25Z;
		private string _X26B6;
		private string _X26B5;
		private string _X26Z;
		private string _X28B7;
		private string _X28Z1;
		private string _X28N;
		private string _X27B5;
		private string _X27Z;
		/// <summary>
		/// 
		/// </summary>
		public int EMID
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
		public int? PSID
		{
			get{ return _PSID; }
			set
			{
				this.OnPropertyValueChange(_.PSID,_PSID,value);
				this._PSID=value;
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
		public int? PeopleNum
		{
			get{ return _PeopleNum; }
			set
			{
				this.OnPropertyValueChange(_.PeopleNum,_PeopleNum,value);
				this._PeopleNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ClassNum
		{
			get{ return _ClassNum; }
			set
			{
				this.OnPropertyValueChange(_.ClassNum,_ClassNum,value);
				this._ClassNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TotalSorce
		{
			get{ return _TotalSorce; }
			set
			{
				this.OnPropertyValueChange(_.TotalSorce,_TotalSorce,value);
				this._TotalSorce=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Period
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
		public string PMDate
		{
			get{ return _PMDate; }
			set
			{
				this.OnPropertyValueChange(_.PMDate,_PMDate,value);
				this._PMDate=value;
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
		public string ChkOper
		{
			get{ return _ChkOper; }
			set
			{
				this.OnPropertyValueChange(_.ChkOper,_ChkOper,value);
				this._ChkOper=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RtufileOper
		{
			get{ return _RtufileOper; }
			set
			{
				this.OnPropertyValueChange(_.RtufileOper,_RtufileOper,value);
				this._RtufileOper=value;
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
		public string X21A0
		{
			get{ return _X21A0; }
			set
			{
				this.OnPropertyValueChange(_.X21A0,_X21A0,value);
				this._X21A0=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X21B0
		{
			get{ return _X21B0; }
			set
			{
				this.OnPropertyValueChange(_.X21B0,_X21B0,value);
				this._X21B0=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X21B1
		{
			get{ return _X21B1; }
			set
			{
				this.OnPropertyValueChange(_.X21B1,_X21B1,value);
				this._X21B1=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X21B2
		{
			get{ return _X21B2; }
			set
			{
				this.OnPropertyValueChange(_.X21B2,_X21B2,value);
				this._X21B2=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X21H2
		{
			get{ return _X21H2; }
			set
			{
				this.OnPropertyValueChange(_.X21H2,_X21H2,value);
				this._X21H2=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X22A0
		{
			get{ return _X22A0; }
			set
			{
				this.OnPropertyValueChange(_.X22A0,_X22A0,value);
				this._X22A0=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X22B1
		{
			get{ return _X22B1; }
			set
			{
				this.OnPropertyValueChange(_.X22B1,_X22B1,value);
				this._X22B1=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X22B3
		{
			get{ return _X22B3; }
			set
			{
				this.OnPropertyValueChange(_.X22B3,_X22B3,value);
				this._X22B3=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X22H3
		{
			get{ return _X22H3; }
			set
			{
				this.OnPropertyValueChange(_.X22H3,_X22H3,value);
				this._X22H3=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X23A0
		{
			get{ return _X23A0; }
			set
			{
				this.OnPropertyValueChange(_.X23A0,_X23A0,value);
				this._X23A0=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X23Z
		{
			get{ return _X23Z; }
			set
			{
				this.OnPropertyValueChange(_.X23Z,_X23Z,value);
				this._X23Z=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X23B4
		{
			get{ return _X23B4; }
			set
			{
				this.OnPropertyValueChange(_.X23B4,_X23B4,value);
				this._X23B4=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X24
		{
			get{ return _X24; }
			set
			{
				this.OnPropertyValueChange(_.X24,_X24,value);
				this._X24=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X25A0
		{
			get{ return _X25A0; }
			set
			{
				this.OnPropertyValueChange(_.X25A0,_X25A0,value);
				this._X25A0=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X25Z
		{
			get{ return _X25Z; }
			set
			{
				this.OnPropertyValueChange(_.X25Z,_X25Z,value);
				this._X25Z=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X26B6
		{
			get{ return _X26B6; }
			set
			{
				this.OnPropertyValueChange(_.X26B6,_X26B6,value);
				this._X26B6=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X26B5
		{
			get{ return _X26B5; }
			set
			{
				this.OnPropertyValueChange(_.X26B5,_X26B5,value);
				this._X26B5=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X26Z
		{
			get{ return _X26Z; }
			set
			{
				this.OnPropertyValueChange(_.X26Z,_X26Z,value);
				this._X26Z=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X28B7
		{
			get{ return _X28B7; }
			set
			{
				this.OnPropertyValueChange(_.X28B7,_X28B7,value);
				this._X28B7=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X28Z1
		{
			get{ return _X28Z1; }
			set
			{
				this.OnPropertyValueChange(_.X28Z1,_X28Z1,value);
				this._X28Z1=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X28N
		{
			get{ return _X28N; }
			set
			{
				this.OnPropertyValueChange(_.X28N,_X28N,value);
				this._X28N=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X27B5
		{
			get{ return _X27B5; }
			set
			{
				this.OnPropertyValueChange(_.X27B5,_X27B5,value);
				this._X27B5=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string X27Z
		{
			get{ return _X27Z; }
			set
			{
				this.OnPropertyValueChange(_.X27Z,_X27Z,value);
				this._X27Z=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.EMID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.EMID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.EMID,
				_.PSID,
				_.AtyID,
				_.DeptID,
				_.Content,
				_.PeopleNum,
				_.ClassNum,
				_.TotalSorce,
				_.Period,
				_.PMDate,
				_.Oper,
				_.ChkOper,
				_.RtufileOper,
				_.State,
				_.Memo,
				_.X21A0,
				_.X21B0,
				_.X21B1,
				_.X21B2,
				_.X21H2,
				_.X22A0,
				_.X22B1,
				_.X22B3,
				_.X22H3,
				_.X23A0,
				_.X23Z,
				_.X23B4,
				_.X24,
				_.X25A0,
				_.X25Z,
				_.X26B6,
				_.X26B5,
				_.X26Z,
				_.X28B7,
				_.X28Z1,
				_.X28N,
				_.X27B5,
				_.X27Z};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._EMID,
				this._PSID,
				this._AtyID,
				this._DeptID,
				this._Content,
				this._PeopleNum,
				this._ClassNum,
				this._TotalSorce,
				this._Period,
				this._PMDate,
				this._Oper,
				this._ChkOper,
				this._RtufileOper,
				this._State,
				this._Memo,
				this._X21A0,
				this._X21B0,
				this._X21B1,
				this._X21B2,
				this._X21H2,
				this._X22A0,
				this._X22B1,
				this._X22B3,
				this._X22H3,
				this._X23A0,
				this._X23Z,
				this._X23B4,
				this._X24,
				this._X25A0,
				this._X25Z,
				this._X26B6,
				this._X26B5,
				this._X26Z,
				this._X28B7,
				this._X28Z1,
				this._X28N,
				this._X27B5,
				this._X27Z};
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
			public readonly static Field All = new Field("*","ExpManage");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMID = new Field("EMID","ExpManage","EMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","ExpManage","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AtyID = new Field("AtyID","ExpManage","AtyID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptID = new Field("DeptID","ExpManage","DeptID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","ExpManage","Content");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PeopleNum = new Field("PeopleNum","ExpManage","PeopleNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassNum = new Field("ClassNum","ExpManage","ClassNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TotalSorce = new Field("TotalSorce","ExpManage","TotalSorce");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Period = new Field("Period","ExpManage","Period");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PMDate = new Field("PMDate","ExpManage","PMDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oper = new Field("Oper","ExpManage","Oper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ChkOper = new Field("ChkOper","ExpManage","ChkOper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RtufileOper = new Field("RtufileOper","ExpManage","RtufileOper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","ExpManage","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","ExpManage","Memo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X21A0 = new Field("X21A0","ExpManage","X21A0");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X21B0 = new Field("X21B0","ExpManage","X21B0");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X21B1 = new Field("X21B1","ExpManage","X21B1");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X21B2 = new Field("X21B2","ExpManage","X21B2");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X21H2 = new Field("X21H2","ExpManage","X21H2");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X22A0 = new Field("X22A0","ExpManage","X22A0");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X22B1 = new Field("X22B1","ExpManage","X22B1");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X22B3 = new Field("X22B3","ExpManage","X22B3");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X22H3 = new Field("X22H3","ExpManage","X22H3");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X23A0 = new Field("X23A0","ExpManage","X23A0");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X23Z = new Field("X23Z","ExpManage","X23Z");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X23B4 = new Field("X23B4","ExpManage","X23B4");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X24 = new Field("X24","ExpManage","X24");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X25A0 = new Field("X25A0","ExpManage","X25A0");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X25Z = new Field("X25Z","ExpManage","X25Z");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X26B6 = new Field("X26B6","ExpManage","X26B6");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X26B5 = new Field("X26B5","ExpManage","X26B5");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X26Z = new Field("X26Z","ExpManage","X26Z");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X28B7 = new Field("X28B7","ExpManage","X28B7");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X28Z1 = new Field("X28Z1","ExpManage","X28Z1");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X28N = new Field("X28N","ExpManage","X28N");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X27B5 = new Field("X27B5","ExpManage","X27B5");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field X27Z = new Field("X27Z","ExpManage","X27Z");
		}
		#endregion


	}
}

