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
	/// 实体类vw_Stureport_Max 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Stureport_Max")]
	[Serializable]
	public partial class vw_Stureport_Max : Entity 
	{
		#region Model
		private decimal? _BasSource;
		private int? _CCID;
		private decimal? _TruePoint;
		private int? _StuID;
		private int? _SPID;
		private int? _Grid;
		private string _InPlan;
		private string _PlanSort;
		private string _IsMain;
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
		public int? Grid
		{
			get{ return _Grid; }
			set
			{
				this.OnPropertyValueChange(_.Grid,_Grid,value);
				this._Grid=value;
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
		public string PlanSort
		{
			get{ return _PlanSort; }
			set
			{
				this.OnPropertyValueChange(_.PlanSort,_PlanSort,value);
				this._PlanSort=value;
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
				_.BasSource,
				_.CCID,
				_.TruePoint,
				_.StuID,
				_.SPID,
				_.Grid,
				_.InPlan,
				_.PlanSort,
				_.IsMain};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._BasSource,
				this._CCID,
				this._TruePoint,
				this._StuID,
				this._SPID,
				this._Grid,
				this._InPlan,
				this._PlanSort,
				this._IsMain};
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
			public readonly static Field All = new Field("*","vw_Stureport_Max");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BasSource = new Field("BasSource","vw_Stureport_Max","BasSource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_Stureport_Max","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TruePoint = new Field("TruePoint","vw_Stureport_Max","TruePoint");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StuID = new Field("StuID","vw_Stureport_Max","StuID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_Stureport_Max","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Grid = new Field("Grid","vw_Stureport_Max","Grid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field InPlan = new Field("InPlan","vw_Stureport_Max","InPlan");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PlanSort = new Field("PlanSort","vw_Stureport_Max","PlanSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IsMain = new Field("IsMain","vw_Stureport_Max","IsMain");
		}
		#endregion


	}
}

