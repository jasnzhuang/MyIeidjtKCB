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
	/// 实体类StatByDept 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("StatByDept")]
	[Serializable]
	public partial class StatByDept : Entity 
	{
		#region Model
		private int _STADID;
		private int? _AtyID;
		private int? _CCID;
		private int? _DeptID;
		private int? _GRID;
		private string _DeptCode;
		private int? _LevID;
		private string _LevContent;
		private int? _FromL;
		private int? _ToL;
		private int? _PSNum;
		private int? _AllNum;
		private decimal? _Per;
		private decimal? _AvgS;
		/// <summary>
		/// 
		/// </summary>
		public int STADID
		{
			get{ return _STADID; }
			set
			{
				this.OnPropertyValueChange(_.STADID,_STADID,value);
				this._STADID=value;
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
		public int? LevID
		{
			get{ return _LevID; }
			set
			{
				this.OnPropertyValueChange(_.LevID,_LevID,value);
				this._LevID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LevContent
		{
			get{ return _LevContent; }
			set
			{
				this.OnPropertyValueChange(_.LevContent,_LevContent,value);
				this._LevContent=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FromL
		{
			get{ return _FromL; }
			set
			{
				this.OnPropertyValueChange(_.FromL,_FromL,value);
				this._FromL=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ToL
		{
			get{ return _ToL; }
			set
			{
				this.OnPropertyValueChange(_.ToL,_ToL,value);
				this._ToL=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PSNum
		{
			get{ return _PSNum; }
			set
			{
				this.OnPropertyValueChange(_.PSNum,_PSNum,value);
				this._PSNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AllNum
		{
			get{ return _AllNum; }
			set
			{
				this.OnPropertyValueChange(_.AllNum,_AllNum,value);
				this._AllNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Per
		{
			get{ return _Per; }
			set
			{
				this.OnPropertyValueChange(_.Per,_Per,value);
				this._Per=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AvgS
		{
			get{ return _AvgS; }
			set
			{
				this.OnPropertyValueChange(_.AvgS,_AvgS,value);
				this._AvgS=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.STADID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.STADID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.STADID,
				_.AtyID,
				_.CCID,
				_.DeptID,
				_.GRID,
				_.DeptCode,
				_.LevID,
				_.LevContent,
				_.FromL,
				_.ToL,
				_.PSNum,
				_.AllNum,
				_.Per,
				_.AvgS};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._STADID,
				this._AtyID,
				this._CCID,
				this._DeptID,
				this._GRID,
				this._DeptCode,
				this._LevID,
				this._LevContent,
				this._FromL,
				this._ToL,
				this._PSNum,
				this._AllNum,
				this._Per,
				this._AvgS};
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
			public readonly static Field All = new Field("*","StatByDept");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STADID = new Field("STADID","StatByDept","STADID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AtyID = new Field("AtyID","StatByDept","AtyID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","StatByDept","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptID = new Field("DeptID","StatByDept","DeptID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","StatByDept","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCode = new Field("DeptCode","StatByDept","DeptCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LevID = new Field("LevID","StatByDept","LevID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LevContent = new Field("LevContent","StatByDept","LevContent");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FromL = new Field("FromL","StatByDept","FromL");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ToL = new Field("ToL","StatByDept","ToL");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSNum = new Field("PSNum","StatByDept","PSNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AllNum = new Field("AllNum","StatByDept","AllNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Per = new Field("Per","StatByDept","Per");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AvgS = new Field("AvgS","StatByDept","AvgS");
		}
		#endregion


	}
}

