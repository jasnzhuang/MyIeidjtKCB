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
	/// 实体类SciMoney 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("SciMoney")]
	[Serializable]
	public partial class SciMoney : Entity 
	{
		#region Model
		private int _LevID;
		private string _ItemLev;
		private string _Pos;
		private decimal? _Sorce;
		/// <summary>
		/// 
		/// </summary>
		public int LevID
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
		public string ItemLev
		{
			get{ return _ItemLev; }
			set
			{
				this.OnPropertyValueChange(_.ItemLev,_ItemLev,value);
				this._ItemLev=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Pos
		{
			get{ return _Pos; }
			set
			{
				this.OnPropertyValueChange(_.Pos,_Pos,value);
				this._Pos=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Sorce
		{
			get{ return _Sorce; }
			set
			{
				this.OnPropertyValueChange(_.Sorce,_Sorce,value);
				this._Sorce=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.LevID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.LevID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.LevID,
				_.ItemLev,
				_.Pos,
				_.Sorce};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._LevID,
				this._ItemLev,
				this._Pos,
				this._Sorce};
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
			public readonly static Field All = new Field("*","SciMoney");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LevID = new Field("LevID","SciMoney","LevID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ItemLev = new Field("ItemLev","SciMoney","ItemLev");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Pos = new Field("Pos","SciMoney","Pos");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sorce = new Field("sorce","SciMoney","sorce");
		}
		#endregion


	}
}

