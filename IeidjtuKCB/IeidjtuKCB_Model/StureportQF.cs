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
	/// 实体类StureportQF 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("StureportQF")]
	[Serializable]
	public partial class StureportQF : Entity 
	{
		#region Model
		private int _SSRID;
		private int? _SRID;
		private int? _Atyid;
		private int? _Stuid;
		private string _Examine;
		private string _Experiment;
		private string _Normal;
		private string _Exam;
		private decimal? _ExamNum;
		private decimal? _TruePoint;
		private string _TrueResult;
		private string _Memo;
		/// <summary>
		/// 
		/// </summary>
		public int SSRID
		{
			get{ return _SSRID; }
			set
			{
				this.OnPropertyValueChange(_.SSRID,_SSRID,value);
				this._SSRID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SRID
		{
			get{ return _SRID; }
			set
			{
				this.OnPropertyValueChange(_.SRID,_SRID,value);
				this._SRID=value;
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
		public int? Stuid
		{
			get{ return _Stuid; }
			set
			{
				this.OnPropertyValueChange(_.Stuid,_Stuid,value);
				this._Stuid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Examine
		{
			get{ return _Examine; }
			set
			{
				this.OnPropertyValueChange(_.Examine,_Examine,value);
				this._Examine=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Experiment
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
		public string Normal
		{
			get{ return _Normal; }
			set
			{
				this.OnPropertyValueChange(_.Normal,_Normal,value);
				this._Normal=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Exam
		{
			get{ return _Exam; }
			set
			{
				this.OnPropertyValueChange(_.Exam,_Exam,value);
				this._Exam=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ExamNum
		{
			get{ return _ExamNum; }
			set
			{
				this.OnPropertyValueChange(_.ExamNum,_ExamNum,value);
				this._ExamNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TruePoint
		{
			get{ return _TruePoint; }
			set
			{
				this.OnPropertyValueChange(_.TruePoint,_TruePoint,value);
				this._TruePoint=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TrueResult
		{
			get{ return _TrueResult; }
			set
			{
				this.OnPropertyValueChange(_.TrueResult,_TrueResult,value);
				this._TrueResult=value;
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
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.SSRID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.SSRID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.SSRID,
				_.SRID,
				_.Atyid,
				_.Stuid,
				_.Examine,
				_.Experiment,
				_.Normal,
				_.Exam,
				_.ExamNum,
				_.TruePoint,
				_.TrueResult,
				_.Memo};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SSRID,
				this._SRID,
				this._Atyid,
				this._Stuid,
				this._Examine,
				this._Experiment,
				this._Normal,
				this._Exam,
				this._ExamNum,
				this._TruePoint,
				this._TrueResult,
				this._Memo};
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
			public readonly static Field All = new Field("*","StureportQF");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SSRID = new Field("SSRID","StureportQF","SSRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SRID = new Field("SRID","StureportQF","SRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("atyid","StureportQF","atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stuid = new Field("stuid","StureportQF","stuid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Examine = new Field("examine","StureportQF","examine");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Experiment = new Field("Experiment","StureportQF","Experiment");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Normal = new Field("Normal","StureportQF","Normal");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Exam = new Field("Exam","StureportQF","Exam");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExamNum = new Field("ExamNum","StureportQF","ExamNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TruePoint = new Field("truePoint","StureportQF","truePoint");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TrueResult = new Field("trueResult","StureportQF","trueResult");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","StureportQF","Memo");
		}
		#endregion


	}
}

