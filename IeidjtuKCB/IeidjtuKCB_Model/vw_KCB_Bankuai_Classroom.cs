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
	/// 实体类vw_KCB_Bankuai_Classroom 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_KCB_Bankuai_Classroom")]
	[Serializable]
	public partial class vw_KCB_Bankuai_Classroom : Entity 
	{
		#region Model
		private int _KBCID;
		private int? _CRIDA;
		private int? _CRIDB;
		private string _CRnameA;
		private string _CRnameB;
		private int? _CCID;
		private int? _ATYID;
		/// <summary>
		/// 
		/// </summary>
		public int KBCID
		{
			get{ return _KBCID; }
			set
			{
				this.OnPropertyValueChange(_.KBCID,_KBCID,value);
				this._KBCID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CRIDA
		{
			get{ return _CRIDA; }
			set
			{
				this.OnPropertyValueChange(_.CRIDA,_CRIDA,value);
				this._CRIDA=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CRIDB
		{
			get{ return _CRIDB; }
			set
			{
				this.OnPropertyValueChange(_.CRIDB,_CRIDB,value);
				this._CRIDB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CRnameA
		{
			get{ return _CRnameA; }
			set
			{
				this.OnPropertyValueChange(_.CRnameA,_CRnameA,value);
				this._CRnameA=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CRnameB
		{
			get{ return _CRnameB; }
			set
			{
				this.OnPropertyValueChange(_.CRnameB,_CRnameB,value);
				this._CRnameB=value;
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
		public int? ATYID
		{
			get{ return _ATYID; }
			set
			{
				this.OnPropertyValueChange(_.ATYID,_ATYID,value);
				this._ATYID=value;
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
				_.KBCID,
				_.CRIDA,
				_.CRIDB,
				_.CRnameA,
				_.CRnameB,
				_.CCID,
				_.ATYID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._KBCID,
				this._CRIDA,
				this._CRIDB,
				this._CRnameA,
				this._CRnameB,
				this._CCID,
				this._ATYID};
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
			public readonly static Field All = new Field("*","vw_KCB_Bankuai_Classroom");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KBCID = new Field("KBCID","vw_KCB_Bankuai_Classroom","KBCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CRIDA = new Field("CRIDA","vw_KCB_Bankuai_Classroom","CRIDA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CRIDB = new Field("CRIDB","vw_KCB_Bankuai_Classroom","CRIDB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CRnameA = new Field("CRnameA","vw_KCB_Bankuai_Classroom","CRnameA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CRnameB = new Field("CRnameB","vw_KCB_Bankuai_Classroom","CRnameB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_KCB_Bankuai_Classroom","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATYID = new Field("ATYID","vw_KCB_Bankuai_Classroom","ATYID");
		}
		#endregion


	}
}

