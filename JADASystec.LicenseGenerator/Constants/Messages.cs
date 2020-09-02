using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JADASystec.LicenseGenerator.Constants
{
    public static class Messages
    {
        public const string SystemName = "JADA SYSTEC - PUNTO DE VENTA";
        public const string ErrorMessage = "OCURRIÓ UN ERROR AL GUARDAR LOS DATOS.";
        public const string SuccessMessage = "DATOS GUARDADOS CORRECTAMENTE.";
        public const string ErrorClaveExistente = "LA CLAVE YA EXISTE, VERIFICAR CON UN ADMINISTRADOR.";
        public const string ErrorLoadMessage = "OCURRIÓ UN ERROR AL CARGAR LOS DATOS.";
        public const string ConfirmOutMessage = "¿DESEA CERRAR COMPLETAMENTE EL SISTEMA?";
        public const string GridSelectMessage = "DEBE SELECCIONAR UNA FILA DE LA TABLA.";
        public const string GridSelectCliente = "DEBE SELECCIONAR UNA CLIENTE.";
        public const string ConfirmDeleteMessage = "¿DESEA ELIMINAR ESTE REGISTRO?";
        public const string SuccessDeleteMessage = "DATOS ELIMINADOS CORRECTAMENTE.";
        public const string ErrorDeleteMessage = "OCURRIÓ UN ERROR AL ELIMINAR LOS DATOS.";
        public const string DeleteMedicionMessage = "NO SE PUEDE ELIMINAR ESTA MEDICIÓN.";
        public const string DeleteConsultaMessage = "NO SE PUEDE ELIMINAR ESTE SERVICIO";
        public const string ErrorFormulario = "OCURRIÓ UN ERROR AL CARGAR EL FORMULARIO.";
        public const string LoginErrorMessage = "FAVOR DE VERIFICAR SUS CREDENCIALES.";
        public const string ErrorMacExists = "ESTA MAC SE ENCUENTRA OCUPADA.";
        public const string ErrorAlCancelarFrm = "OCURRIÓ UN ERROR AL CANCELAR EL FORMULARIO.";
        public const string VersionSistema = "Versión 2.0.";
        public const string ErrorBusqueda = "OCURRIÓ UN ERROR AL BUSCAR LOS DATOS.";
        public const string CategoryIsOcuped = "ESTA CATEGORÍA CONTIENE PRODUCTOS EXISTENTES";
        public const string ConfirmCancelInput = "¿DESEA CANCELAR ESTE REGISTRO?";
        public const string ConfirmOutMessageChild = "¿DESEA CERRAR EL FORMULARIO?";
        public const string ErrorAlEliminarTabla = "OCURRIO UN ERROR AL ELIMINAR EL REGISTRO DE LA TABLA";
        public const string DocumentIncorrect = "NO HA SELECCIONADO UN ARCHIVO CON EL FORMATO CORRECTO.";
        public const string Empty = "NO HA SELECCIONADO NINGUN ARCHIVO.";
        public const string Correct = "NO HAY DIFERENCIAS DE INVENTARIO.";
        public const string OneService = "SOLO UN SERVICIO A LA VEZ.";
        public const string NoEliminarTurno = "NO SE PUEDE ELIMINAR ESTE TURNO.";
        public const string HaveProduct = "SE BORRARÁ LA LISTA DE PRODUCTOS, ¿DESEA CONTINUAR?";

        public const string FechaSelectMessage = "SELECCIONE UNA FECHA POSTERIOR O IGUAL A LA DE HOY.";
        public const string ClienteSelectMessage = "SELECCIONE UN CLIENTE.";
        public const string PaqueteSelectMessage = "SELECCIONE UN PAQUETE.";
        public const string ServicioSelectMessage = "SELECCIONE UN SERVICIO.";
        public const string PaidAppointment = "NO PUEDE ELIMINAR CITAS PAGADAS.";
        public const string PagoAnticipado = "NO PUEDE ELIMINAR CITAS CON ANTICIPO DE PAGO.";
        public const string NoEliminarTurnoAsignado = "NO SE PUEDE ELIMINAR EL TURNO, ESTA ASIGNADO A LOS EMPLEADOS.";
        public const string CambiarCliente = "¿DESEA CAMBIAR DE CLIENTE?.";
        public const string EiminarArticulo = "¿DESEA QUITAR ESTE ARTICULO?";
        public const string NoEliminarServicioPagado = "NO SE PUEDE ELIMINAR EL SERVICIO, YA FUE PAGADO";
        public const string CerrarTurno = "¿DESEA CERRAR EL TURNO?";
        public const string TurnoCerrado = "EL TURNO ACTUAL YA ESTÁ CERRADO.";
        public const string ServicioAplicado = "EL SERVICIO NO PUEDE SER APLICADO. TIENE QUE ESTAR PAGADO.";
        public const string NoPaquete = "EL SERVICIO NO PERTENECE A UN PAQUETE";
        public const string AutorizarVentaCredito = "NECESITA AUTORIZACION ¿DESEA CONTINUAR?";

        public const string ErrorAutorizar = "LA CUENTA NO ES VALIDA O NO EXISTE";
        public const string ConfirmChangeVenta = "LA VENTA SE REINICIARA ¿DESEA CONTINUAR?";

        public const string NoEliminarFormaPago = "NO SE PUEDE ELIMINAR ESTA FORMA DE PAGO.";
        public const string NoModificarFormaPago = "NO SE PUEDE MODIFICAR ESTA FORMA DE PAGO.";
        public const string ErrorReporte = "OCURRIO UN ERROR AL CARGAR EL REPORTE.";
        public const string ErrorFechaFin = "LA FECHA FIN NO PUEDE SER MENOR A LA FECHA INICIO.";
        public const string CloseSystem = "EL SISTEMA SE CERRARA PARA GUARDAR LOS CAMBIOS";
        public const string ConsultaNoPagada = "LA CONSULTA NO HA SIDO PAGADA";
        public const string ConsultaSiPagada = "LA CONSULTA YA HA SIDO PAGADA";
        public const string ConfirmCloseForm = "Ya existe un formulario abierto de {0}, ¿Desea cerrar y abrir otro formulario?";
        public const string ConsultaNoValida = "SELECCIONE UNA CONSULTA DE CONTROL NUTRICIONAL";
        public const string ConSeguimiento = "LA CONSULTA YA CUENTA CON UN SEGUIMIENTO";

        public const string VarificarModificacion = "NO SE PUEDE MODIFICAR. DESEA VISUALIZAR LA INFORMACIÓN";
        public const string RegistroEntradaSalida = "EL EMPLEADO NO PERTENECE A LA SUCURSAL ACTUAL.";

        public const string CitaAddMessage = "AGREGUE UNA CITA.";
        public const string CitaSelectMessage = "SELECCIONE UNA CITA.";
        public const string CitaAplicada = "LA CITA YA HA SIDO APLICADA.";
        public const string CitaAlcargarLosdatos = "OCURRIO UN ERROR AL CARGAR LOS DATOS";
        public const string CitaErrorPaquete = "OCURRIO UN ERROR AL GUARDAR EL PAQUETE";
        public const string CitaErrorNavegacion = "OCURRIO UN ERROR AL INTENTAR NAVEGAR EN LAS FECHAS.";

        public const string SucursalEliminarVitural = "NO SE PUEDE ELIMINAR LA SUCURSAL VIRTUAL.";
        public const string statusPedido = "EL REGISTRO YA TIENE ASIGNADO UNA ORDEN DE PEDIDO";
        public const string confirmShippingCost = "ESTE PROCESO ES IRREVERSIBLE ¿DESEA CONTINUAR?";
        public const string ProductoPromocion = "EL PRODUCTO YA CUENTA CON UNA PROMOCIÓN.";
        public const string ServicioPromocion = "EL SERVICIO YA CUENTA CON UNA PROMOCIÓN.";

        public const string ModuloConstruccion = "EL MÓDULO DEL SISTEMA SE ENCUENTRA EN CONSTRUCCIÓN.";
        public const string NoDeleteRegister = "NO SE PUEDE BORRAR ESTE REGISTRO.";

        public const string ArtComunNombre = "INGRESE UN PRODUCTO COMUN.";
        public const string ArtComunCantidad = "INGRESE UNA CANTIDAD.";
        public const string ArtComunPrecio = "INGRESE EL PRECIO.";
        public const string ErrorActivacion = "DATOS INCORRECTOS DEL ARCHIVO DE LICENCIA.";
        public const string ConfirmOutMessageMembresia = "EL SISTEMA SE CERRARA POR COMPLETO PARA APLICAR LOS CAMBIOS";


        public const string SuccessMessageVEspera = "SE AGREGO A VENTA EN ESPERA CORRECTAMENTE";
        public const string ErrorMessageVEspera = "OCURRIO UN ERROR AL AGREGAR LA VENTA EN ESPERA";
        public const string ConfirmSaleCancel = "¿DESEA CANCELAR ESTA COMPRA?, ESTE PROCESO ES IRREVERSIBLE.";
        public const string ConfirmCancelSale = "COMPRA CANCELADA CORRECTAMENTE.";
        public const string ErrorCancelSale = "OCURRIO UN ERROR AL CANCELAR LA VENTA.";

        #region Message JADA
        public const string NotProductDB = "!Producto no encontrado en la Base de Datos.!";
        public const string NotDelete = "No se puede Eliminar el Cliente Generico.";
        public const string NotUpdate = "No se puede Modificar el Cliente Generico.";
        #endregion
    }
}
