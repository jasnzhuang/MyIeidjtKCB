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
	/// 实体类FindHistory 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("FindHistory")]
	[Serializable]
	public partial class FindHistory : Entity 
	{
		#region Model
		private int _ID;
		private string _TableName;
		private string _FindName;
		private string _FindView;
		private string _FindContent;
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
		/// <summary>
		/// 
		/// </summary>
		public string TableName
		{
			get{ return _TableName; }
			set
			{
				this.OnPropertyValueChange(_.TableName,_TableName,value);
				this._TableName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FindName
		{
			get{ return _FindName; }
			set
			{
				this.OnPropertyValueChange(_.FindName,_FindName,value);
				this._FindName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FindView
		{
			get{ return _FindView; }
			set
			{
				this.OnPropertyValueChange(_.FindView,_FindView,value);
				this._FindView=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FindContent
		{
			get{ return _FindContent; }
			set
			{
				this.OnPropertyValueChange(_.FindContent,_FindContent,value);
				this._FindContent=value;
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
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.ID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ID,
				_.TableName,
				_.FindName,
				_.FindView,
				_.FindContent};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._TableName,
				this._FindName,
				this._FindView,
				this._FindContent};
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
			public readonly static Field All = new Field("*","FindHistory");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID","FindHistory","ID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TableName = new Field("TableName","FindHistory","TableName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FindName = new Field("FindName","FindHistory","FindName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FindView = new Field("FindView","FindHistory","FindView");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FindContent = new Field("FindContent","FindHistory","FindContent");
		}
		#endregion


	}
}
