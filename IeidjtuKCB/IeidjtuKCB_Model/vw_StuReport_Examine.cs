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
	/// 实体类vw_StuReport_Examine 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_StuReport_Examine")]
	[Serializable]
	public partial class vw_StuReport_Examine : Entity 
	{
		#region Model
		private int _SRID;
		private int? _ATYID;
		private float? _examine;
		private int? _SequID;
		private int? _CCID;
		private string _ClassName;
		private string _Minor;
		/// <summary>
		/// 
		/// </summary>
		public int SRID
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
		public float? examine
		{
			get{ return _examine; }
			set
			{
				this.OnPropertyValueChange(_.examine,_examine,value);
				this._examine=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SequID
		{
			get{ return _SequID; }
			set
			{
				this.OnPropertyValueChange(_.SequID,_SequID,value);
				this._SequID=value;
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
		public string ClassName
		{
			get{ return _ClassName; }
			set
			{
				this.OnPropertyValueChange(_.ClassName,_ClassName,value);
				this._ClassName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Minor
		{
			get{ return _Minor; }
			set
			{
				this.OnPropertyValueChange(_.Minor,_Minor,value);
				this._Minor=value;
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
				_.SRID,
				_.ATYID,
				_.examine,
				_.SequID,
				_.CCID,
				_.ClassName,
				_.Minor};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SRID,
				this._ATYID,
				this._examine,
				this._SequID,
				this._CCID,
				this._ClassName,
				this._Minor};
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
			public readonly static Field All = new Field("*","vw_StuReport_Examine");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SRID = new Field("SRID","vw_StuReport_Examine","SRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATYID = new Field("ATYID","vw_StuReport_Examine","ATYID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field examine = new Field("examine","vw_StuReport_Examine","examine");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SequID = new Field("SequID","vw_StuReport_Examine","SequID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_StuReport_Examine","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassName = new Field("ClassName","vw_StuReport_Examine","ClassName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Minor = new Field("Minor","vw_StuReport_Examine","Minor");
		}
		#endregion


	}
}
