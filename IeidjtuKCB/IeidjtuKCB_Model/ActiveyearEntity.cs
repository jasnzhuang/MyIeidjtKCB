﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Support: http://www.cnblogs.com/huxj
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
    /// 实体类Activeyear 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("Activeyear")]
    public partial class Activeyear : Entity
    {
        #region Model
        private int _ATID;
        private int? _ATNo;
        private int? _YearName;
        private string _ATName;
        private string _Memo;
        private string _State;
        private string _XKstate;
        private string _PKstate;
        private string _Regstate;
        private DateTime? _Startdate;
        private DateTime? _Enddate;
        private int? _Weeks;
        private string _Process;
        private string _Appstate;
        private string _RsState;
        private string _CJState;
        /// <summary>
        /// 
        /// </summary>
        public int ATID
        {
            get { return _ATID; }
            set
            {
                this.OnPropertyValueChange(_.ATID, _ATID, value);
                this._ATID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ATNo
        {
            get { return _ATNo; }
            set
            {
                this.OnPropertyValueChange(_.ATNo, _ATNo, value);
                this._ATNo = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? YearName
        {
            get { return _YearName; }
            set
            {
                this.OnPropertyValueChange(_.YearName, _YearName, value);
                this._YearName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ATName
        {
            get { return _ATName; }
            set
            {
                this.OnPropertyValueChange(_.ATName, _ATName, value);
                this._ATName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Memo
        {
            get { return _Memo; }
            set
            {
                this.OnPropertyValueChange(_.Memo, _Memo, value);
                this._Memo = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string State
        {
            get { return _State; }
            set
            {
                this.OnPropertyValueChange(_.State, _State, value);
                this._State = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string XKstate
        {
            get { return _XKstate; }
            set
            {
                this.OnPropertyValueChange(_.XKstate, _XKstate, value);
                this._XKstate = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PKstate
        {
            get { return _PKstate; }
            set
            {
                this.OnPropertyValueChange(_.PKstate, _PKstate, value);
                this._PKstate = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Regstate
        {
            get { return _Regstate; }
            set
            {
                this.OnPropertyValueChange(_.Regstate, _Regstate, value);
                this._Regstate = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Startdate
        {
            get { return _Startdate; }
            set
            {
                this.OnPropertyValueChange(_.Startdate, _Startdate, value);
                this._Startdate = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Enddate
        {
            get { return _Enddate; }
            set
            {
                this.OnPropertyValueChange(_.Enddate, _Enddate, value);
                this._Enddate = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Weeks
        {
            get { return _Weeks; }
            set
            {
                this.OnPropertyValueChange(_.Weeks, _Weeks, value);
                this._Weeks = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Process
        {
            get { return _Process; }
            set
            {
                this.OnPropertyValueChange(_.Process, _Process, value);
                this._Process = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Appstate
        {
            get { return _Appstate; }
            set
            {
                this.OnPropertyValueChange(_.Appstate, _Appstate, value);
                this._Appstate = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RsState
        {
            get { return _RsState; }
            set
            {
                this.OnPropertyValueChange(_.RsState, _RsState, value);
                this._RsState = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CJState
        {
            get { return _CJState; }
            set
            {
                this.OnPropertyValueChange(_.CJState, _CJState, value);
                this._CJState = value;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        public override Field GetIdentityField()
        {
            return _.ATID;
        }
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
                _.ATID};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.ATID,
                _.ATNo,
                _.YearName,
                _.ATName,
                _.Memo,
                _.State,
                _.XKstate,
                _.PKstate,
                _.Regstate,
                _.Startdate,
                _.Enddate,
                _.Weeks,
                _.Process,
                _.Appstate,
                _.RsState,
                _.CJState};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._ATID,
                this._ATNo,
                this._YearName,
                this._ATName,
                this._Memo,
                this._State,
                this._XKstate,
                this._PKstate,
                this._Regstate,
                this._Startdate,
                this._Enddate,
                this._Weeks,
                this._Process,
                this._Appstate,
                this._RsState,
                this._CJState};
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
            public readonly static Field All = new Field("*", "Activeyear");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ATID = new Field("ATID", "Activeyear", "ATID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ATNo = new Field("ATNo", "Activeyear", "ATNo");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field YearName = new Field("YearName", "Activeyear", "YearName");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ATName = new Field("ATName", "Activeyear", "ATName");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Memo = new Field("Memo", "Activeyear", "Memo");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field State = new Field("State", "Activeyear", "State");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field XKstate = new Field("XKstate", "Activeyear", "XKstate");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PKstate = new Field("PKstate", "Activeyear", "PKstate");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Regstate = new Field("Regstate", "Activeyear", "Regstate");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Startdate = new Field("Startdate", "Activeyear", "Startdate");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Enddate = new Field("Enddate", "Activeyear", "Enddate");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Weeks = new Field("Weeks", "Activeyear", "Weeks");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Process = new Field("Process", "Activeyear", "Process");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Appstate = new Field("Appstate", "Activeyear", "Appstate");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RsState = new Field("RsState", "Activeyear", "RsState");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CJState = new Field("CJState", "Activeyear", "CJState");
        }
        #endregion


    }
}

