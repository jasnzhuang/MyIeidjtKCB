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
	/// 实体类Uploadfile 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("uploadfile")]
	[Serializable]
	public partial class Uploadfile : Entity 
	{
		#region Model
		private int _FFid;
		private string _GLCode;
		private string _FILETITLE;
		private string _FILEDESC;
		private string _FILETYPE;
		private string _FILECONTENTTYPE;
		private string _FILEPATH;
		private string _M_Filename;
		private int? _FILESIZE;
		private int? _HITS;
		private DateTime? _UploadTime;
		/// <summary>
		/// 
		/// </summary>
		public int FFid
		{
			get{ return _FFid; }
			set
			{
				this.OnPropertyValueChange(_.FFid,_FFid,value);
				this._FFid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLCode
		{
			get{ return _GLCode; }
			set
			{
				this.OnPropertyValueChange(_.GLCode,_GLCode,value);
				this._GLCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FILETITLE
		{
			get{ return _FILETITLE; }
			set
			{
				this.OnPropertyValueChange(_.FILETITLE,_FILETITLE,value);
				this._FILETITLE=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FILEDESC
		{
			get{ return _FILEDESC; }
			set
			{
				this.OnPropertyValueChange(_.FILEDESC,_FILEDESC,value);
				this._FILEDESC=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FILETYPE
		{
			get{ return _FILETYPE; }
			set
			{
				this.OnPropertyValueChange(_.FILETYPE,_FILETYPE,value);
				this._FILETYPE=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FILECONTENTTYPE
		{
			get{ return _FILECONTENTTYPE; }
			set
			{
				this.OnPropertyValueChange(_.FILECONTENTTYPE,_FILECONTENTTYPE,value);
				this._FILECONTENTTYPE=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FILEPATH
		{
			get{ return _FILEPATH; }
			set
			{
				this.OnPropertyValueChange(_.FILEPATH,_FILEPATH,value);
				this._FILEPATH=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_Filename
		{
			get{ return _M_Filename; }
			set
			{
				this.OnPropertyValueChange(_.M_Filename,_M_Filename,value);
				this._M_Filename=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FILESIZE
		{
			get{ return _FILESIZE; }
			set
			{
				this.OnPropertyValueChange(_.FILESIZE,_FILESIZE,value);
				this._FILESIZE=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? HITS
		{
			get{ return _HITS; }
			set
			{
				this.OnPropertyValueChange(_.HITS,_HITS,value);
				this._HITS=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UploadTime
		{
			get{ return _UploadTime; }
			set
			{
				this.OnPropertyValueChange(_.UploadTime,_UploadTime,value);
				this._UploadTime=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.FFid};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.FFid,
				_.GLCode,
				_.FILETITLE,
				_.FILEDESC,
				_.FILETYPE,
				_.FILECONTENTTYPE,
				_.FILEPATH,
				_.M_Filename,
				_.FILESIZE,
				_.HITS,
				_.UploadTime};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._FFid,
				this._GLCode,
				this._FILETITLE,
				this._FILEDESC,
				this._FILETYPE,
				this._FILECONTENTTYPE,
				this._FILEPATH,
				this._M_Filename,
				this._FILESIZE,
				this._HITS,
				this._UploadTime};
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
			public readonly static Field All = new Field("*","uploadfile");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FFid = new Field("FFid","uploadfile","FFid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GLCode = new Field("GLCode","uploadfile","GLCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FILETITLE = new Field("FILETITLE","uploadfile","FILETITLE");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FILEDESC = new Field("FILEDESC","uploadfile","FILEDESC");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FILETYPE = new Field("FILETYPE","uploadfile","FILETYPE");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FILECONTENTTYPE = new Field("FILECONTENTTYPE","uploadfile","FILECONTENTTYPE");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FILEPATH = new Field("FILEPATH","uploadfile","FILEPATH");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M_Filename = new Field("m_Filename","uploadfile","m_Filename");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FILESIZE = new Field("FILESIZE","uploadfile","FILESIZE");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HITS = new Field("HITS","uploadfile","HITS");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UploadTime = new Field("UploadTime","uploadfile","UploadTime");
		}
		#endregion


	}
}

