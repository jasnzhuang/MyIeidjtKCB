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
	/// 实体类CCTime 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("CCTime")]
	[Serializable]
	public partial class CCTime : Entity 
	{
		#region Model
		private int _CTID;
		private int? _Atyid;
		private int _CCID;
		private int? _Term;
		private int? _StartA;
		private int? _EndA;
		private int? _PerWeekA;
		private string _Onweek;
		private string _StartB;
		private string _EndB;
		private string _PerWeekB;
		private string _Memo;
		private int? _W1;
		private int? _W2;
		private int? _W3;
		private int? _W4;
		private int? _W5;
		private int? _W6;
		private int? _W7;
		private int? _W8;
		private int? _W9;
		private int? _W10;
		private int? _W11;
		private int? _W12;
		private int? _W13;
		private int? _W14;
		private int? _W15;
		private int? _W16;
		private int? _W18;
		private int? _W19;
		private int? _W20;
		private int? _W21;
		/// <summary>
		/// 
		/// </summary>
		public int CTID
		{
			get{ return _CTID; }
			set
			{
				this.OnPropertyValueChange(_.CTID,_CTID,value);
				this._CTID=value;
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
		public int CCID
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
		public int? Term
		{
			get{ return _Term; }
			set
			{
				this.OnPropertyValueChange(_.Term,_Term,value);
				this._Term=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StartA
		{
			get{ return _StartA; }
			set
			{
				this.OnPropertyValueChange(_.StartA,_StartA,value);
				this._StartA=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EndA
		{
			get{ return _EndA; }
			set
			{
				this.OnPropertyValueChange(_.EndA,_EndA,value);
				this._EndA=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PerWeekA
		{
			get{ return _PerWeekA; }
			set
			{
				this.OnPropertyValueChange(_.PerWeekA,_PerWeekA,value);
				this._PerWeekA=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Onweek
		{
			get{ return _Onweek; }
			set
			{
				this.OnPropertyValueChange(_.Onweek,_Onweek,value);
				this._Onweek=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StartB
		{
			get{ return _StartB; }
			set
			{
				this.OnPropertyValueChange(_.StartB,_StartB,value);
				this._StartB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EndB
		{
			get{ return _EndB; }
			set
			{
				this.OnPropertyValueChange(_.EndB,_EndB,value);
				this._EndB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PerWeekB
		{
			get{ return _PerWeekB; }
			set
			{
				this.OnPropertyValueChange(_.PerWeekB,_PerWeekB,value);
				this._PerWeekB=value;
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
		/// <summary>
		/// 
		/// </summary>
		public int? W1
		{
			get{ return _W1; }
			set
			{
				this.OnPropertyValueChange(_.W1,_W1,value);
				this._W1=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? W2
		{
			get{ return _W2; }
			set
			{
				this.OnPropertyValueChange(_.W2,_W2,value);
				this._W2=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? W3
		{
			get{ return _W3; }
			set
			{
				this.OnPropertyValueChange(_.W3,_W3,value);
				this._W3=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? W4
		{
			get{ return _W4; }
			set
			{
				this.OnPropertyValueChange(_.W4,_W4,value);
				this._W4=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? W5
		{
			get{ return _W5; }
			set
			{
				this.OnPropertyValueChange(_.W5,_W5,value);
				this._W5=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? W6
		{
			get{ return _W6; }
			set
			{
				this.OnPropertyValueChange(_.W6,_W6,value);
				this._W6=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? W7
		{
			get{ return _W7; }
			set
			{
				this.OnPropertyValueChange(_.W7,_W7,value);
				this._W7=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? W8
		{
			get{ return _W8; }
			set
			{
				this.OnPropertyValueChange(_.W8,_W8,value);
				this._W8=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? W9
		{
			get{ return _W9; }
			set
			{
				this.OnPropertyValueChange(_.W9,_W9,value);
				this._W9=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? W10
		{
			get{ return _W10; }
			set
			{
				this.OnPropertyValueChange(_.W10,_W10,value);
				this._W10=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? W11
		{
			get{ return _W11; }
			set
			{
				this.OnPropertyValueChange(_.W11,_W11,value);
				this._W11=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? W12
		{
			get{ return _W12; }
			set
			{
				this.OnPropertyValueChange(_.W12,_W12,value);
				this._W12=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? W13
		{
			get{ return _W13; }
			set
			{
				this.OnPropertyValueChange(_.W13,_W13,value);
				this._W13=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? W14
		{
			get{ return _W14; }
			set
			{
				this.OnPropertyValueChange(_.W14,_W14,value);
				this._W14=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? W15
		{
			get{ return _W15; }
			set
			{
				this.OnPropertyValueChange(_.W15,_W15,value);
				this._W15=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? W16
		{
			get{ return _W16; }
			set
			{
				this.OnPropertyValueChange(_.W16,_W16,value);
				this._W16=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? W18
		{
			get{ return _W18; }
			set
			{
				this.OnPropertyValueChange(_.W18,_W18,value);
				this._W18=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? W19
		{
			get{ return _W19; }
			set
			{
				this.OnPropertyValueChange(_.W19,_W19,value);
				this._W19=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? W20
		{
			get{ return _W20; }
			set
			{
				this.OnPropertyValueChange(_.W20,_W20,value);
				this._W20=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? W21
		{
			get{ return _W21; }
			set
			{
				this.OnPropertyValueChange(_.W21,_W21,value);
				this._W21=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.CTID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.CTID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.CTID,
				_.Atyid,
				_.CCID,
				_.Term,
				_.StartA,
				_.EndA,
				_.PerWeekA,
				_.Onweek,
				_.StartB,
				_.EndB,
				_.PerWeekB,
				_.Memo,
				_.W1,
				_.W2,
				_.W3,
				_.W4,
				_.W5,
				_.W6,
				_.W7,
				_.W8,
				_.W9,
				_.W10,
				_.W11,
				_.W12,
				_.W13,
				_.W14,
				_.W15,
				_.W16,
				_.W18,
				_.W19,
				_.W20,
				_.W21};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._CTID,
				this._Atyid,
				this._CCID,
				this._Term,
				this._StartA,
				this._EndA,
				this._PerWeekA,
				this._Onweek,
				this._StartB,
				this._EndB,
				this._PerWeekB,
				this._Memo,
				this._W1,
				this._W2,
				this._W3,
				this._W4,
				this._W5,
				this._W6,
				this._W7,
				this._W8,
				this._W9,
				this._W10,
				this._W11,
				this._W12,
				this._W13,
				this._W14,
				this._W15,
				this._W16,
				this._W18,
				this._W19,
				this._W20,
				this._W21};
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
			public readonly static Field All = new Field("*","CCTime");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CTID = new Field("CTID","CCTime","CTID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("atyid","CCTime","atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","CCTime","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Term = new Field("Term","CCTime","Term");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StartA = new Field("StartA","CCTime","StartA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EndA = new Field("EndA","CCTime","EndA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PerWeekA = new Field("PerWeekA","CCTime","PerWeekA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Onweek = new Field("Onweek","CCTime","Onweek");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StartB = new Field("StartB","CCTime","StartB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EndB = new Field("EndB","CCTime","EndB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PerWeekB = new Field("PerWeekB","CCTime","PerWeekB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","CCTime","Memo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W1 = new Field("w1","CCTime","w1");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W2 = new Field("W2","CCTime","W2");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W3 = new Field("W3","CCTime","W3");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W4 = new Field("W4","CCTime","W4");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W5 = new Field("W5","CCTime","W5");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W6 = new Field("W6","CCTime","W6");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W7 = new Field("W7","CCTime","W7");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W8 = new Field("W8","CCTime","W8");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W9 = new Field("W9","CCTime","W9");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W10 = new Field("W10","CCTime","W10");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W11 = new Field("W11","CCTime","W11");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W12 = new Field("W12","CCTime","W12");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W13 = new Field("W13","CCTime","W13");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W14 = new Field("W14","CCTime","W14");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W15 = new Field("W15","CCTime","W15");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W16 = new Field("W16","CCTime","W16");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W18 = new Field("W18","CCTime","W18");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W19 = new Field("W19","CCTime","W19");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W20 = new Field("W20","CCTime","W20");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field W21 = new Field("W21","CCTime","W21");
		}
		#endregion


	}
}

