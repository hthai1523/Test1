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

namespace test1.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLySanPham")]
	public partial class DatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertIncome(Income instance);
    partial void UpdateIncome(Income instance);
    partial void DeleteIncome(Income instance);
    partial void InsertInvoice(Invoice instance);
    partial void UpdateInvoice(Invoice instance);
    partial void DeleteInvoice(Invoice instance);
    partial void InsertInvoiceDetail(InvoiceDetail instance);
    partial void UpdateInvoiceDetail(InvoiceDetail instance);
    partial void DeleteInvoiceDetail(InvoiceDetail instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
        #endregion

        public DatabaseDataContext() :
                base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QuanLySanPhamConnectionString"].ConnectionString, mappingSource)
        {
            OnCreated();
        }

        public DatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<Income> Incomes
		{
			get
			{
				return this.GetTable<Income>();
			}
		}
		
		public System.Data.Linq.Table<Invoice> Invoices
		{
			get
			{
				return this.GetTable<Invoice>();
			}
		}
		
		public System.Data.Linq.Table<InvoiceDetail> InvoiceDetails
		{
			get
			{
				return this.GetTable<InvoiceDetail>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _UserName;
		
		private string _Password;
		
		private System.Nullable<bool> _IsAdmin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnIsAdminChanging(System.Nullable<bool> value);
    partial void OnIsAdminChanged();
    #endregion
		
		public Account()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NChar(10)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsAdmin", DbType="Bit")]
		public System.Nullable<bool> IsAdmin
		{
			get
			{
				return this._IsAdmin;
			}
			set
			{
				if ((this._IsAdmin != value))
				{
					this.OnIsAdminChanging(value);
					this.SendPropertyChanging();
					this._IsAdmin = value;
					this.SendPropertyChanged("IsAdmin");
					this.OnIsAdminChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Category")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _CategoryName;
		
		private string _URL;
		
		private System.Nullable<bool> _ShowOnHomePage;
		
		private System.Nullable<bool> _isDelete;
		
		private System.Nullable<System.DateTime> _CreatedOnUtc;
		
		private System.Nullable<System.DateTime> _UpdatedOnUtc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCategoryNameChanging(string value);
    partial void OnCategoryNameChanged();
    partial void OnURLChanging(string value);
    partial void OnURLChanged();
    partial void OnShowOnHomePageChanging(System.Nullable<bool> value);
    partial void OnShowOnHomePageChanged();
    partial void OnisDeleteChanging(System.Nullable<bool> value);
    partial void OnisDeleteChanged();
    partial void OnCreatedOnUtcChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnUtcChanged();
    partial void OnUpdatedOnUtcChanging(System.Nullable<System.DateTime> value);
    partial void OnUpdatedOnUtcChanged();
    #endregion
		
		public Category()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryName", DbType="NChar(10)")]
		public string CategoryName
		{
			get
			{
				return this._CategoryName;
			}
			set
			{
				if ((this._CategoryName != value))
				{
					this.OnCategoryNameChanging(value);
					this.SendPropertyChanging();
					this._CategoryName = value;
					this.SendPropertyChanged("CategoryName");
					this.OnCategoryNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URL", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string URL
		{
			get
			{
				return this._URL;
			}
			set
			{
				if ((this._URL != value))
				{
					this.OnURLChanging(value);
					this.SendPropertyChanging();
					this._URL = value;
					this.SendPropertyChanged("URL");
					this.OnURLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShowOnHomePage", DbType="Bit")]
		public System.Nullable<bool> ShowOnHomePage
		{
			get
			{
				return this._ShowOnHomePage;
			}
			set
			{
				if ((this._ShowOnHomePage != value))
				{
					this.OnShowOnHomePageChanging(value);
					this.SendPropertyChanging();
					this._ShowOnHomePage = value;
					this.SendPropertyChanged("ShowOnHomePage");
					this.OnShowOnHomePageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isDelete", DbType="Bit")]
		public System.Nullable<bool> isDelete
		{
			get
			{
				return this._isDelete;
			}
			set
			{
				if ((this._isDelete != value))
				{
					this.OnisDeleteChanging(value);
					this.SendPropertyChanging();
					this._isDelete = value;
					this.SendPropertyChanged("isDelete");
					this.OnisDeleteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOnUtc", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOnUtc
		{
			get
			{
				return this._CreatedOnUtc;
			}
			set
			{
				if ((this._CreatedOnUtc != value))
				{
					this.OnCreatedOnUtcChanging(value);
					this.SendPropertyChanging();
					this._CreatedOnUtc = value;
					this.SendPropertyChanged("CreatedOnUtc");
					this.OnCreatedOnUtcChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdatedOnUtc", DbType="DateTime")]
		public System.Nullable<System.DateTime> UpdatedOnUtc
		{
			get
			{
				return this._UpdatedOnUtc;
			}
			set
			{
				if ((this._UpdatedOnUtc != value))
				{
					this.OnUpdatedOnUtcChanging(value);
					this.SendPropertyChanging();
					this._UpdatedOnUtc = value;
					this.SendPropertyChanged("UpdatedOnUtc");
					this.OnUpdatedOnUtcChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Income")]
	public partial class Income : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<double> _Total;
		
		private System.Nullable<System.DateTime> _getMonth;
		
		private System.Nullable<System.DateTime> _getWeak;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTotalChanging(System.Nullable<double> value);
    partial void OnTotalChanged();
    partial void OngetMonthChanging(System.Nullable<System.DateTime> value);
    partial void OngetMonthChanged();
    partial void OngetWeakChanging(System.Nullable<System.DateTime> value);
    partial void OngetWeakChanged();
    #endregion
		
		public Income()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total", DbType="Float")]
		public System.Nullable<double> Total
		{
			get
			{
				return this._Total;
			}
			set
			{
				if ((this._Total != value))
				{
					this.OnTotalChanging(value);
					this.SendPropertyChanging();
					this._Total = value;
					this.SendPropertyChanged("Total");
					this.OnTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_getMonth", DbType="Date")]
		public System.Nullable<System.DateTime> getMonth
		{
			get
			{
				return this._getMonth;
			}
			set
			{
				if ((this._getMonth != value))
				{
					this.OngetMonthChanging(value);
					this.SendPropertyChanging();
					this._getMonth = value;
					this.SendPropertyChanged("getMonth");
					this.OngetMonthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_getWeak", DbType="Date")]
		public System.Nullable<System.DateTime> getWeak
		{
			get
			{
				return this._getWeak;
			}
			set
			{
				if ((this._getWeak != value))
				{
					this.OngetWeakChanging(value);
					this.SendPropertyChanging();
					this._getWeak = value;
					this.SendPropertyChanged("getWeak");
					this.OngetWeakChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Invoice")]
	public partial class Invoice : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _NameProduct;
		
		private System.Nullable<int> _AccountID;
		
		private System.Nullable<int> _Status;
		
		private System.Nullable<System.DateTime> _CreateOnUtc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameProductChanging(string value);
    partial void OnNameProductChanged();
    partial void OnAccountIDChanging(System.Nullable<int> value);
    partial void OnAccountIDChanged();
    partial void OnStatusChanging(System.Nullable<int> value);
    partial void OnStatusChanged();
    partial void OnCreateOnUtcChanging(System.Nullable<System.DateTime> value);
    partial void OnCreateOnUtcChanged();
    #endregion
		
		public Invoice()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameProduct", DbType="NVarChar(50)")]
		public string NameProduct
		{
			get
			{
				return this._NameProduct;
			}
			set
			{
				if ((this._NameProduct != value))
				{
					this.OnNameProductChanging(value);
					this.SendPropertyChanging();
					this._NameProduct = value;
					this.SendPropertyChanged("NameProduct");
					this.OnNameProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountID", DbType="Int")]
		public System.Nullable<int> AccountID
		{
			get
			{
				return this._AccountID;
			}
			set
			{
				if ((this._AccountID != value))
				{
					this.OnAccountIDChanging(value);
					this.SendPropertyChanging();
					this._AccountID = value;
					this.SendPropertyChanged("AccountID");
					this.OnAccountIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int")]
		public System.Nullable<int> Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateOnUtc", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreateOnUtc
		{
			get
			{
				return this._CreateOnUtc;
			}
			set
			{
				if ((this._CreateOnUtc != value))
				{
					this.OnCreateOnUtcChanging(value);
					this.SendPropertyChanging();
					this._CreateOnUtc = value;
					this.SendPropertyChanged("CreateOnUtc");
					this.OnCreateOnUtcChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.InvoiceDetail")]
	public partial class InvoiceDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _InvoiceID;
		
		private int _ProductID;
		
		private int _Quantity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnInvoiceIDChanging(int value);
    partial void OnInvoiceIDChanged();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    #endregion
		
		public InvoiceDetail()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InvoiceID", DbType="Int NOT NULL")]
		public int InvoiceID
		{
			get
			{
				return this._InvoiceID;
			}
			set
			{
				if ((this._InvoiceID != value))
				{
					this.OnInvoiceIDChanging(value);
					this.SendPropertyChanging();
					this._InvoiceID = value;
					this.SendPropertyChanged("InvoiceID");
					this.OnInvoiceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", DbType="Int NOT NULL")]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _NameProduct;
		
		private string _CategoryName;
		
		private string _Description;
		
		private System.Nullable<double> _Price;
		
		private System.Nullable<double> _PriceDiscount;
		
		private System.Nullable<bool> _isDelete;
		
		private System.Nullable<bool> _ShowOnHomePage;
		
		private System.Nullable<System.DateTime> _CreatedOnUtc;
		
		private System.Nullable<System.DateTime> _UpdatedOnUtc;
		
		private string _URL;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameProductChanging(string value);
    partial void OnNameProductChanged();
    partial void OnCategoryNameChanging(string value);
    partial void OnCategoryNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPriceChanging(System.Nullable<double> value);
    partial void OnPriceChanged();
    partial void OnPriceDiscountChanging(System.Nullable<double> value);
    partial void OnPriceDiscountChanged();
    partial void OnisDeleteChanging(System.Nullable<bool> value);
    partial void OnisDeleteChanged();
    partial void OnShowOnHomePageChanging(System.Nullable<bool> value);
    partial void OnShowOnHomePageChanged();
    partial void OnCreatedOnUtcChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnUtcChanged();
    partial void OnUpdatedOnUtcChanging(System.Nullable<System.DateTime> value);
    partial void OnUpdatedOnUtcChanged();
    partial void OnURLChanging(string value);
    partial void OnURLChanged();
    #endregion
		
		public Product()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameProduct", DbType="NVarChar(100)")]
		public string NameProduct
		{
			get
			{
				return this._NameProduct;
			}
			set
			{
				if ((this._NameProduct != value))
				{
					this.OnNameProductChanging(value);
					this.SendPropertyChanging();
					this._NameProduct = value;
					this.SendPropertyChanged("NameProduct");
					this.OnNameProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryName", DbType="NVarChar(50)")]
		public string CategoryName
		{
			get
			{
				return this._CategoryName;
			}
			set
			{
				if ((this._CategoryName != value))
				{
					this.OnCategoryNameChanging(value);
					this.SendPropertyChanging();
					this._CategoryName = value;
					this.SendPropertyChanged("CategoryName");
					this.OnCategoryNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(500)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float")]
		public System.Nullable<double> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PriceDiscount", DbType="Float")]
		public System.Nullable<double> PriceDiscount
		{
			get
			{
				return this._PriceDiscount;
			}
			set
			{
				if ((this._PriceDiscount != value))
				{
					this.OnPriceDiscountChanging(value);
					this.SendPropertyChanging();
					this._PriceDiscount = value;
					this.SendPropertyChanged("PriceDiscount");
					this.OnPriceDiscountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isDelete", DbType="Bit")]
		public System.Nullable<bool> isDelete
		{
			get
			{
				return this._isDelete;
			}
			set
			{
				if ((this._isDelete != value))
				{
					this.OnisDeleteChanging(value);
					this.SendPropertyChanging();
					this._isDelete = value;
					this.SendPropertyChanged("isDelete");
					this.OnisDeleteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShowOnHomePage", DbType="Bit")]
		public System.Nullable<bool> ShowOnHomePage
		{
			get
			{
				return this._ShowOnHomePage;
			}
			set
			{
				if ((this._ShowOnHomePage != value))
				{
					this.OnShowOnHomePageChanging(value);
					this.SendPropertyChanging();
					this._ShowOnHomePage = value;
					this.SendPropertyChanged("ShowOnHomePage");
					this.OnShowOnHomePageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOnUtc", DbType="Date")]
		public System.Nullable<System.DateTime> CreatedOnUtc
		{
			get
			{
				return this._CreatedOnUtc;
			}
			set
			{
				if ((this._CreatedOnUtc != value))
				{
					this.OnCreatedOnUtcChanging(value);
					this.SendPropertyChanging();
					this._CreatedOnUtc = value;
					this.SendPropertyChanged("CreatedOnUtc");
					this.OnCreatedOnUtcChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdatedOnUtc", DbType="Date")]
		public System.Nullable<System.DateTime> UpdatedOnUtc
		{
			get
			{
				return this._UpdatedOnUtc;
			}
			set
			{
				if ((this._UpdatedOnUtc != value))
				{
					this.OnUpdatedOnUtcChanging(value);
					this.SendPropertyChanging();
					this._UpdatedOnUtc = value;
					this.SendPropertyChanged("UpdatedOnUtc");
					this.OnUpdatedOnUtcChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URL", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string URL
		{
			get
			{
				return this._URL;
			}
			set
			{
				if ((this._URL != value))
				{
					this.OnURLChanging(value);
					this.SendPropertyChanging();
					this._URL = value;
					this.SendPropertyChanged("URL");
					this.OnURLChanged();
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