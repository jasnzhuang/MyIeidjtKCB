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
	/// 实体类ThesisTypeEnd 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("ThesisTypeEnd")]
	[Serializable]
	public partial class ThesisTypeEnd : Entity 
	{
		#region Model
		private int _ThTyID;
		private string _ThTyName;
		/// <summary>
		/// 
		/// </summary>
		public int ThTyID
		{
			get{ return _ThTyID; }
			set
			{
				this.OnPropertyValueChange(_.ThTyID,_ThTyID,value);
				this._ThTyID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ThTyName
		{
			get{ return _ThTyName; }
			set
			{
				this.OnPropertyValueChange(_.ThTyName,_ThTyName,value);
				this._ThTyName=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.ThTyID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.ThTyID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ThTyID,
				_.ThTyName};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ThTyID,
				this._ThTyName};
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
			public readonly static Field All = new Field("*","ThesisTypeEnd");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ThTyID = new Field("ThTyID","ThesisTypeEnd","ThTyID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ThTyName = new Field("ThTyName","ThesisTypeEnd","ThTyName");
		}
		#endregion


	}
}
