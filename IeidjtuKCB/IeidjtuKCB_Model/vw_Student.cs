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
	/// 实体类vw_Student 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Student")]
	[Serializable]
	public partial class vw_Student : Entity 
	{
		#region Model
		private string _学号;
		private int? _小学号;
		private string _系部;
		private string _专业;
		private string _年级;
		private string _班级;
		private string _学生姓名;
		private string _曾用名;
		private string _性别;
		private string _出生年月日;
		private string _政治面貌;
		private string _民族;
		private string _毕业学校;
		private string _生源;
		private string _籍贯;
		private string _家庭住址;
		private string _家庭电话;
		private string _邮政编码;
		private string _入学方式;
		private string _父亲姓名;
		private string _母亲姓名;
		private string _父亲单位;
		private string _父亲职务;
		private string _母亲单位;
		private string _母亲职务;
		private decimal? _身高;
		private decimal? _体重;
		private string _职务;
		private string _特长;
		private string _宿舍号;
		private string _宿舍电话;
		private string _备注;
		private int _StdID;
		private int? _CLassID;
		private int? _DeptID;
		private int? _GradeID;
		private int? _SPID;
		private string _Password;
		private string _外语语种;
		private string _身份证号码;
		private string _n;
		private string _y;
		private string _r;
		private string _DeptCode;
		private string _Direct;
		private string _Question;
		private int? _SPYear;
		private string _Biye;
		private string _Xuewei;
		private string _KSH;
		private string _RGName;
		private string _Mark;
		private string _xxstate;
		private string _SPNo;
		private string _ByState;
		private string _state;
		private string _ifJoin;
		private int? _CX12;
		private int? _BJGNum;
		private int? _Lost;
		private int? _LastNum;
		private DateTime? _LastTime;
		private string _BYSJ;
		private string _Bank;
		private int? _CurTerm;
		private string _Email;
		private string _EnglishLev;
		private float? _EndlishSource;
		private string _Engname;
		private string _Photo;
		private string _SelfPlan;
		private string _层次;
		private string _vGroup;
		/// <summary>
		/// 
		/// </summary>
		public string 学号
		{
			get{ return _学号; }
			set
			{
				this.OnPropertyValueChange(_.学号,_学号,value);
				this._学号=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 小学号
		{
			get{ return _小学号; }
			set
			{
				this.OnPropertyValueChange(_.小学号,_小学号,value);
				this._小学号=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 系部
		{
			get{ return _系部; }
			set
			{
				this.OnPropertyValueChange(_.系部,_系部,value);
				this._系部=value;
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
		public string 班级
		{
			get{ return _班级; }
			set
			{
				this.OnPropertyValueChange(_.班级,_班级,value);
				this._班级=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 学生姓名
		{
			get{ return _学生姓名; }
			set
			{
				this.OnPropertyValueChange(_.学生姓名,_学生姓名,value);
				this._学生姓名=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 曾用名
		{
			get{ return _曾用名; }
			set
			{
				this.OnPropertyValueChange(_.曾用名,_曾用名,value);
				this._曾用名=value;
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
		public string 出生年月日
		{
			get{ return _出生年月日; }
			set
			{
				this.OnPropertyValueChange(_.出生年月日,_出生年月日,value);
				this._出生年月日=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 政治面貌
		{
			get{ return _政治面貌; }
			set
			{
				this.OnPropertyValueChange(_.政治面貌,_政治面貌,value);
				this._政治面貌=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 民族
		{
			get{ return _民族; }
			set
			{
				this.OnPropertyValueChange(_.民族,_民族,value);
				this._民族=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 毕业学校
		{
			get{ return _毕业学校; }
			set
			{
				this.OnPropertyValueChange(_.毕业学校,_毕业学校,value);
				this._毕业学校=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 生源
		{
			get{ return _生源; }
			set
			{
				this.OnPropertyValueChange(_.生源,_生源,value);
				this._生源=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 籍贯
		{
			get{ return _籍贯; }
			set
			{
				this.OnPropertyValueChange(_.籍贯,_籍贯,value);
				this._籍贯=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 家庭住址
		{
			get{ return _家庭住址; }
			set
			{
				this.OnPropertyValueChange(_.家庭住址,_家庭住址,value);
				this._家庭住址=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 家庭电话
		{
			get{ return _家庭电话; }
			set
			{
				this.OnPropertyValueChange(_.家庭电话,_家庭电话,value);
				this._家庭电话=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 邮政编码
		{
			get{ return _邮政编码; }
			set
			{
				this.OnPropertyValueChange(_.邮政编码,_邮政编码,value);
				this._邮政编码=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 入学方式
		{
			get{ return _入学方式; }
			set
			{
				this.OnPropertyValueChange(_.入学方式,_入学方式,value);
				this._入学方式=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 父亲姓名
		{
			get{ return _父亲姓名; }
			set
			{
				this.OnPropertyValueChange(_.父亲姓名,_父亲姓名,value);
				this._父亲姓名=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 母亲姓名
		{
			get{ return _母亲姓名; }
			set
			{
				this.OnPropertyValueChange(_.母亲姓名,_母亲姓名,value);
				this._母亲姓名=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 父亲单位
		{
			get{ return _父亲单位; }
			set
			{
				this.OnPropertyValueChange(_.父亲单位,_父亲单位,value);
				this._父亲单位=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 父亲职务
		{
			get{ return _父亲职务; }
			set
			{
				this.OnPropertyValueChange(_.父亲职务,_父亲职务,value);
				this._父亲职务=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 母亲单位
		{
			get{ return _母亲单位; }
			set
			{
				this.OnPropertyValueChange(_.母亲单位,_母亲单位,value);
				this._母亲单位=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 母亲职务
		{
			get{ return _母亲职务; }
			set
			{
				this.OnPropertyValueChange(_.母亲职务,_母亲职务,value);
				this._母亲职务=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 身高
		{
			get{ return _身高; }
			set
			{
				this.OnPropertyValueChange(_.身高,_身高,value);
				this._身高=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 体重
		{
			get{ return _体重; }
			set
			{
				this.OnPropertyValueChange(_.体重,_体重,value);
				this._体重=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 职务
		{
			get{ return _职务; }
			set
			{
				this.OnPropertyValueChange(_.职务,_职务,value);
				this._职务=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 特长
		{
			get{ return _特长; }
			set
			{
				this.OnPropertyValueChange(_.特长,_特长,value);
				this._特长=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 宿舍号
		{
			get{ return _宿舍号; }
			set
			{
				this.OnPropertyValueChange(_.宿舍号,_宿舍号,value);
				this._宿舍号=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 宿舍电话
		{
			get{ return _宿舍电话; }
			set
			{
				this.OnPropertyValueChange(_.宿舍电话,_宿舍电话,value);
				this._宿舍电话=value;
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
		public int StdID
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
		public string Password
		{
			get{ return _Password; }
			set
			{
				this.OnPropertyValueChange(_.Password,_Password,value);
				this._Password=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 外语语种
		{
			get{ return _外语语种; }
			set
			{
				this.OnPropertyValueChange(_.外语语种,_外语语种,value);
				this._外语语种=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 身份证号码
		{
			get{ return _身份证号码; }
			set
			{
				this.OnPropertyValueChange(_.身份证号码,_身份证号码,value);
				this._身份证号码=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string n
		{
			get{ return _n; }
			set
			{
				this.OnPropertyValueChange(_.n,_n,value);
				this._n=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string y
		{
			get{ return _y; }
			set
			{
				this.OnPropertyValueChange(_.y,_y,value);
				this._y=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string r
		{
			get{ return _r; }
			set
			{
				this.OnPropertyValueChange(_.r,_r,value);
				this._r=value;
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
		public string Question
		{
			get{ return _Question; }
			set
			{
				this.OnPropertyValueChange(_.Question,_Question,value);
				this._Question=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SPYear
		{
			get{ return _SPYear; }
			set
			{
				this.OnPropertyValueChange(_.SPYear,_SPYear,value);
				this._SPYear=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Biye
		{
			get{ return _Biye; }
			set
			{
				this.OnPropertyValueChange(_.Biye,_Biye,value);
				this._Biye=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Xuewei
		{
			get{ return _Xuewei; }
			set
			{
				this.OnPropertyValueChange(_.Xuewei,_Xuewei,value);
				this._Xuewei=value;
			}
		}
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
		public string Mark
		{
			get{ return _Mark; }
			set
			{
				this.OnPropertyValueChange(_.Mark,_Mark,value);
				this._Mark=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string xxstate
		{
			get{ return _xxstate; }
			set
			{
				this.OnPropertyValueChange(_.xxstate,_xxstate,value);
				this._xxstate=value;
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
		public string ByState
		{
			get{ return _ByState; }
			set
			{
				this.OnPropertyValueChange(_.ByState,_ByState,value);
				this._ByState=value;
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
		public string ifJoin
		{
			get{ return _ifJoin; }
			set
			{
				this.OnPropertyValueChange(_.ifJoin,_ifJoin,value);
				this._ifJoin=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CX12
		{
			get{ return _CX12; }
			set
			{
				this.OnPropertyValueChange(_.CX12,_CX12,value);
				this._CX12=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BJGNum
		{
			get{ return _BJGNum; }
			set
			{
				this.OnPropertyValueChange(_.BJGNum,_BJGNum,value);
				this._BJGNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Lost
		{
			get{ return _Lost; }
			set
			{
				this.OnPropertyValueChange(_.Lost,_Lost,value);
				this._Lost=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LastNum
		{
			get{ return _LastNum; }
			set
			{
				this.OnPropertyValueChange(_.LastNum,_LastNum,value);
				this._LastNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LastTime
		{
			get{ return _LastTime; }
			set
			{
				this.OnPropertyValueChange(_.LastTime,_LastTime,value);
				this._LastTime=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BYSJ
		{
			get{ return _BYSJ; }
			set
			{
				this.OnPropertyValueChange(_.BYSJ,_BYSJ,value);
				this._BYSJ=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Bank
		{
			get{ return _Bank; }
			set
			{
				this.OnPropertyValueChange(_.Bank,_Bank,value);
				this._Bank=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CurTerm
		{
			get{ return _CurTerm; }
			set
			{
				this.OnPropertyValueChange(_.CurTerm,_CurTerm,value);
				this._CurTerm=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			get{ return _Email; }
			set
			{
				this.OnPropertyValueChange(_.Email,_Email,value);
				this._Email=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EnglishLev
		{
			get{ return _EnglishLev; }
			set
			{
				this.OnPropertyValueChange(_.EnglishLev,_EnglishLev,value);
				this._EnglishLev=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public float? EndlishSource
		{
			get{ return _EndlishSource; }
			set
			{
				this.OnPropertyValueChange(_.EndlishSource,_EndlishSource,value);
				this._EndlishSource=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Engname
		{
			get{ return _Engname; }
			set
			{
				this.OnPropertyValueChange(_.Engname,_Engname,value);
				this._Engname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Photo
		{
			get{ return _Photo; }
			set
			{
				this.OnPropertyValueChange(_.Photo,_Photo,value);
				this._Photo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SelfPlan
		{
			get{ return _SelfPlan; }
			set
			{
				this.OnPropertyValueChange(_.SelfPlan,_SelfPlan,value);
				this._SelfPlan=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 层次
		{
			get{ return _层次; }
			set
			{
				this.OnPropertyValueChange(_.层次,_层次,value);
				this._层次=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string vGroup
		{
			get{ return _vGroup; }
			set
			{
				this.OnPropertyValueChange(_.vGroup,_vGroup,value);
				this._vGroup=value;
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
				_.学号,
				_.小学号,
				_.系部,
				_.专业,
				_.年级,
				_.班级,
				_.学生姓名,
				_.曾用名,
				_.性别,
				_.出生年月日,
				_.政治面貌,
				_.民族,
				_.毕业学校,
				_.生源,
				_.籍贯,
				_.家庭住址,
				_.家庭电话,
				_.邮政编码,
				_.入学方式,
				_.父亲姓名,
				_.母亲姓名,
				_.父亲单位,
				_.父亲职务,
				_.母亲单位,
				_.母亲职务,
				_.身高,
				_.体重,
				_.职务,
				_.特长,
				_.宿舍号,
				_.宿舍电话,
				_.备注,
				_.StdID,
				_.CLassID,
				_.DeptID,
				_.GradeID,
				_.SPID,
				_.Password,
				_.外语语种,
				_.身份证号码,
				_.n,
				_.y,
				_.r,
				_.DeptCode,
				_.Direct,
				_.Question,
				_.SPYear,
				_.Biye,
				_.Xuewei,
				_.KSH,
				_.RGName,
				_.Mark,
				_.xxstate,
				_.SPNo,
				_.ByState,
				_.state,
				_.ifJoin,
				_.CX12,
				_.BJGNum,
				_.Lost,
				_.LastNum,
				_.LastTime,
				_.BYSJ,
				_.Bank,
				_.CurTerm,
				_.Email,
				_.EnglishLev,
				_.EndlishSource,
				_.Engname,
				_.Photo,
				_.SelfPlan,
				_.层次,
				_.vGroup};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._学号,
				this._小学号,
				this._系部,
				this._专业,
				this._年级,
				this._班级,
				this._学生姓名,
				this._曾用名,
				this._性别,
				this._出生年月日,
				this._政治面貌,
				this._民族,
				this._毕业学校,
				this._生源,
				this._籍贯,
				this._家庭住址,
				this._家庭电话,
				this._邮政编码,
				this._入学方式,
				this._父亲姓名,
				this._母亲姓名,
				this._父亲单位,
				this._父亲职务,
				this._母亲单位,
				this._母亲职务,
				this._身高,
				this._体重,
				this._职务,
				this._特长,
				this._宿舍号,
				this._宿舍电话,
				this._备注,
				this._StdID,
				this._CLassID,
				this._DeptID,
				this._GradeID,
				this._SPID,
				this._Password,
				this._外语语种,
				this._身份证号码,
				this._n,
				this._y,
				this._r,
				this._DeptCode,
				this._Direct,
				this._Question,
				this._SPYear,
				this._Biye,
				this._Xuewei,
				this._KSH,
				this._RGName,
				this._Mark,
				this._xxstate,
				this._SPNo,
				this._ByState,
				this._state,
				this._ifJoin,
				this._CX12,
				this._BJGNum,
				this._Lost,
				this._LastNum,
				this._LastTime,
				this._BYSJ,
				this._Bank,
				this._CurTerm,
				this._Email,
				this._EnglishLev,
				this._EndlishSource,
				this._Engname,
				this._Photo,
				this._SelfPlan,
				this._层次,
				this._vGroup};
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
			public readonly static Field All = new Field("*","vw_Student");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学号 = new Field("学号","vw_Student","学号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 小学号 = new Field("小学号","vw_Student","小学号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 系部 = new Field("系部","vw_Student","系部");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 专业 = new Field("专业","vw_Student","专业");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 年级 = new Field("年级","vw_Student","年级");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 班级 = new Field("班级","vw_Student","班级");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学生姓名 = new Field("学生姓名","vw_Student","学生姓名");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 曾用名 = new Field("曾用名","vw_Student","曾用名");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 性别 = new Field("性别","vw_Student","性别");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 出生年月日 = new Field("出生年月日","vw_Student","出生年月日");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 政治面貌 = new Field("政治面貌","vw_Student","政治面貌");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 民族 = new Field("民族","vw_Student","民族");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 毕业学校 = new Field("毕业学校","vw_Student","毕业学校");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 生源 = new Field("生源","vw_Student","生源");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 籍贯 = new Field("籍贯","vw_Student","籍贯");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 家庭住址 = new Field("家庭住址","vw_Student","家庭住址");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 家庭电话 = new Field("家庭电话","vw_Student","家庭电话");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 邮政编码 = new Field("邮政编码","vw_Student","邮政编码");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 入学方式 = new Field("入学方式","vw_Student","入学方式");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 父亲姓名 = new Field("父亲姓名","vw_Student","父亲姓名");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 母亲姓名 = new Field("母亲姓名","vw_Student","母亲姓名");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 父亲单位 = new Field("父亲单位","vw_Student","父亲单位");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 父亲职务 = new Field("父亲职务","vw_Student","父亲职务");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 母亲单位 = new Field("母亲单位","vw_Student","母亲单位");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 母亲职务 = new Field("母亲职务","vw_Student","母亲职务");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 身高 = new Field("身高","vw_Student","身高");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 体重 = new Field("体重","vw_Student","体重");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 职务 = new Field("职务","vw_Student","职务");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 特长 = new Field("特长","vw_Student","特长");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 宿舍号 = new Field("宿舍号","vw_Student","宿舍号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 宿舍电话 = new Field("宿舍电话","vw_Student","宿舍电话");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 备注 = new Field("备注","vw_Student","备注");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdID = new Field("StdID","vw_Student","StdID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLassID = new Field("CLassID","vw_Student","CLassID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptID = new Field("DeptID","vw_Student","DeptID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GradeID = new Field("GradeID","vw_Student","GradeID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_Student","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Password = new Field("Password","vw_Student","Password");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 外语语种 = new Field("外语语种","vw_Student","外语语种");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 身份证号码 = new Field("身份证号码","vw_Student","身份证号码");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field n = new Field("n","vw_Student","n");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field y = new Field("y","vw_Student","y");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field r = new Field("r","vw_Student","r");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCode = new Field("DeptCode","vw_Student","DeptCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Direct = new Field("Direct","vw_Student","Direct");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Question = new Field("Question","vw_Student","Question");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPYear = new Field("SPYear","vw_Student","SPYear");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Biye = new Field("Biye","vw_Student","Biye");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Xuewei = new Field("Xuewei","vw_Student","Xuewei");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KSH = new Field("KSH","vw_Student","KSH");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RGName = new Field("RGName","vw_Student","RGName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Mark = new Field("Mark","vw_Student","Mark");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field xxstate = new Field("xxstate","vw_Student","xxstate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPNo = new Field("SPNo","vw_Student","SPNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ByState = new Field("ByState","vw_Student","ByState");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field state = new Field("state","vw_Student","state");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ifJoin = new Field("ifJoin","vw_Student","ifJoin");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CX12 = new Field("CX12","vw_Student","CX12");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BJGNum = new Field("BJGNum","vw_Student","BJGNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Lost = new Field("Lost","vw_Student","Lost");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LastNum = new Field("LastNum","vw_Student","LastNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LastTime = new Field("LastTime","vw_Student","LastTime");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BYSJ = new Field("BYSJ","vw_Student","BYSJ");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Bank = new Field("Bank","vw_Student","Bank");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CurTerm = new Field("CurTerm","vw_Student","CurTerm");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Email = new Field("Email","vw_Student","Email");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EnglishLev = new Field("EnglishLev","vw_Student","EnglishLev");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EndlishSource = new Field("EndlishSource","vw_Student","EndlishSource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Engname = new Field("Engname","vw_Student","Engname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Photo = new Field("Photo","vw_Student","Photo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SelfPlan = new Field("SelfPlan","vw_Student","SelfPlan");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 层次 = new Field("层次","vw_Student","层次");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field vGroup = new Field("vGroup","vw_Student","vGroup");
		}
		#endregion


	}
}

