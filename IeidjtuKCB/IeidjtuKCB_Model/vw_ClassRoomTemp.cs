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
	/// 实体类vw_ClassRoomTemp 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_ClassRoomTemp")]
	[Serializable]
	public partial class vw_ClassRoomTemp : Entity 
	{
		#region Model
		private int _CRID;
		private string _BuildName;
		private string _CRname;
		private string _Sort;
		private int? _PsNumber;
		private string _ActiveDesk;
		/// <summary>
		/// 
		/// </summary>
		public int CRID
		{
			get{ return _CRID; }
			set
			{
				this.OnPropertyValueChange(_.CRID,_CRID,value);
				this._CRID=value;
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
		public int? PsNumber
		{
			get{ return _PsNumber; }
			set
			{
				this.OnPropertyValueChange(_.PsNumber,_PsNumber,value);
				this._PsNumber=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ActiveDesk
		{
			get{ return _ActiveDesk; }
			set
			{
				this.OnPropertyValueChange(_.ActiveDesk,_ActiveDesk,value);
				this._ActiveDesk=value;
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
				_.CRID,
				_.BuildName,
				_.CRname,
				_.Sort,
				_.PsNumber,
				_.ActiveDesk};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._CRID,
				this._BuildName,
				this._CRname,
				this._Sort,
				this._PsNumber,
				this._ActiveDesk};
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
			public readonly static Field All = new Field("*","vw_ClassRoomTemp");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CRID = new Field("CRID","vw_ClassRoomTemp","CRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BuildName = new Field("BuildName","vw_ClassRoomTemp","BuildName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CRname = new Field("CRname","vw_ClassRoomTemp","CRname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sort = new Field("Sort","vw_ClassRoomTemp","Sort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PsNumber = new Field("PsNumber","vw_ClassRoomTemp","PsNumber");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ActiveDesk = new Field("ActiveDesk","vw_ClassRoomTemp","ActiveDesk");
		}
		#endregion


	}
}

