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
	/// 实体类RECON 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("RECON")]
	[Serializable]
	public partial class RECON : Entity 
	{
		#region Model
		private int _RECONID;
		private int? _CCID;
		private int? _CONID;
		private string _RECON;
		/// <summary>
		/// 
		/// </summary>
		public int RECONID
		{
			get{ return _RECONID; }
			set
			{
				this.OnPropertyValueChange(_.RECONID,_RECONID,value);
				this._RECONID=value;
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
		public int? CONID
		{
			get{ return _CONID; }
			set
			{
				this.OnPropertyValueChange(_.CONID,_CONID,value);
				this._CONID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RECON1
		{
			get{ return _RECON; }
			set
			{
				this.OnPropertyValueChange(_.RECON,_RECON,value);
				this._RECON=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.RECONID,
				_.CCID,
				_.CONID,
				_.RECON};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._RECONID,
				this._CCID,
				this._CONID,
				this._RECON};
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
			public readonly static Field All = new Field("*","RECON");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RECONID = new Field("RECONID","RECON","RECONID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","RECON","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CONID = new Field("CONID","RECON","CONID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RECON = new Field("RECON","RECON","RECON");
		}
		#endregion


	}
}

