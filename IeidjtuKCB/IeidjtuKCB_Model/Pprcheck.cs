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
	/// 实体类Pprcheck 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Pprcheck")]
	[Serializable]
	public partial class Pprcheck : Entity 
	{
		#region Model
		private int _ScrdID;
		private int? _CCID;
		private int? _ScrID;
		private int? _PaperID;
		private string _StdAnswer;
		private decimal? _Stdscore;
		private string _State;
		/// <summary>
		/// 
		/// </summary>
		public int ScrdID
		{
			get{ return _ScrdID; }
			set
			{
				this.OnPropertyValueChange(_.ScrdID,_ScrdID,value);
				this._ScrdID=value;
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
		public int? ScrID
		{
			get{ return _ScrID; }
			set
			{
				this.OnPropertyValueChange(_.ScrID,_ScrID,value);
				this._ScrID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PaperID
		{
			get{ return _PaperID; }
			set
			{
				this.OnPropertyValueChange(_.PaperID,_PaperID,value);
				this._PaperID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StdAnswer
		{
			get{ return _StdAnswer; }
			set
			{
				this.OnPropertyValueChange(_.StdAnswer,_StdAnswer,value);
				this._StdAnswer=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Stdscore
		{
			get{ return _Stdscore; }
			set
			{
				this.OnPropertyValueChange(_.Stdscore,_Stdscore,value);
				this._Stdscore=value;
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
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ScrdID,
				_.CCID,
				_.ScrID,
				_.PaperID,
				_.StdAnswer,
				_.Stdscore,
				_.State};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ScrdID,
				this._CCID,
				this._ScrID,
				this._PaperID,
				this._StdAnswer,
				this._Stdscore,
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
			public readonly static Field All = new Field("*","Pprcheck");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ScrdID = new Field("ScrdID","Pprcheck","ScrdID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","Pprcheck","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ScrID = new Field("ScrID","Pprcheck","ScrID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PaperID = new Field("PaperID","Pprcheck","PaperID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdAnswer = new Field("StdAnswer","Pprcheck","StdAnswer");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdscore = new Field("Stdscore","Pprcheck","Stdscore");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","Pprcheck","State");
		}
		#endregion


	}
}

