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
	/// 实体类vw_ExamineSignup 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_ExamineSignup")]
	[Serializable]
	public partial class vw_ExamineSignup : Entity 
	{
		#region Model
		private int _ESID;
		private int? _EMID;
		private int? _StdID;
		private DateTime? _Signdate;
		private string _state;
		private string _EMName;
		private string _Estate;
		private string _姓名;
		private string _年级;
		private string _校区;
		private string _学院;
		private string _系别;
		private string _专业;
		private string _学制;
		private string _入学年份;
		private string _准考证号;
		private string _考场号;
		private string _流水号;
		private string _成绩;
		private string _身份证号;
		private string _备注;
		private string _Stdcode;
		private int? _DeptID;
		private int? _GradeID;
		private int? _CLassID;
		private int? _SPID;
		private string _DeptCode;
		private int? _EMRID;
		private string _性别;
		private int? _Lev;
		private int? _Atyid;
		private string _ExamDate;
		private string _BuildName;
		private string _CRname;
		private string _MarkName;
		private string _SchoolNo;
		private string _RGName;
		private string _CLName;
		private string _Content;
		private string _CheckMarkA;
		/// <summary>
		/// 
		/// </summary>
		public int ESID
		{
			get{ return _ESID; }
			set
			{
				this.OnPropertyValueChange(_.ESID,_ESID,value);
				this._ESID=value;
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
		public DateTime? Signdate
		{
			get{ return _Signdate; }
			set
			{
				this.OnPropertyValueChange(_.Signdate,_Signdate,value);
				this._Signdate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string state
		{
			get{ return _state; }
			set
			{
				this.OnPropertyValueChange(_.state,_state,value);
				this._state=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMName
		{
			get{ return _EMName; }
			set
			{
				this.OnPropertyValueChange(_.EMName,_EMName,value);
				this._EMName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Estate
		{
			get{ return _Estate; }
			set
			{
				this.OnPropertyValueChange(_.Estate,_Estate,value);
				this._Estate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 姓名
		{
			get{ return _姓名; }
			set
			{
				this.OnPropertyValueChange(_.姓名,_姓名,value);
				this._姓名=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 年级
		{
			get{ return _年级; }
			set
			{
				this.OnPropertyValueChange(_.年级,_年级,value);
				this._年级=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 校区
		{
			get{ return _校区; }
			set
			{
				this.OnPropertyValueChange(_.校区,_校区,value);
				this._校区=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 学院
		{
			get{ return _学院; }
			set
			{
				this.OnPropertyValueChange(_.学院,_学院,value);
				this._学院=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 系别
		{
			get{ return _系别; }
			set
			{
				this.OnPropertyValueChange(_.系别,_系别,value);
				this._系别=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 专业
		{
			get{ return _专业; }
			set
			{
				this.OnPropertyValueChange(_.专业,_专业,value);
				this._专业=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 学制
		{
			get{ return _学制; }
			set
			{
				this.OnPropertyValueChange(_.学制,_学制,value);
				this._学制=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 入学年份
		{
			get{ return _入学年份; }
			set
			{
				this.OnPropertyValueChange(_.入学年份,_入学年份,value);
				this._入学年份=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 准考证号
		{
			get{ return _准考证号; }
			set
			{
				this.OnPropertyValueChange(_.准考证号,_准考证号,value);
				this._准考证号=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 考场号
		{
			get{ return _考场号; }
			set
			{
				this.OnPropertyValueChange(_.考场号,_考场号,value);
				this._考场号=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 流水号
		{
			get{ return _流水号; }
			set
			{
				this.OnPropertyValueChange(_.流水号,_流水号,value);
				this._流水号=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 成绩
		{
			get{ return _成绩; }
			set
			{
				this.OnPropertyValueChange(_.成绩,_成绩,value);
				this._成绩=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 身份证号
		{
			get{ return _身份证号; }
			set
			{
				this.OnPropertyValueChange(_.身份证号,_身份证号,value);
				this._身份证号=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 备注
		{
			get{ return _备注; }
			set
			{
				this.OnPropertyValueChange(_.备注,_备注,value);
				this._备注=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Stdcode
		{
			get{ return _Stdcode; }
			set
			{
				this.OnPropertyValueChange(_.Stdcode,_Stdcode,value);
				this._Stdcode=value;
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
		public int? GradeID
		{
			get{ return _GradeID; }
			set
			{
				this.OnPropertyValueChange(_.GradeID,_GradeID,value);
				this._GradeID=value;
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
		public string DeptCode
		{
			get{ return _DeptCode; }
			set
			{
				this.OnPropertyValueChange(_.DeptCode,_DeptCode,value);
				this._DeptCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EMRID
		{
			get{ return _EMRID; }
			set
			{
				this.OnPropertyValueChange(_.EMRID,_EMRID,value);
				this._EMRID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 性别
		{
			get{ return _性别; }
			set
			{
				this.OnPropertyValueChange(_.性别,_性别,value);
				this._性别=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Lev
		{
			get{ return _Lev; }
			set
			{
				this.OnPropertyValueChange(_.Lev,_Lev,value);
				this._Lev=value;
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
		public string ExamDate
		{
			get{ return _ExamDate; }
			set
			{
				this.OnPropertyValueChange(_.ExamDate,_ExamDate,value);
				this._ExamDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BuildName
		{
			get{ return _BuildName; }
			set
			{
				this.OnPropertyValueChange(_.BuildName,_BuildName,value);
				this._BuildName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CRname
		{
			get{ return _CRname; }
			set
			{
				this.OnPropertyValueChange(_.CRname,_CRname,value);
				this._CRname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MarkName
		{
			get{ return _MarkName; }
			set
			{
				this.OnPropertyValueChange(_.MarkName,_MarkName,value);
				this._MarkName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SchoolNo
		{
			get{ return _SchoolNo; }
			set
			{
				this.OnPropertyValueChange(_.SchoolNo,_SchoolNo,value);
				this._SchoolNo=value;
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
		public string CLName
		{
			get{ return _CLName; }
			set
			{
				this.OnPropertyValueChange(_.CLName,_CLName,value);
				this._CLName=value;
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
		public string CheckMarkA
		{
			get{ return _CheckMarkA; }
			set
			{
				this.OnPropertyValueChange(_.CheckMarkA,_CheckMarkA,value);
				this._CheckMarkA=value;
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
				_.ESID,
				_.EMID,
				_.StdID,
				_.Signdate,
				_.state,
				_.EMName,
				_.Estate,
				_.姓名,
				_.年级,
				_.校区,
				_.学院,
				_.系别,
				_.专业,
				_.学制,
				_.入学年份,
				_.准考证号,
				_.考场号,
				_.流水号,
				_.成绩,
				_.身份证号,
				_.备注,
				_.Stdcode,
				_.DeptID,
				_.GradeID,
				_.CLassID,
				_.SPID,
				_.DeptCode,
				_.EMRID,
				_.性别,
				_.Lev,
				_.Atyid,
				_.ExamDate,
				_.BuildName,
				_.CRname,
				_.MarkName,
				_.SchoolNo,
				_.RGName,
				_.CLName,
				_.Content,
				_.CheckMarkA};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ESID,
				this._EMID,
				this._StdID,
				this._Signdate,
				this._state,
				this._EMName,
				this._Estate,
				this._姓名,
				this._年级,
				this._校区,
				this._学院,
				this._系别,
				this._专业,
				this._学制,
				this._入学年份,
				this._准考证号,
				this._考场号,
				this._流水号,
				this._成绩,
				this._身份证号,
				this._备注,
				this._Stdcode,
				this._DeptID,
				this._GradeID,
				this._CLassID,
				this._SPID,
				this._DeptCode,
				this._EMRID,
				this._性别,
				this._Lev,
				this._Atyid,
				this._ExamDate,
				this._BuildName,
				this._CRname,
				this._MarkName,
				this._SchoolNo,
				this._RGName,
				this._CLName,
				this._Content,
				this._CheckMarkA};
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
			public readonly static Field All = new Field("*","vw_ExamineSignup");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ESID = new Field("ESID","vw_ExamineSignup","ESID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMID = new Field("EMID","vw_ExamineSignup","EMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdID = new Field("StdID","vw_ExamineSignup","StdID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Signdate = new Field("Signdate","vw_ExamineSignup","Signdate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field state = new Field("state","vw_ExamineSignup","state");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMName = new Field("EMName","vw_ExamineSignup","EMName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Estate = new Field("Estate","vw_ExamineSignup","Estate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 姓名 = new Field("姓名","vw_ExamineSignup","姓名");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 年级 = new Field("年级","vw_ExamineSignup","年级");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 校区 = new Field("校区","vw_ExamineSignup","校区");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学院 = new Field("学院","vw_ExamineSignup","学院");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 系别 = new Field("系别","vw_ExamineSignup","系别");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 专业 = new Field("专业","vw_ExamineSignup","专业");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学制 = new Field("学制","vw_ExamineSignup","学制");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 入学年份 = new Field("入学年份","vw_ExamineSignup","入学年份");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 准考证号 = new Field("准考证号","vw_ExamineSignup","准考证号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 考场号 = new Field("考场号","vw_ExamineSignup","考场号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 流水号 = new Field("流水号","vw_ExamineSignup","流水号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 成绩 = new Field("成绩","vw_ExamineSignup","成绩");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 身份证号 = new Field("身份证号","vw_ExamineSignup","身份证号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 备注 = new Field("备注","vw_ExamineSignup","备注");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdcode = new Field("Stdcode","vw_ExamineSignup","Stdcode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptID = new Field("DeptID","vw_ExamineSignup","DeptID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GradeID = new Field("GradeID","vw_ExamineSignup","GradeID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLassID = new Field("CLassID","vw_ExamineSignup","CLassID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_ExamineSignup","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCode = new Field("DeptCode","vw_ExamineSignup","DeptCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMRID = new Field("EMRID","vw_ExamineSignup","EMRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 性别 = new Field("性别","vw_ExamineSignup","性别");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Lev = new Field("Lev","vw_ExamineSignup","Lev");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("Atyid","vw_ExamineSignup","Atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExamDate = new Field("ExamDate","vw_ExamineSignup","ExamDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BuildName = new Field("BuildName","vw_ExamineSignup","BuildName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CRname = new Field("CRname","vw_ExamineSignup","CRname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MarkName = new Field("MarkName","vw_ExamineSignup","MarkName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SchoolNo = new Field("SchoolNo","vw_ExamineSignup","SchoolNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RGName = new Field("RGName","vw_ExamineSignup","RGName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLName = new Field("CLName","vw_ExamineSignup","CLName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","vw_ExamineSignup","Content");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CheckMarkA = new Field("CheckMarkA","vw_ExamineSignup","CheckMarkA");
		}
		#endregion


	}
}

