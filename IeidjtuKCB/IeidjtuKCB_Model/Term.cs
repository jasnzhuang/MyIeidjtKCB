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
	/// 实体类Term 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Term")]
	[Serializable]
	public partial class Term : Entity 
	{
		#region Model
		private int _TermID;
		private string _TermName;
		private int _Weeks;
		private string _Memo;
		/// <summary>
		/// 
		/// </summary>
		public int TermID
		{
			get{ return _TermID; }
			set
			{
				this.OnPropertyValueChange(_.TermID,_TermID,value);
				this._TermID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TermName
		{
			get{ return _TermName; }
			set
			{
				this.OnPropertyValueChange(_.TermName,_TermName,value);
				this._TermName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Weeks
		{
			get{ return _Weeks; }
			set
			{
				this.OnPropertyValueChange(_.Weeks,_Weeks,value);
				this._Weeks=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Memo
		{
			get{ return _Memo; }
			set
			{
				this.OnPropertyValueChange(_.Memo,_Memo,value);
				this._Memo=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.TermID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.TermID,
				_.TermName,
				_.Weeks,
				_.Memo};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TermID,
				this._TermName,
				this._Weeks,
				this._Memo};
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
			public readonly static Field All = new Field("*","Term");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TermID = new Field("TermID","Term","TermID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TermName = new Field("TermName","Term","TermName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Weeks = new Field("Weeks","Term","Weeks");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","Term","Memo");
		}
		#endregion


	}
}

