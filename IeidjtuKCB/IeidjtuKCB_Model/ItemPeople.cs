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
	/// 实体类ItemPeople 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("ItemPeople")]
	[Serializable]
	public partial class ItemPeople : Entity 
	{
		#region Model
		private int _IPID;
		private int? _ITID;
		private int? _PSID;
		private int? _Num;
		private string _Oper;
		private string _ChkOper;
		private string _RtufileOper;
		private string _State;
		/// <summary>
		/// 
		/// </summary>
		public int IPID
		{
			get{ return _IPID; }
			set
			{
				this.OnPropertyValueChange(_.IPID,_IPID,value);
				this._IPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ITID
		{
			get{ return _ITID; }
			set
			{
				this.OnPropertyValueChange(_.ITID,_ITID,value);
				this._ITID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PSID
		{
			get{ return _PSID; }
			set
			{
				this.OnPropertyValueChange(_.PSID,_PSID,value);
				this._PSID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Num
		{
			get{ return _Num; }
			set
			{
				this.OnPropertyValueChange(_.Num,_Num,value);
				this._Num=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Oper
		{
			get{ return _Oper; }
			set
			{
				this.OnPropertyValueChange(_.Oper,_Oper,value);
				this._Oper=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChkOper
		{
			get{ return _ChkOper; }
			set
			{
				this.OnPropertyValueChange(_.ChkOper,_ChkOper,value);
				this._ChkOper=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RtufileOper
		{
			get{ return _RtufileOper; }
			set
			{
				this.OnPropertyValueChange(_.RtufileOper,_RtufileOper,value);
				this._RtufileOper=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string State
		{
			get{ return _State; }
			set
			{
				this.OnPropertyValueChange(_.State,_State,value);
				this._State=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.IPID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.IPID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.IPID,
				_.ITID,
				_.PSID,
				_.Num,
				_.Oper,
				_.ChkOper,
				_.RtufileOper,
				_.State};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._IPID,
				this._ITID,
				this._PSID,
				this._Num,
				this._Oper,
				this._ChkOper,
				this._RtufileOper,
				this._State};
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
			public readonly static Field All = new Field("*","ItemPeople");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IPID = new Field("IPID","ItemPeople","IPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ITID = new Field("ITID","ItemPeople","ITID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","ItemPeople","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Num = new Field("Num","ItemPeople","Num");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oper = new Field("Oper","ItemPeople","Oper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ChkOper = new Field("ChkOper","ItemPeople","ChkOper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RtufileOper = new Field("RtufileOper","ItemPeople","RtufileOper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","ItemPeople","State");
		}
		#endregion


	}
}

