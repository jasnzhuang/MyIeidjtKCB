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
	/// 实体类MKUserlist 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("MKUserlist")]
	[Serializable]
	public partial class MKUserlist : Entity 
	{
		#region Model
		private int _MUID;
		private int? _PSID;
		private int? _MKuai;
		private int? _Role;
		/// <summary>
		/// 
		/// </summary>
		public int MUID
		{
			get{ return _MUID; }
			set
			{
				this.OnPropertyValueChange(_.MUID,_MUID,value);
				this._MUID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PSID
		{
			get{ return _PSID; }
			set
			{
				this.OnPropertyValueChange(_.PSID,_PSID,value);
				this._PSID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MKuai
		{
			get{ return _MKuai; }
			set
			{
				this.OnPropertyValueChange(_.MKuai,_MKuai,value);
				this._MKuai=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Role
		{
			get{ return _Role; }
			set
			{
				this.OnPropertyValueChange(_.Role,_Role,value);
				this._Role=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.MUID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.MUID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.MUID,
				_.PSID,
				_.MKuai,
				_.Role};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._MUID,
				this._PSID,
				this._MKuai,
				this._Role};
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
			public readonly static Field All = new Field("*","MKUserlist");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MUID = new Field("MUID","MKUserlist","MUID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","MKUserlist","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MKuai = new Field("MKuai","MKUserlist","MKuai");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Role = new Field("Role","MKUserlist","Role");
		}
		#endregion


	}
}

