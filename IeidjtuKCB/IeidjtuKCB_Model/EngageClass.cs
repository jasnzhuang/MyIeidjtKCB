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
	/// 实体类EngageClass 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("EngageClass")]
	[Serializable]
	public partial class EngageClass : Entity 
	{
		#region Model
		private int _ECID;
		private int? _EPID;
		private int? _CLID;
		private int? _CCID;
		private int? _SPID;
		private int? _TCHID;
		private int? _ActYear;
		private int? _CRID;
		private string _ReportState;
		private string _Affirmant;
		private string _Memo;
		private string _State;
		private int? _MaxStuNum;
		private int? _StuNum;
		/// <summary>
		/// 
		/// </summary>
		public int ECID
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
		public int? TCHID
		{
			get{ return _TCHID; }
			set
			{
				this.OnPropertyValueChange(_.TCHID,_TCHID,value);
				this._TCHID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ActYear
		{
			get{ return _ActYear; }
			set
			{
				this.OnPropertyValueChange(_.ActYear,_ActYear,value);
				this._ActYear=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CRID
		{
			get{ return _CRID; }
			set
			{
				this.OnPropertyValueChange(_.CRID,_CRID,value);
				this._CRID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReportState
		{
			get{ return _ReportState; }
			set
			{
				this.OnPropertyValueChange(_.ReportState,_ReportState,value);
				this._ReportState=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Affirmant
		{
			get{ return _Affirmant; }
			set
			{
				this.OnPropertyValueChange(_.Affirmant,_Affirmant,value);
				this._Affirmant=value;
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
		public int? MaxStuNum
		{
			get{ return _MaxStuNum; }
			set
			{
				this.OnPropertyValueChange(_.MaxStuNum,_MaxStuNum,value);
				this._MaxStuNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StuNum
		{
			get{ return _StuNum; }
			set
			{
				this.OnPropertyValueChange(_.StuNum,_StuNum,value);
				this._StuNum=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.ECID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.ECID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ECID,
				_.EPID,
				_.CLID,
				_.CCID,
				_.SPID,
				_.TCHID,
				_.ActYear,
				_.CRID,
				_.ReportState,
				_.Affirmant,
				_.Memo,
				_.State,
				_.MaxStuNum,
				_.StuNum};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ECID,
				this._EPID,
				this._CLID,
				this._CCID,
				this._SPID,
				this._TCHID,
				this._ActYear,
				this._CRID,
				this._ReportState,
				this._Affirmant,
				this._Memo,
				this._State,
				this._MaxStuNum,
				this._StuNum};
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
			public readonly static Field All = new Field("*","EngageClass");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ECID = new Field("ECID","EngageClass","ECID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EPID = new Field("EPID","EngageClass","EPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLID = new Field("CLID","EngageClass","CLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","EngageClass","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","EngageClass","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCHID = new Field("TCHID","EngageClass","TCHID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ActYear = new Field("ActYear","EngageClass","ActYear");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CRID = new Field("CRID","EngageClass","CRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ReportState = new Field("ReportState","EngageClass","ReportState");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Affirmant = new Field("Affirmant","EngageClass","Affirmant");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","EngageClass","Memo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","EngageClass","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MaxStuNum = new Field("MaxStuNum","EngageClass","MaxStuNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StuNum = new Field("StuNum","EngageClass","StuNum");
		}
		#endregion


	}
}

