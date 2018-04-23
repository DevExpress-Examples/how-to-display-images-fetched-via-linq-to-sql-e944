﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PictureAndLinq
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="AdventureWorks")]
	public partial class AdventureWorksDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProductPhoto(ProductPhoto instance);
    partial void UpdateProductPhoto(ProductPhoto instance);
    partial void DeleteProductPhoto(ProductPhoto instance);
    #endregion
		
		public AdventureWorksDataContext() : 
				base(global::PictureAndLinq.Properties.Settings.Default.AdventureWorksConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AdventureWorksDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AdventureWorksDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AdventureWorksDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AdventureWorksDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ProductPhoto> ProductPhotos
		{
			get
			{
				return this.GetTable<ProductPhoto>();
			}
		}
	}
	
	[Table(Name="Production.ProductPhoto")]
	public partial class ProductPhoto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductPhotoID;
		
		private System.Data.Linq.Binary _ThumbNailPhoto;
		
		private string _ThumbnailPhotoFileName;
		
		private System.Data.Linq.Binary _LargePhoto;
		
		private string _LargePhotoFileName;
		
		private System.DateTime _ModifiedDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductPhotoIDChanging(int value);
    partial void OnProductPhotoIDChanged();
    partial void OnThumbNailPhotoChanging(System.Data.Linq.Binary value);
    partial void OnThumbNailPhotoChanged();
    partial void OnThumbnailPhotoFileNameChanging(string value);
    partial void OnThumbnailPhotoFileNameChanged();
    partial void OnLargePhotoChanging(System.Data.Linq.Binary value);
    partial void OnLargePhotoChanged();
    partial void OnLargePhotoFileNameChanging(string value);
    partial void OnLargePhotoFileNameChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
		
		public ProductPhoto()
		{
			OnCreated();
		}
		
		[Column(Storage="_ProductPhotoID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductPhotoID
		{
			get
			{
				return this._ProductPhotoID;
			}
			set
			{
				if ((this._ProductPhotoID != value))
				{
					this.OnProductPhotoIDChanging(value);
					this.SendPropertyChanging();
					this._ProductPhotoID = value;
					this.SendPropertyChanged("ProductPhotoID");
					this.OnProductPhotoIDChanged();
				}
			}
		}
		
		[Column(Storage="_ThumbNailPhoto", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary ThumbNailPhoto
		{
			get
			{
				return this._ThumbNailPhoto;
			}
			set
			{
				if ((this._ThumbNailPhoto != value))
				{
					this.OnThumbNailPhotoChanging(value);
					this.SendPropertyChanging();
					this._ThumbNailPhoto = value;
					this.SendPropertyChanged("ThumbNailPhoto");
					this.OnThumbNailPhotoChanged();
				}
			}
		}
		
		[Column(Storage="_ThumbnailPhotoFileName", DbType="NVarChar(50)")]
		public string ThumbnailPhotoFileName
		{
			get
			{
				return this._ThumbnailPhotoFileName;
			}
			set
			{
				if ((this._ThumbnailPhotoFileName != value))
				{
					this.OnThumbnailPhotoFileNameChanging(value);
					this.SendPropertyChanging();
					this._ThumbnailPhotoFileName = value;
					this.SendPropertyChanged("ThumbnailPhotoFileName");
					this.OnThumbnailPhotoFileNameChanged();
				}
			}
		}
		
		[Column(Storage="_LargePhoto", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary LargePhoto
		{
			get
			{
				return this._LargePhoto;
			}
			set
			{
				if ((this._LargePhoto != value))
				{
					this.OnLargePhotoChanging(value);
					this.SendPropertyChanging();
					this._LargePhoto = value;
					this.SendPropertyChanged("LargePhoto");
					this.OnLargePhotoChanged();
				}
			}
		}
		
		[Column(Storage="_LargePhotoFileName", DbType="NVarChar(50)")]
		public string LargePhotoFileName
		{
			get
			{
				return this._LargePhotoFileName;
			}
			set
			{
				if ((this._LargePhotoFileName != value))
				{
					this.OnLargePhotoFileNameChanging(value);
					this.SendPropertyChanging();
					this._LargePhotoFileName = value;
					this.SendPropertyChanged("LargePhotoFileName");
					this.OnLargePhotoFileNameChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._ModifiedDate;
			}
			set
			{
				if ((this._ModifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
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
