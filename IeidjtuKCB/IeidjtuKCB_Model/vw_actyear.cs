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
	/// 实体类vw_actyear 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_actyear")]
	[Serializable]
	public partial class vw_actyear : Entity 
	{
		#region Model
		private string _ATName;
		private int _ATID;
		private int? _YearName;
		private string _State;
		private int? _ATNo;
		/// <summary>
		/// 
		/// </summary>
		public string ATName
		{
			get{ return _ATName; }
			set
			{
				this.OnPropertyValueChange(_.ATName,_ATName,value);
				this._ATName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ATID
		{
			get{ return _ATID; }
			set
			{
				this.OnPropertyValueChange(_.ATID,_ATID,value);
				this._ATID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? YearName
		{
			get{ return _YearName; }
			set
			{
				this.OnPropertyValueChange(_.YearName,_YearName,value);
				this._YearName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string State
		{
			get{ return _State; }
			set
			{
				this.OnPropertyValueChange(_.State,_State,value);
				this._State=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ATNo
		{
			get{ return _ATNo; }
			set
			{
				this.OnPropertyValueChange(_.ATNo,_ATNo,value);
				this._ATNo=value;
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
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.ATID;
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ATName,
				_.ATID,
				_.YearName,
				_.State,
				_.ATNo};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ATName,
				this._ATID,
				this._YearName,
				this._State,
				this._ATNo};
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
			public readonly static Field All = new Field("*","vw_actyear");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATName = new Field("ATName","vw_actyear","ATName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATID = new Field("ATID","vw_actyear","ATID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field YearName = new Field("YearName","vw_actyear","YearName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","vw_actyear","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATNo = new Field("ATNo","vw_actyear","ATNo");
		}
		#endregion


	}
}

