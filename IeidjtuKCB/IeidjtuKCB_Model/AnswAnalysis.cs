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
	/// 实体类AnswAnalysis 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("AnswAnalysis")]
	[Serializable]
	public partial class AnswAnalysis : Entity 
	{
		#region Model
		private int _ContID;
		private int? _CCID;
		private string _Contname;
		private string _Contchrt;
		private string _Contgram;
		private string _ContWH;
		/// <summary>
		/// 
		/// </summary>
		public int ContID
		{
			get{ return _ContID; }
			set
			{
				this.OnPropertyValueChange(_.ContID,_ContID,value);
				this._ContID=value;
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
		public string Contname
		{
			get{ return _Contname; }
			set
			{
				this.OnPropertyValueChange(_.Contname,_Contname,value);
				this._Contname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Contchrt
		{
			get{ return _Contchrt; }
			set
			{
				this.OnPropertyValueChange(_.Contchrt,_Contchrt,value);
				this._Contchrt=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Contgram
		{
			get{ return _Contgram; }
			set
			{
				this.OnPropertyValueChange(_.Contgram,_Contgram,value);
				this._Contgram=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ContWH
		{
			get{ return _ContWH; }
			set
			{
				this.OnPropertyValueChange(_.ContWH,_ContWH,value);
				this._ContWH=value;
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
				_.ContID,
				_.CCID,
				_.Contname,
				_.Contchrt,
				_.Contgram,
				_.ContWH};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ContID,
				this._CCID,
				this._Contname,
				this._Contchrt,
				this._Contgram,
				this._ContWH};
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
			public readonly static Field All = new Field("*","AnswAnalysis");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ContID = new Field("ContID","AnswAnalysis","ContID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","AnswAnalysis","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Contname = new Field("Contname","AnswAnalysis","Contname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Contchrt = new Field("Contchrt","AnswAnalysis","Contchrt");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Contgram = new Field("Contgram","AnswAnalysis","Contgram");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ContWH = new Field("ContWH","AnswAnalysis","ContWH");
		}
		#endregion


	}
}

