using System;
using System.ComponentModel;
using System.Diagnostics;

namespace MercaderSG.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public AltaCliente m_AltaCliente;

            public AltaCliente AltaCliente
            {
                [DebuggerHidden]
                get
                {
                    m_AltaCliente = Create__Instance__(m_AltaCliente);
                    return m_AltaCliente;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_AltaCliente))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_AltaCliente);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public AltaFamilia m_AltaFamilia;

            public AltaFamilia AltaFamilia
            {
                [DebuggerHidden]
                get
                {
                    m_AltaFamilia = Create__Instance__(m_AltaFamilia);
                    return m_AltaFamilia;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_AltaFamilia))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_AltaFamilia);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public AltaLocalidad m_AltaLocalidad;

            public AltaLocalidad AltaLocalidad
            {
                [DebuggerHidden]
                get
                {
                    m_AltaLocalidad = Create__Instance__(m_AltaLocalidad);
                    return m_AltaLocalidad;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_AltaLocalidad))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_AltaLocalidad);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public AltaProducto m_AltaProducto;

            public AltaProducto AltaProducto
            {
                [DebuggerHidden]
                get
                {
                    m_AltaProducto = Create__Instance__(m_AltaProducto);
                    return m_AltaProducto;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_AltaProducto))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_AltaProducto);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public AltaProveedor m_AltaProveedor;

            public AltaProveedor AltaProveedor
            {
                [DebuggerHidden]
                get
                {
                    m_AltaProveedor = Create__Instance__(m_AltaProveedor);
                    return m_AltaProveedor;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_AltaProveedor))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_AltaProveedor);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public AltaUsuario m_AltaUsuario;

            public AltaUsuario AltaUsuario
            {
                [DebuggerHidden]
                get
                {
                    m_AltaUsuario = Create__Instance__(m_AltaUsuario);
                    return m_AltaUsuario;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_AltaUsuario))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_AltaUsuario);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Backup m_Backup;

            public Backup Backup
            {
                [DebuggerHidden]
                get
                {
                    m_Backup = Create__Instance__(m_Backup);
                    return m_Backup;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Backup))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Backup);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public BarraProgreso m_BarraProgreso;

            public BarraProgreso BarraProgreso
            {
                [DebuggerHidden]
                get
                {
                    m_BarraProgreso = Create__Instance__(m_BarraProgreso);
                    return m_BarraProgreso;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_BarraProgreso))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_BarraProgreso);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Bitacora m_Bitacora;

            public Bitacora Bitacora
            {
                [DebuggerHidden]
                get
                {
                    m_Bitacora = Create__Instance__(m_Bitacora);
                    return m_Bitacora;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Bitacora))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Bitacora);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public BuscarCliente m_BuscarCliente;

            public BuscarCliente BuscarCliente
            {
                [DebuggerHidden]
                get
                {
                    m_BuscarCliente = Create__Instance__(m_BuscarCliente);
                    return m_BuscarCliente;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_BuscarCliente))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_BuscarCliente);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public BuscarProducto m_BuscarProducto;

            public BuscarProducto BuscarProducto
            {
                [DebuggerHidden]
                get
                {
                    m_BuscarProducto = Create__Instance__(m_BuscarProducto);
                    return m_BuscarProducto;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_BuscarProducto))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_BuscarProducto);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public BuscarProveedor m_BuscarProveedor;

            public BuscarProveedor BuscarProveedor
            {
                [DebuggerHidden]
                get
                {
                    m_BuscarProveedor = Create__Instance__(m_BuscarProveedor);
                    return m_BuscarProveedor;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_BuscarProveedor))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_BuscarProveedor);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public CambiarContrasena m_CambiarContrasena;

            public CambiarContrasena CambiarContrasena
            {
                [DebuggerHidden]
                get
                {
                    m_CambiarContrasena = Create__Instance__(m_CambiarContrasena);
                    return m_CambiarContrasena;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_CambiarContrasena))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_CambiarContrasena);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ConsultarNP m_ConsultarNP;

            public ConsultarNP ConsultarNP
            {
                [DebuggerHidden]
                get
                {
                    m_ConsultarNP = Create__Instance__(m_ConsultarNP);
                    return m_ConsultarNP;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ConsultarNP))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ConsultarNP);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ConsultarNV m_ConsultarNV;

            public ConsultarNV ConsultarNV
            {
                [DebuggerHidden]
                get
                {
                    m_ConsultarNV = Create__Instance__(m_ConsultarNV);
                    return m_ConsultarNV;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ConsultarNV))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ConsultarNV);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ConsultarRemito m_ConsultarRemito;

            public ConsultarRemito ConsultarRemito
            {
                [DebuggerHidden]
                get
                {
                    m_ConsultarRemito = Create__Instance__(m_ConsultarRemito);
                    return m_ConsultarRemito;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ConsultarRemito))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ConsultarRemito);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public DesbloquearUsuario m_DesbloquearUsuario;

            public DesbloquearUsuario DesbloquearUsuario
            {
                [DebuggerHidden]
                get
                {
                    m_DesbloquearUsuario = Create__Instance__(m_DesbloquearUsuario);
                    return m_DesbloquearUsuario;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_DesbloquearUsuario))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_DesbloquearUsuario);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public EliminarTelCliente m_EliminarTelCliente;

            public EliminarTelCliente EliminarTelCliente
            {
                [DebuggerHidden]
                get
                {
                    m_EliminarTelCliente = Create__Instance__(m_EliminarTelCliente);
                    return m_EliminarTelCliente;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_EliminarTelCliente))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_EliminarTelCliente);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public EliminarTelProveedor m_EliminarTelProveedor;

            public EliminarTelProveedor EliminarTelProveedor
            {
                [DebuggerHidden]
                get
                {
                    m_EliminarTelProveedor = Create__Instance__(m_EliminarTelProveedor);
                    return m_EliminarTelProveedor;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_EliminarTelProveedor))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_EliminarTelProveedor);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public EliminarTelUsuario m_EliminarTelUsuario;

            public EliminarTelUsuario EliminarTelUsuario
            {
                [DebuggerHidden]
                get
                {
                    m_EliminarTelUsuario = Create__Instance__(m_EliminarTelUsuario);
                    return m_EliminarTelUsuario;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_EliminarTelUsuario))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_EliminarTelUsuario);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FamiliaPatente m_FamiliaPatente;

            public FamiliaPatente FamiliaPatente
            {
                [DebuggerHidden]
                get
                {
                    m_FamiliaPatente = Create__Instance__(m_FamiliaPatente);
                    return m_FamiliaPatente;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FamiliaPatente))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FamiliaPatente);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public GestionCliente m_GestionCliente;

            public GestionCliente GestionCliente
            {
                [DebuggerHidden]
                get
                {
                    m_GestionCliente = Create__Instance__(m_GestionCliente);
                    return m_GestionCliente;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_GestionCliente))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_GestionCliente);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public GestionFamilia m_GestionFamilia;

            public GestionFamilia GestionFamilia
            {
                [DebuggerHidden]
                get
                {
                    m_GestionFamilia = Create__Instance__(m_GestionFamilia);
                    return m_GestionFamilia;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_GestionFamilia))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_GestionFamilia);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public GestionNP m_GestionNP;

            public GestionNP GestionNP
            {
                [DebuggerHidden]
                get
                {
                    m_GestionNP = Create__Instance__(m_GestionNP);
                    return m_GestionNP;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_GestionNP))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_GestionNP);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public GestionNV m_GestionNV;

            public GestionNV GestionNV
            {
                [DebuggerHidden]
                get
                {
                    m_GestionNV = Create__Instance__(m_GestionNV);
                    return m_GestionNV;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_GestionNV))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_GestionNV);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public GestionProducto m_GestionProducto;

            public GestionProducto GestionProducto
            {
                [DebuggerHidden]
                get
                {
                    m_GestionProducto = Create__Instance__(m_GestionProducto);
                    return m_GestionProducto;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_GestionProducto))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_GestionProducto);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public GestionProveedor m_GestionProveedor;

            public GestionProveedor GestionProveedor
            {
                [DebuggerHidden]
                get
                {
                    m_GestionProveedor = Create__Instance__(m_GestionProveedor);
                    return m_GestionProveedor;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_GestionProveedor))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_GestionProveedor);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public GestionUsuario m_GestionUsuario;

            public GestionUsuario GestionUsuario
            {
                [DebuggerHidden]
                get
                {
                    m_GestionUsuario = Create__Instance__(m_GestionUsuario);
                    return m_GestionUsuario;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_GestionUsuario))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_GestionUsuario);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public LogIn m_LogIn;

            public LogIn LogIn
            {
                [DebuggerHidden]
                get
                {
                    m_LogIn = Create__Instance__(m_LogIn);
                    return m_LogIn;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_LogIn))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_LogIn);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ModificarCliente m_ModificarCliente;

            public ModificarCliente ModificarCliente
            {
                [DebuggerHidden]
                get
                {
                    m_ModificarCliente = Create__Instance__(m_ModificarCliente);
                    return m_ModificarCliente;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ModificarCliente))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ModificarCliente);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ModificarFamilia m_ModificarFamilia;

            public ModificarFamilia ModificarFamilia
            {
                [DebuggerHidden]
                get
                {
                    m_ModificarFamilia = Create__Instance__(m_ModificarFamilia);
                    return m_ModificarFamilia;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ModificarFamilia))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ModificarFamilia);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ModificarPrecio m_ModificarPrecio;

            public ModificarPrecio ModificarPrecio
            {
                [DebuggerHidden]
                get
                {
                    m_ModificarPrecio = Create__Instance__(m_ModificarPrecio);
                    return m_ModificarPrecio;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ModificarPrecio))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ModificarPrecio);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ModificarProducto m_ModificarProducto;

            public ModificarProducto ModificarProducto
            {
                [DebuggerHidden]
                get
                {
                    m_ModificarProducto = Create__Instance__(m_ModificarProducto);
                    return m_ModificarProducto;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ModificarProducto))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ModificarProducto);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ModificarProveedor m_ModificarProveedor;

            public ModificarProveedor ModificarProveedor
            {
                [DebuggerHidden]
                get
                {
                    m_ModificarProveedor = Create__Instance__(m_ModificarProveedor);
                    return m_ModificarProveedor;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ModificarProveedor))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ModificarProveedor);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ModificarStock m_ModificarStock;

            public ModificarStock ModificarStock
            {
                [DebuggerHidden]
                get
                {
                    m_ModificarStock = Create__Instance__(m_ModificarStock);
                    return m_ModificarStock;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ModificarStock))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ModificarStock);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ModificarUsuario m_ModificarUsuario;

            public ModificarUsuario ModificarUsuario
            {
                [DebuggerHidden]
                get
                {
                    m_ModificarUsuario = Create__Instance__(m_ModificarUsuario);
                    return m_ModificarUsuario;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ModificarUsuario))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ModificarUsuario);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public NotaPedido m_NotaPedido;

            public NotaPedido NotaPedido
            {
                [DebuggerHidden]
                get
                {
                    m_NotaPedido = Create__Instance__(m_NotaPedido);
                    return m_NotaPedido;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_NotaPedido))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_NotaPedido);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public NotaVenta m_NotaVenta;

            public NotaVenta NotaVenta
            {
                [DebuggerHidden]
                get
                {
                    m_NotaVenta = Create__Instance__(m_NotaVenta);
                    return m_NotaVenta;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_NotaVenta))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_NotaVenta);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Principal m_Principal;

            public Principal Principal
            {
                [DebuggerHidden]
                get
                {
                    m_Principal = Create__Instance__(m_Principal);
                    return m_Principal;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Principal))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Principal);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ResetearContrasena m_ResetearContrasena;

            public ResetearContrasena ResetearContrasena
            {
                [DebuggerHidden]
                get
                {
                    m_ResetearContrasena = Create__Instance__(m_ResetearContrasena);
                    return m_ResetearContrasena;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ResetearContrasena))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ResetearContrasena);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Restore m_Restore;

            public Restore Restore
            {
                [DebuggerHidden]
                get
                {
                    m_Restore = Create__Instance__(m_Restore);
                    return m_Restore;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Restore))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Restore);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ResultadoFamPatUsu m_ResultadoFamPatUsu;

            public ResultadoFamPatUsu ResultadoFamPatUsu
            {
                [DebuggerHidden]
                get
                {
                    m_ResultadoFamPatUsu = Create__Instance__(m_ResultadoFamPatUsu);
                    return m_ResultadoFamPatUsu;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ResultadoFamPatUsu))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ResultadoFamPatUsu);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public UltimaNPRepor m_UltimaNPRepor;

            public UltimaNPRepor UltimaNPRepor
            {
                [DebuggerHidden]
                get
                {
                    m_UltimaNPRepor = Create__Instance__(m_UltimaNPRepor);
                    return m_UltimaNPRepor;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_UltimaNPRepor))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_UltimaNPRepor);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public UltimaNVRepor m_UltimaNVRepor;

            public UltimaNVRepor UltimaNVRepor
            {
                [DebuggerHidden]
                get
                {
                    m_UltimaNVRepor = Create__Instance__(m_UltimaNVRepor);
                    return m_UltimaNVRepor;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_UltimaNVRepor))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_UltimaNVRepor);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public UsuarioFamilia m_UsuarioFamilia;

            public UsuarioFamilia UsuarioFamilia
            {
                [DebuggerHidden]
                get
                {
                    m_UsuarioFamilia = Create__Instance__(m_UsuarioFamilia);
                    return m_UsuarioFamilia;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_UsuarioFamilia))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_UsuarioFamilia);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public UsuarioPatente m_UsuarioPatente;

            public UsuarioPatente UsuarioPatente
            {
                [DebuggerHidden]
                get
                {
                    m_UsuarioPatente = Create__Instance__(m_UsuarioPatente);
                    return m_UsuarioPatente;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_UsuarioPatente))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_UsuarioPatente);
                }
            }
        }
    }
}