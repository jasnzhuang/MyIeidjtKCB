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
	/// 实体类vw_EduPlanA 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_EduPlanA")]
	[Serializable]
	public partial class vw_EduPlanA : Entity 
	{
		#region Model
		private string _课程名称;
		private string _课程代码;
		private string _专业名称;
		private string _课程要求;
		private decimal? _学分;
		private decimal? _总学时;
		private int? _讲课学时;
		private int? _实验学时;
		private int? _上机学时;
		private string _考试类型;
		private int? _开课学期;
		private int? _开始周次;
		private int? _结束周次;
		private int? _周学时数;
		private int _EPID;
		private string _主干课;
		private int _SPID;
		private int _GRDID;
		private int _CCID;
		private string _学期名称;
		private string _学期;
		private int? _ATYID;
		private string _GRNo;
		private string _年级;
		private string _Sort;
		private string _CCnameEng;
		private string _Memo;
		private int? _EMID;
		private string _StartB;
		private string _EndB;
		private string _PerWB;
		private string _Direct;
		private string _学习方式;
		private string _课程类别;
		private string _CSortCode;
		private decimal? _Other;
		private string _Cunit;
		private string _CSort;
		private string _SPNo;
		private int? _StuNum;
		private string _Deptcode;
		private int? _组班人数;
		private string _RsGroup;
		private string _IFPK;
		private string _ifCheck;
		private string _ifCheckBY;
		private int? _ToDeptID;
		private string _ToDeptCode;
		private string _ToDeptname;
		private int? _ToDeptIDB;
		private string _ToDeptnameB;
		private string _ToDeptCodeB;
		private int? _HaveDG;
		private string _GRstate;
		private int? _EGID;
		private int? _EGSequ;
		private string _BX;
		private string _Tohigh;
		private string _CSA;
		private DateTime? _Lastdate;
		/// <summary>
		/// 
		/// </summary>
		public string 课程名称
		{
			get{ return _课程名称; }
			set
			{
				this.OnPropertyValueChange(_.课程名称,_课程名称,value);
				this._课程名称=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 课程代码
		{
			get{ return _课程代码; }
			set
			{
				this.OnPropertyValueChange(_.课程代码,_课程代码,value);
				this._课程代码=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 专业名称
		{
			get{ return _专业名称; }
			set
			{
				this.OnPropertyValueChange(_.专业名称,_专业名称,value);
				this._专业名称=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 课程要求
		{
			get{ return _课程要求; }
			set
			{
				this.OnPropertyValueChange(_.课程要求,_课程要求,value);
				this._课程要求=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 学分
		{
			get{ return _学分; }
			set
			{
				this.OnPropertyValueChange(_.学分,_学分,value);
				this._学分=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 总学时
		{
			get{ return _总学时; }
			set
			{
				this.OnPropertyValueChange(_.总学时,_总学时,value);
				this._总学时=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 讲课学时
		{
			get{ return _讲课学时; }
			set
			{
				this.OnPropertyValueChange(_.讲课学时,_讲课学时,value);
				this._讲课学时=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 实验学时
		{
			get{ return _实验学时; }
			set
			{
				this.OnPropertyValueChange(_.实验学时,_实验学时,value);
				this._实验学时=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 上机学时
		{
			get{ return _上机学时; }
			set
			{
				this.OnPropertyValueChange(_.上机学时,_上机学时,value);
				this._上机学时=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 考试类型
		{
			get{ return _考试类型; }
			set
			{
				this.OnPropertyValueChange(_.考试类型,_考试类型,value);
				this._考试类型=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 开课学期
		{
			get{ return _开课学期; }
			set
			{
				this.OnPropertyValueChange(_.开课学期,_开课学期,value);
				this._开课学期=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 开始周次
		{
			get{ return _开始周次; }
			set
			{
				this.OnPropertyValueChange(_.开始周次,_开始周次,value);
				this._开始周次=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 结束周次
		{
			get{ return _结束周次; }
			set
			{
				this.OnPropertyValueChange(_.结束周次,_结束周次,value);
				this._结束周次=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 周学时数
		{
			get{ return _周学时数; }
			set
			{
				this.OnPropertyValueChange(_.周学时数,_周学时数,value);
				this._周学时数=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int EPID
		{
			get{ return _EPID; }
			set
			{
				this.OnPropertyValueChange(_.EPID,_EPID,value);
				this._EPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 主干课
		{
			get{ return _主干课; }
			set
			{
				this.OnPropertyValueChange(_.主干课,_主干课,value);
				this._主干课=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SPID
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
		public int GRDID
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
		public string 学期名称
		{
			get{ return _学期名称; }
			set
			{
				this.OnPropertyValueChange(_.学期名称,_学期名称,value);
				this._学期名称=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 学期
		{
			get{ return _学期; }
			set
			{
				this.OnPropertyValueChange(_.学期,_学期,value);
				this._学期=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ATYID
		{
			get{ return _ATYID; }
			set
			{
				this.OnPropertyValueChange(_.ATYID,_ATYID,value);
				this._ATYID=value;
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
		public string Sort
		{
			get{ return _Sort; }
			set
			{
				this.OnPropertyValueChange(_.Sort,_Sort,value);
				this._Sort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CCnameEng
		{
			get{ return _CCnameEng; }
			set
			{
				this.OnPropertyValueChange(_.CCnameEng,_CCnameEng,value);
				this._CCnameEng=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Memo
		{
			get{ return _Memo; }
			set
			{
				this.OnPropertyValueChange(_.Memo,_Memo,value);
				this._Memo=value;
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
		public string StartB
		{
			get{ return _StartB; }
			set
			{
				this.OnPropertyValueChange(_.StartB,_StartB,value);
				this._StartB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EndB
		{
			get{ return _EndB; }
			set
			{
				this.OnPropertyValueChange(_.EndB,_EndB,value);
				this._EndB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PerWB
		{
			get{ return _PerWB; }
			set
			{
				this.OnPropertyValueChange(_.PerWB,_PerWB,value);
				this._PerWB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Direct
		{
			get{ return _Direct; }
			set
			{
				this.OnPropertyValueChange(_.Direct,_Direct,value);
				this._Direct=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 学习方式
		{
			get{ return _学习方式; }
			set
			{
				this.OnPropertyValueChange(_.学习方式,_学习方式,value);
				this._学习方式=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 课程类别
		{
			get{ return _课程类别; }
			set
			{
				this.OnPropertyValueChange(_.课程类别,_课程类别,value);
				this._课程类别=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CSortCode
		{
			get{ return _CSortCode; }
			set
			{
				this.OnPropertyValueChange(_.CSortCode,_CSortCode,value);
				this._CSortCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Other
		{
			get{ return _Other; }
			set
			{
				this.OnPropertyValueChange(_.Other,_Other,value);
				this._Other=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Cunit
		{
			get{ return _Cunit; }
			set
			{
				this.OnPropertyValueChange(_.Cunit,_Cunit,value);
				this._Cunit=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CSort
		{
			get{ return _CSort; }
			set
			{
				this.OnPropertyValueChange(_.CSort,_CSort,value);
				this._CSort=value;
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
		public int? StuNum
		{
			get{ return _StuNum; }
			set
			{
				this.OnPropertyValueChange(_.StuNum,_StuNum,value);
				this._StuNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Deptcode
		{
			get{ return _Deptcode; }
			set
			{
				this.OnPropertyValueChange(_.Deptcode,_Deptcode,value);
				this._Deptcode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 组班人数
		{
			get{ return _组班人数; }
			set
			{
				this.OnPropertyValueChange(_.组班人数,_组班人数,value);
				this._组班人数=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RsGroup
		{
			get{ return _RsGroup; }
			set
			{
				this.OnPropertyValueChange(_.RsGroup,_RsGroup,value);
				this._RsGroup=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IFPK
		{
			get{ return _IFPK; }
			set
			{
				this.OnPropertyValueChange(_.IFPK,_IFPK,value);
				this._IFPK=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ifCheck
		{
			get{ return _ifCheck; }
			set
			{
				this.OnPropertyValueChange(_.ifCheck,_ifCheck,value);
				this._ifCheck=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ifCheckBY
		{
			get{ return _ifCheckBY; }
			set
			{
				this.OnPropertyValueChange(_.ifCheckBY,_ifCheckBY,value);
				this._ifCheckBY=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ToDeptID
		{
			get{ return _ToDeptID; }
			set
			{
				this.OnPropertyValueChange(_.ToDeptID,_ToDeptID,value);
				this._ToDeptID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ToDeptCode
		{
			get{ return _ToDeptCode; }
			set
			{
				this.OnPropertyValueChange(_.ToDeptCode,_ToDeptCode,value);
				this._ToDeptCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ToDeptname
		{
			get{ return _ToDeptname; }
			set
			{
				this.OnPropertyValueChange(_.ToDeptname,_ToDeptname,value);
				this._ToDeptname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ToDeptIDB
		{
			get{ return _ToDeptIDB; }
			set
			{
				this.OnPropertyValueChange(_.ToDeptIDB,_ToDeptIDB,value);
				this._ToDeptIDB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ToDeptnameB
		{
			get{ return _ToDeptnameB; }
			set
			{
				this.OnPropertyValueChange(_.ToDeptnameB,_ToDeptnameB,value);
				this._ToDeptnameB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ToDeptCodeB
		{
			get{ return _ToDeptCodeB; }
			set
			{
				this.OnPropertyValueChange(_.ToDeptCodeB,_ToDeptCodeB,value);
				this._ToDeptCodeB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? HaveDG
		{
			get{ return _HaveDG; }
			set
			{
				this.OnPropertyValueChange(_.HaveDG,_HaveDG,value);
				this._HaveDG=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GRstate
		{
			get{ return _GRstate; }
			set
			{
				this.OnPropertyValueChange(_.GRstate,_GRstate,value);
				this._GRstate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EGID
		{
			get{ return _EGID; }
			set
			{
				this.OnPropertyValueChange(_.EGID,_EGID,value);
				this._EGID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EGSequ
		{
			get{ return _EGSequ; }
			set
			{
				this.OnPropertyValueChange(_.EGSequ,_EGSequ,value);
				this._EGSequ=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BX
		{
			get{ return _BX; }
			set
			{
				this.OnPropertyValueChange(_.BX,_BX,value);
				this._BX=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Tohigh
		{
			get{ return _Tohigh; }
			set
			{
				this.OnPropertyValueChange(_.Tohigh,_Tohigh,value);
				this._Tohigh=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CSA
		{
			get{ return _CSA; }
			set
			{
				this.OnPropertyValueChange(_.CSA,_CSA,value);
				this._CSA=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Lastdate
		{
			get{ return _Lastdate; }
			set
			{
				this.OnPropertyValueChange(_.Lastdate,_Lastdate,value);
				this._Lastdate=value;
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
				_.课程名称,
				_.课程代码,
				_.专业名称,
				_.课程要求,
				_.学分,
				_.总学时,
				_.讲课学时,
				_.实验学时,
				_.上机学时,
				_.考试类型,
				_.开课学期,
				_.开始周次,
				_.结束周次,
				_.周学时数,
				_.EPID,
				_.主干课,
				_.SPID,
				_.GRDID,
				_.CCID,
				_.学期名称,
				_.学期,
				_.ATYID,
				_.GRNo,
				_.年级,
				_.Sort,
				_.CCnameEng,
				_.Memo,
				_.EMID,
				_.StartB,
				_.EndB,
				_.PerWB,
				_.Direct,
				_.学习方式,
				_.课程类别,
				_.CSortCode,
				_.Other,
				_.Cunit,
				_.CSort,
				_.SPNo,
				_.StuNum,
				_.Deptcode,
				_.组班人数,
				_.RsGroup,
				_.IFPK,
				_.ifCheck,
				_.ifCheckBY,
				_.ToDeptID,
				_.ToDeptCode,
				_.ToDeptname,
				_.ToDeptIDB,
				_.ToDeptnameB,
				_.ToDeptCodeB,
				_.HaveDG,
				_.GRstate,
				_.EGID,
				_.EGSequ,
				_.BX,
				_.Tohigh,
				_.CSA,
				_.Lastdate};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._课程名称,
				this._课程代码,
				this._专业名称,
				this._课程要求,
				this._学分,
				this._总学时,
				this._讲课学时,
				this._实验学时,
				this._上机学时,
				this._考试类型,
				this._开课学期,
				this._开始周次,
				this._结束周次,
				this._周学时数,
				this._EPID,
				this._主干课,
				this._SPID,
				this._GRDID,
				this._CCID,
				this._学期名称,
				this._学期,
				this._ATYID,
				this._GRNo,
				this._年级,
				this._Sort,
				this._CCnameEng,
				this._Memo,
				this._EMID,
				this._StartB,
				this._EndB,
				this._PerWB,
				this._Direct,
				this._学习方式,
				this._课程类别,
				this._CSortCode,
				this._Other,
				this._Cunit,
				this._CSort,
				this._SPNo,
				this._StuNum,
				this._Deptcode,
				this._组班人数,
				this._RsGroup,
				this._IFPK,
				this._ifCheck,
				this._ifCheckBY,
				this._ToDeptID,
				this._ToDeptCode,
				this._ToDeptname,
				this._ToDeptIDB,
				this._ToDeptnameB,
				this._ToDeptCodeB,
				this._HaveDG,
				this._GRstate,
				this._EGID,
				this._EGSequ,
				this._BX,
				this._Tohigh,
				this._CSA,
				this._Lastdate};
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
			public readonly static Field All = new Field("*","vw_EduPlanA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 课程名称 = new Field("课程名称","vw_EduPlanA","课程名称");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 课程代码 = new Field("课程代码","vw_EduPlanA","课程代码");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 专业名称 = new Field("专业名称","vw_EduPlanA","专业名称");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 课程要求 = new Field("课程要求","vw_EduPlanA","课程要求");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学分 = new Field("学分","vw_EduPlanA","学分");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 总学时 = new Field("总学时","vw_EduPlanA","总学时");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 讲课学时 = new Field("讲课学时","vw_EduPlanA","讲课学时");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 实验学时 = new Field("实验学时","vw_EduPlanA","实验学时");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 上机学时 = new Field("上机学时","vw_EduPlanA","上机学时");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 考试类型 = new Field("考试类型","vw_EduPlanA","考试类型");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 开课学期 = new Field("开课学期","vw_EduPlanA","开课学期");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 开始周次 = new Field("开始周次","vw_EduPlanA","开始周次");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 结束周次 = new Field("结束周次","vw_EduPlanA","结束周次");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 周学时数 = new Field("周学时数","vw_EduPlanA","周学时数");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EPID = new Field("EPID","vw_EduPlanA","EPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 主干课 = new Field("主干课","vw_EduPlanA","主干课");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_EduPlanA","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRDID = new Field("GRDID","vw_EduPlanA","GRDID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_EduPlanA","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学期名称 = new Field("学期名称","vw_EduPlanA","学期名称");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学期 = new Field("学期","vw_EduPlanA","学期");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATYID = new Field("ATYID","vw_EduPlanA","ATYID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRNo = new Field("GRNo","vw_EduPlanA","GRNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 年级 = new Field("年级","vw_EduPlanA","年级");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sort = new Field("Sort","vw_EduPlanA","Sort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCnameEng = new Field("CCnameEng","vw_EduPlanA","CCnameEng");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","vw_EduPlanA","Memo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMID = new Field("EMID","vw_EduPlanA","EMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StartB = new Field("StartB","vw_EduPlanA","StartB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EndB = new Field("EndB","vw_EduPlanA","EndB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PerWB = new Field("PerWB","vw_EduPlanA","PerWB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Direct = new Field("Direct","vw_EduPlanA","Direct");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学习方式 = new Field("学习方式","vw_EduPlanA","学习方式");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 课程类别 = new Field("课程类别","vw_EduPlanA","课程类别");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CSortCode = new Field("CSortCode","vw_EduPlanA","CSortCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Other = new Field("Other","vw_EduPlanA","Other");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Cunit = new Field("Cunit","vw_EduPlanA","Cunit");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CSort = new Field("CSort","vw_EduPlanA","CSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPNo = new Field("SPNo","vw_EduPlanA","SPNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StuNum = new Field("StuNum","vw_EduPlanA","StuNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Deptcode = new Field("Deptcode","vw_EduPlanA","Deptcode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 组班人数 = new Field("组班人数","vw_EduPlanA","组班人数");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RsGroup = new Field("RsGroup","vw_EduPlanA","RsGroup");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IFPK = new Field("IFPK","vw_EduPlanA","IFPK");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ifCheck = new Field("ifCheck","vw_EduPlanA","ifCheck");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ifCheckBY = new Field("ifCheckBY","vw_EduPlanA","ifCheckBY");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ToDeptID = new Field("ToDeptID","vw_EduPlanA","ToDeptID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ToDeptCode = new Field("ToDeptCode","vw_EduPlanA","ToDeptCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ToDeptname = new Field("ToDeptname","vw_EduPlanA","ToDeptname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ToDeptIDB = new Field("ToDeptIDB","vw_EduPlanA","ToDeptIDB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ToDeptnameB = new Field("ToDeptnameB","vw_EduPlanA","ToDeptnameB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ToDeptCodeB = new Field("ToDeptCodeB","vw_EduPlanA","ToDeptCodeB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HaveDG = new Field("HaveDG","vw_EduPlanA","HaveDG");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRstate = new Field("GRstate","vw_EduPlanA","GRstate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EGID = new Field("EGID","vw_EduPlanA","EGID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EGSequ = new Field("EGSequ","vw_EduPlanA","EGSequ");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BX = new Field("BX","vw_EduPlanA","BX");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Tohigh = new Field("Tohigh","vw_EduPlanA","Tohigh");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CSA = new Field("CSA","vw_EduPlanA","CSA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Lastdate = new Field("Lastdate","vw_EduPlanA","Lastdate");
		}
		#endregion


	}
}

