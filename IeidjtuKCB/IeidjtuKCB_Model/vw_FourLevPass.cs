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
	/// 实体类vw_FourLevPass 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_FourLevPass")]
	[Serializable]
	public partial class vw_FourLevPass : Entity 
	{
		#region Model
		private int? _StuID;
		private int? _SPID;
		private int? _Grid;
		/// <summary>
		/// 
		/// </summary>
		public int? StuID
		{
			get{ return _StuID; }
			set
			{
				this.OnPropertyValueChange(_.StuID,_StuID,value);
				this._StuID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SPID
		{
			get{ return _SPID; }
			set
			{
				this.OnPropertyValueChange(_.SPID,_SPID,value);
				this._SPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Grid
		{
			get{ return _Grid; }
			set
			{
				this.OnPropertyValueChange(_.Grid,_Grid,value);
				this._Grid=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 是否只读
		/// </summary>
		public override bool IsReadOnly()
		{
			return true;
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.StuID,
				_.SPID,
				_.Grid};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._StuID,
				this._SPID,
				this._Grid};
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
			public readonly static Field All = new Field("*","vw_FourLevPass");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StuID = new Field("StuID","vw_FourLevPass","StuID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_FourLevPass","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Grid = new Field("Grid","vw_FourLevPass","Grid");
		}
		#endregion


	}
}

