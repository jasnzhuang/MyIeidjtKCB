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
	/// 实体类TecLev 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("TecLev")]
	[Serializable]
	public partial class TecLev : Entity 
	{
		#region Model
		private int _TLID;
		private string _TLev;
		/// <summary>
		/// 
		/// </summary>
		public int TLID
		{
			get{ return _TLID; }
			set
			{
				this.OnPropertyValueChange(_.TLID,_TLID,value);
				this._TLID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TLev
		{
			get{ return _TLev; }
			set
			{
				this.OnPropertyValueChange(_.TLev,_TLev,value);
				this._TLev=value;
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
				_.TLID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.TLID,
				_.TLev};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TLID,
				this._TLev};
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
			public readonly static Field All = new Field("*","TecLev");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TLID = new Field("TLID","TecLev","TLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TLev = new Field("TLev","TecLev","TLev");
		}
		#endregion


	}
}
