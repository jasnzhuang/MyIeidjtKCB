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
	/// 实体类ContRElative 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("ContRElative")]
	[Serializable]
	public partial class ContRElative : Entity 
	{
		#region Model
		private int _RelID;
		private int? _CCID;
		private int? _ContID;
		private string _ConWH;
		private string _Component;
		private string _ChpNo;
		private string _Degree;
		/// <summary>
		/// 
		/// </summary>
		public int RelID
		{
			get{ return _RelID; }
			set
			{
				this.OnPropertyValueChange(_.RelID,_RelID,value);
				this._RelID=value;
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
		public int? ContID
		{
			get{ return _ContID; }
			set
			{
				this.OnPropertyValueChange(_.ContID,_ContID,value);
				this._ContID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ConWH
		{
			get{ return _ConWH; }
			set
			{
				this.OnPropertyValueChange(_.ConWH,_ConWH,value);
				this._ConWH=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Component
		{
			get{ return _Component; }
			set
			{
				this.OnPropertyValueChange(_.Component,_Component,value);
				this._Component=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChpNo
		{
			get{ return _ChpNo; }
			set
			{
				this.OnPropertyValueChange(_.ChpNo,_ChpNo,value);
				this._ChpNo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Degree
		{
			get{ return _Degree; }
			set
			{
				this.OnPropertyValueChange(_.Degree,_Degree,value);
				this._Degree=value;
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
				_.RelID,
				_.CCID,
				_.ContID,
				_.ConWH,
				_.Component,
				_.ChpNo,
				_.Degree};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._RelID,
				this._CCID,
				this._ContID,
				this._ConWH,
				this._Component,
				this._ChpNo,
				this._Degree};
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
			public readonly static Field All = new Field("*","ContRElative");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RelID = new Field("RelID","ContRElative","RelID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","ContRElative","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ContID = new Field("ContID","ContRElative","ContID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ConWH = new Field("ConWH","ContRElative","ConWH");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Component = new Field("Component","ContRElative","Component");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ChpNo = new Field("ChpNo","ContRElative","ChpNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Degree = new Field("Degree","ContRElative","Degree");
		}
		#endregion


	}
}

