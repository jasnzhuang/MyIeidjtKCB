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
	/// 实体类vw_chargesetting 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_chargesetting")]
	[Serializable]
	public partial class vw_chargesetting : Entity 
	{
		#region Model
		private string _GRName;
		private int _CHSID;
		private int? _GRDID;
		private string _RefaceNum;
		private string _SchoolingNum;
		private string _Edusys;
		private string _GRNo;
		private string _State;
		private string _Gxkstate;
		private int? _SPID;
		private string _SPName;
		private string _SPCode;
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
		public int CHSID
		{
			get{ return _CHSID; }
			set
			{
				this.OnPropertyValueChange(_.CHSID,_CHSID,value);
				this._CHSID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GRDID
		{
			get{ return _GRDID; }
			set
			{
				this.OnPropertyValueChange(_.GRDID,_GRDID,value);
				this._GRDID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RefaceNum
		{
			get{ return _RefaceNum; }
			set
			{
				this.OnPropertyValueChange(_.RefaceNum,_RefaceNum,value);
				this._RefaceNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SchoolingNum
		{
			get{ return _SchoolingNum; }
			set
			{
				this.OnPropertyValueChange(_.SchoolingNum,_SchoolingNum,value);
				this._SchoolingNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Edusys
		{
			get{ return _Edusys; }
			set
			{
				this.OnPropertyValueChange(_.Edusys,_Edusys,value);
				this._Edusys=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GRNo
		{
			get{ return _GRNo; }
			set
			{
				this.OnPropertyValueChange(_.GRNo,_GRNo,value);
				this._GRNo=value;
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
		public string Gxkstate
		{
			get{ return _Gxkstate; }
			set
			{
				this.OnPropertyValueChange(_.Gxkstate,_Gxkstate,value);
				this._Gxkstate=value;
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
		public string SPCode
		{
			get{ return _SPCode; }
			set
			{
				this.OnPropertyValueChange(_.SPCode,_SPCode,value);
				this._SPCode=value;
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
				_.GRName,
				_.CHSID,
				_.GRDID,
				_.RefaceNum,
				_.SchoolingNum,
				_.Edusys,
				_.GRNo,
				_.State,
				_.Gxkstate,
				_.SPID,
				_.SPName,
				_.SPCode};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._GRName,
				this._CHSID,
				this._GRDID,
				this._RefaceNum,
				this._SchoolingNum,
				this._Edusys,
				this._GRNo,
				this._State,
				this._Gxkstate,
				this._SPID,
				this._SPName,
				this._SPCode};
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
			public readonly static Field All = new Field("*","vw_chargesetting");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRName = new Field("GRName","vw_chargesetting","GRName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CHSID = new Field("CHSID","vw_chargesetting","CHSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRDID = new Field("GRDID","vw_chargesetting","GRDID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RefaceNum = new Field("RefaceNum","vw_chargesetting","RefaceNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SchoolingNum = new Field("SchoolingNum","vw_chargesetting","SchoolingNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Edusys = new Field("Edusys","vw_chargesetting","Edusys");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRNo = new Field("GRNo","vw_chargesetting","GRNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","vw_chargesetting","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Gxkstate = new Field("Gxkstate","vw_chargesetting","Gxkstate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_chargesetting","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPName = new Field("SPName","vw_chargesetting","SPName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPCode = new Field("SPCode","vw_chargesetting","SPCode");
		}
		#endregion


	}
}

