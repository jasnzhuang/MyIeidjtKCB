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
	/// 实体类TeacherCond 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("TeacherCond")]
	[Serializable]
	public partial class TeacherCond : Entity 
	{
		#region Model
		private int _TCNDID;
		private int? _TCHID;
		private string _TCName;
		private string _STDCode;
		private int? _Weekth;
		private string _Exclude;
		private string _Others;
		/// <summary>
		/// 
		/// </summary>
		public int TCNDID
		{
			get{ return _TCNDID; }
			set
			{
				this.OnPropertyValueChange(_.TCNDID,_TCNDID,value);
				this._TCNDID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TCHID
		{
			get{ return _TCHID; }
			set
			{
				this.OnPropertyValueChange(_.TCHID,_TCHID,value);
				this._TCHID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TCName
		{
			get{ return _TCName; }
			set
			{
				this.OnPropertyValueChange(_.TCName,_TCName,value);
				this._TCName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STDCode
		{
			get{ return _STDCode; }
			set
			{
				this.OnPropertyValueChange(_.STDCode,_STDCode,value);
				this._STDCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Weekth
		{
			get{ return _Weekth; }
			set
			{
				this.OnPropertyValueChange(_.Weekth,_Weekth,value);
				this._Weekth=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Exclude
		{
			get{ return _Exclude; }
			set
			{
				this.OnPropertyValueChange(_.Exclude,_Exclude,value);
				this._Exclude=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Others
		{
			get{ return _Others; }
			set
			{
				this.OnPropertyValueChange(_.Others,_Others,value);
				this._Others=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.TCNDID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.TCNDID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.TCNDID,
				_.TCHID,
				_.TCName,
				_.STDCode,
				_.Weekth,
				_.Exclude,
				_.Others};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TCNDID,
				this._TCHID,
				this._TCName,
				this._STDCode,
				this._Weekth,
				this._Exclude,
				this._Others};
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
			public readonly static Field All = new Field("*","TeacherCond");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCNDID = new Field("TCNDID","TeacherCond","TCNDID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCHID = new Field("TCHID","TeacherCond","TCHID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCName = new Field("TCName","TeacherCond","TCName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STDCode = new Field("STDCode","TeacherCond","STDCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Weekth = new Field("Weekth","TeacherCond","Weekth");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Exclude = new Field("Exclude","TeacherCond","Exclude");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Others = new Field("Others","TeacherCond","Others");
		}
		#endregion


	}
}

