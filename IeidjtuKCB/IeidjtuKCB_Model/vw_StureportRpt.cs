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
	/// 实体类vw_StureportRpt 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_StureportRpt")]
	[Serializable]
	public partial class vw_StureportRpt : Entity 
	{
		#region Model
		private int? _Atyid;
		private int? _STDID;
		private int? _CCID;
		private string _Examine;
		private string _TrueResult;
		private decimal? _Truepoint;
		private string _ATName;
		private string _StdCode;
		private string _StdName;
		private string _CCname;
		private string _CCode;
		private decimal? _Source;
		private int? _ATNo;
		private string _ifCheck;
		private string _ifCheckBy;
		private string _InPlan;
		private string _State;
		private string _isMain;
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
		public int? STDID
		{
			get{ return _STDID; }
			set
			{
				this.OnPropertyValueChange(_.STDID,_STDID,value);
				this._STDID=value;
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
		public decimal? Truepoint
		{
			get{ return _Truepoint; }
			set
			{
				this.OnPropertyValueChange(_.Truepoint,_Truepoint,value);
				this._Truepoint=value;
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
		public int? ATNo
		{
			get{ return _ATNo; }
			set
			{
				this.OnPropertyValueChange(_.ATNo,_ATNo,value);
				this._ATNo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ifCheck
		{
			get{ return _ifCheck; }
			set
			{
				this.OnPropertyValueChange(_.ifCheck,_ifCheck,value);
				this._ifCheck=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ifCheckBy
		{
			get{ return _ifCheckBy; }
			set
			{
				this.OnPropertyValueChange(_.ifCheckBy,_ifCheckBy,value);
				this._ifCheckBy=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InPlan
		{
			get{ return _InPlan; }
			set
			{
				this.OnPropertyValueChange(_.InPlan,_InPlan,value);
				this._InPlan=value;
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
		public string isMain
		{
			get{ return _isMain; }
			set
			{
				this.OnPropertyValueChange(_.isMain,_isMain,value);
				this._isMain=value;
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
				_.Atyid,
				_.STDID,
				_.CCID,
				_.Examine,
				_.TrueResult,
				_.Truepoint,
				_.ATName,
				_.StdCode,
				_.StdName,
				_.CCname,
				_.CCode,
				_.Source,
				_.ATNo,
				_.ifCheck,
				_.ifCheckBy,
				_.InPlan,
				_.State,
				_.isMain};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Atyid,
				this._STDID,
				this._CCID,
				this._Examine,
				this._TrueResult,
				this._Truepoint,
				this._ATName,
				this._StdCode,
				this._StdName,
				this._CCname,
				this._CCode,
				this._Source,
				this._ATNo,
				this._ifCheck,
				this._ifCheckBy,
				this._InPlan,
				this._State,
				this._isMain};
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
			public readonly static Field All = new Field("*","vw_StureportRpt");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("Atyid","vw_StureportRpt","Atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STDID = new Field("STDID","vw_StureportRpt","STDID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_StureportRpt","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Examine = new Field("Examine","vw_StureportRpt","Examine");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TrueResult = new Field("TrueResult","vw_StureportRpt","TrueResult");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Truepoint = new Field("Truepoint","vw_StureportRpt","Truepoint");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATName = new Field("ATName","vw_StureportRpt","ATName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdCode = new Field("StdCode","vw_StureportRpt","StdCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdName = new Field("StdName","vw_StureportRpt","StdName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCname = new Field("CCname","vw_StureportRpt","CCname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCode = new Field("CCode","vw_StureportRpt","CCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Source = new Field("Source","vw_StureportRpt","Source");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATNo = new Field("ATNo","vw_StureportRpt","ATNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ifCheck = new Field("ifCheck","vw_StureportRpt","ifCheck");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ifCheckBy = new Field("ifCheckBy","vw_StureportRpt","ifCheckBy");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field InPlan = new Field("InPlan","vw_StureportRpt","InPlan");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","vw_StureportRpt","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field isMain = new Field("isMain","vw_StureportRpt","isMain");
		}
		#endregion


	}
}

