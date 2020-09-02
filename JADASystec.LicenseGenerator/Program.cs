using JADASystec.Business.Dependencies;
using JADASystec.LicenseGenerator.Forms.General;
using JADASystect.CrossCutting.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JADASystec.LicenseGenerator
{
    static class Program
    {
        /// <summary
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-MX");
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTY5MjM5QDMxMzcyZTMxMmUzMEJHY2RiUTdhVWRYeFRTNG5pWXZQZ21ZZGhUUU9LcnhxSDFmZjJKNXN4R0E9");
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            InitializeContainer();
            Application.Run(new FrmHomePage());
        }

        public static void InitializeContainer()
        {
            RegisterDependencies();
            if (!ServiceLocator.ContainerIsBuild)
                ServiceLocator.Instance.Build();
        }

        public static void RegisterDependencies()
        {
            Register.RegisterDependencies();
            RegisterViewModelDependencies();
            RegisterValidationDependencies();
        }

        private static void RegisterValidationDependencies()
        {
            //ServiceLocator.Instance.Register<LoginValidator, IValidator<LoginViewModel>>();
            //ServiceLocator.Instance.Register<FormaPagoValidator, IValidator<FormaPagoViewModel>>();
            //ServiceLocator.Instance.Register<ClienteValidator, IValidator<ClienteViewModel>>();
            //ServiceLocator.Instance.Register<CategoriaProductoValidator, IValidator<CategoriaProductoViewModel>>();
            //ServiceLocator.Instance.Register<ServicioValidator, IValidator<ServicioViewModel>>();
            //ServiceLocator.Instance.Register<UsuarioValidator, IValidator<UsuarioViewModel>>();
            //ServiceLocator.Instance.Register<ProveedorValidator, IValidator<ProveedorViewModel>>();
            //ServiceLocator.Instance.Register<ProductoValidator, IValidator<ProductoViewModel>>();
            //ServiceLocator.Instance.Register<SucursalValidator, IValidator<SucursalViewModel>>();
            //ServiceLocator.Instance.Register<VentaValidator, IValidator<VentasViewModel>>();
            //ServiceLocator.Instance.Register<VentaValidator, IValidator<VentasViewModel>>();
            //ServiceLocator.Instance.Register<EncuestaValidator, IValidator<EncuestasViewModel>>();
            //ServiceLocator.Instance.Register<EmpleadoValidator, IValidator<EmpleadoViewModel>>();
            //ServiceLocator.Instance.Register<ReglaValidator, IValidator<ReglaPerfilViewModel>>();
            //ServiceLocator.Instance.Register<PaqueteValidator, IValidator<PaqueteViewModel>>();
            //ServiceLocator.Instance.Register<RegistroEntradaSalidaValidator, IValidator<RegistroEntradaSalidaViewModel>>();
            //ServiceLocator.Instance.Register<CompraValidator, IValidator<ComprasViewModel>>();
            //ServiceLocator.Instance.Register<CapturaCitaValidator, IValidator<CapturaCitaViewModel>>();
            //ServiceLocator.Instance.Register<ProductosMonederoValidator, IValidator<ProductosMonederoViewModel>>();
            //ServiceLocator.Instance.Register<ConsultaValidator, IValidator<CIDcontrolViewModel>>();
            //ServiceLocator.Instance.Register<EntradaSalidaAlmacenValidator, IValidator<EntradaSalidaAlmacenViewModel>>();
            //ServiceLocator.Instance.Register<AlimentoValidator, IValidator<AlimentoViewModels>>();
            //ServiceLocator.Instance.Register<CambioVentaValidator, IValidator<CambioVentaViewModel>>();
            //ServiceLocator.Instance.Register<CancelacionVentaValidator, IValidator<CancelacionVentaViewModel>>();
            //ServiceLocator.Instance.Register<ListaMedicionValidator, IValidator<ListaMedicionViewModel>>();
            //ServiceLocator.Instance.Register<MedicionValidator, IValidator<MedicionViewModel>>();
            //ServiceLocator.Instance.Register<DireccionesClienteValidator, IValidator<DireccionesClienteViewModel>>();
            //ServiceLocator.Instance.Register<PromocionValidator, IValidator<PromocionViewModel>>();
            //ServiceLocator.Instance.Register<AbonoPaqueteValidator, IValidator<PaqueteViewModel>>();
            //ServiceLocator.Instance.Register<ContestarMedicionValidator, IValidator<ContestarMedicionViewModel>>();
            //ServiceLocator.Instance.Register<AbonoPaqueteValidator, IValidator<PaqueteViewModel>>();
            //ServiceLocator.Instance.Register<CapturaConsultaValidator, IValidator<OpcionesViewModel>>();
            //ServiceLocator.Instance.Register<DireccionesClienteValidator, IValidator<DireccionesClienteViewModel>>();
            //ServiceLocator.Instance.Register<PromocionValidator, IValidator<PromocionViewModel>>();
            //ServiceLocator.Instance.Register<ListaPreciosValidator, IValidator<ListaPreciosViewModel>>();
            //ServiceLocator.Instance.Register<TraspasoProductoValidator, IValidator<TraspasoProductoViewModel>>();
            //ServiceLocator.Instance.Register<ArchivosConsultaValidator, IValidator<ArchivosConsultaViewModel>>();
            //ServiceLocator.Instance.Register<ReportePrecioProductoValidator, IValidator<ReportePrecioProductoViewModel>>();
            //ServiceLocator.Instance.Register<AutorizarValidator, IValidator<AutorizarViewModel>>();
            //ServiceLocator.Instance.Register<ReportePrecioProductoValidator, IValidator<ReportePrecioProductoViewModel>>();
            //ServiceLocator.Instance.Register<ArticuloValidator, IValidator<ArticulosViewModel>>();
            //ServiceLocator.Instance.Register<RegistrarEquipoValidator, IValidator<RegistrarEquipoViewModel>>();
            //ServiceLocator.Instance.Register<DatosEmpresaValidator, IValidator<DatosEmpresaViewModel>>();
            //ServiceLocator.Instance.Register<ConfiguracionesValidator, IValidator<ConfiguracionesViewModel>>();
            //ServiceLocator.Instance.Register<GastoEnvioValidator, IValidator<PedidoRealizadoViewModel>>();
            //ServiceLocator.Instance.Register<ValidarPagoValidator, IValidator<ValidarPagoViewModel>>();
            //ServiceLocator.Instance.Register<NumeroGuiaValidator, IValidator<NumeroGuiaViewModel>>();
            //ServiceLocator.Instance.Register<BancoValidator, IValidator<BancoViewModel>>();
            //ServiceLocator.Instance.Register<TarjetaValidator, IValidator<TarjetaViewModel>>();
            //ServiceLocator.Instance.Register<PuestoValidator, IValidator<PuestoViewModel>>();
        }

        private static void RegisterViewModelDependencies()
        {
            //ServiceLocator.Instance.Register<ValidatorFactory>();
            //ServiceLocator.Instance.Register<LoginViewModel>();
            //ServiceLocator.Instance.Register<FormaPagoViewModel>();
            //ServiceLocator.Instance.Register<ProductoViewModel>();
            //ServiceLocator.Instance.Register<ClienteViewModel>();
            //ServiceLocator.Instance.Register<VentasViewModel>();
            //ServiceLocator.Instance.Register<BusquedaProductoViewModel>();
            //ServiceLocator.Instance.Register<CategoriaProductoViewModel>();
            //ServiceLocator.Instance.Register<UsuarioViewModel>();
            //ServiceLocator.Instance.Register<ServicioViewModel>();
            //ServiceLocator.Instance.Register<SeleccionarPagoViewModel>();
            //ServiceLocator.Instance.Register<ProveedorViewModel>();
            //ServiceLocator.Instance.Register<SucursalViewModel>();
            //ServiceLocator.Instance.Register<ProveedorACompraViewModel>();
            //ServiceLocator.Instance.Register<CapturaCitaViewModel>();
            //ServiceLocator.Instance.Register<EncuestasViewModel>();
            //ServiceLocator.Instance.Register<EmpleadoViewModel>();
            //ServiceLocator.Instance.Register<ReglaPerfilViewModel>();
            //ServiceLocator.Instance.Register<PaqueteViewModel>();
            //ServiceLocator.Instance.Register<RegistroEntradaSalidaViewModel>();
            //ServiceLocator.Instance.Register<ComprasViewModel>();
            //ServiceLocator.Instance.Register<ConsultaViewModel>();
            //ServiceLocator.Instance.Register<OpcionesViewModel>();
            //ServiceLocator.Instance.Register<CIDcontrolViewModel>();
            //ServiceLocator.Instance.Register<PromocionViewModel>();
            //ServiceLocator.Instance.Register<ProductosMonederoViewModel>();
            //ServiceLocator.Instance.Register<AlimentoViewModels>();
            //ServiceLocator.Instance.Register<CambioVentaViewModel>();
            //ServiceLocator.Instance.Register<TurnoViewModel>();
            //ServiceLocator.Instance.Register<CancelacionVentaViewModel>();
            //ServiceLocator.Instance.Register<MedicionViewModel>();
            //ServiceLocator.Instance.Register<ListaMedicionViewModel>();
            //ServiceLocator.Instance.Register<AbonoPaqueteDetalleViewModel>();
            //ServiceLocator.Instance.Register<TurnoPrincipalViewModel>();
            //ServiceLocator.Instance.Register<ContestarMedicionViewModel>();
            //ServiceLocator.Instance.Register<CapturaConsultaViewModel>();
            //ServiceLocator.Instance.Register<DireccionesClienteViewModel>();
            //ServiceLocator.Instance.Register<CitasSinAgendarViewModel>();
            //ServiceLocator.Instance.Register<PaquetesClienteViewModel>();
            //ServiceLocator.Instance.Register<ListaPreciosViewModel>();
            //ServiceLocator.Instance.Register<MovimientoAlmacenViewModel>();
            //ServiceLocator.Instance.Register<ServicioBusquedaViewModel>();
            //ServiceLocator.Instance.Register<ServiciosClienteViewModel>();
            //ServiceLocator.Instance.Register<EntradaSalidaAlmacenViewModel>();
            //ServiceLocator.Instance.Register<SaldoPaqueteCitaViewModel>();
            //ServiceLocator.Instance.Register<HomeViewModel>();
            //ServiceLocator.Instance.Register<ReporteCompraViewModel>();
            //ServiceLocator.Instance.Register<ReporteProductoViewModel>();
            //ServiceLocator.Instance.Register<TraspasoProductoViewModel>();
            //ServiceLocator.Instance.Register<ServicioPedienteViewModel>();
            //ServiceLocator.Instance.Register<AplicarPuntosVentaViewModels>();
            //ServiceLocator.Instance.Register<ArchivosConsultaViewModel>();
            //ServiceLocator.Instance.Register<ConfiguracionesViewModel>();
            //ServiceLocator.Instance.Register<ReportePrecioProductoViewModel>();
            //ServiceLocator.Instance.Register<ReporteServicioViewModel>();
            //ServiceLocator.Instance.Register<BuscarConsultaViewModel>();
            //ServiceLocator.Instance.Register<AutorizarViewModel>();
            //ServiceLocator.Instance.Register<BuscarCitasViewModel>();
            //ServiceLocator.Instance.Register<VentasCreditoViewModel>();
            //ServiceLocator.Instance.Register<ArticulosViewModel>();
            //ServiceLocator.Instance.Register<CapturaDeArticulosViewModel>();
            //ServiceLocator.Instance.Register<ReporteProductoVendidoViewModel>();
            //ServiceLocator.Instance.Register<ReporteAsistenciaEmpleadoViewModel>();
            //ServiceLocator.Instance.Register<RegistrarEquipoViewModel>();
            //ServiceLocator.Instance.Register<DatosEmpresaViewModel>();
            //ServiceLocator.Instance.Register<PedidoRealizadoViewModel>();
            //ServiceLocator.Instance.Register<confirmarPagoPedidoViewModel>();
            //ServiceLocator.Instance.Register<ValidarPagoViewModel>();
            //ServiceLocator.Instance.Register<NumeroGuiaViewModel>();
            //ServiceLocator.Instance.Register<BancoViewModel>();
            //ServiceLocator.Instance.Register<ReimprimirTicketViewModel>();
            //ServiceLocator.Instance.Register<AbonosVentaCreditoViewModel>();
            //ServiceLocator.Instance.Register<TarjetaViewModel>();
            //ServiceLocator.Instance.Register<UnidadMedidaViewModel>();
            //ServiceLocator.Instance.Register<PuestoViewModel>();
            //ServiceLocator.Instance.Register<AplicarServicioViewModel>();
            //ServiceLocator.Instance.Register<MembresiaViewModel>();
            //ServiceLocator.Instance.Register<VentaEnEsperaViewModel>();
            //ServiceLocator.Instance.Register<BackUpViewModel>();
        }
    }
}
