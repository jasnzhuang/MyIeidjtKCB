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
	/// 实体类Curricula 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Curricula")]
	[Serializable]
	public partial class Curricula : Entity 
	{
		#region Model
		private int _CCID;
		private string _CCode;
		private string _CPyCode;
		private string _CCname;
		private string _CCnameEng;
		private string _Mark;
		private string _Csort;
		private string _Cunit;
		private string _Deptcode;
		private int? _MaxNum;
		private decimal? _Source;
		private decimal? _Period;
		private int? _Prelect;
		private int? _Experiment;
		private int? _OnComputer;
		private decimal? _Other;
		private string _Examsort;
		private string _Memo;
		private short? _ClassNum;
		private int? _CLevel;
		private string _MMedia;
		private string _RoomSort;
		private string _SelectMode;
		private int? _NormalScale;
		private int? _ExpScale;
		private int? _ExamineScale;
		private int? _StuNum;
		private string _UseDControl;
		private string _RsGroup;
		private string _IFPK;
		private string _IFCheck;
		private string _IFCheckBY;
		private string _Resume;
		private string _ModifyOper;
		private DateTime? _ModifyDate;
		private string _NewOper;
		private DateTime? _NewDate;
		private string _EachSection;
		private int? _OutLinenum;
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
		public string CPyCode
		{
			get{ return _CPyCode; }
			set
			{
				this.OnPropertyValueChange(_.CPyCode,_CPyCode,value);
				this._CPyCode=value;
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
		public string Csort
		{
			get{ return _Csort; }
			set
			{
				this.OnPropertyValueChange(_.Csort,_Csort,value);
				this._Csort=value;
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
		public int? MaxNum
		{
			get{ return _MaxNum; }
			set
			{
				this.OnPropertyValueChange(_.MaxNum,_MaxNum,value);
				this._MaxNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Source
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
		public decimal? Period
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
		public int? Prelect
		{
			get{ return _Prelect; }
			set
			{
				this.OnPropertyValueChange(_.Prelect,_Prelect,value);
				this._Prelect=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Experiment
		{
			get{ return _Experiment; }
			set
			{
				this.OnPropertyValueChange(_.Experiment,_Experiment,value);
				this._Experiment=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OnComputer
		{
			get{ return _OnComputer; }
			set
			{
				this.OnPropertyValueChange(_.OnComputer,_OnComputer,value);
				this._OnComputer=value;
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
		public string Examsort
		{
			get{ return _Examsort; }
			set
			{
				this.OnPropertyValueChange(_.Examsort,_Examsort,value);
				this._Examsort=value;
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
		public short? ClassNum
		{
			get{ return _ClassNum; }
			set
			{
				this.OnPropertyValueChange(_.ClassNum,_ClassNum,value);
				this._ClassNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CLevel
		{
			get{ return _CLevel; }
			set
			{
				this.OnPropertyValueChange(_.CLevel,_CLevel,value);
				this._CLevel=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MMedia
		{
			get{ return _MMedia; }
			set
			{
				this.OnPropertyValueChange(_.MMedia,_MMedia,value);
				this._MMedia=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoomSort
		{
			get{ return _RoomSort; }
			set
			{
				this.OnPropertyValueChange(_.RoomSort,_RoomSort,value);
				this._RoomSort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SelectMode
		{
			get{ return _SelectMode; }
			set
			{
				this.OnPropertyValueChange(_.SelectMode,_SelectMode,value);
				this._SelectMode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? NormalScale
		{
			get{ return _NormalScale; }
			set
			{
				this.OnPropertyValueChange(_.NormalScale,_NormalScale,value);
				this._NormalScale=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExpScale
		{
			get{ return _ExpScale; }
			set
			{
				this.OnPropertyValueChange(_.ExpScale,_ExpScale,value);
				this._ExpScale=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExamineScale
		{
			get{ return _ExamineScale; }
			set
			{
				this.OnPropertyValueChange(_.ExamineScale,_ExamineScale,value);
				this._ExamineScale=value;
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
		public string UseDControl
		{
			get{ return _UseDControl; }
			set
			{
				this.OnPropertyValueChange(_.UseDControl,_UseDControl,value);
				this._UseDControl=value;
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
		public string IFCheck
		{
			get{ return _IFCheck; }
			set
			{
				this.OnPropertyValueChange(_.IFCheck,_IFCheck,value);
				this._IFCheck=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IFCheckBY
		{
			get{ return _IFCheckBY; }
			set
			{
				this.OnPropertyValueChange(_.IFCheckBY,_IFCheckBY,value);
				this._IFCheckBY=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Resume
		{
			get{ return _Resume; }
			set
			{
				this.OnPropertyValueChange(_.Resume,_Resume,value);
				this._Resume=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ModifyOper
		{
			get{ return _ModifyOper; }
			set
			{
				this.OnPropertyValueChange(_.ModifyOper,_ModifyOper,value);
				this._ModifyOper=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ModifyDate
		{
			get{ return _ModifyDate; }
			set
			{
				this.OnPropertyValueChange(_.ModifyDate,_ModifyDate,value);
				this._ModifyDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewOper
		{
			get{ return _NewOper; }
			set
			{
				this.OnPropertyValueChange(_.NewOper,_NewOper,value);
				this._NewOper=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? NewDate
		{
			get{ return _NewDate; }
			set
			{
				this.OnPropertyValueChange(_.NewDate,_NewDate,value);
				this._NewDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EachSection
		{
			get{ return _EachSection; }
			set
			{
				this.OnPropertyValueChange(_.EachSection,_EachSection,value);
				this._EachSection=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OutLinenum
		{
			get{ return _OutLinenum; }
			set
			{
				this.OnPropertyValueChange(_.OutLinenum,_OutLinenum,value);
				this._OutLinenum=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.CCID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.CCID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.CCID,
				_.CCode,
				_.CPyCode,
				_.CCname,
				_.CCnameEng,
				_.Mark,
				_.Csort,
				_.Cunit,
				_.Deptcode,
				_.MaxNum,
				_.Source,
				_.Period,
				_.Prelect,
				_.Experiment,
				_.OnComputer,
				_.Other,
				_.Examsort,
				_.Memo,
				_.ClassNum,
				_.CLevel,
				_.MMedia,
				_.RoomSort,
				_.SelectMode,
				_.NormalScale,
				_.ExpScale,
				_.ExamineScale,
				_.StuNum,
				_.UseDControl,
				_.RsGroup,
				_.IFPK,
				_.IFCheck,
				_.IFCheckBY,
				_.Resume,
				_.ModifyOper,
				_.ModifyDate,
				_.NewOper,
				_.NewDate,
				_.EachSection,
				_.OutLinenum};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._CCID,
				this._CCode,
				this._CPyCode,
				this._CCname,
				this._CCnameEng,
				this._Mark,
				this._Csort,
				this._Cunit,
				this._Deptcode,
				this._MaxNum,
				this._Source,
				this._Period,
				this._Prelect,
				this._Experiment,
				this._OnComputer,
				this._Other,
				this._Examsort,
				this._Memo,
				this._ClassNum,
				this._CLevel,
				this._MMedia,
				this._RoomSort,
				this._SelectMode,
				this._NormalScale,
				this._ExpScale,
				this._ExamineScale,
				this._StuNum,
				this._UseDControl,
				this._RsGroup,
				this._IFPK,
				this._IFCheck,
				this._IFCheckBY,
				this._Resume,
				this._ModifyOper,
				this._ModifyDate,
				this._NewOper,
				this._NewDate,
				this._EachSection,
				this._OutLinenum};
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
			public readonly static Field All = new Field("*","Curricula");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","Curricula","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCode = new Field("CCode","Curricula","CCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CPyCode = new Field("CPyCode","Curricula","CPyCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCname = new Field("CCname","Curricula","CCname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCnameEng = new Field("CCnameEng","Curricula","CCnameEng");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Mark = new Field("Mark","Curricula","Mark");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Csort = new Field("Csort","Curricula","Csort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Cunit = new Field("Cunit","Curricula","Cunit");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Deptcode = new Field("Deptcode","Curricula","Deptcode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MaxNum = new Field("MaxNum","Curricula","MaxNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Source = new Field("Source","Curricula","Source");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Period = new Field("Period","Curricula","Period");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Prelect = new Field("Prelect","Curricula","Prelect");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Experiment = new Field("Experiment","Curricula","Experiment");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OnComputer = new Field("OnComputer","Curricula","OnComputer");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Other = new Field("Other","Curricula","Other");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Examsort = new Field("Examsort","Curricula","Examsort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","Curricula","Memo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassNum = new Field("ClassNum","Curricula","ClassNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLevel = new Field("CLevel","Curricula","CLevel");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MMedia = new Field("MMedia","Curricula","MMedia");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RoomSort = new Field("RoomSort","Curricula","RoomSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SelectMode = new Field("SelectMode","Curricula","SelectMode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field NormalScale = new Field("NormalScale","Curricula","NormalScale");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExpScale = new Field("ExpScale","Curricula","ExpScale");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExamineScale = new Field("ExamineScale","Curricula","ExamineScale");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StuNum = new Field("StuNum","Curricula","StuNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UseDControl = new Field("UseDControl","Curricula","UseDControl");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RsGroup = new Field("RsGroup","Curricula","RsGroup");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IFPK = new Field("IFPK","Curricula","IFPK");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IFCheck = new Field("IFCheck","Curricula","IFCheck");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IFCheckBY = new Field("IFCheckBY","Curricula","IFCheckBY");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Resume = new Field("Resume","Curricula","Resume");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ModifyOper = new Field("ModifyOper","Curricula","ModifyOper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ModifyDate = new Field("ModifyDate","Curricula","ModifyDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field NewOper = new Field("NewOper","Curricula","NewOper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field NewDate = new Field("NewDate","Curricula","NewDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EachSection = new Field("EachSection","Curricula","EachSection");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OutLinenum = new Field("OutLinenum","Curricula","OutLinenum");
		}
		#endregion


	}
}

