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
	/// 实体类EduDirect 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("EduDirect")]
	[Serializable]
	public partial class EduDirect : Entity 
	{
		#region Model
		private int _EDID;
		private int? _EMID;
		private int? _GRID;
		private int? _SPID;
		private string _DCode;
		private string _Direction;
		/// <summary>
		/// 
		/// </summary>
		public int EDID
		{
			get{ return _EDID; }
			set
			{
				this.OnPropertyValueChange(_.EDID,_EDID,value);
				this._EDID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EMID
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
		public string DCode
		{
			get{ return _DCode; }
			set
			{
				this.OnPropertyValueChange(_.DCode,_DCode,value);
				this._DCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Direction
		{
			get{ return _Direction; }
			set
			{
				this.OnPropertyValueChange(_.Direction,_Direction,value);
				this._Direction=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.EDID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.EDID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.EDID,
				_.EMID,
				_.GRID,
				_.SPID,
				_.DCode,
				_.Direction};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._EDID,
				this._EMID,
				this._GRID,
				this._SPID,
				this._DCode,
				this._Direction};
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
			public readonly static Field All = new Field("*","EduDirect");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EDID = new Field("EDID","EduDirect","EDID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMID = new Field("EMID","EduDirect","EMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","EduDirect","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","EduDirect","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DCode = new Field("DCode","EduDirect","DCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Direction = new Field("Direction","EduDirect","Direction");
		}
		#endregion


	}
}

