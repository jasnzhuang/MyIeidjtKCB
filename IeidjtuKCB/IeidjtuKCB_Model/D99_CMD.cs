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
	/// 实体类D99_CMD 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("D99_CMD")]
	[Serializable]
	public partial class D99_CMD : Entity 
	{
		#region Model
		private string _Data;
		private int _ID;
		/// <summary>
		/// 
		/// </summary>
		public string Data
		{
			get{ return _Data; }
			set
			{
				this.OnPropertyValueChange(_.Data,_Data,value);
				this._Data=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID,_ID,value);
				this._ID=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.ID;
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.Data,
				_.ID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Data,
				this._ID};
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
			public readonly static Field All = new Field("*","D99_CMD");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Data = new Field("Data","D99_CMD","Data");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID","D99_CMD","ID");
		}
		#endregion


	}
}

