﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace JN.ESB.Scheduler.DataAccess
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EsbSchedulerDB")]
	public partial class SchedulerDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertESB_SCHD(ESB_SCHD instance);
    partial void UpdateESB_SCHD(ESB_SCHD instance);
    partial void DeleteESB_SCHD(ESB_SCHD instance);
    partial void InsertESB_SCHD_EsbWS(ESB_SCHD_EsbWS instance);
    partial void UpdateESB_SCHD_EsbWS(ESB_SCHD_EsbWS instance);
    partial void DeleteESB_SCHD_EsbWS(ESB_SCHD_EsbWS instance);
    partial void InsertESB_SCHD_HISTORY(ESB_SCHD_HISTORY instance);
    partial void UpdateESB_SCHD_HISTORY(ESB_SCHD_HISTORY instance);
    partial void DeleteESB_SCHD_HISTORY(ESB_SCHD_HISTORY instance);
    partial void InsertESB_SCHD_HISTORY_VIEW(ESB_SCHD_HISTORY_VIEW instance);
    partial void UpdateESB_SCHD_HISTORY_VIEW(ESB_SCHD_HISTORY_VIEW instance);
    partial void DeleteESB_SCHD_HISTORY_VIEW(ESB_SCHD_HISTORY_VIEW instance);
    #endregion
		
		public SchedulerDataClassesDataContext() : 
				base(global::JN.ESB.Scheduler.DataAccess.Properties.Settings.Default.EsbSchedulerDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SchedulerDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SchedulerDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SchedulerDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SchedulerDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ESB_SCHD> ESB_SCHD
		{
			get
			{
				return this.GetTable<ESB_SCHD>();
			}
		}
		
		public System.Data.Linq.Table<ESB_SCHD_EsbWS> ESB_SCHD_EsbWS
		{
			get
			{
				return this.GetTable<ESB_SCHD_EsbWS>();
			}
		}
		
		public System.Data.Linq.Table<ESB_SCHD_HISTORY> ESB_SCHD_HISTORY
		{
			get
			{
				return this.GetTable<ESB_SCHD_HISTORY>();
			}
		}
		
		public System.Data.Linq.Table<ESB_SCHD_HISTORY_VIEW> ESB_SCHD_HISTORY_VIEW
		{
			get
			{
				return this.GetTable<ESB_SCHD_HISTORY_VIEW>();
			}
		}
		
		public System.Data.Linq.Table<ESB_SCHD_VIEW> ESB_SCHD_VIEW
		{
			get
			{
				return this.GetTable<ESB_SCHD_VIEW>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ESB_SCHD")]
	public partial class ESB_SCHD : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _SCHD_ID;
		
		private string _TRIG_NAME;
		
		private string _TRIG_GROUP;
		
		private string _SCHD_NAME;
		
		private string _SCHD_DESC;
		
		private string _START_TIME;
		
		private string _END_TIME;
		
		private string _SCHD_FREQ;
		
		private System.Guid _SCHD_HOST;
		
		private string _SCHD_TIME;
		
		private string _SCHD_USER;
		
		private string _SCHD_CRON;
		
		private string _JOB_NAME;
		
		private string _HOST_NAME;
		
		private EntitySet<ESB_SCHD_EsbWS> _ESB_SCHD_EsbWS;
		
		private EntitySet<ESB_SCHD_HISTORY> _ESB_SCHD_HISTORY;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSCHD_IDChanging(string value);
    partial void OnSCHD_IDChanged();
    partial void OnTRIG_NAMEChanging(string value);
    partial void OnTRIG_NAMEChanged();
    partial void OnTRIG_GROUPChanging(string value);
    partial void OnTRIG_GROUPChanged();
    partial void OnSCHD_NAMEChanging(string value);
    partial void OnSCHD_NAMEChanged();
    partial void OnSCHD_DESCChanging(string value);
    partial void OnSCHD_DESCChanged();
    partial void OnSTART_TIMEChanging(string value);
    partial void OnSTART_TIMEChanged();
    partial void OnEND_TIMEChanging(string value);
    partial void OnEND_TIMEChanged();
    partial void OnSCHD_FREQChanging(string value);
    partial void OnSCHD_FREQChanged();
    partial void OnSCHD_HOSTChanging(System.Guid value);
    partial void OnSCHD_HOSTChanged();
    partial void OnSCHD_TIMEChanging(string value);
    partial void OnSCHD_TIMEChanged();
    partial void OnSCHD_USERChanging(string value);
    partial void OnSCHD_USERChanged();
    partial void OnSCHD_CRONChanging(string value);
    partial void OnSCHD_CRONChanged();
    partial void OnJOB_NAMEChanging(string value);
    partial void OnJOB_NAMEChanged();
    partial void OnHOST_NAMEChanging(string value);
    partial void OnHOST_NAMEChanged();
    #endregion
		
		public ESB_SCHD()
		{
			this._ESB_SCHD_EsbWS = new EntitySet<ESB_SCHD_EsbWS>(new Action<ESB_SCHD_EsbWS>(this.attach_ESB_SCHD_EsbWS), new Action<ESB_SCHD_EsbWS>(this.detach_ESB_SCHD_EsbWS));
			this._ESB_SCHD_HISTORY = new EntitySet<ESB_SCHD_HISTORY>(new Action<ESB_SCHD_HISTORY>(this.attach_ESB_SCHD_HISTORY), new Action<ESB_SCHD_HISTORY>(this.detach_ESB_SCHD_HISTORY));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string SCHD_ID
		{
			get
			{
				return this._SCHD_ID;
			}
			set
			{
				if ((this._SCHD_ID != value))
				{
					this.OnSCHD_IDChanging(value);
					this.SendPropertyChanging();
					this._SCHD_ID = value;
					this.SendPropertyChanged("SCHD_ID");
					this.OnSCHD_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRIG_NAME", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string TRIG_NAME
		{
			get
			{
				return this._TRIG_NAME;
			}
			set
			{
				if ((this._TRIG_NAME != value))
				{
					this.OnTRIG_NAMEChanging(value);
					this.SendPropertyChanging();
					this._TRIG_NAME = value;
					this.SendPropertyChanged("TRIG_NAME");
					this.OnTRIG_NAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRIG_GROUP", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string TRIG_GROUP
		{
			get
			{
				return this._TRIG_GROUP;
			}
			set
			{
				if ((this._TRIG_GROUP != value))
				{
					this.OnTRIG_GROUPChanging(value);
					this.SendPropertyChanging();
					this._TRIG_GROUP = value;
					this.SendPropertyChanged("TRIG_GROUP");
					this.OnTRIG_GROUPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_NAME", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string SCHD_NAME
		{
			get
			{
				return this._SCHD_NAME;
			}
			set
			{
				if ((this._SCHD_NAME != value))
				{
					this.OnSCHD_NAMEChanging(value);
					this.SendPropertyChanging();
					this._SCHD_NAME = value;
					this.SendPropertyChanged("SCHD_NAME");
					this.OnSCHD_NAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_DESC", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
		public string SCHD_DESC
		{
			get
			{
				return this._SCHD_DESC;
			}
			set
			{
				if ((this._SCHD_DESC != value))
				{
					this.OnSCHD_DESCChanging(value);
					this.SendPropertyChanging();
					this._SCHD_DESC = value;
					this.SendPropertyChanged("SCHD_DESC");
					this.OnSCHD_DESCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_START_TIME", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string START_TIME
		{
			get
			{
				return this._START_TIME;
			}
			set
			{
				if ((this._START_TIME != value))
				{
					this.OnSTART_TIMEChanging(value);
					this.SendPropertyChanging();
					this._START_TIME = value;
					this.SendPropertyChanged("START_TIME");
					this.OnSTART_TIMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_END_TIME", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string END_TIME
		{
			get
			{
				return this._END_TIME;
			}
			set
			{
				if ((this._END_TIME != value))
				{
					this.OnEND_TIMEChanging(value);
					this.SendPropertyChanging();
					this._END_TIME = value;
					this.SendPropertyChanged("END_TIME");
					this.OnEND_TIMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_FREQ", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string SCHD_FREQ
		{
			get
			{
				return this._SCHD_FREQ;
			}
			set
			{
				if ((this._SCHD_FREQ != value))
				{
					this.OnSCHD_FREQChanging(value);
					this.SendPropertyChanging();
					this._SCHD_FREQ = value;
					this.SendPropertyChanged("SCHD_FREQ");
					this.OnSCHD_FREQChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_HOST", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid SCHD_HOST
		{
			get
			{
				return this._SCHD_HOST;
			}
			set
			{
				if ((this._SCHD_HOST != value))
				{
					this.OnSCHD_HOSTChanging(value);
					this.SendPropertyChanging();
					this._SCHD_HOST = value;
					this.SendPropertyChanged("SCHD_HOST");
					this.OnSCHD_HOSTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_TIME", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SCHD_TIME
		{
			get
			{
				return this._SCHD_TIME;
			}
			set
			{
				if ((this._SCHD_TIME != value))
				{
					this.OnSCHD_TIMEChanging(value);
					this.SendPropertyChanging();
					this._SCHD_TIME = value;
					this.SendPropertyChanged("SCHD_TIME");
					this.OnSCHD_TIMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_USER", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SCHD_USER
		{
			get
			{
				return this._SCHD_USER;
			}
			set
			{
				if ((this._SCHD_USER != value))
				{
					this.OnSCHD_USERChanging(value);
					this.SendPropertyChanging();
					this._SCHD_USER = value;
					this.SendPropertyChanged("SCHD_USER");
					this.OnSCHD_USERChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_CRON", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SCHD_CRON
		{
			get
			{
				return this._SCHD_CRON;
			}
			set
			{
				if ((this._SCHD_CRON != value))
				{
					this.OnSCHD_CRONChanging(value);
					this.SendPropertyChanging();
					this._SCHD_CRON = value;
					this.SendPropertyChanged("SCHD_CRON");
					this.OnSCHD_CRONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JOB_NAME", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string JOB_NAME
		{
			get
			{
				return this._JOB_NAME;
			}
			set
			{
				if ((this._JOB_NAME != value))
				{
					this.OnJOB_NAMEChanging(value);
					this.SendPropertyChanging();
					this._JOB_NAME = value;
					this.SendPropertyChanged("JOB_NAME");
					this.OnJOB_NAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOST_NAME", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string HOST_NAME
		{
			get
			{
				return this._HOST_NAME;
			}
			set
			{
				if ((this._HOST_NAME != value))
				{
					this.OnHOST_NAMEChanging(value);
					this.SendPropertyChanging();
					this._HOST_NAME = value;
					this.SendPropertyChanged("HOST_NAME");
					this.OnHOST_NAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ESB_SCHD_ESB_SCHD_EsbWS", Storage="_ESB_SCHD_EsbWS", ThisKey="SCHD_ID", OtherKey="SCHD_ID")]
		public EntitySet<ESB_SCHD_EsbWS> ESB_SCHD_EsbWS
		{
			get
			{
				return this._ESB_SCHD_EsbWS;
			}
			set
			{
				this._ESB_SCHD_EsbWS.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ESB_SCHD_ESB_SCHD_HISTORY", Storage="_ESB_SCHD_HISTORY", ThisKey="SCHD_ID", OtherKey="SCHD_ID")]
		public EntitySet<ESB_SCHD_HISTORY> ESB_SCHD_HISTORY
		{
			get
			{
				return this._ESB_SCHD_HISTORY;
			}
			set
			{
				this._ESB_SCHD_HISTORY.Assign(value);
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
		
		private void attach_ESB_SCHD_EsbWS(ESB_SCHD_EsbWS entity)
		{
			this.SendPropertyChanging();
			entity.ESB_SCHD = this;
		}
		
		private void detach_ESB_SCHD_EsbWS(ESB_SCHD_EsbWS entity)
		{
			this.SendPropertyChanging();
			entity.ESB_SCHD = null;
		}
		
		private void attach_ESB_SCHD_HISTORY(ESB_SCHD_HISTORY entity)
		{
			this.SendPropertyChanging();
			entity.ESB_SCHD = this;
		}
		
		private void detach_ESB_SCHD_HISTORY(ESB_SCHD_HISTORY entity)
		{
			this.SendPropertyChanging();
			entity.ESB_SCHD = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ESB_SCHD_EsbWS")]
	public partial class ESB_SCHD_EsbWS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _OID;
		
		private string _SCHD_ID;
		
		private System.Guid _EntityID;
		
		private string _EntityName;
		
		private System.Guid _ServiceID;
		
		private string _ServiceName;
		
		private string _MethodName;
		
		private string _ParamString;
		
		private string _ParamUrl;
		
		private string _PassWord;
		
		private EntityRef<ESB_SCHD> _ESB_SCHD;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOIDChanging(string value);
    partial void OnOIDChanged();
    partial void OnSCHD_IDChanging(string value);
    partial void OnSCHD_IDChanged();
    partial void OnEntityIDChanging(System.Guid value);
    partial void OnEntityIDChanged();
    partial void OnEntityNameChanging(string value);
    partial void OnEntityNameChanged();
    partial void OnServiceIDChanging(System.Guid value);
    partial void OnServiceIDChanged();
    partial void OnServiceNameChanging(string value);
    partial void OnServiceNameChanged();
    partial void OnMethodNameChanging(string value);
    partial void OnMethodNameChanged();
    partial void OnParamStringChanging(string value);
    partial void OnParamStringChanged();
    partial void OnParamUrlChanging(string value);
    partial void OnParamUrlChanged();
    partial void OnPassWordChanging(string value);
    partial void OnPassWordChanged();
    #endregion
		
		public ESB_SCHD_EsbWS()
		{
			this._ESB_SCHD = default(EntityRef<ESB_SCHD>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string OID
		{
			get
			{
				return this._OID;
			}
			set
			{
				if ((this._OID != value))
				{
					this.OnOIDChanging(value);
					this.SendPropertyChanging();
					this._OID = value;
					this.SendPropertyChanged("OID");
					this.OnOIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SCHD_ID
		{
			get
			{
				return this._SCHD_ID;
			}
			set
			{
				if ((this._SCHD_ID != value))
				{
					if (this._ESB_SCHD.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSCHD_IDChanging(value);
					this.SendPropertyChanging();
					this._SCHD_ID = value;
					this.SendPropertyChanged("SCHD_ID");
					this.OnSCHD_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EntityID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid EntityID
		{
			get
			{
				return this._EntityID;
			}
			set
			{
				if ((this._EntityID != value))
				{
					this.OnEntityIDChanging(value);
					this.SendPropertyChanging();
					this._EntityID = value;
					this.SendPropertyChanged("EntityID");
					this.OnEntityIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EntityName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EntityName
		{
			get
			{
				return this._EntityName;
			}
			set
			{
				if ((this._EntityName != value))
				{
					this.OnEntityNameChanging(value);
					this.SendPropertyChanging();
					this._EntityName = value;
					this.SendPropertyChanged("EntityName");
					this.OnEntityNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ServiceID
		{
			get
			{
				return this._ServiceID;
			}
			set
			{
				if ((this._ServiceID != value))
				{
					this.OnServiceIDChanging(value);
					this.SendPropertyChanging();
					this._ServiceID = value;
					this.SendPropertyChanged("ServiceID");
					this.OnServiceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ServiceName
		{
			get
			{
				return this._ServiceName;
			}
			set
			{
				if ((this._ServiceName != value))
				{
					this.OnServiceNameChanging(value);
					this.SendPropertyChanging();
					this._ServiceName = value;
					this.SendPropertyChanged("ServiceName");
					this.OnServiceNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MethodName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MethodName
		{
			get
			{
				return this._MethodName;
			}
			set
			{
				if ((this._MethodName != value))
				{
					this.OnMethodNameChanging(value);
					this.SendPropertyChanging();
					this._MethodName = value;
					this.SendPropertyChanged("MethodName");
					this.OnMethodNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParamString", DbType="VarChar(500) NOT NULL")]
		public string ParamString
		{
			get
			{
				return this._ParamString;
			}
			set
			{
				if ((this._ParamString != value))
				{
					this.OnParamStringChanging(value);
					this.SendPropertyChanging();
					this._ParamString = value;
					this.SendPropertyChanged("ParamString");
					this.OnParamStringChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParamUrl", DbType="VarChar(100) NOT NULL")]
		public string ParamUrl
		{
			get
			{
				return this._ParamUrl;
			}
			set
			{
				if ((this._ParamUrl != value))
				{
					this.OnParamUrlChanging(value);
					this.SendPropertyChanging();
					this._ParamUrl = value;
					this.SendPropertyChanged("ParamUrl");
					this.OnParamUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PassWord", DbType="VarChar(100) NOT NULL")]
		public string PassWord
		{
			get
			{
				return this._PassWord;
			}
			set
			{
				if ((this._PassWord != value))
				{
					this.OnPassWordChanging(value);
					this.SendPropertyChanging();
					this._PassWord = value;
					this.SendPropertyChanged("PassWord");
					this.OnPassWordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ESB_SCHD_ESB_SCHD_EsbWS", Storage="_ESB_SCHD", ThisKey="SCHD_ID", OtherKey="SCHD_ID", IsForeignKey=true)]
		public ESB_SCHD ESB_SCHD
		{
			get
			{
				return this._ESB_SCHD.Entity;
			}
			set
			{
				ESB_SCHD previousValue = this._ESB_SCHD.Entity;
				if (((previousValue != value) 
							|| (this._ESB_SCHD.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ESB_SCHD.Entity = null;
						previousValue.ESB_SCHD_EsbWS.Remove(this);
					}
					this._ESB_SCHD.Entity = value;
					if ((value != null))
					{
						value.ESB_SCHD_EsbWS.Add(this);
						this._SCHD_ID = value.SCHD_ID;
					}
					else
					{
						this._SCHD_ID = default(string);
					}
					this.SendPropertyChanged("ESB_SCHD");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ESB_SCHD_HISTORY")]
	public partial class ESB_SCHD_HISTORY : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _OID;
		
		private string _SCHD_ID;
		
		private string _BEGIN_TIME;
		
		private string _END_TIME;
		
		private int _CALL_STATUS;
		
		private string _CALL_MEMO;
		
		private EntityRef<ESB_SCHD> _ESB_SCHD;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOIDChanging(string value);
    partial void OnOIDChanged();
    partial void OnSCHD_IDChanging(string value);
    partial void OnSCHD_IDChanged();
    partial void OnBEGIN_TIMEChanging(string value);
    partial void OnBEGIN_TIMEChanged();
    partial void OnEND_TIMEChanging(string value);
    partial void OnEND_TIMEChanged();
    partial void OnCALL_STATUSChanging(int value);
    partial void OnCALL_STATUSChanged();
    partial void OnCALL_MEMOChanging(string value);
    partial void OnCALL_MEMOChanged();
    #endregion
		
		public ESB_SCHD_HISTORY()
		{
			this._ESB_SCHD = default(EntityRef<ESB_SCHD>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string OID
		{
			get
			{
				return this._OID;
			}
			set
			{
				if ((this._OID != value))
				{
					this.OnOIDChanging(value);
					this.SendPropertyChanging();
					this._OID = value;
					this.SendPropertyChanged("OID");
					this.OnOIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SCHD_ID
		{
			get
			{
				return this._SCHD_ID;
			}
			set
			{
				if ((this._SCHD_ID != value))
				{
					if (this._ESB_SCHD.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSCHD_IDChanging(value);
					this.SendPropertyChanging();
					this._SCHD_ID = value;
					this.SendPropertyChanged("SCHD_ID");
					this.OnSCHD_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BEGIN_TIME", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string BEGIN_TIME
		{
			get
			{
				return this._BEGIN_TIME;
			}
			set
			{
				if ((this._BEGIN_TIME != value))
				{
					this.OnBEGIN_TIMEChanging(value);
					this.SendPropertyChanging();
					this._BEGIN_TIME = value;
					this.SendPropertyChanged("BEGIN_TIME");
					this.OnBEGIN_TIMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_END_TIME", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string END_TIME
		{
			get
			{
				return this._END_TIME;
			}
			set
			{
				if ((this._END_TIME != value))
				{
					this.OnEND_TIMEChanging(value);
					this.SendPropertyChanging();
					this._END_TIME = value;
					this.SendPropertyChanged("END_TIME");
					this.OnEND_TIMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CALL_STATUS", DbType="Int NOT NULL")]
		public int CALL_STATUS
		{
			get
			{
				return this._CALL_STATUS;
			}
			set
			{
				if ((this._CALL_STATUS != value))
				{
					this.OnCALL_STATUSChanging(value);
					this.SendPropertyChanging();
					this._CALL_STATUS = value;
					this.SendPropertyChanged("CALL_STATUS");
					this.OnCALL_STATUSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CALL_MEMO", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string CALL_MEMO
		{
			get
			{
				return this._CALL_MEMO;
			}
			set
			{
				if ((this._CALL_MEMO != value))
				{
					this.OnCALL_MEMOChanging(value);
					this.SendPropertyChanging();
					this._CALL_MEMO = value;
					this.SendPropertyChanged("CALL_MEMO");
					this.OnCALL_MEMOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ESB_SCHD_ESB_SCHD_HISTORY", Storage="_ESB_SCHD", ThisKey="SCHD_ID", OtherKey="SCHD_ID", IsForeignKey=true)]
		public ESB_SCHD ESB_SCHD
		{
			get
			{
				return this._ESB_SCHD.Entity;
			}
			set
			{
				ESB_SCHD previousValue = this._ESB_SCHD.Entity;
				if (((previousValue != value) 
							|| (this._ESB_SCHD.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ESB_SCHD.Entity = null;
						previousValue.ESB_SCHD_HISTORY.Remove(this);
					}
					this._ESB_SCHD.Entity = value;
					if ((value != null))
					{
						value.ESB_SCHD_HISTORY.Add(this);
						this._SCHD_ID = value.SCHD_ID;
					}
					else
					{
						this._SCHD_ID = default(string);
					}
					this.SendPropertyChanged("ESB_SCHD");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ESB_SCHD_HISTORY_VIEW")]
	public partial class ESB_SCHD_HISTORY_VIEW : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TRIG_NAME;
		
		private string _TRIG_GROUP;
		
		private string _SCHD_NAME;
		
		private System.DateTime _BEGIN_TIME;
		
		private System.DateTime _END_TIME;
		
		private int _CALL_STATUS;
		
		private string _CALL_MEMO;
		
		private System.Guid _SCHD_HOST;
		
		private string _SCHD_ID;
		
		private string _OID;
		
		private string _HOST_NAME;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTRIG_NAMEChanging(string value);
    partial void OnTRIG_NAMEChanged();
    partial void OnTRIG_GROUPChanging(string value);
    partial void OnTRIG_GROUPChanged();
    partial void OnSCHD_NAMEChanging(string value);
    partial void OnSCHD_NAMEChanged();
    partial void OnBEGIN_TIMEChanging(System.DateTime value);
    partial void OnBEGIN_TIMEChanged();
    partial void OnEND_TIMEChanging(System.DateTime value);
    partial void OnEND_TIMEChanged();
    partial void OnCALL_STATUSChanging(int value);
    partial void OnCALL_STATUSChanged();
    partial void OnCALL_MEMOChanging(string value);
    partial void OnCALL_MEMOChanged();
    partial void OnSCHD_HOSTChanging(System.Guid value);
    partial void OnSCHD_HOSTChanged();
    partial void OnSCHD_IDChanging(string value);
    partial void OnSCHD_IDChanged();
    partial void OnOIDChanging(string value);
    partial void OnOIDChanged();
    partial void OnHOST_NAMEChanging(string value);
    partial void OnHOST_NAMEChanged();
    #endregion
		
		public ESB_SCHD_HISTORY_VIEW()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRIG_NAME", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string TRIG_NAME
		{
			get
			{
				return this._TRIG_NAME;
			}
			set
			{
				if ((this._TRIG_NAME != value))
				{
					this.OnTRIG_NAMEChanging(value);
					this.SendPropertyChanging();
					this._TRIG_NAME = value;
					this.SendPropertyChanged("TRIG_NAME");
					this.OnTRIG_NAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRIG_GROUP", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string TRIG_GROUP
		{
			get
			{
				return this._TRIG_GROUP;
			}
			set
			{
				if ((this._TRIG_GROUP != value))
				{
					this.OnTRIG_GROUPChanging(value);
					this.SendPropertyChanging();
					this._TRIG_GROUP = value;
					this.SendPropertyChanged("TRIG_GROUP");
					this.OnTRIG_GROUPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_NAME", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string SCHD_NAME
		{
			get
			{
				return this._SCHD_NAME;
			}
			set
			{
				if ((this._SCHD_NAME != value))
				{
					this.OnSCHD_NAMEChanging(value);
					this.SendPropertyChanging();
					this._SCHD_NAME = value;
					this.SendPropertyChanged("SCHD_NAME");
					this.OnSCHD_NAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BEGIN_TIME", DbType="DateTime")]
		public System.DateTime BEGIN_TIME
		{
			get
			{
				return this._BEGIN_TIME;
			}
			set
			{
				if ((this._BEGIN_TIME != value))
				{
					this.OnBEGIN_TIMEChanging(value);
					this.SendPropertyChanging();
					this._BEGIN_TIME = value;
					this.SendPropertyChanged("BEGIN_TIME");
					this.OnBEGIN_TIMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_END_TIME", DbType="DateTime")]
		public System.DateTime END_TIME
		{
			get
			{
				return this._END_TIME;
			}
			set
			{
				if ((this._END_TIME != value))
				{
					this.OnEND_TIMEChanging(value);
					this.SendPropertyChanging();
					this._END_TIME = value;
					this.SendPropertyChanged("END_TIME");
					this.OnEND_TIMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CALL_STATUS", DbType="Int NOT NULL")]
		public int CALL_STATUS
		{
			get
			{
				return this._CALL_STATUS;
			}
			set
			{
				if ((this._CALL_STATUS != value))
				{
					this.OnCALL_STATUSChanging(value);
					this.SendPropertyChanging();
					this._CALL_STATUS = value;
					this.SendPropertyChanged("CALL_STATUS");
					this.OnCALL_STATUSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CALL_MEMO", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string CALL_MEMO
		{
			get
			{
				return this._CALL_MEMO;
			}
			set
			{
				if ((this._CALL_MEMO != value))
				{
					this.OnCALL_MEMOChanging(value);
					this.SendPropertyChanging();
					this._CALL_MEMO = value;
					this.SendPropertyChanged("CALL_MEMO");
					this.OnCALL_MEMOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_HOST", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid SCHD_HOST
		{
			get
			{
				return this._SCHD_HOST;
			}
			set
			{
				if ((this._SCHD_HOST != value))
				{
					this.OnSCHD_HOSTChanging(value);
					this.SendPropertyChanging();
					this._SCHD_HOST = value;
					this.SendPropertyChanged("SCHD_HOST");
					this.OnSCHD_HOSTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SCHD_ID
		{
			get
			{
				return this._SCHD_ID;
			}
			set
			{
				if ((this._SCHD_ID != value))
				{
					this.OnSCHD_IDChanging(value);
					this.SendPropertyChanging();
					this._SCHD_ID = value;
					this.SendPropertyChanged("SCHD_ID");
					this.OnSCHD_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string OID
		{
			get
			{
				return this._OID;
			}
			set
			{
				if ((this._OID != value))
				{
					this.OnOIDChanging(value);
					this.SendPropertyChanging();
					this._OID = value;
					this.SendPropertyChanged("OID");
					this.OnOIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOST_NAME", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string HOST_NAME
		{
			get
			{
				return this._HOST_NAME;
			}
			set
			{
				if ((this._HOST_NAME != value))
				{
					this.OnHOST_NAMEChanging(value);
					this.SendPropertyChanging();
					this._HOST_NAME = value;
					this.SendPropertyChanged("HOST_NAME");
					this.OnHOST_NAMEChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ESB_SCHD_VIEW")]
	public partial class ESB_SCHD_VIEW
	{
		
		private string _TRIG_NAME;
		
		private string _TRIG_GROUP;
		
		private string _SCHD_NAME;
		
		private string _SCHD_DESC;
		
		private string _START_TIME;
		
		private string _END_TIME;
		
		private string _SCHD_FREQ;
		
		private System.Guid _SCHD_HOST;
		
		private string _SCHD_TIME;
		
		private string _SCHD_USER;
		
		private string _SCHD_CRON;
		
		private System.Nullable<long> _NEXT_FIRE_TIME;
		
		private System.Nullable<long> _PREV_FIRE_TIME;
		
		private string _SCHD_ID;
		
		private string _TRIGGER_STATE;
		
		private string _HOST_NAME;
		
		public ESB_SCHD_VIEW()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRIG_NAME", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string TRIG_NAME
		{
			get
			{
				return this._TRIG_NAME;
			}
			set
			{
				if ((this._TRIG_NAME != value))
				{
					this._TRIG_NAME = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRIG_GROUP", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string TRIG_GROUP
		{
			get
			{
				return this._TRIG_GROUP;
			}
			set
			{
				if ((this._TRIG_GROUP != value))
				{
					this._TRIG_GROUP = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_NAME", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string SCHD_NAME
		{
			get
			{
				return this._SCHD_NAME;
			}
			set
			{
				if ((this._SCHD_NAME != value))
				{
					this._SCHD_NAME = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_DESC", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
		public string SCHD_DESC
		{
			get
			{
				return this._SCHD_DESC;
			}
			set
			{
				if ((this._SCHD_DESC != value))
				{
					this._SCHD_DESC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_START_TIME", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string START_TIME
		{
			get
			{
				return this._START_TIME;
			}
			set
			{
				if ((this._START_TIME != value))
				{
					this._START_TIME = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_END_TIME", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string END_TIME
		{
			get
			{
				return this._END_TIME;
			}
			set
			{
				if ((this._END_TIME != value))
				{
					this._END_TIME = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_FREQ", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string SCHD_FREQ
		{
			get
			{
				return this._SCHD_FREQ;
			}
			set
			{
				if ((this._SCHD_FREQ != value))
				{
					this._SCHD_FREQ = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_HOST", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid SCHD_HOST
		{
			get
			{
				return this._SCHD_HOST;
			}
			set
			{
				if ((this._SCHD_HOST != value))
				{
					this._SCHD_HOST = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_TIME", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SCHD_TIME
		{
			get
			{
				return this._SCHD_TIME;
			}
			set
			{
				if ((this._SCHD_TIME != value))
				{
					this._SCHD_TIME = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_USER", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SCHD_USER
		{
			get
			{
				return this._SCHD_USER;
			}
			set
			{
				if ((this._SCHD_USER != value))
				{
					this._SCHD_USER = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_CRON", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SCHD_CRON
		{
			get
			{
				return this._SCHD_CRON;
			}
			set
			{
				if ((this._SCHD_CRON != value))
				{
					this._SCHD_CRON = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NEXT_FIRE_TIME", DbType="BigInt")]
		public System.Nullable<long> NEXT_FIRE_TIME
		{
			get
			{
				return this._NEXT_FIRE_TIME;
			}
			set
			{
				if ((this._NEXT_FIRE_TIME != value))
				{
					this._NEXT_FIRE_TIME = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PREV_FIRE_TIME", DbType="BigInt")]
		public System.Nullable<long> PREV_FIRE_TIME
		{
			get
			{
				return this._PREV_FIRE_TIME;
			}
			set
			{
				if ((this._PREV_FIRE_TIME != value))
				{
					this._PREV_FIRE_TIME = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHD_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SCHD_ID
		{
			get
			{
				return this._SCHD_ID;
			}
			set
			{
				if ((this._SCHD_ID != value))
				{
					this._SCHD_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRIGGER_STATE", DbType="VarChar(16) NOT NULL", CanBeNull=false)]
		public string TRIGGER_STATE
		{
			get
			{
				return this._TRIGGER_STATE;
			}
			set
			{
				if ((this._TRIGGER_STATE != value))
				{
					this._TRIGGER_STATE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOST_NAME", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string HOST_NAME
		{
			get
			{
				return this._HOST_NAME;
			}
			set
			{
				if ((this._HOST_NAME != value))
				{
					this._HOST_NAME = value;
				}
			}
		}
	}
}
#pragma warning restore 1591