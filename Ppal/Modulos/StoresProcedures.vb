' Version: 650, 7-may.-2018 12:42
' Version: 598, 20-nov.-2017 12:34
'♥ versión: 586, 6-oct.-2017 07:11
Public Module StoresProcedures
    Public Const DelCotAct As String = "DelCotAct"
    Public Const DelCotActividad As String = "DelCotActividad"
    Public Const DelCotActTipos As String = "DelCotActTipos"
    Public Const DelCotCargo As String = "DelCotCargo"
	'Public Const DelCotCliente As String = "DelCotCliente"
	'Public Const DelCotClienteContacto As String = "DelCotClienteContacto"
	Public Const DelCotCotizacionAutoriz As String = "DelCotCotizacionAutoriz"
    'Public Const DelCotCotizacionItems As String = "DelCotCotizacionItems"
    Public Const DelCotCotizacionFormato As String = "DelCotCotizacionFormato"
    Public Const DelCotEntradaSalida As String = "DelCotEntradaSalida"
    'Public Const DelCotEstado As String = "DelCotEstado"
    Public Const DelCotEstadoCot As String = "DelCotEstadoCot"
    Public Const DelCotEventos As String = "DelCotEventos"
    Public Const DelCotEventosTipos As String = "DelCotEventosTipos"
    Public Const DelCotFormaPago As String = "DelCotFormaPago"
    Public Const DelCotGrupo As String = "DelCotGrupo"
    Public Const DelCotGrupoSub As String = "DelCotGrupoSub"
    Public Const DelCotItem As String = "DelCotItem"

    Public Const DelCotIva As String = "DelCotIva"
    Public Const DelCotIvaZonaSub As String = "DelCotIvaZonaSub"
    Public Const DelCotOrigen As String = "DelCotOrigen"
    Public Const DelCotProfesion As String = "DelCotProfesion"
    Public Const DelCotTipo As String = "DelCotTipo"
    Public Const DelCotTipoCliente As String = "DelCotTipoCliente"
    Public Const DelCotTipoPerfil As String = "DelCotTipoPerfil"
    Public Const DelCotZona As String = "DelCotZona"
    Public Const DelCotZonaSub As String = "DelCotZonaSub"
    'Public Const DelVehColor As String = "DelVehColor"
    'Public Const DelVehLinea As String = "DelVehLinea"
    Public Const DelVehLineaModelo As String = "DelVehLineaModelo2"
    'Public Const DelVehMarca As String = "DelVehMarca"
    Public Const DelVehTriangulacion As String = "DelVehTriangulacion"
    Public Const GetCotActiviCRM As String = "GetCotActiviCRM3"
    'Public Const GetCotActividades As String = "GetCotActividades"
    Public Const GetCotActividadUna As String = "GetCotActividadUna2"
    Public Const GetCotActividadUnaSoloUsuarios As String = "GetCotActividadUnaSoloUsuarios"
    Public Const GetCotActiviResumen As String = "GetCotActiviResumen2"
    Public Const GetCotActNotas As String = "GetCotActNotas"
    'Public Const GetCotActTipos As String = "GetCotActTipos"
    Public Const GetCotAuditoria_Act As String = "GetCotAuditoria_Act"
	'Public Const GetCotAuditoria_Cli As String = "GetCotAuditoria_Cli"
	'Public Const GetCotAuditoria_Cotizacion As String = "GetCotAuditoria_Cotizacion"
	Public Const GetCotAuditoria_Items As String = "GetCotAuditoria_Items"
    Public Const GetCotAuditoria_LineaModelo As String = "GetCotAuditoria_LineaModelo"
    'Public Const GetCotAuditoria_Procs As String = "GetCotAuditoria_Procs"
    'Public Const GetCotBodegas As String = "GetCotBodegas"
    'Public Const GetCotBodegaUsuario_Permitidas As String = "GetCotBodegaUsuario_Permitidas"
    'Public Const GetCotBodegaUsuario As String = "GetCotBodegaUsuario"
    'Public Const GetCotCargos As String = "GetCotCargos"
    'Public Const GetCotClienteContactos As String = "GetCotClienteContactos2"
    'Public Const GetCotClienteContactosBasico As String = "GetCotClienteContactosBasico" 'GetCotClienteContactos2
    'Public Const GetCotClientes As String = "GetCotClientes"
    'Public Const GetCotClientesBasicoMasContactos As String = "GetCotClientesBasicoMasContactos8"
    Public Const GetCotClientesBasicoMasContactos_Mobile As String = "GetCotClientesBasicoMasContactos_Mobile"
    'Public Const GetCotClienteUltimoNumero As String = "GetCotClienteUltimoNumero"
    'Public Const GetCotCotizacionAutoriz As String = "GetCotCotizacionAutoriz"
    'Public Const GetCotCotizacionesClie As String = "GetCotCotizacionesClie5"
    'Public Const GetCotCotizacionesPorCliente As String = "GetCotCotizacionesPorCliente"
    'Public Const GetCotCotizacionesUlt As String = "GetCotCotizacionesUlt"
    'Public Const GetCotCotizacionEstado As String = "GetCotCotizacionEstado"
    'Public Const GetCotCotizacionFormatos As String = "GetCotCotizacionFormatos2"
    Public Const GetCotCotizacionFormatosUno As String = "GetCotCotizacionFormatosUno"
    Public Const GetCotCotizacionFormatosUnoDatos As String = "GetCotCotizacionFormatosUnoDatos3"
    Public Const GetCotCotizacionFormatosUnoVeh As String = "GetCotCotizacionFormatosUnoVeh"
    'Public Const GetCotCotizacionTotal As String = "GetCotCotizacionTotal"
    Public Const GetCotCotizacionUltima As String = "GetCotCotizacionUltima"
    'Public Const GetCotCotizacionVerifItem As String = "GetCotCotizacionVerifItem"
    Public Const GetCotDatosInteresantes As String = "GetCotDatosInteresantes2"
    Public Const GetCotDatosInteresantes_MiEstadistica As String = "GetCotDatosInteresantes_MiEstadistica"
    Public Const GetCotDatosInteresantes_Opos As String = "GetCotDatosInteresantes_Opos"
    Public Const GetCotDatosInteresantes_Promociones As String = "GetCotDatosInteresantes_Promociones"
    Public Const GetCotDatosInteresantes_UltItem As String = "GetCotDatosInteresantes_UltItem"
    Public Const GetCotDatosInteresantes_UltVta As String = "GetCotDatosInteresantes_UltVta"
    Public Const GetCotEstadis As String = "GetCotEstadis2"
    'Public Const GetCotEstados As String = "GetCotEstados"
    'Public Const GetCotEventosOport As String = "GetCotEventosOport"
    Public Const GetCotEventosTipos As String = "GetCotEventosTipos"
    Public Const GetCotEventoUno As String = "GetCotEventoUno"
    'Public Const GetCotFormaPago As String = "GetCotFormaPago"
    'Public Const GetCotFotosItems As String = "GetCotFotosItems"
    Public Const GetCotFotosUsuarios As String = "GetCotFotosUsuarios"
    'Public Const GetCotGrupos As String = "GetCotGrupos"
    'Public Const GetCotHistoria As String = "GetCotHistoria4"
    'Public Const GetCotItemHistorial As String = "GetCotItemHistorial"
    Public Const GetCotItemMov As String = "GetCotItemMov"

    Public Const GetCotItemPorCodigo As String = "GetCotItemPorCodigo2"
    'Public Const GetCotItemPorCodigoVeh As String = "GetCotItemPorCodigoVeh5"
    'Public Const GetCotItems As String = "GetCotItems9"
    'Public Const GetCotItemsNotas As String = "GetCotItemsNotas"
    'Public Const GetCotItemStock As String = "GetCotItemStock"

    Public Const GetCotItemUltimoNumero As String = "GetCotItemUltimoNumero"
    Public Const GetCotIvas As String = "GetCotIvas"
    'Public Const GetCotIvasSubZona As String = "GetCotIvasSubZona2"
    Public Const GetCotIvasSubZonaMaestro As String = "GetCotIvasSubZonaMaestro"
    'Public Const GetCotOrigenes As String = "GetCotOrigenes"
    'Public Const GetCotProfesiones As String = "GetCotProfesiones"
    'Public Const GetCotTasaDia As String = "GetCotTasaDia"
    Public Const GetCotTasaMoneda As String = "GetCotTasaMoneda"
    'Public Const GetCotTipoCliente As String = "GetCotTipoCliente"
    'Public Const GetCotTipoPago As String = "GetCotTipoPago"
    'Public Const GetCotTipoPerfil As String = "GetCotTipoPerfil"
    'Public Const GetCotTipos As String = "GetCotTipos"
    'Public Const GetCotTiposCamp As String = "GetCotTiposCamp"
    Public Const GetCotUsuariosWho As String = "GetCotUsuariosWho"
    'Public Const GetCotVendedores As String = "GetCotVendedores2"
    'Public Const GetCotVerifNit As String = "GetCotVerifNit"
    Public Const GetCotVerifRazonSocial As String = "GetCotVerifRazonSocial"
    'Public Const GetCotZonas As String = "GetCotZonas"
    Public Const GetImagen As String = "GetImagen"
    Public Const GetPermisosUsuario As String = "GetPermisosUsuario_New"
    'Public Const GetVehColores As String = "GetVehColores"
    Public Const GetVehConcesionariosPais As String = "GetVehConcesionariosPais"
    'Public Const GetVehiculosEmpresa As String = "GetVehiculosEmpresa"
    Public Const GetVehLineaModelo_Total As String = "GetVehLineaModelo_Total"
    'Public Const GetVehLineasMarca As String = "GetVehLineasMarca2"
    Public Const GetVehLineasMarca_PuedenCrear As String = "GetVehLineasMarca_PuedenCrear"
    'Public Const GetVehLineasModelo As String = "GetVehLineasModelo"
    'Public Const GetVehModelos As String = "GetVehModelos3"
    Public Const GetVehReservas As String = "GetVehReservas"
    Public Const GetVehTriangulacion As String = "GetVehTriangulacion"
    Public Const GetVehTriangulacionResultados As String = "GetVehTriangulacionResultados6"
    Public Const GetVehTriangulacionResultadosQuien As String = "GetVehTriangulacionResultadosQuien3"
    'Public Const GetVehTriangulacionTotal As String = "GetVehTriangulacionTotal2"
    'Public Const PutCotAct As String = "PutCotAct2"
    Public Const PutCotActSoloUsuario As String = "PutCotActSoloUsuario"
    Public Const PutCotActividad As String = "PutCotActividad"
    Public Const PutCotActTipos As String = "PutCotActTipos"
    Public Const PutCotCargo As String = "PutCotCargo"
    'Public Const PutCotClientes As String = "PutCotClientes4"
    'Public Const PutCotClienteContacto As String = "PutCotClienteContacto2"
    Public Const PutCotContactoMail As String = "PutCotContactoMail"
    'Public Const PutCotCotiza As String = "PutCotCotiza3"
    'Public Const PutCotCotizaCambiar As String = "PutCotCotizaCambiar2"
    Public Const PutCotCotizacionAutoriz As String = "PutCotCotizacionAutoriz"
    Public Const PutCotCotizacionFormato As String = "PutCotCotizacionFormato2"
    'Public Const PutCotCotizacionItems As String = "PutCotCotizacionItems3"
    Public Const PutCotDatosIniciales As String = "PutCotDatosIniciales"
    Public Const PutCotEntradaSalida As String = "PutCotEntradaSalida"
    'Public Const PutCotEstado As String = "PutCotEstado"
    Public Const PutCotEstadoCot As String = "PutCotEstadoCot"
    'Public Const PutCotEventos As String = "PutCotEventos4"
    Public Const PutCotEventosTipos As String = "PutCotEventosTipos"
    Public Const PutCotFormaPago As String = "PutCotFormaPago"
    Public Const PutCotGrupo As String = "PutCotGrupo"
    Public Const PutCotGrupoSub As String = "PutCotGrupoSub"
	'Public Const PutCotItem As String = "PutCotItem4"
	'Public Const PutCotItemVeh As String = "PutCotItemVeh6"
	Public Const PutCotIva As String = "PutCotIva2"
    Public Const PutCotIvaZonaSub As String = "PutCotIvaZonaSub"
    Public Const PutCotMoneda As String = "PutCotMoneda"
    Public Const PutCotOrigen As String = "PutCotOrigen"
    Public Const PutCotProfesion As String = "PutCotProfesion"
    Public Const PutCotReciboCaja As String = "PutCotReciboCaja"
    Public Const PutCotTasaDia As String = "PutCotTasaDia2"
    Public Const PutCotTipo As String = "PutCotTipo5"
    Public Const PutCotTipoCliente As String = "PutCotTipoCliente"
    Public Const PutCotTipoPerfil As String = "PutCotTipoPerfil"
    'Public Const PutCotStatusFinal As String = "PutCotStatusFinal3"
    Public Const PutCotUsuarioPresup As String = "PutCotUsuarioPresup"
    Public Const PutCotUsuariosWho As String = "PutCotUsuariosWho"
    Public Const PutCotZona As String = "PutCotZona"
    Public Const PutCotZonaSub As String = "PutCotZonaSub"
    Public Const PutImagenCotItem As String = "PutImagenCotItem"
    'Public Const PutVehColor As String = "PutVehColor"
    'Public Const PutVehLinea As String = "PutVehLinea2"
    Public Const PutVehLineaModelo As String = "PutVehLineaModelo4"
    'Public Const PutVehLineaModelo_Consolidar As String = "PutVehLineaModelo_Consolidar"
    'Public Const PutVehMarca As String = "PutVehMarca"
    'Public Const PutVehReservas As String = "PutVehReservas"
    Public Const PutVehTriangulacion As String = "PutVehTriangulacion4"
    'Public Const Get As String = ""
    'Public Const Get As String = ""
    'Public Const Get As String = ""
    'Public Const Get As String = ""
    'Public Const Get As String = ""
    Public Const PutCotBodega As String = "PutCotBodega"
    Public Const DelCotBodega As String = "DelCotBodega"
    'Public Const GetCotUsuBod As String = "GetCotUsuBod"
    Public Const DelCotUsuBod As String = "DelCotUsuBod"
    Public Const PutCotUsuBod As String = "PutCotUsuBod"

End Module
