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
	/// 实体类vw_Singl_PK 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Singl_PK")]
	[Serializable]
	public partial class vw_Singl_PK : Entity 
	{
		#region Model
		private int? _CCNum;
		private int? _CCID;
		private string _课程名称;
		/// <summary>
		/// 
		/// </summary>
		public int? CCNum
		{
			get{ return _CCNum; }
			set
			{
				this.OnPropertyValueChange(_.CCNum,_CCNum,value);
				this._CCNum=value;
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
		public string 课程名称
		{
			get{ return _课程名称; }
			set
			{
				this.OnPropertyValueChange(_.课程名称,_课程名称,value);
				this._课程名称=value;
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
				_.CCNum,
				_.CCID,
				_.课程名称};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._CCNum,
				this._CCID,
				this._课程名称};
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
			public readonly static Field All = new Field("*","vw_Singl_PK");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCNum = new Field("CCNum","vw_Singl_PK","CCNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_Singl_PK","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 课程名称 = new Field("课程名称","vw_Singl_PK","课程名称");
		}
		#endregion


	}
}

