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
	/// 实体类vw_ExpitemList 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_ExpitemList")]
	[Serializable]
	public partial class vw_ExpitemList : Entity 
	{
		#region Model
		private int _ExpItemID;
		private int? _CCID;
		private int? _XH;
		private string _Expname;
		private string _ExpContent;
		private int? _EGNID;
		private string _Equpment;
		private int? _GroupPsNum;
		private int? _Period;
		private string _Oper;
		private string _expLimit;
		private string _ExpSort;
		private string _CCode;
		private string _CCname;
		private string _EGroupName;
		private int? _Nums;
		private int? _Deptid;
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
		public int? EGNID
		{
			get{ return _EGNID; }
			set
			{
				this.OnPropertyValueChange(_.EGNID,_EGNID,value);
				this._EGNID=value;
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
		public string CCode
		{
			get{ return _CCode; }
			set
			{
				this.OnPropertyValueChange(_.CCode,_CCode,value);
				this._CCode=value;
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
		public string EGroupName
		{
			get{ return _EGroupName; }
			set
			{
				this.OnPropertyValueChange(_.EGroupName,_EGroupName,value);
				this._EGroupName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Nums
		{
			get{ return _Nums; }
			set
			{
				this.OnPropertyValueChange(_.Nums,_Nums,value);
				this._Nums=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Deptid
		{
			get{ return _Deptid; }
			set
			{
				this.OnPropertyValueChange(_.Deptid,_Deptid,value);
				this._Deptid=value;
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
				_.CCID,
				_.XH,
				_.Expname,
				_.ExpContent,
				_.EGNID,
				_.Equpment,
				_.GroupPsNum,
				_.Period,
				_.Oper,
				_.expLimit,
				_.ExpSort,
				_.CCode,
				_.CCname,
				_.EGroupName,
				_.Nums,
				_.Deptid};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ExpItemID,
				this._CCID,
				this._XH,
				this._Expname,
				this._ExpContent,
				this._EGNID,
				this._Equpment,
				this._GroupPsNum,
				this._Period,
				this._Oper,
				this._expLimit,
				this._ExpSort,
				this._CCode,
				this._CCname,
				this._EGroupName,
				this._Nums,
				this._Deptid};
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
			public readonly static Field All = new Field("*","vw_ExpitemList");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExpItemID = new Field("ExpItemID","vw_ExpitemList","ExpItemID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_ExpitemList","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field XH = new Field("XH","vw_ExpitemList","XH");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Expname = new Field("Expname","vw_ExpitemList","Expname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExpContent = new Field("ExpContent","vw_ExpitemList","ExpContent");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EGNID = new Field("EGNID","vw_ExpitemList","EGNID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Equpment = new Field("Equpment","vw_ExpitemList","Equpment");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GroupPsNum = new Field("GroupPsNum","vw_ExpitemList","GroupPsNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Period = new Field("Period","vw_ExpitemList","Period");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oper = new Field("Oper","vw_ExpitemList","Oper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field expLimit = new Field("expLimit","vw_ExpitemList","expLimit");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExpSort = new Field("ExpSort","vw_ExpitemList","ExpSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCode = new Field("CCode","vw_ExpitemList","CCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCname = new Field("CCname","vw_ExpitemList","CCname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EGroupName = new Field("EGroupName","vw_ExpitemList","EGroupName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Nums = new Field("Nums","vw_ExpitemList","Nums");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Deptid = new Field("Deptid","vw_ExpitemList","Deptid");
		}
		#endregion


	}
}

