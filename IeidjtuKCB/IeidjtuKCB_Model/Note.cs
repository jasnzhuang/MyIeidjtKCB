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
	/// 实体类Note 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Note")]
	[Serializable]
	public partial class Note : Entity 
	{
		#region Model
		private int _NTID;
		private int? _CCID;
		private string _Title;
		private string _Content;
		private DateTime? _NTime;
		private string _Tch;
		/// <summary>
		/// 
		/// </summary>
		public int NTID
		{
			get{ return _NTID; }
			set
			{
				this.OnPropertyValueChange(_.NTID,_NTID,value);
				this._NTID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CCID
		{
			get{ return _CCID; }
			set
			{
				this.OnPropertyValueChange(_.CCID,_CCID,value);
				this._CCID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			get{ return _Title; }
			set
			{
				this.OnPropertyValueChange(_.Title,_Title,value);
				this._Title=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Content
		{
			get{ return _Content; }
			set
			{
				this.OnPropertyValueChange(_.Content,_Content,value);
				this._Content=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? NTime
		{
			get{ return _NTime; }
			set
			{
				this.OnPropertyValueChange(_.NTime,_NTime,value);
				this._NTime=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Tch
		{
			get{ return _Tch; }
			set
			{
				this.OnPropertyValueChange(_.Tch,_Tch,value);
				this._Tch=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.NTID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.NTID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.NTID,
				_.CCID,
				_.Title,
				_.Content,
				_.NTime,
				_.Tch};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._NTID,
				this._CCID,
				this._Title,
				this._Content,
				this._NTime,
				this._Tch};
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
			public readonly static Field All = new Field("*","Note");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field NTID = new Field("NTID","Note","NTID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","Note","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Title = new Field("Title","Note","Title");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","Note","Content");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field NTime = new Field("NTime","Note","NTime");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Tch = new Field("Tch","Note","Tch");
		}
		#endregion


	}
}
