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
	/// 实体类SCRelation 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("SCRelation")]
	[Serializable]
	public partial class SCRelation : Entity 
	{
		#region Model
		private int _SCRID;
		private string _Scource;
		private decimal? _Relation;
		/// <summary>
		/// 
		/// </summary>
		public int SCRID
		{
			get{ return _SCRID; }
			set
			{
				this.OnPropertyValueChange(_.SCRID,_SCRID,value);
				this._SCRID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Scource
		{
			get{ return _Scource; }
			set
			{
				this.OnPropertyValueChange(_.Scource,_Scource,value);
				this._Scource=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Relation
		{
			get{ return _Relation; }
			set
			{
				this.OnPropertyValueChange(_.Relation,_Relation,value);
				this._Relation=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.SCRID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.SCRID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.SCRID,
				_.Scource,
				_.Relation};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SCRID,
				this._Scource,
				this._Relation};
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
			public readonly static Field All = new Field("*","SCRelation");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SCRID = new Field("SCRID","SCRelation","SCRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Scource = new Field("Scource","SCRelation","Scource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Relation = new Field("Relation","SCRelation","Relation");
		}
		#endregion


	}
}

