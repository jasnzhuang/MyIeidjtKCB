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
	/// 实体类MinorStu 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("MinorStu")]
	[Serializable]
	public partial class MinorStu : Entity 
	{
		#region Model
		private int _MSID;
		private int? _SPID;
		private int? _CLID;
		private int? _StdID;
		private DateTime? _LogDate;
		private string _State;
		private string _Graduate;
		private int? _EMID;
		/// <summary>
		/// 
		/// </summary>
		public int MSID
		{
			get{ return _MSID; }
			set
			{
				this.OnPropertyValueChange(_.MSID,_MSID,value);
				this._MSID=value;
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
		public int? CLID
		{
			get{ return _CLID; }
			set
			{
				this.OnPropertyValueChange(_.CLID,_CLID,value);
				this._CLID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StdID
		{
			get{ return _StdID; }
			set
			{
				this.OnPropertyValueChange(_.StdID,_StdID,value);
				this._StdID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LogDate
		{
			get{ return _LogDate; }
			set
			{
				this.OnPropertyValueChange(_.LogDate,_LogDate,value);
				this._LogDate=value;
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
		public string Graduate
		{
			get{ return _Graduate; }
			set
			{
				this.OnPropertyValueChange(_.Graduate,_Graduate,value);
				this._Graduate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EMID
		{
			get{ return _EMID; }
			set
			{
				this.OnPropertyValueChange(_.EMID,_EMID,value);
				this._EMID=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.MSID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.MSID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.MSID,
				_.SPID,
				_.CLID,
				_.StdID,
				_.LogDate,
				_.State,
				_.Graduate,
				_.EMID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._MSID,
				this._SPID,
				this._CLID,
				this._StdID,
				this._LogDate,
				this._State,
				this._Graduate,
				this._EMID};
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
			public readonly static Field All = new Field("*","MinorStu");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MSID = new Field("MSID","MinorStu","MSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","MinorStu","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLID = new Field("CLID","MinorStu","CLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdID = new Field("StdID","MinorStu","StdID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LogDate = new Field("LogDate","MinorStu","LogDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("state","MinorStu","state");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Graduate = new Field("Graduate","MinorStu","Graduate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMID = new Field("EMID","MinorStu","EMID");
		}
		#endregion


	}
}

