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
	/// 实体类AHead 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("AHead")]
	[Serializable]
	public partial class AHead : Entity 
	{
		#region Model
		private int _ADID;
		private int? _CCID;
		private int? _AHCCID;
		private string _AHCCname;
		/// <summary>
		/// 
		/// </summary>
		public int ADID
		{
			get{ return _ADID; }
			set
			{
				this.OnPropertyValueChange(_.ADID,_ADID,value);
				this._ADID=value;
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
		public int? AHCCID
		{
			get{ return _AHCCID; }
			set
			{
				this.OnPropertyValueChange(_.AHCCID,_AHCCID,value);
				this._AHCCID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AHCCname
		{
			get{ return _AHCCname; }
			set
			{
				this.OnPropertyValueChange(_.AHCCname,_AHCCname,value);
				this._AHCCname=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.ADID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.ADID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ADID,
				_.CCID,
				_.AHCCID,
				_.AHCCname};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ADID,
				this._CCID,
				this._AHCCID,
				this._AHCCname};
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
			public readonly static Field All = new Field("*","AHead");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ADID = new Field("ADID","AHead","ADID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","AHead","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AHCCID = new Field("AHCCID","AHead","AHCCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AHCCname = new Field("AHCCname","AHead","AHCCname");
		}
		#endregion


	}
}

