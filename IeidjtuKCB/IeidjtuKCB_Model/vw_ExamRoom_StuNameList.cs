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
	/// 实体类vw_ExamRoom_StuNameList 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_ExamRoom_StuNameList")]
	[Serializable]
	public partial class vw_ExamRoom_StuNameList : Entity 
	{
		#region Model
		private string _StdCode;
		private string _StdName;
		private string _PMState;
		private string _RGState;
		private int? _EXRID;
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
		/// <summary>
		/// 
		/// </summary>
		public string StdName
		{
			get{ return _StdName; }
			set
			{
				this.OnPropertyValueChange(_.StdName,_StdName,value);
				this._StdName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PMState
		{
			get{ return _PMState; }
			set
			{
				this.OnPropertyValueChange(_.PMState,_PMState,value);
				this._PMState=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RGState
		{
			get{ return _RGState; }
			set
			{
				this.OnPropertyValueChange(_.RGState,_RGState,value);
				this._RGState=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EXRID
		{
			get{ return _EXRID; }
			set
			{
				this.OnPropertyValueChange(_.EXRID,_EXRID,value);
				this._EXRID=value;
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
				_.StdCode,
				_.StdName,
				_.PMState,
				_.RGState,
				_.EXRID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._StdCode,
				this._StdName,
				this._PMState,
				this._RGState,
				this._EXRID};
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
			public readonly static Field All = new Field("*","vw_ExamRoom_StuNameList");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdCode = new Field("StdCode","vw_ExamRoom_StuNameList","StdCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdName = new Field("StdName","vw_ExamRoom_StuNameList","StdName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PMState = new Field("PMState","vw_ExamRoom_StuNameList","PMState");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RGState = new Field("RGState","vw_ExamRoom_StuNameList","RGState");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EXRID = new Field("EXRID","vw_ExamRoom_StuNameList","EXRID");
		}
		#endregion


	}
}

