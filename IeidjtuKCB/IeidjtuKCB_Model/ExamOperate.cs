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
	/// 实体类ExamOperate 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("ExamOperate")]
	[Serializable]
	public partial class ExamOperate : Entity 
	{
		#region Model
		private int _EOPID;
		private string _Operation;
		/// <summary>
		/// 
		/// </summary>
		public int EOPID
		{
			get{ return _EOPID; }
			set
			{
				this.OnPropertyValueChange(_.EOPID,_EOPID,value);
				this._EOPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Operation
		{
			get{ return _Operation; }
			set
			{
				this.OnPropertyValueChange(_.Operation,_Operation,value);
				this._Operation=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.EOPID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.EOPID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.EOPID,
				_.Operation};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._EOPID,
				this._Operation};
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
			public readonly static Field All = new Field("*","ExamOperate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EOPID = new Field("EOPID","ExamOperate","EOPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Operation = new Field("Operation","ExamOperate","Operation");
		}
		#endregion


	}
}

