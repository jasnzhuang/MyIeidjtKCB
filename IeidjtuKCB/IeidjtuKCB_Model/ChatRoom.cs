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
	/// 实体类ChatRoom 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("ChatRoom")]
	[Serializable]
	public partial class ChatRoom : Entity 
	{
		#region Model
		private int _CMID;
		private string _CMname;
		private DateTime? _CMdate;
		private int? _BID;
		private string _State;
		/// <summary>
		/// 
		/// </summary>
		public int CMID
		{
			get{ return _CMID; }
			set
			{
				this.OnPropertyValueChange(_.CMID,_CMID,value);
				this._CMID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CMname
		{
			get{ return _CMname; }
			set
			{
				this.OnPropertyValueChange(_.CMname,_CMname,value);
				this._CMname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CMdate
		{
			get{ return _CMdate; }
			set
			{
				this.OnPropertyValueChange(_.CMdate,_CMdate,value);
				this._CMdate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BID
		{
			get{ return _BID; }
			set
			{
				this.OnPropertyValueChange(_.BID,_BID,value);
				this._BID=value;
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
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.CMID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.CMID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.CMID,
				_.CMname,
				_.CMdate,
				_.BID,
				_.State};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._CMID,
				this._CMname,
				this._CMdate,
				this._BID,
				this._State};
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
			public readonly static Field All = new Field("*","ChatRoom");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CMID = new Field("CMID","ChatRoom","CMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CMname = new Field("CMname","ChatRoom","CMname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CMdate = new Field("CMdate","ChatRoom","CMdate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BID = new Field("BID","ChatRoom","BID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("state","ChatRoom","state");
		}
		#endregion


	}
}

