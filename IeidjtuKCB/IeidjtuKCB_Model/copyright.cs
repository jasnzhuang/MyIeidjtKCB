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
	/// 实体类Copyright 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("copyright")]
	[Serializable]
	public partial class Copyright : Entity 
	{
		#region Model
		private int _ZLID;
		private string _ZLsort;
		private int? _Source;
		/// <summary>
		/// 
		/// </summary>
		public int ZLID
		{
			get{ return _ZLID; }
			set
			{
				this.OnPropertyValueChange(_.ZLID,_ZLID,value);
				this._ZLID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZLsort
		{
			get{ return _ZLsort; }
			set
			{
				this.OnPropertyValueChange(_.ZLsort,_ZLsort,value);
				this._ZLsort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Source
		{
			get{ return _Source; }
			set
			{
				this.OnPropertyValueChange(_.Source,_Source,value);
				this._Source=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.ZLID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.ZLID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ZLID,
				_.ZLsort,
				_.Source};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ZLID,
				this._ZLsort,
				this._Source};
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
			public readonly static Field All = new Field("*","copyright");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ZLID = new Field("ZLID","copyright","ZLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ZLsort = new Field("ZLsort","copyright","ZLsort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Source = new Field("source","copyright","source");
		}
		#endregion


	}
}

