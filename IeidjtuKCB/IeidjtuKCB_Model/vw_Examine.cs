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
	/// 实体类vw_Examine 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Examine")]
	[Serializable]
	public partial class vw_Examine : Entity 
	{
		#region Model
		private int _EMID;
		private string _EMName;
		private int? _Atyid;
		private string _Content;
		private decimal? _Freight;
		private DateTime? _Deadline;
		private DateTime? _Publishdate;
		private string _state;
		private string _PubOper;
		private string _CheckMarkA;
		private string _OutMarkA;
		private string _ExamDate;
		private int? _Lev;
		private string _ATName;
		private string _MarkName;
		/// <summary>
		/// 
		/// </summary>
		public int EMID
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
		public decimal? Freight
		{
			get{ return _Freight; }
			set
			{
				this.OnPropertyValueChange(_.Freight,_Freight,value);
				this._Freight=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Deadline
		{
			get{ return _Deadline; }
			set
			{
				this.OnPropertyValueChange(_.Deadline,_Deadline,value);
				this._Deadline=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Publishdate
		{
			get{ return _Publishdate; }
			set
			{
				this.OnPropertyValueChange(_.Publishdate,_Publishdate,value);
				this._Publishdate=value;
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
		public string PubOper
		{
			get{ return _PubOper; }
			set
			{
				this.OnPropertyValueChange(_.PubOper,_PubOper,value);
				this._PubOper=value;
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
		/// <summary>
		/// 
		/// </summary>
		public string OutMarkA
		{
			get{ return _OutMarkA; }
			set
			{
				this.OnPropertyValueChange(_.OutMarkA,_OutMarkA,value);
				this._OutMarkA=value;
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
		public string MarkName
		{
			get{ return _MarkName; }
			set
			{
				this.OnPropertyValueChange(_.MarkName,_MarkName,value);
				this._MarkName=value;
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
				_.EMID,
				_.EMName,
				_.Atyid,
				_.Content,
				_.Freight,
				_.Deadline,
				_.Publishdate,
				_.state,
				_.PubOper,
				_.CheckMarkA,
				_.OutMarkA,
				_.ExamDate,
				_.Lev,
				_.ATName,
				_.MarkName};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._EMID,
				this._EMName,
				this._Atyid,
				this._Content,
				this._Freight,
				this._Deadline,
				this._Publishdate,
				this._state,
				this._PubOper,
				this._CheckMarkA,
				this._OutMarkA,
				this._ExamDate,
				this._Lev,
				this._ATName,
				this._MarkName};
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
			public readonly static Field All = new Field("*","vw_Examine");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMID = new Field("EMID","vw_Examine","EMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMName = new Field("EMName","vw_Examine","EMName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("Atyid","vw_Examine","Atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","vw_Examine","Content");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Freight = new Field("Freight","vw_Examine","Freight");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Deadline = new Field("Deadline","vw_Examine","Deadline");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Publishdate = new Field("Publishdate","vw_Examine","Publishdate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field state = new Field("state","vw_Examine","state");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PubOper = new Field("PubOper","vw_Examine","PubOper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CheckMarkA = new Field("CheckMarkA","vw_Examine","CheckMarkA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OutMarkA = new Field("OutMarkA","vw_Examine","OutMarkA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExamDate = new Field("ExamDate","vw_Examine","ExamDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Lev = new Field("Lev","vw_Examine","Lev");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATName = new Field("ATName","vw_Examine","ATName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MarkName = new Field("MarkName","vw_Examine","MarkName");
		}
		#endregion


	}
}

