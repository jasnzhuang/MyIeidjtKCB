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
	/// 实体类TeacherState 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("TeacherState")]
	[Serializable]
	public partial class TeacherState : Entity 
	{
		#region Model
		private int _TSID;
		private string _PSState;
		/// <summary>
		/// 
		/// </summary>
		public int TSID
		{
			get{ return _TSID; }
			set
			{
				this.OnPropertyValueChange(_.TSID,_TSID,value);
				this._TSID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PSState
		{
			get{ return _PSState; }
			set
			{
				this.OnPropertyValueChange(_.PSState,_PSState,value);
				this._PSState=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.TSID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.TSID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.TSID,
				_.PSState};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TSID,
				this._PSState};
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
			public readonly static Field All = new Field("*","TeacherState");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TSID = new Field("TSID","TeacherState","TSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSState = new Field("PSState","TeacherState","PSState");
		}
		#endregion


	}
}
