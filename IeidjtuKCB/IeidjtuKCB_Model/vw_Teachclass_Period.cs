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
	/// 实体类vw_Teachclass_Period 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Teachclass_Period")]
	[Serializable]
	public partial class vw_Teachclass_Period : Entity 
	{
		#region Model
		private int _TCID;
		private int? _CCID;
		private int? _MaxStuNum;
		private int? _CTID;
		private int? _PKstate;
		private int? _RGID;
		private string _CLRSort;
		private decimal? _Period;
		private int? _ActYear;
		private int? _TCHID;
		/// <summary>
		/// 
		/// </summary>
		public int TCID
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
		public int? CTID
		{
			get{ return _CTID; }
			set
			{
				this.OnPropertyValueChange(_.CTID,_CTID,value);
				this._CTID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PKstate
		{
			get{ return _PKstate; }
			set
			{
				this.OnPropertyValueChange(_.PKstate,_PKstate,value);
				this._PKstate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RGID
		{
			get{ return _RGID; }
			set
			{
				this.OnPropertyValueChange(_.RGID,_RGID,value);
				this._RGID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLRSort
		{
			get{ return _CLRSort; }
			set
			{
				this.OnPropertyValueChange(_.CLRSort,_CLRSort,value);
				this._CLRSort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Period
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
		public int? TCHID
		{
			get{ return _TCHID; }
			set
			{
				this.OnPropertyValueChange(_.TCHID,_TCHID,value);
				this._TCHID=value;
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
				_.TCID,
				_.CCID,
				_.MaxStuNum,
				_.CTID,
				_.PKstate,
				_.RGID,
				_.CLRSort,
				_.Period,
				_.ActYear,
				_.TCHID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TCID,
				this._CCID,
				this._MaxStuNum,
				this._CTID,
				this._PKstate,
				this._RGID,
				this._CLRSort,
				this._Period,
				this._ActYear,
				this._TCHID};
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
			public readonly static Field All = new Field("*","vw_Teachclass_Period");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","vw_Teachclass_Period","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_Teachclass_Period","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MaxStuNum = new Field("MaxStuNum","vw_Teachclass_Period","MaxStuNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CTID = new Field("CTID","vw_Teachclass_Period","CTID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PKstate = new Field("PKstate","vw_Teachclass_Period","PKstate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RGID = new Field("RGID","vw_Teachclass_Period","RGID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLRSort = new Field("CLRSort","vw_Teachclass_Period","CLRSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Period = new Field("Period","vw_Teachclass_Period","Period");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ActYear = new Field("ActYear","vw_Teachclass_Period","ActYear");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCHID = new Field("TCHID","vw_Teachclass_Period","TCHID");
		}
		#endregion


	}
}

