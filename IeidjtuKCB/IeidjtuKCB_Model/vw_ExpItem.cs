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
	/// 实体类vw_ExpItem 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_ExpItem")]
	[Serializable]
	public partial class vw_ExpItem : Entity 
	{
		#region Model
		private int _ExpItemID;
		private int? _XH;
		private int? _CCID;
		private string _Expname;
		private string _ExpContent;
		private string _Equpment;
		private int? _GroupPsNum;
		private int? _Period;
		private string _Oper;
		private string _CCname;
		private string _expLimit;
		private string _ExpSort;
		private string _Version;
		private string _ApplyTo;
		private int? _EOMID;
		/// <summary>
		/// 
		/// </summary>
		public int ExpItemID
		{
			get{ return _ExpItemID; }
			set
			{
				this.OnPropertyValueChange(_.ExpItemID,_ExpItemID,value);
				this._ExpItemID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? XH
		{
			get{ return _XH; }
			set
			{
				this.OnPropertyValueChange(_.XH,_XH,value);
				this._XH=value;
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
		public string Expname
		{
			get{ return _Expname; }
			set
			{
				this.OnPropertyValueChange(_.Expname,_Expname,value);
				this._Expname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExpContent
		{
			get{ return _ExpContent; }
			set
			{
				this.OnPropertyValueChange(_.ExpContent,_ExpContent,value);
				this._ExpContent=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Equpment
		{
			get{ return _Equpment; }
			set
			{
				this.OnPropertyValueChange(_.Equpment,_Equpment,value);
				this._Equpment=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GroupPsNum
		{
			get{ return _GroupPsNum; }
			set
			{
				this.OnPropertyValueChange(_.GroupPsNum,_GroupPsNum,value);
				this._GroupPsNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Period
		{
			get{ return _Period; }
			set
			{
				this.OnPropertyValueChange(_.Period,_Period,value);
				this._Period=value;
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
		public string CCname
		{
			get{ return _CCname; }
			set
			{
				this.OnPropertyValueChange(_.CCname,_CCname,value);
				this._CCname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string expLimit
		{
			get{ return _expLimit; }
			set
			{
				this.OnPropertyValueChange(_.expLimit,_expLimit,value);
				this._expLimit=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExpSort
		{
			get{ return _ExpSort; }
			set
			{
				this.OnPropertyValueChange(_.ExpSort,_ExpSort,value);
				this._ExpSort=value;
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
		public int? EOMID
		{
			get{ return _EOMID; }
			set
			{
				this.OnPropertyValueChange(_.EOMID,_EOMID,value);
				this._EOMID=value;
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
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ExpItemID,
				_.XH,
				_.CCID,
				_.Expname,
				_.ExpContent,
				_.Equpment,
				_.GroupPsNum,
				_.Period,
				_.Oper,
				_.CCname,
				_.expLimit,
				_.ExpSort,
				_.Version,
				_.ApplyTo,
				_.EOMID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ExpItemID,
				this._XH,
				this._CCID,
				this._Expname,
				this._ExpContent,
				this._Equpment,
				this._GroupPsNum,
				this._Period,
				this._Oper,
				this._CCname,
				this._expLimit,
				this._ExpSort,
				this._Version,
				this._ApplyTo,
				this._EOMID};
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
			public readonly static Field All = new Field("*","vw_ExpItem");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExpItemID = new Field("ExpItemID","vw_ExpItem","ExpItemID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field XH = new Field("XH","vw_ExpItem","XH");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_ExpItem","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Expname = new Field("Expname","vw_ExpItem","Expname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExpContent = new Field("ExpContent","vw_ExpItem","ExpContent");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Equpment = new Field("Equpment","vw_ExpItem","Equpment");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GroupPsNum = new Field("GroupPsNum","vw_ExpItem","GroupPsNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Period = new Field("Period","vw_ExpItem","Period");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oper = new Field("Oper","vw_ExpItem","Oper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCname = new Field("CCname","vw_ExpItem","CCname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field expLimit = new Field("expLimit","vw_ExpItem","expLimit");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExpSort = new Field("ExpSort","vw_ExpItem","ExpSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Version = new Field("Version","vw_ExpItem","Version");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ApplyTo = new Field("ApplyTo","vw_ExpItem","ApplyTo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EOMID = new Field("EOMID","vw_ExpItem","EOMID");
		}
		#endregion


	}
}

