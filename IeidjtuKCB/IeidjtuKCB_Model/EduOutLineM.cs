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
	/// 实体类EduOutLineM 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("EduOutLineM")]
	[Serializable]
	public partial class EduOutLineM : Entity 
	{
		#region Model
		private int _EOMID;
		private int _CCID;
		private string _EnglishMemo;
		private string _ApplyTo;
		private string _Version;
		private string _Explain;
		private string _Oper;
		private string _Checker;
		private string _Confirmer;
		private string _Books;
		private string _State;
		private string _EUnits;
		private DateTime? _InputDate;
		private string _EOMSort;
		/// <summary>
		/// 
		/// </summary>
		public int EOMID
		{
			get{ return _EOMID; }
			set
			{
				this.OnPropertyValueChange(_.EOMID,_EOMID,value);
				this._EOMID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CCID
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
		public string EnglishMemo
		{
			get{ return _EnglishMemo; }
			set
			{
				this.OnPropertyValueChange(_.EnglishMemo,_EnglishMemo,value);
				this._EnglishMemo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ApplyTo
		{
			get{ return _ApplyTo; }
			set
			{
				this.OnPropertyValueChange(_.ApplyTo,_ApplyTo,value);
				this._ApplyTo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Version
		{
			get{ return _Version; }
			set
			{
				this.OnPropertyValueChange(_.Version,_Version,value);
				this._Version=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Explain
		{
			get{ return _Explain; }
			set
			{
				this.OnPropertyValueChange(_.Explain,_Explain,value);
				this._Explain=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Oper
		{
			get{ return _Oper; }
			set
			{
				this.OnPropertyValueChange(_.Oper,_Oper,value);
				this._Oper=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Checker
		{
			get{ return _Checker; }
			set
			{
				this.OnPropertyValueChange(_.Checker,_Checker,value);
				this._Checker=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Confirmer
		{
			get{ return _Confirmer; }
			set
			{
				this.OnPropertyValueChange(_.Confirmer,_Confirmer,value);
				this._Confirmer=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Books
		{
			get{ return _Books; }
			set
			{
				this.OnPropertyValueChange(_.Books,_Books,value);
				this._Books=value;
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
		public string EUnits
		{
			get{ return _EUnits; }
			set
			{
				this.OnPropertyValueChange(_.EUnits,_EUnits,value);
				this._EUnits=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? InputDate
		{
			get{ return _InputDate; }
			set
			{
				this.OnPropertyValueChange(_.InputDate,_InputDate,value);
				this._InputDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EOMSort
		{
			get{ return _EOMSort; }
			set
			{
				this.OnPropertyValueChange(_.EOMSort,_EOMSort,value);
				this._EOMSort=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.EOMID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.EOMID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.EOMID,
				_.CCID,
				_.EnglishMemo,
				_.ApplyTo,
				_.Version,
				_.Explain,
				_.Oper,
				_.Checker,
				_.Confirmer,
				_.Books,
				_.State,
				_.EUnits,
				_.InputDate,
				_.EOMSort};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._EOMID,
				this._CCID,
				this._EnglishMemo,
				this._ApplyTo,
				this._Version,
				this._Explain,
				this._Oper,
				this._Checker,
				this._Confirmer,
				this._Books,
				this._State,
				this._EUnits,
				this._InputDate,
				this._EOMSort};
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
			public readonly static Field All = new Field("*","EduOutLineM");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EOMID = new Field("EOMID","EduOutLineM","EOMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","EduOutLineM","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EnglishMemo = new Field("EnglishMemo","EduOutLineM","EnglishMemo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ApplyTo = new Field("ApplyTo","EduOutLineM","ApplyTo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Version = new Field("Version","EduOutLineM","Version");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Explain = new Field("Explain","EduOutLineM","Explain");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oper = new Field("Oper","EduOutLineM","Oper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Checker = new Field("Checker","EduOutLineM","Checker");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Confirmer = new Field("Confirmer","EduOutLineM","Confirmer");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Books = new Field("Books","EduOutLineM","Books");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","EduOutLineM","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EUnits = new Field("EUnits","EduOutLineM","EUnits");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field InputDate = new Field("InputDate","EduOutLineM","InputDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EOMSort = new Field("EOMSort","EduOutLineM","EOMSort");
		}
		#endregion


	}
}

