﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="humanesocietyproject")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertClient(Client instance);
    partial void UpdateClient(Client instance);
    partial void DeleteClient(Client instance);
    partial void InsertAnimal(Animal instance);
    partial void UpdateAnimal(Animal instance);
    partial void DeleteAnimal(Animal instance);
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::ClassLibrary1.Properties.Settings.Default.humanesocietyprojectConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Client> Clients
		{
			get
			{
				return this.GetTable<Client>();
			}
		}
		
		public System.Data.Linq.Table<Animal> Animals
		{
			get
			{
				return this.GetTable<Animal>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Client")]
	public partial class Client : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Email;
		
		private string _UserName;
		
		private string _Pass;
		
		private string _Name;
		
		private System.Nullable<int> _Age;
		
		private System.Nullable<int> _Gender;
		
		private string _OtherAnimalsInHousehold;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPassChanging(string value);
    partial void OnPassChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAgeChanging(System.Nullable<int> value);
    partial void OnAgeChanged();
    partial void OnGenderChanging(System.Nullable<int> value);
    partial void OnGenderChanged();
    partial void OnOtherAnimalsInHouseholdChanging(string value);
    partial void OnOtherAnimalsInHouseholdChanged();
    #endregion
		
		public Client()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(255)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pass", DbType="VarChar(255)")]
		public string Pass
		{
			get
			{
				return this._Pass;
			}
			set
			{
				if ((this._Pass != value))
				{
					this.OnPassChanging(value);
					this.SendPropertyChanging();
					this._Pass = value;
					this.SendPropertyChanged("Pass");
					this.OnPassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(255)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="Int")]
		public System.Nullable<int> Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OtherAnimalsInHousehold", DbType="VarChar(255)")]
		public string OtherAnimalsInHousehold
		{
			get
			{
				return this._OtherAnimalsInHousehold;
			}
			set
			{
				if ((this._OtherAnimalsInHousehold != value))
				{
					this.OnOtherAnimalsInHouseholdChanging(value);
					this.SendPropertyChanging();
					this._OtherAnimalsInHousehold = value;
					this.SendPropertyChanged("OtherAnimalsInHousehold");
					this.OnOtherAnimalsInHouseholdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Animals")]
	public partial class Animal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Animaltype;
		
		private string _Name;
		
		private string _Gender;
		
		private System.Nullable<int> _RoomKeptIn;
		
		private string _AdoptionStatus;
		
		private System.Nullable<decimal> _Worth;
		
		private string _Shots;
		
		private System.Nullable<int> _Hunger;
		
		private System.Nullable<int> _Age;
		
		private string _Breed;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnAnimaltypeChanging(string value);
    partial void OnAnimaltypeChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnRoomKeptInChanging(System.Nullable<int> value);
    partial void OnRoomKeptInChanged();
    partial void OnAdoptionStatusChanging(string value);
    partial void OnAdoptionStatusChanged();
    partial void OnWorthChanging(System.Nullable<decimal> value);
    partial void OnWorthChanged();
    partial void OnShotsChanging(string value);
    partial void OnShotsChanged();
    partial void OnHungerChanging(System.Nullable<int> value);
    partial void OnHungerChanged();
    partial void OnAgeChanging(System.Nullable<int> value);
    partial void OnAgeChanged();
    partial void OnBreedChanging(string value);
    partial void OnBreedChanged();
    #endregion
		
		public Animal()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Animaltype", DbType="VarChar(255)")]
		public string Animaltype
		{
			get
			{
				return this._Animaltype;
			}
			set
			{
				if ((this._Animaltype != value))
				{
					this.OnAnimaltypeChanging(value);
					this.SendPropertyChanging();
					this._Animaltype = value;
					this.SendPropertyChanged("Animaltype");
					this.OnAnimaltypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(255)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(255)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomKeptIn", DbType="Int")]
		public System.Nullable<int> RoomKeptIn
		{
			get
			{
				return this._RoomKeptIn;
			}
			set
			{
				if ((this._RoomKeptIn != value))
				{
					this.OnRoomKeptInChanging(value);
					this.SendPropertyChanging();
					this._RoomKeptIn = value;
					this.SendPropertyChanged("RoomKeptIn");
					this.OnRoomKeptInChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdoptionStatus", DbType="VarChar(255)")]
		public string AdoptionStatus
		{
			get
			{
				return this._AdoptionStatus;
			}
			set
			{
				if ((this._AdoptionStatus != value))
				{
					this.OnAdoptionStatusChanging(value);
					this.SendPropertyChanging();
					this._AdoptionStatus = value;
					this.SendPropertyChanged("AdoptionStatus");
					this.OnAdoptionStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Worth", DbType="Decimal(7,2)")]
		public System.Nullable<decimal> Worth
		{
			get
			{
				return this._Worth;
			}
			set
			{
				if ((this._Worth != value))
				{
					this.OnWorthChanging(value);
					this.SendPropertyChanging();
					this._Worth = value;
					this.SendPropertyChanged("Worth");
					this.OnWorthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Shots", DbType="VarChar(255)")]
		public string Shots
		{
			get
			{
				return this._Shots;
			}
			set
			{
				if ((this._Shots != value))
				{
					this.OnShotsChanging(value);
					this.SendPropertyChanging();
					this._Shots = value;
					this.SendPropertyChanged("Shots");
					this.OnShotsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hunger", DbType="Int")]
		public System.Nullable<int> Hunger
		{
			get
			{
				return this._Hunger;
			}
			set
			{
				if ((this._Hunger != value))
				{
					this.OnHungerChanging(value);
					this.SendPropertyChanging();
					this._Hunger = value;
					this.SendPropertyChanged("Hunger");
					this.OnHungerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Breed", DbType="VarChar(255)")]
		public string Breed
		{
			get
			{
				return this._Breed;
			}
			set
			{
				if ((this._Breed != value))
				{
					this.OnBreedChanging(value);
					this.SendPropertyChanging();
					this._Breed = value;
					this.SendPropertyChanged("Breed");
					this.OnBreedChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employees")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Gender;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    #endregion
		
		public Employee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(255)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(255)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
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
