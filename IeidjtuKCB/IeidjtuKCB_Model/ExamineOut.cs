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
	/// 实体类ExamineOut 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("ExamineOut")]
	[Serializable]
	public partial class ExamineOut : Entity 
	{
		#region Model
		private int _ID;
		private int? _EMID;
		private int? _Stdid;
		private string _学号;
		private string _姓名;
		private string _性别;
		private string _年级;
		private string _校区;
		private string _学院;
		private string _系别;
		private string _专业;
		private int _学制;
		private string _入学年份;
		private string _身份证号;
		private string _是否通过;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID,_ID,value);
				this._ID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EMID
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
		public int? Stdid
		{
			get{ return _Stdid; }
			set
			{
				this.OnPropertyValueChange(_.Stdid,_Stdid,value);
				this._Stdid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 学号
		{
			get{ return _学号; }
			set
			{
				this.OnPropertyValueChange(_.学号,_学号,value);
				this._学号=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 姓名
		{
			get{ return _姓名; }
			set
			{
				this.OnPropertyValueChange(_.姓名,_姓名,value);
				this._姓名=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 性别
		{
			get{ return _性别; }
			set
			{
				this.OnPropertyValueChange(_.性别,_性别,value);
				this._性别=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 年级
		{
			get{ return _年级; }
			set
			{
				this.OnPropertyValueChange(_.年级,_年级,value);
				this._年级=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 校区
		{
			get{ return _校区; }
			set
			{
				this.OnPropertyValueChange(_.校区,_校区,value);
				this._校区=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 学院
		{
			get{ return _学院; }
			set
			{
				this.OnPropertyValueChange(_.学院,_学院,value);
				this._学院=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 系别
		{
			get{ return _系别; }
			set
			{
				this.OnPropertyValueChange(_.系别,_系别,value);
				this._系别=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 专业
		{
			get{ return _专业; }
			set
			{
				this.OnPropertyValueChange(_.专业,_专业,value);
				this._专业=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int 学制
		{
			get{ return _学制; }
			set
			{
				this.OnPropertyValueChange(_.学制,_学制,value);
				this._学制=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 入学年份
		{
			get{ return _入学年份; }
			set
			{
				this.OnPropertyValueChange(_.入学年份,_入学年份,value);
				this._入学年份=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 身份证号
		{
			get{ return _身份证号; }
			set
			{
				this.OnPropertyValueChange(_.身份证号,_身份证号,value);
				this._身份证号=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 是否通过
		{
			get{ return _是否通过; }
			set
			{
				this.OnPropertyValueChange(_.是否通过,_是否通过,value);
				this._是否通过=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.ID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.ID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ID,
				_.EMID,
				_.Stdid,
				_.学号,
				_.姓名,
				_.性别,
				_.年级,
				_.校区,
				_.学院,
				_.系别,
				_.专业,
				_.学制,
				_.入学年份,
				_.身份证号,
				_.是否通过};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._EMID,
				this._Stdid,
				this._学号,
				this._姓名,
				this._性别,
				this._年级,
				this._校区,
				this._学院,
				this._系别,
				this._专业,
				this._学制,
				this._入学年份,
				this._身份证号,
				this._是否通过};
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
			public readonly static Field All = new Field("*","ExamineOut");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID","ExamineOut","ID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMID = new Field("EMID","ExamineOut","EMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdid = new Field("stdid","ExamineOut","stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学号 = new Field("学号","ExamineOut","学号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 姓名 = new Field("姓名","ExamineOut","姓名");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 性别 = new Field("性别","ExamineOut","性别");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 年级 = new Field("年级","ExamineOut","年级");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 校区 = new Field("校区","ExamineOut","校区");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学院 = new Field("学院","ExamineOut","学院");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 系别 = new Field("系别","ExamineOut","系别");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 专业 = new Field("专业","ExamineOut","专业");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学制 = new Field("学制","ExamineOut","学制");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 入学年份 = new Field("入学年份","ExamineOut","入学年份");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 身份证号 = new Field("身份证号","ExamineOut","身份证号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 是否通过 = new Field("是否通过","ExamineOut","是否通过");
		}
		#endregion


	}
}
