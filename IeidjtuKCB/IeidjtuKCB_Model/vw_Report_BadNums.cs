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
	/// 实体类vw_Report_BadNums 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Report_BadNums")]
	[Serializable]
	public partial class vw_Report_BadNums : Entity 
	{
		#region Model
		private int _Nums;
		private int? _STDID;
		private int? _CCID;
		private int? _SPID;
		private int? _GRID;
		private string _ifCheck;
		private string _ifCheckBy;
		private int? _CLID;
		/// <summary>
		/// 
		/// </summary>
		public int Nums
		{
			get{ return _Nums; }
			set
			{
				this.OnPropertyValueChange(_.Nums,_Nums,value);
				this._Nums=value;
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
		public int? CLID
		{
			get{ return _CLID; }
			set
			{
				this.OnPropertyValueChange(_.CLID,_CLID,value);
				this._CLID=value;
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
				_.Nums,
				_.STDID,
				_.CCID,
				_.SPID,
				_.GRID,
				_.ifCheck,
				_.ifCheckBy,
				_.CLID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Nums,
				this._STDID,
				this._CCID,
				this._SPID,
				this._GRID,
				this._ifCheck,
				this._ifCheckBy,
				this._CLID};
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
			public readonly static Field All = new Field("*","vw_Report_BadNums");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Nums = new Field("Nums","vw_Report_BadNums","Nums");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STDID = new Field("STDID","vw_Report_BadNums","STDID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_Report_BadNums","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_Report_BadNums","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","vw_Report_BadNums","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ifCheck = new Field("ifCheck","vw_Report_BadNums","ifCheck");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ifCheckBy = new Field("ifCheckBy","vw_Report_BadNums","ifCheckBy");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLID = new Field("CLID","vw_Report_BadNums","CLID");
		}
		#endregion


	}
}
