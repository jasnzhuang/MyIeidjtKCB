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
	/// 实体类Contents 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Contents")]
	[Serializable]
	public partial class Contents : Entity 
	{
		#region Model
		private int _ChpID;
		private int? _CCID;
		private int? _ChapterID;
		private string _ChpNo;
		private string _ChpName;
		private string _ChpContent;
		private string _ChpDiffic;
		private string _ChpImport;
		private string _Keyword;
		private string _Complement;
		private string _Path;
		private string _State;
		/// <summary>
		/// 
		/// </summary>
		public int ChpID
		{
			get{ return _ChpID; }
			set
			{
				this.OnPropertyValueChange(_.ChpID,_ChpID,value);
				this._ChpID=value;
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
		public int? ChapterID
		{
			get{ return _ChapterID; }
			set
			{
				this.OnPropertyValueChange(_.ChapterID,_ChapterID,value);
				this._ChapterID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChpNo
		{
			get{ return _ChpNo; }
			set
			{
				this.OnPropertyValueChange(_.ChpNo,_ChpNo,value);
				this._ChpNo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChpName
		{
			get{ return _ChpName; }
			set
			{
				this.OnPropertyValueChange(_.ChpName,_ChpName,value);
				this._ChpName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChpContent
		{
			get{ return _ChpContent; }
			set
			{
				this.OnPropertyValueChange(_.ChpContent,_ChpContent,value);
				this._ChpContent=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChpDiffic
		{
			get{ return _ChpDiffic; }
			set
			{
				this.OnPropertyValueChange(_.ChpDiffic,_ChpDiffic,value);
				this._ChpDiffic=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChpImport
		{
			get{ return _ChpImport; }
			set
			{
				this.OnPropertyValueChange(_.ChpImport,_ChpImport,value);
				this._ChpImport=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Keyword
		{
			get{ return _Keyword; }
			set
			{
				this.OnPropertyValueChange(_.Keyword,_Keyword,value);
				this._Keyword=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Complement
		{
			get{ return _Complement; }
			set
			{
				this.OnPropertyValueChange(_.Complement,_Complement,value);
				this._Complement=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Path
		{
			get{ return _Path; }
			set
			{
				this.OnPropertyValueChange(_.Path,_Path,value);
				this._Path=value;
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
			return _.ChpID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.ChpID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ChpID,
				_.CCID,
				_.ChapterID,
				_.ChpNo,
				_.ChpName,
				_.ChpContent,
				_.ChpDiffic,
				_.ChpImport,
				_.Keyword,
				_.Complement,
				_.Path,
				_.State};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ChpID,
				this._CCID,
				this._ChapterID,
				this._ChpNo,
				this._ChpName,
				this._ChpContent,
				this._ChpDiffic,
				this._ChpImport,
				this._Keyword,
				this._Complement,
				this._Path,
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
			public readonly static Field All = new Field("*","Contents");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ChpID = new Field("ChpID","Contents","ChpID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","Contents","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ChapterID = new Field("ChapterID","Contents","ChapterID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ChpNo = new Field("ChpNo","Contents","ChpNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ChpName = new Field("ChpName","Contents","ChpName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ChpContent = new Field("ChpContent","Contents","ChpContent");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ChpDiffic = new Field("ChpDiffic","Contents","ChpDiffic");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ChpImport = new Field("ChpImport","Contents","ChpImport");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Keyword = new Field("Keyword","Contents","Keyword");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Complement = new Field("Complement","Contents","Complement");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Path = new Field("Path","Contents","Path");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("state","Contents","state");
		}
		#endregion


	}
}

