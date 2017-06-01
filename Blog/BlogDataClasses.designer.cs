﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Blog
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Blog")]
	public partial class BlogDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertClass(Class instance);
    partial void UpdateClass(Class instance);
    partial void DeleteClass(Class instance);
    partial void InsertMessage(Message instance);
    partial void UpdateMessage(Message instance);
    partial void DeleteMessage(Message instance);
    partial void InsertNews(News instance);
    partial void UpdateNews(News instance);
    partial void DeleteNews(News instance);
    partial void InsertPhoto(Photo instance);
    partial void UpdatePhoto(Photo instance);
    partial void DeletePhoto(Photo instance);
    partial void InsertRegister(Register instance);
    partial void UpdateRegister(Register instance);
    partial void DeleteRegister(Register instance);
    #endregion
		
		public BlogDataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BlogConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BlogDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BlogDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BlogDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BlogDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Class> Class
		{
			get
			{
				return this.GetTable<Class>();
			}
		}
		
		public System.Data.Linq.Table<Message> Message
		{
			get
			{
				return this.GetTable<Message>();
			}
		}
		
		public System.Data.Linq.Table<News> News
		{
			get
			{
				return this.GetTable<News>();
			}
		}
		
		public System.Data.Linq.Table<Photo> Photo
		{
			get
			{
				return this.GetTable<Photo>();
			}
		}
		
		public System.Data.Linq.Table<Register> Register
		{
			get
			{
				return this.GetTable<Register>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Class")]
	public partial class Class : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Class_id;
		
		private string _Class_name;
		
		private System.Nullable<System.DateTime> _AddDate;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnClass_idChanging(int value);
    partial void OnClass_idChanged();
    partial void OnClass_nameChanging(string value);
    partial void OnClass_nameChanged();
    partial void OnAddDateChanging(System.Nullable<System.DateTime> value);
    partial void OnAddDateChanged();
    #endregion
		
		public Class()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Class_id
		{
			get
			{
				return this._Class_id;
			}
			set
			{
				if ((this._Class_id != value))
				{
					this.OnClass_idChanging(value);
					this.SendPropertyChanging();
					this._Class_id = value;
					this.SendPropertyChanged("Class_id");
					this.OnClass_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class_name", DbType="NVarChar(30)")]
		public string Class_name
		{
			get
			{
				return this._Class_name;
			}
			set
			{
				if ((this._Class_name != value))
				{
					this.OnClass_nameChanging(value);
					this.SendPropertyChanging();
					this._Class_name = value;
					this.SendPropertyChanged("Class_name");
					this.OnClass_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> AddDate
		{
			get
			{
				return this._AddDate;
			}
			set
			{
				if ((this._AddDate != value))
				{
					this.OnAddDateChanging(value);
					this.SendPropertyChanging();
					this._AddDate = value;
					this.SendPropertyChanged("AddDate");
					this.OnAddDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Message")]
	public partial class Message : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _UserName;
		
		private System.Nullable<System.DateTime> _date;
		
		private string _icon;
		
		private string _body;
		
		private string _face;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OndateChanging(System.Nullable<System.DateTime> value);
    partial void OndateChanged();
    partial void OniconChanging(string value);
    partial void OniconChanged();
    partial void OnbodyChanging(string value);
    partial void OnbodyChanged();
    partial void OnfaceChanging(string value);
    partial void OnfaceChanged();
    #endregion
		
		public Message()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(20)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_icon", DbType="VarChar(50)")]
		public string icon
		{
			get
			{
				return this._icon;
			}
			set
			{
				if ((this._icon != value))
				{
					this.OniconChanging(value);
					this.SendPropertyChanging();
					this._icon = value;
					this.SendPropertyChanged("icon");
					this.OniconChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_body", DbType="VarChar(100)")]
		public string body
		{
			get
			{
				return this._body;
			}
			set
			{
				if ((this._body != value))
				{
					this.OnbodyChanging(value);
					this.SendPropertyChanging();
					this._body = value;
					this.SendPropertyChanged("body");
					this.OnbodyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_face", DbType="VarChar(50)")]
		public string face
		{
			get
			{
				return this._face;
			}
			set
			{
				if ((this._face != value))
				{
					this.OnfaceChanging(value);
					this.SendPropertyChanging();
					this._face = value;
					this.SendPropertyChanged("face");
					this.OnfaceChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.News")]
	public partial class News : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _News_id;
		
		private string _Title;
		
		private string _Body;
		
		private System.Nullable<System.DateTime> _AddDate;
		
		private System.Nullable<int> _Click;
		
		private System.Nullable<int> _Re;
		
		private string _Class;
		
		private System.Nullable<bool> _IsSave;
		
		private System.Nullable<bool> _IsDel;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNews_idChanging(int value);
    partial void OnNews_idChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnBodyChanging(string value);
    partial void OnBodyChanged();
    partial void OnAddDateChanging(System.Nullable<System.DateTime> value);
    partial void OnAddDateChanged();
    partial void OnClickChanging(System.Nullable<int> value);
    partial void OnClickChanged();
    partial void OnReChanging(System.Nullable<int> value);
    partial void OnReChanged();
    partial void OnClassChanging(string value);
    partial void OnClassChanged();
    partial void OnIsSaveChanging(System.Nullable<bool> value);
    partial void OnIsSaveChanged();
    partial void OnIsDelChanging(System.Nullable<bool> value);
    partial void OnIsDelChanged();
    #endregion
		
		public News()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_News_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int News_id
		{
			get
			{
				return this._News_id;
			}
			set
			{
				if ((this._News_id != value))
				{
					this.OnNews_idChanging(value);
					this.SendPropertyChanging();
					this._News_id = value;
					this.SendPropertyChanged("News_id");
					this.OnNews_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(30)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Body", DbType="NVarChar(3000)")]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this.OnBodyChanging(value);
					this.SendPropertyChanging();
					this._Body = value;
					this.SendPropertyChanged("Body");
					this.OnBodyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> AddDate
		{
			get
			{
				return this._AddDate;
			}
			set
			{
				if ((this._AddDate != value))
				{
					this.OnAddDateChanging(value);
					this.SendPropertyChanging();
					this._AddDate = value;
					this.SendPropertyChanged("AddDate");
					this.OnAddDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Click", DbType="Int")]
		public System.Nullable<int> Click
		{
			get
			{
				return this._Click;
			}
			set
			{
				if ((this._Click != value))
				{
					this.OnClickChanging(value);
					this.SendPropertyChanging();
					this._Click = value;
					this.SendPropertyChanged("Click");
					this.OnClickChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Re", DbType="Int")]
		public System.Nullable<int> Re
		{
			get
			{
				return this._Re;
			}
			set
			{
				if ((this._Re != value))
				{
					this.OnReChanging(value);
					this.SendPropertyChanging();
					this._Re = value;
					this.SendPropertyChanged("Re");
					this.OnReChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class", DbType="NVarChar(15)")]
		public string Class
		{
			get
			{
				return this._Class;
			}
			set
			{
				if ((this._Class != value))
				{
					this.OnClassChanging(value);
					this.SendPropertyChanging();
					this._Class = value;
					this.SendPropertyChanged("Class");
					this.OnClassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsSave", DbType="Bit")]
		public System.Nullable<bool> IsSave
		{
			get
			{
				return this._IsSave;
			}
			set
			{
				if ((this._IsSave != value))
				{
					this.OnIsSaveChanging(value);
					this.SendPropertyChanging();
					this._IsSave = value;
					this.SendPropertyChanged("IsSave");
					this.OnIsSaveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsDel", DbType="Bit")]
		public System.Nullable<bool> IsDel
		{
			get
			{
				return this._IsDel;
			}
			set
			{
				if ((this._IsDel != value))
				{
					this.OnIsDelChanging(value);
					this.SendPropertyChanging();
					this._IsDel = value;
					this.SendPropertyChanged("IsDel");
					this.OnIsDelChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Photo")]
	public partial class Photo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _photo_id;
		
		private string _Title;
		
		private string _Info;
		
		private System.Nullable<System.DateTime> _AddDate;
		
		private string _Url;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onphoto_idChanging(int value);
    partial void Onphoto_idChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnInfoChanging(string value);
    partial void OnInfoChanged();
    partial void OnAddDateChanging(System.Nullable<System.DateTime> value);
    partial void OnAddDateChanged();
    partial void OnUrlChanging(string value);
    partial void OnUrlChanged();
    #endregion
		
		public Photo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_photo_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int photo_id
		{
			get
			{
				return this._photo_id;
			}
			set
			{
				if ((this._photo_id != value))
				{
					this.Onphoto_idChanging(value);
					this.SendPropertyChanging();
					this._photo_id = value;
					this.SendPropertyChanged("photo_id");
					this.Onphoto_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(50)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Info", DbType="VarChar(50)")]
		public string Info
		{
			get
			{
				return this._Info;
			}
			set
			{
				if ((this._Info != value))
				{
					this.OnInfoChanging(value);
					this.SendPropertyChanging();
					this._Info = value;
					this.SendPropertyChanged("Info");
					this.OnInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> AddDate
		{
			get
			{
				return this._AddDate;
			}
			set
			{
				if ((this._AddDate != value))
				{
					this.OnAddDateChanging(value);
					this.SendPropertyChanging();
					this._AddDate = value;
					this.SendPropertyChanged("AddDate");
					this.OnAddDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Url", DbType="VarChar(50)")]
		public string Url
		{
			get
			{
				return this._Url;
			}
			set
			{
				if ((this._Url != value))
				{
					this.OnUrlChanging(value);
					this.SendPropertyChanging();
					this._Url = value;
					this.SendPropertyChanged("Url");
					this.OnUrlChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Register")]
	public partial class Register : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _user_id;
		
		private string _user_name;
		
		private string _password;
		
		private string _sendpassword;
		
		private string _question;
		
		private string _answer;
		
		private string _email;
		
		private string _relname;
		
		private string _address;
		
		private int _age;
		
		private string _sex;
		
		private string _phone;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onuser_idChanging(int value);
    partial void Onuser_idChanged();
    partial void Onuser_nameChanging(string value);
    partial void Onuser_nameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnsendpasswordChanging(string value);
    partial void OnsendpasswordChanged();
    partial void OnquestionChanging(string value);
    partial void OnquestionChanged();
    partial void OnanswerChanging(string value);
    partial void OnanswerChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnrelnameChanging(string value);
    partial void OnrelnameChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OnageChanging(int value);
    partial void OnageChanged();
    partial void OnsexChanging(string value);
    partial void OnsexChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    #endregion
		
		public Register()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_name", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string user_name
		{
			get
			{
				return this._user_name;
			}
			set
			{
				if ((this._user_name != value))
				{
					this.Onuser_nameChanging(value);
					this.SendPropertyChanging();
					this._user_name = value;
					this.SendPropertyChanged("user_name");
					this.Onuser_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sendpassword", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string sendpassword
		{
			get
			{
				return this._sendpassword;
			}
			set
			{
				if ((this._sendpassword != value))
				{
					this.OnsendpasswordChanging(value);
					this.SendPropertyChanging();
					this._sendpassword = value;
					this.SendPropertyChanged("sendpassword");
					this.OnsendpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_question", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string question
		{
			get
			{
				return this._question;
			}
			set
			{
				if ((this._question != value))
				{
					this.OnquestionChanging(value);
					this.SendPropertyChanging();
					this._question = value;
					this.SendPropertyChanged("question");
					this.OnquestionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_answer", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string answer
		{
			get
			{
				return this._answer;
			}
			set
			{
				if ((this._answer != value))
				{
					this.OnanswerChanging(value);
					this.SendPropertyChanging();
					this._answer = value;
					this.SendPropertyChanged("answer");
					this.OnanswerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(15)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_relname", DbType="VarChar(15)")]
		public string relname
		{
			get
			{
				return this._relname;
			}
			set
			{
				if ((this._relname != value))
				{
					this.OnrelnameChanging(value);
					this.SendPropertyChanging();
					this._relname = value;
					this.SendPropertyChanged("relname");
					this.OnrelnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="VarChar(200)")]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_age", DbType="Int NOT NULL")]
		public int age
		{
			get
			{
				return this._age;
			}
			set
			{
				if ((this._age != value))
				{
					this.OnageChanging(value);
					this.SendPropertyChanging();
					this._age = value;
					this.SendPropertyChanged("age");
					this.OnageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sex", DbType="Char(2)")]
		public string sex
		{
			get
			{
				return this._sex;
			}
			set
			{
				if ((this._sex != value))
				{
					this.OnsexChanging(value);
					this.SendPropertyChanging();
					this._sex = value;
					this.SendPropertyChanged("sex");
					this.OnsexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
