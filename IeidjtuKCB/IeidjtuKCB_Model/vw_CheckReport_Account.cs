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
	/// 实体类vw_CheckReport_Account 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_CheckReport_Account")]
	[Serializable]
	public partial class vw_CheckReport_Account : Entity 
	{
		#region Model
		private int? _SPID;
		private string _SPNo;
		private string _SPName;
		private int? _GRID;
		private string _GRName;
		private string _ClassName;
		private string _CCode;
		private string _CCname;
		private int? _CCID;
		private string _Content;
		private int? _Nums;
		private int? _Atyid;
		private string _ATName;
		private string _RGName;
		private int? _RGID;
		private int? _BasicNum;
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
		public string SPNo
		{
			get{ return _SPNo; }
			set
			{
				this.OnPropertyValueChange(_.SPNo,_SPNo,value);
				this._SPNo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SPName
		{
			get{ return _SPName; }
			set
			{
				this.OnPropertyValueChange(_.SPName,_SPName,value);
				this._SPName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GRID
		{
			get{ return _GRID; }
			set
			{
				this.OnPropertyValueChange(_.GRID,_GRID,value);
				this._GRID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GRName
		{
			get{ return _GRName; }
			set
			{
				this.OnPropertyValueChange(_.GRName,_GRName,value);
				this._GRName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClassName
		{
			get{ return _ClassName; }
			set
			{
				this.OnPropertyValueChange(_.ClassName,_ClassName,value);
				this._ClassName=value;
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
		public string Content
		{
			get{ return _Content; }
			set
			{
				this.OnPropertyValueChange(_.Content,_Content,value);
				this._Content=value;
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
		public int? Atyid
		{
			get{ return _Atyid; }
			set
			{
				this.OnPropertyValueChange(_.Atyid,_Atyid,value);
				this._Atyid=value;
			}
		}
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
		public string RGName
		{
			get{ return _RGName; }
			set
			{
				this.OnPropertyValueChange(_.RGName,_RGName,value);
				this._RGName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RGID
		{
			get{ return _RGID; }
			set
			{
				this.OnPropertyValueChange(_.RGID,_RGID,value);
				this._RGID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BasicNum
		{
			get{ return _BasicNum; }
			set
			{
				this.OnPropertyValueChange(_.BasicNum,_BasicNum,value);
				this._BasicNum=value;
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
				_.SPID,
				_.SPNo,
				_.SPName,
				_.GRID,
				_.GRName,
				_.ClassName,
				_.CCode,
				_.CCname,
				_.CCID,
				_.Content,
				_.Nums,
				_.Atyid,
				_.ATName,
				_.RGName,
				_.RGID,
				_.BasicNum};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SPID,
				this._SPNo,
				this._SPName,
				this._GRID,
				this._GRName,
				this._ClassName,
				this._CCode,
				this._CCname,
				this._CCID,
				this._Content,
				this._Nums,
				this._Atyid,
				this._ATName,
				this._RGName,
				this._RGID,
				this._BasicNum};
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
			public readonly static Field All = new Field("*","vw_CheckReport_Account");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_CheckReport_Account","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPNo = new Field("SPNo","vw_CheckReport_Account","SPNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPName = new Field("SPName","vw_CheckReport_Account","SPName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","vw_CheckReport_Account","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRName = new Field("GRName","vw_CheckReport_Account","GRName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassName = new Field("ClassName","vw_CheckReport_Account","ClassName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCode = new Field("CCode","vw_CheckReport_Account","CCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCname = new Field("CCname","vw_CheckReport_Account","CCname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_CheckReport_Account","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","vw_CheckReport_Account","Content");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Nums = new Field("Nums","vw_CheckReport_Account","Nums");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("Atyid","vw_CheckReport_Account","Atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATName = new Field("ATName","vw_CheckReport_Account","ATName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RGName = new Field("RGName","vw_CheckReport_Account","RGName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RGID = new Field("RGID","vw_CheckReport_Account","RGID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BasicNum = new Field("BasicNum","vw_CheckReport_Account","BasicNum");
		}
		#endregion


	}
}

