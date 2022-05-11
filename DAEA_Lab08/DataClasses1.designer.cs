﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAEA_Lab08
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Neptuno")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Insertclientes(clientes instance);
    partial void Updateclientes(clientes instance);
    partial void Deleteclientes(clientes instance);
    partial void InsertPedidos(Pedidos instance);
    partial void UpdatePedidos(Pedidos instance);
    partial void DeletePedidos(Pedidos instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::DAEA_Lab08.Properties.Settings.Default.NeptunoConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<clientes> clientes
		{
			get
			{
				return this.GetTable<clientes>();
			}
		}
		
		public System.Data.Linq.Table<Pedidos> Pedidos
		{
			get
			{
				return this.GetTable<Pedidos>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.clientes")]
	public partial class clientes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _idCliente;
		
		private string _NombreCompañia;
		
		private string _NombreContacto;
		
		private string _CargoContacto;
		
		private string _Direccion;
		
		private string _Ciudad;
		
		private string _Region;
		
		private string _CodPostal;
		
		private string _Pais;
		
		private string _Telefono;
		
		private string _Fax;
		
		private EntitySet<Pedidos> _Pedidos;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidClienteChanging(string value);
    partial void OnidClienteChanged();
    partial void OnNombreCompañiaChanging(string value);
    partial void OnNombreCompañiaChanged();
    partial void OnNombreContactoChanging(string value);
    partial void OnNombreContactoChanged();
    partial void OnCargoContactoChanging(string value);
    partial void OnCargoContactoChanged();
    partial void OnDireccionChanging(string value);
    partial void OnDireccionChanged();
    partial void OnCiudadChanging(string value);
    partial void OnCiudadChanged();
    partial void OnRegionChanging(string value);
    partial void OnRegionChanged();
    partial void OnCodPostalChanging(string value);
    partial void OnCodPostalChanged();
    partial void OnPaisChanging(string value);
    partial void OnPaisChanged();
    partial void OnTelefonoChanging(string value);
    partial void OnTelefonoChanged();
    partial void OnFaxChanging(string value);
    partial void OnFaxChanged();
    #endregion
		
		public clientes()
		{
			this._Pedidos = new EntitySet<Pedidos>(new Action<Pedidos>(this.attach_Pedidos), new Action<Pedidos>(this.detach_Pedidos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCliente", DbType="VarChar(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string idCliente
		{
			get
			{
				return this._idCliente;
			}
			set
			{
				if ((this._idCliente != value))
				{
					this.OnidClienteChanging(value);
					this.SendPropertyChanging();
					this._idCliente = value;
					this.SendPropertyChanged("idCliente");
					this.OnidClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreCompañia", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string NombreCompañia
		{
			get
			{
				return this._NombreCompañia;
			}
			set
			{
				if ((this._NombreCompañia != value))
				{
					this.OnNombreCompañiaChanging(value);
					this.SendPropertyChanging();
					this._NombreCompañia = value;
					this.SendPropertyChanged("NombreCompañia");
					this.OnNombreCompañiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreContacto", DbType="VarChar(100)")]
		public string NombreContacto
		{
			get
			{
				return this._NombreContacto;
			}
			set
			{
				if ((this._NombreContacto != value))
				{
					this.OnNombreContactoChanging(value);
					this.SendPropertyChanging();
					this._NombreContacto = value;
					this.SendPropertyChanged("NombreContacto");
					this.OnNombreContactoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CargoContacto", DbType="VarChar(100)")]
		public string CargoContacto
		{
			get
			{
				return this._CargoContacto;
			}
			set
			{
				if ((this._CargoContacto != value))
				{
					this.OnCargoContactoChanging(value);
					this.SendPropertyChanging();
					this._CargoContacto = value;
					this.SendPropertyChanged("CargoContacto");
					this.OnCargoContactoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(100)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this.OnDireccionChanging(value);
					this.SendPropertyChanging();
					this._Direccion = value;
					this.SendPropertyChanged("Direccion");
					this.OnDireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ciudad", DbType="VarChar(100)")]
		public string Ciudad
		{
			get
			{
				return this._Ciudad;
			}
			set
			{
				if ((this._Ciudad != value))
				{
					this.OnCiudadChanging(value);
					this.SendPropertyChanging();
					this._Ciudad = value;
					this.SendPropertyChanged("Ciudad");
					this.OnCiudadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Region", DbType="VarChar(100)")]
		public string Region
		{
			get
			{
				return this._Region;
			}
			set
			{
				if ((this._Region != value))
				{
					this.OnRegionChanging(value);
					this.SendPropertyChanging();
					this._Region = value;
					this.SendPropertyChanged("Region");
					this.OnRegionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodPostal", DbType="VarChar(100)")]
		public string CodPostal
		{
			get
			{
				return this._CodPostal;
			}
			set
			{
				if ((this._CodPostal != value))
				{
					this.OnCodPostalChanging(value);
					this.SendPropertyChanging();
					this._CodPostal = value;
					this.SendPropertyChanged("CodPostal");
					this.OnCodPostalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pais", DbType="VarChar(100)")]
		public string Pais
		{
			get
			{
				return this._Pais;
			}
			set
			{
				if ((this._Pais != value))
				{
					this.OnPaisChanging(value);
					this.SendPropertyChanging();
					this._Pais = value;
					this.SendPropertyChanged("Pais");
					this.OnPaisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="VarChar(30)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fax", DbType="VarChar(30)")]
		public string Fax
		{
			get
			{
				return this._Fax;
			}
			set
			{
				if ((this._Fax != value))
				{
					this.OnFaxChanging(value);
					this.SendPropertyChanging();
					this._Fax = value;
					this.SendPropertyChanged("Fax");
					this.OnFaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="clientes_Pedidos", Storage="_Pedidos", ThisKey="idCliente", OtherKey="IdCliente")]
		public EntitySet<Pedidos> Pedidos
		{
			get
			{
				return this._Pedidos;
			}
			set
			{
				this._Pedidos.Assign(value);
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
		
		private void attach_Pedidos(Pedidos entity)
		{
			this.SendPropertyChanging();
			entity.clientes = this;
		}
		
		private void detach_Pedidos(Pedidos entity)
		{
			this.SendPropertyChanging();
			entity.clientes = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pedidos")]
	public partial class Pedidos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdPedido;
		
		private string _IdCliente;
		
		private int _IdEmpleado;
		
		private System.Nullable<System.DateTime> _FechaPedido;
		
		private System.Nullable<System.DateTime> _FechaEntrega;
		
		private System.Nullable<System.DateTime> _FechaEnvio;
		
		private System.Nullable<int> _FormaEnvio;
		
		private System.Nullable<decimal> _Cargo;
		
		private string _Destinatario;
		
		private string _DireccionDestinatario;
		
		private string _CiudadDestinatario;
		
		private string _RegionDestinatario;
		
		private string _CodPostalDestinatario;
		
		private string _PaisDestinatario;
		
		private EntityRef<clientes> _clientes;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdPedidoChanging(int value);
    partial void OnIdPedidoChanged();
    partial void OnIdClienteChanging(string value);
    partial void OnIdClienteChanged();
    partial void OnIdEmpleadoChanging(int value);
    partial void OnIdEmpleadoChanged();
    partial void OnFechaPedidoChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaPedidoChanged();
    partial void OnFechaEntregaChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaEntregaChanged();
    partial void OnFechaEnvioChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaEnvioChanged();
    partial void OnFormaEnvioChanging(System.Nullable<int> value);
    partial void OnFormaEnvioChanged();
    partial void OnCargoChanging(System.Nullable<decimal> value);
    partial void OnCargoChanged();
    partial void OnDestinatarioChanging(string value);
    partial void OnDestinatarioChanged();
    partial void OnDireccionDestinatarioChanging(string value);
    partial void OnDireccionDestinatarioChanged();
    partial void OnCiudadDestinatarioChanging(string value);
    partial void OnCiudadDestinatarioChanged();
    partial void OnRegionDestinatarioChanging(string value);
    partial void OnRegionDestinatarioChanged();
    partial void OnCodPostalDestinatarioChanging(string value);
    partial void OnCodPostalDestinatarioChanged();
    partial void OnPaisDestinatarioChanging(string value);
    partial void OnPaisDestinatarioChanged();
    #endregion
		
		public Pedidos()
		{
			this._clientes = default(EntityRef<clientes>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPedido", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdPedido
		{
			get
			{
				return this._IdPedido;
			}
			set
			{
				if ((this._IdPedido != value))
				{
					this.OnIdPedidoChanging(value);
					this.SendPropertyChanging();
					this._IdPedido = value;
					this.SendPropertyChanged("IdPedido");
					this.OnIdPedidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdCliente", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string IdCliente
		{
			get
			{
				return this._IdCliente;
			}
			set
			{
				if ((this._IdCliente != value))
				{
					if (this._clientes.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdClienteChanging(value);
					this.SendPropertyChanging();
					this._IdCliente = value;
					this.SendPropertyChanged("IdCliente");
					this.OnIdClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEmpleado", DbType="Int NOT NULL")]
		public int IdEmpleado
		{
			get
			{
				return this._IdEmpleado;
			}
			set
			{
				if ((this._IdEmpleado != value))
				{
					this.OnIdEmpleadoChanging(value);
					this.SendPropertyChanging();
					this._IdEmpleado = value;
					this.SendPropertyChanged("IdEmpleado");
					this.OnIdEmpleadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaPedido", DbType="Date")]
		public System.Nullable<System.DateTime> FechaPedido
		{
			get
			{
				return this._FechaPedido;
			}
			set
			{
				if ((this._FechaPedido != value))
				{
					this.OnFechaPedidoChanging(value);
					this.SendPropertyChanging();
					this._FechaPedido = value;
					this.SendPropertyChanged("FechaPedido");
					this.OnFechaPedidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaEntrega", DbType="Date")]
		public System.Nullable<System.DateTime> FechaEntrega
		{
			get
			{
				return this._FechaEntrega;
			}
			set
			{
				if ((this._FechaEntrega != value))
				{
					this.OnFechaEntregaChanging(value);
					this.SendPropertyChanging();
					this._FechaEntrega = value;
					this.SendPropertyChanged("FechaEntrega");
					this.OnFechaEntregaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaEnvio", DbType="Date")]
		public System.Nullable<System.DateTime> FechaEnvio
		{
			get
			{
				return this._FechaEnvio;
			}
			set
			{
				if ((this._FechaEnvio != value))
				{
					this.OnFechaEnvioChanging(value);
					this.SendPropertyChanging();
					this._FechaEnvio = value;
					this.SendPropertyChanged("FechaEnvio");
					this.OnFechaEnvioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FormaEnvio", DbType="Int")]
		public System.Nullable<int> FormaEnvio
		{
			get
			{
				return this._FormaEnvio;
			}
			set
			{
				if ((this._FormaEnvio != value))
				{
					this.OnFormaEnvioChanging(value);
					this.SendPropertyChanging();
					this._FormaEnvio = value;
					this.SendPropertyChanged("FormaEnvio");
					this.OnFormaEnvioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cargo", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Cargo
		{
			get
			{
				return this._Cargo;
			}
			set
			{
				if ((this._Cargo != value))
				{
					this.OnCargoChanging(value);
					this.SendPropertyChanging();
					this._Cargo = value;
					this.SendPropertyChanged("Cargo");
					this.OnCargoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Destinatario", DbType="VarChar(60)")]
		public string Destinatario
		{
			get
			{
				return this._Destinatario;
			}
			set
			{
				if ((this._Destinatario != value))
				{
					this.OnDestinatarioChanging(value);
					this.SendPropertyChanging();
					this._Destinatario = value;
					this.SendPropertyChanged("Destinatario");
					this.OnDestinatarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DireccionDestinatario", DbType="VarChar(60)")]
		public string DireccionDestinatario
		{
			get
			{
				return this._DireccionDestinatario;
			}
			set
			{
				if ((this._DireccionDestinatario != value))
				{
					this.OnDireccionDestinatarioChanging(value);
					this.SendPropertyChanging();
					this._DireccionDestinatario = value;
					this.SendPropertyChanged("DireccionDestinatario");
					this.OnDireccionDestinatarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CiudadDestinatario", DbType="VarChar(60)")]
		public string CiudadDestinatario
		{
			get
			{
				return this._CiudadDestinatario;
			}
			set
			{
				if ((this._CiudadDestinatario != value))
				{
					this.OnCiudadDestinatarioChanging(value);
					this.SendPropertyChanging();
					this._CiudadDestinatario = value;
					this.SendPropertyChanged("CiudadDestinatario");
					this.OnCiudadDestinatarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegionDestinatario", DbType="VarChar(60)")]
		public string RegionDestinatario
		{
			get
			{
				return this._RegionDestinatario;
			}
			set
			{
				if ((this._RegionDestinatario != value))
				{
					this.OnRegionDestinatarioChanging(value);
					this.SendPropertyChanging();
					this._RegionDestinatario = value;
					this.SendPropertyChanged("RegionDestinatario");
					this.OnRegionDestinatarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodPostalDestinatario", DbType="VarChar(60)")]
		public string CodPostalDestinatario
		{
			get
			{
				return this._CodPostalDestinatario;
			}
			set
			{
				if ((this._CodPostalDestinatario != value))
				{
					this.OnCodPostalDestinatarioChanging(value);
					this.SendPropertyChanging();
					this._CodPostalDestinatario = value;
					this.SendPropertyChanged("CodPostalDestinatario");
					this.OnCodPostalDestinatarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaisDestinatario", DbType="VarChar(60)")]
		public string PaisDestinatario
		{
			get
			{
				return this._PaisDestinatario;
			}
			set
			{
				if ((this._PaisDestinatario != value))
				{
					this.OnPaisDestinatarioChanging(value);
					this.SendPropertyChanging();
					this._PaisDestinatario = value;
					this.SendPropertyChanged("PaisDestinatario");
					this.OnPaisDestinatarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="clientes_Pedidos", Storage="_clientes", ThisKey="IdCliente", OtherKey="idCliente", IsForeignKey=true)]
		public clientes clientes
		{
			get
			{
				return this._clientes.Entity;
			}
			set
			{
				clientes previousValue = this._clientes.Entity;
				if (((previousValue != value) 
							|| (this._clientes.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._clientes.Entity = null;
						previousValue.Pedidos.Remove(this);
					}
					this._clientes.Entity = value;
					if ((value != null))
					{
						value.Pedidos.Add(this);
						this._IdCliente = value.idCliente;
					}
					else
					{
						this._IdCliente = default(string);
					}
					this.SendPropertyChanged("clientes");
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
