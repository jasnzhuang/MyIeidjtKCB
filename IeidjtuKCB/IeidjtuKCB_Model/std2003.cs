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
	/// 实体类Std2003 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("std2003")]
	[Serializable]
	public partial class Std2003 : Entity 
	{
		#region Model
		private string _KSH;
		private string _ZKZH;
		private string _Stdname;
		private string _XBDM;
		private string _Spname;
		private string _Deptname;
		private string _Source;
		private string _SERNUM;
		private string _KLMC;
		private string _PCMC;
		private string _Sex;
		private string _Birthday;
		private string _ZZMMDM;
		private string _Polity;
		private string _MZDM;
		private string _Nation;
		private string _KSLBDM;
		private string _KSLBMC;
		private string _BYLBDM;
		private string _ZXDM;
		private string _ComeSchool;
		private string _WYYZDM;
		private string _Language;
		private string _KSTZ;
		private string _XTDW;
		private string _DQDM;
		private string _HomePlace;
		private string _Cardid;
		private string _Address;
		private string _PostCode;
		private string _HomeTel;
		private string _KSLXDM;
		private string _SJR;
		private string _WYTL;
		private string _PCDM;
		private string _KLDM;
		private string _TDZY;
		private string _LQZY;
		private string _Bj;
		private string _Xh;
		private string _Bdbz;
		private string _Wycj;
		private int? _CLassID;
		private int? _SPID;
		private int? _Gradeid;
		private int? _DeptID;
		private string _StdCode;
		/// <summary>
		/// 
		/// </summary>
		public string KSH
		{
			get{ return _KSH; }
			set
			{
				this.OnPropertyValueChange(_.KSH,_KSH,value);
				this._KSH=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZKZH
		{
			get{ return _ZKZH; }
			set
			{
				this.OnPropertyValueChange(_.ZKZH,_ZKZH,value);
				this._ZKZH=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Stdname
		{
			get{ return _Stdname; }
			set
			{
				this.OnPropertyValueChange(_.Stdname,_Stdname,value);
				this._Stdname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XBDM
		{
			get{ return _XBDM; }
			set
			{
				this.OnPropertyValueChange(_.XBDM,_XBDM,value);
				this._XBDM=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Spname
		{
			get{ return _Spname; }
			set
			{
				this.OnPropertyValueChange(_.Spname,_Spname,value);
				this._Spname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Deptname
		{
			get{ return _Deptname; }
			set
			{
				this.OnPropertyValueChange(_.Deptname,_Deptname,value);
				this._Deptname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Source
		{
			get{ return _Source; }
			set
			{
				this.OnPropertyValueChange(_.Source,_Source,value);
				this._Source=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SERNUM
		{
			get{ return _SERNUM; }
			set
			{
				this.OnPropertyValueChange(_.SERNUM,_SERNUM,value);
				this._SERNUM=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KLMC
		{
			get{ return _KLMC; }
			set
			{
				this.OnPropertyValueChange(_.KLMC,_KLMC,value);
				this._KLMC=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PCMC
		{
			get{ return _PCMC; }
			set
			{
				this.OnPropertyValueChange(_.PCMC,_PCMC,value);
				this._PCMC=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sex
		{
			get{ return _Sex; }
			set
			{
				this.OnPropertyValueChange(_.Sex,_Sex,value);
				this._Sex=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Birthday
		{
			get{ return _Birthday; }
			set
			{
				this.OnPropertyValueChange(_.Birthday,_Birthday,value);
				this._Birthday=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZZMMDM
		{
			get{ return _ZZMMDM; }
			set
			{
				this.OnPropertyValueChange(_.ZZMMDM,_ZZMMDM,value);
				this._ZZMMDM=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Polity
		{
			get{ return _Polity; }
			set
			{
				this.OnPropertyValueChange(_.Polity,_Polity,value);
				this._Polity=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MZDM
		{
			get{ return _MZDM; }
			set
			{
				this.OnPropertyValueChange(_.MZDM,_MZDM,value);
				this._MZDM=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Nation
		{
			get{ return _Nation; }
			set
			{
				this.OnPropertyValueChange(_.Nation,_Nation,value);
				this._Nation=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KSLBDM
		{
			get{ return _KSLBDM; }
			set
			{
				this.OnPropertyValueChange(_.KSLBDM,_KSLBDM,value);
				this._KSLBDM=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KSLBMC
		{
			get{ return _KSLBMC; }
			set
			{
				this.OnPropertyValueChange(_.KSLBMC,_KSLBMC,value);
				this._KSLBMC=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BYLBDM
		{
			get{ return _BYLBDM; }
			set
			{
				this.OnPropertyValueChange(_.BYLBDM,_BYLBDM,value);
				this._BYLBDM=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZXDM
		{
			get{ return _ZXDM; }
			set
			{
				this.OnPropertyValueChange(_.ZXDM,_ZXDM,value);
				this._ZXDM=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ComeSchool
		{
			get{ return _ComeSchool; }
			set
			{
				this.OnPropertyValueChange(_.ComeSchool,_ComeSchool,value);
				this._ComeSchool=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WYYZDM
		{
			get{ return _WYYZDM; }
			set
			{
				this.OnPropertyValueChange(_.WYYZDM,_WYYZDM,value);
				this._WYYZDM=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Language
		{
			get{ return _Language; }
			set
			{
				this.OnPropertyValueChange(_.Language,_Language,value);
				this._Language=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KSTZ
		{
			get{ return _KSTZ; }
			set
			{
				this.OnPropertyValueChange(_.KSTZ,_KSTZ,value);
				this._KSTZ=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XTDW
		{
			get{ return _XTDW; }
			set
			{
				this.OnPropertyValueChange(_.XTDW,_XTDW,value);
				this._XTDW=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DQDM
		{
			get{ return _DQDM; }
			set
			{
				this.OnPropertyValueChange(_.DQDM,_DQDM,value);
				this._DQDM=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HomePlace
		{
			get{ return _HomePlace; }
			set
			{
				this.OnPropertyValueChange(_.HomePlace,_HomePlace,value);
				this._HomePlace=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Cardid
		{
			get{ return _Cardid; }
			set
			{
				this.OnPropertyValueChange(_.Cardid,_Cardid,value);
				this._Cardid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			get{ return _Address; }
			set
			{
				this.OnPropertyValueChange(_.Address,_Address,value);
				this._Address=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PostCode
		{
			get{ return _PostCode; }
			set
			{
				this.OnPropertyValueChange(_.PostCode,_PostCode,value);
				this._PostCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HomeTel
		{
			get{ return _HomeTel; }
			set
			{
				this.OnPropertyValueChange(_.HomeTel,_HomeTel,value);
				this._HomeTel=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KSLXDM
		{
			get{ return _KSLXDM; }
			set
			{
				this.OnPropertyValueChange(_.KSLXDM,_KSLXDM,value);
				this._KSLXDM=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SJR
		{
			get{ return _SJR; }
			set
			{
				this.OnPropertyValueChange(_.SJR,_SJR,value);
				this._SJR=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WYTL
		{
			get{ return _WYTL; }
			set
			{
				this.OnPropertyValueChange(_.WYTL,_WYTL,value);
				this._WYTL=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PCDM
		{
			get{ return _PCDM; }
			set
			{
				this.OnPropertyValueChange(_.PCDM,_PCDM,value);
				this._PCDM=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KLDM
		{
			get{ return _KLDM; }
			set
			{
				this.OnPropertyValueChange(_.KLDM,_KLDM,value);
				this._KLDM=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TDZY
		{
			get{ return _TDZY; }
			set
			{
				this.OnPropertyValueChange(_.TDZY,_TDZY,value);
				this._TDZY=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LQZY
		{
			get{ return _LQZY; }
			set
			{
				this.OnPropertyValueChange(_.LQZY,_LQZY,value);
				this._LQZY=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Bj
		{
			get{ return _Bj; }
			set
			{
				this.OnPropertyValueChange(_.Bj,_Bj,value);
				this._Bj=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Xh
		{
			get{ return _Xh; }
			set
			{
				this.OnPropertyValueChange(_.Xh,_Xh,value);
				this._Xh=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Bdbz
		{
			get{ return _Bdbz; }
			set
			{
				this.OnPropertyValueChange(_.Bdbz,_Bdbz,value);
				this._Bdbz=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Wycj
		{
			get{ return _Wycj; }
			set
			{
				this.OnPropertyValueChange(_.Wycj,_Wycj,value);
				this._Wycj=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CLassID
		{
			get{ return _CLassID; }
			set
			{
				this.OnPropertyValueChange(_.CLassID,_CLassID,value);
				this._CLassID=value;
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
		public int? Gradeid
		{
			get{ return _Gradeid; }
			set
			{
				this.OnPropertyValueChange(_.Gradeid,_Gradeid,value);
				this._Gradeid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DeptID
		{
			get{ return _DeptID; }
			set
			{
				this.OnPropertyValueChange(_.DeptID,_DeptID,value);
				this._DeptID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StdCode
		{
			get{ return _StdCode; }
			set
			{
				this.OnPropertyValueChange(_.StdCode,_StdCode,value);
				this._StdCode=value;
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
				_.KSH,
				_.ZKZH,
				_.Stdname,
				_.XBDM,
				_.Spname,
				_.Deptname,
				_.Source,
				_.SERNUM,
				_.KLMC,
				_.PCMC,
				_.Sex,
				_.Birthday,
				_.ZZMMDM,
				_.Polity,
				_.MZDM,
				_.Nation,
				_.KSLBDM,
				_.KSLBMC,
				_.BYLBDM,
				_.ZXDM,
				_.ComeSchool,
				_.WYYZDM,
				_.Language,
				_.KSTZ,
				_.XTDW,
				_.DQDM,
				_.HomePlace,
				_.Cardid,
				_.Address,
				_.PostCode,
				_.HomeTel,
				_.KSLXDM,
				_.SJR,
				_.WYTL,
				_.PCDM,
				_.KLDM,
				_.TDZY,
				_.LQZY,
				_.Bj,
				_.Xh,
				_.Bdbz,
				_.Wycj,
				_.CLassID,
				_.SPID,
				_.Gradeid,
				_.DeptID,
				_.StdCode};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._KSH,
				this._ZKZH,
				this._Stdname,
				this._XBDM,
				this._Spname,
				this._Deptname,
				this._Source,
				this._SERNUM,
				this._KLMC,
				this._PCMC,
				this._Sex,
				this._Birthday,
				this._ZZMMDM,
				this._Polity,
				this._MZDM,
				this._Nation,
				this._KSLBDM,
				this._KSLBMC,
				this._BYLBDM,
				this._ZXDM,
				this._ComeSchool,
				this._WYYZDM,
				this._Language,
				this._KSTZ,
				this._XTDW,
				this._DQDM,
				this._HomePlace,
				this._Cardid,
				this._Address,
				this._PostCode,
				this._HomeTel,
				this._KSLXDM,
				this._SJR,
				this._WYTL,
				this._PCDM,
				this._KLDM,
				this._TDZY,
				this._LQZY,
				this._Bj,
				this._Xh,
				this._Bdbz,
				this._Wycj,
				this._CLassID,
				this._SPID,
				this._Gradeid,
				this._DeptID,
				this._StdCode};
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
			public readonly static Field All = new Field("*","std2003");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KSH = new Field("KSH","std2003","KSH");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ZKZH = new Field("ZKZH","std2003","ZKZH");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdname = new Field("stdname","std2003","stdname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field XBDM = new Field("XBDM","std2003","XBDM");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Spname = new Field("spname","std2003","spname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Deptname = new Field("deptname","std2003","deptname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Source = new Field("Source","std2003","Source");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SERNUM = new Field("SERNUM","std2003","SERNUM");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KLMC = new Field("KLMC","std2003","KLMC");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PCMC = new Field("PCMC","std2003","PCMC");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sex = new Field("Sex","std2003","Sex");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Birthday = new Field("Birthday","std2003","Birthday");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ZZMMDM = new Field("ZZMMDM","std2003","ZZMMDM");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Polity = new Field("Polity","std2003","Polity");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MZDM = new Field("MZDM","std2003","MZDM");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Nation = new Field("Nation","std2003","Nation");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KSLBDM = new Field("KSLBDM","std2003","KSLBDM");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KSLBMC = new Field("KSLBMC","std2003","KSLBMC");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BYLBDM = new Field("BYLBDM","std2003","BYLBDM");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ZXDM = new Field("ZXDM","std2003","ZXDM");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ComeSchool = new Field("ComeSchool","std2003","ComeSchool");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field WYYZDM = new Field("WYYZDM","std2003","WYYZDM");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Language = new Field("Language","std2003","Language");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KSTZ = new Field("KSTZ","std2003","KSTZ");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field XTDW = new Field("XTDW","std2003","XTDW");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DQDM = new Field("DQDM","std2003","DQDM");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HomePlace = new Field("HomePlace","std2003","HomePlace");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Cardid = new Field("Cardid","std2003","Cardid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Address = new Field("Address","std2003","Address");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PostCode = new Field("PostCode","std2003","PostCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HomeTel = new Field("HomeTel","std2003","HomeTel");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KSLXDM = new Field("KSLXDM","std2003","KSLXDM");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SJR = new Field("SJR","std2003","SJR");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field WYTL = new Field("WYTL","std2003","WYTL");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PCDM = new Field("PCDM","std2003","PCDM");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KLDM = new Field("KLDM","std2003","KLDM");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TDZY = new Field("TDZY","std2003","TDZY");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LQZY = new Field("LQZY","std2003","LQZY");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Bj = new Field("bj","std2003","bj");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Xh = new Field("xh","std2003","xh");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Bdbz = new Field("bdbz","std2003","bdbz");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Wycj = new Field("wycj","std2003","wycj");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLassID = new Field("CLassID","std2003","CLassID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","std2003","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Gradeid = new Field("Gradeid","std2003","Gradeid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptID = new Field("DeptID","std2003","DeptID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdCode = new Field("StdCode","std2003","StdCode");
		}
		#endregion


	}
}

