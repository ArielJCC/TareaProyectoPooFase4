using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProyectoPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            //## USUARIO ###########################################################################################################
            Console.WriteLine("*----INICIO DE SESION-----*");
            /*Se creo una instancia de un objeto de esta forma agregando las propiedades
            con las cuales se identifican el Inicio de Sesión en la cual son el usuario y contraseña*/
            Usuario usuario = new Usuario();
            Console.WriteLine("Nombre de Usuario: ");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Clave de Usuario: ");
            usuario.Clave = Console.ReadLine();
            
            // Crear el repositorio para Usuario
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            //Agreegar usuario al repositorio
            usuarioRepositorio.Agregar(usuario);
                // Obtener todos los usuarios del repositorio
            List<Usuario> listaUsuarios = usuarioRepositorio.ObtenerTodos();

            Console.WriteLine("Lista de usuarios:");
            foreach (var Usuario in listaUsuarios)
            {
                Console.WriteLine("Nombre de Usuario: " + usuario.Nombre +
                                  ", Clave: " + usuario.Clave);
            }

            Console.Clear();

            //## CLIENTE ###########################################################################################################
            Console.WriteLine("*------------------------*");
            Console.WriteLine("     INGRESO DE DATOS     ");
            Console.WriteLine("         CLIENTE          ");
            Console.WriteLine("*------------------------*");
            //Se crea un objeto
            //instanciando las propiedades de la clase Cliente para la obtención
            //de los datos del usuario
            Cliente cliente = new Cliente();
            Console.WriteLine("Ingrese los nombres: ");
            cliente.Name = Console.ReadLine();
            Console.WriteLine("Ingrese los apellidos: ");
            cliente.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de cedula: ");
            cliente.Cedula = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero celular:");
            cliente.Celular = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la dirección domiciliaria:");
            cliente.DireccionDomicilio = Console.ReadLine();
            Console.WriteLine("Mostrar fecha de emisión:");
            DateTime fechaemision = DateTime.Now;
            Console.WriteLine(fechaemision);
            // Guardar el cliente en el repositorio
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            // Agregar cliente al repositorio
            clienteRepositorio.Agregar(cliente);
            // Obtener todos los clientes del repositorio
            List<Cliente> listaClientes = clienteRepositorio.ObtenerTodos();
            Console.WriteLine("Lista de clientes:");

            foreach (var Cliente in listaClientes)
            {
                Console.WriteLine(cliente.MostrarDatosCliente());
            }

            Console.Clear();

            //## REGISTRO DATOS PRODUCTOS ###################################################################################################
            Console.WriteLine("*------------------------*");
            Console.WriteLine("     INGRESO DE DATOS     ");
            Console.WriteLine("      DE LAS COMPRAS      ");
            Console.WriteLine("*------------------------*");
            /*Datos de los productos de la factura mediante un ciclo for*/
            int NumeroProducto;

            Console.WriteLine("Ingrese el número de productos a registrar:");
            NumeroProducto = Int32.Parse(Console.ReadLine());

            List<RegistroCompras> VERregistroCompras = new List<RegistroCompras> { };
            Console.Clear();
            for (int i = 1; i < NumeroProducto + 1; i++)
            {
                Console.WriteLine("*------------------------*");
                Console.WriteLine("     INGRESO DE DATOS     ");
                Console.WriteLine("      DE LAS COMPRAS      ");
                Console.WriteLine("*------------------------*");
                Console.WriteLine("       Producto: " + i + " ");
                Console.WriteLine("*------------------------*");
                //Se crea el objeto RegistroCompra y se invocan las propiedades de dicha clase
                RegistroCompras rCompra = new RegistroCompras();

                Console.WriteLine("Ingrese la descripción:");
                rCompra.DescripcionProducto = Console.ReadLine();

                Console.WriteLine("Ingrese el precio unitario:");
                rCompra.PrecioUnitario = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad:");
                rCompra.Cantidad = Int32.Parse(Console.ReadLine());

                rCompra.TotalUnitario = rCompra.PrecioUnitario * rCompra.Cantidad;
                Console.WriteLine("Costo total del producto $: " + rCompra.TotalUnitario);
                
                // Se crea el repositorio para RegistroCompras
                RegistroComprasRepositorio registroComprasRepositorio = new RegistroComprasRepositorio();
                registroComprasRepositorio.Agregar(rCompra);
                // Agregar registros de compra al repositorio
                foreach (var ProductoNuevo in VERregistroCompras)
            {
                registroComprasRepositorio.Agregar(ProductoNuevo);
            }

                // Obtener todos los registros de compra del repositorio
                List<RegistroCompras> listaRegistros = registroComprasRepositorio.ObtenerTodos();

                Console.WriteLine("Lista de registros de compra:");
                foreach (var registro in listaRegistros)
            {
                Console.WriteLine("Cantidad: " + registro.Cantidad +
                                  ", Descripción: " + registro.DescripcionProducto +
                                  ", Precio Unitario: " + registro.PrecioUnitario +
                                  ", Precio Total: " + registro.TotalUnitario);
            }

                var productoNuevo = new RegistroCompras
                {
                    DescripcionProducto = rCompra.DescripcionProducto,
                    PrecioUnitario = rCompra.PrecioUnitario,
                    Cantidad = rCompra.Cantidad,
                    TotalUnitario = rCompra.TotalUnitario
                };
                VERregistroCompras.Add(productoNuevo);

                Console.Clear();
            }

            decimal suma = 0;

            for (int i = 0; i < VERregistroCompras.Count; i++)
            {
                suma += VERregistroCompras[i].TotalUnitario;
            }

            Console.WriteLine("El valor a pagar es $: " + suma);

            Console.Clear();

            //## TIPOS PAGOS #######################################################################################################

            //Se crea un objeto de la clase Pago
            Pago pago = new Pago();
            Console.WriteLine("Escriba cualquier método a pagar...\n\n\t Presione enter:");
            pago.FormaPago = Console.ReadLine();
            //Se aplica polimorfismo de tal forma que se trabaja con lista
            Console.WriteLine("-----Formas de Pagos------");
            PagoEfectivo pagoefectivo = new PagoEfectivo();
            PagoCreditoDebito pagotarjetacredito = new PagoCreditoDebito();
            PagoElectronico pagotarjetadebito = new PagoElectronico();
            PagoOtros pagootros = new PagoOtros();

            List<IPago> ListaPagos = new List<IPago>();
            ListaPagos.Add(pagoefectivo);
            ListaPagos.Add(pagotarjetacredito);
            ListaPagos.Add(pagotarjetadebito);
            ListaPagos.Add(pagootros);

            foreach (var item in ListaPagos)
            {
                Console.WriteLine(item.MostrarMetodoPago());
            }
            //Menú de opciones para la propia elección del usuario dependiendo 
            //del pago que se realice
            Console.WriteLine("Elija una opción:");
            Console.WriteLine("\n" +
            "\n1.- Pago en Efectivo" +
            "\n2.- Pago en Crédito/Débito" +
            "\n3.- Pago en Electrónico" +
            "\n4.- Pago por Otros \n");
            //variable de apoyo
            int seleccion = 0;
            Console.WriteLine("Digite una opción:");
            seleccion = Convert.ToInt32(Console.ReadLine());
            switch (seleccion)
            {
                case 1: Console.WriteLine("El pago se está realizando en efectivo...\n\n\t Presione enter"); break;
                case 2: Console.WriteLine("El pago se está realizando por Crédito/Débito...\n\n\t Presione enter"); break;
                case 3: Console.WriteLine("El pago se está realizando por Electrónico...\n\n\t Presione enter"); break;
                case 4: Console.WriteLine("El pago se está realizando por Otro método...\n\n\t Presione enter"); break;
            }
            Console.ReadKey();
            //Se procede a la obtención de la nota de venta implementando la impresión
            //de los datos obtenidos.
            Console.WriteLine("*Su transacción ha sido procesada con éxito*");
            Console.WriteLine("Espere un momento...\n");

            Console.Clear();

            //## FACTURA ###########################################################################################################

            //Aquí se procede a la imprecion de la factura.
            Console.WriteLine("*-----------------------------------------------------------------*");
            Console.WriteLine("                                Rexx Gaming                        ");
            Console.WriteLine("*-----------------------------------------------------------------*");
            //Se aplica el método isntanciando desde la clase Cliente de esta forma muestra los datos
            //ingresados por el usuario.
            Console.WriteLine("\n" + cliente.MostrarDatosCliente());

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("                            FACTURA PRODUCTOS                     ");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine(" CANTIDAD |  DESCRIPCIÓN  |  P. UNITARIO  |   P.TOTAL ");

            for (int i = 0; i < VERregistroCompras.Count; i++)
            {
                Console.WriteLine("\t" + VERregistroCompras[i].Cantidad + "   \t " + VERregistroCompras[i].DescripcionProducto + "    \t " + VERregistroCompras[i].PrecioUnitario + "        \t " + VERregistroCompras[i].TotalUnitario);
            } //aplicación de un ciclo for para la impresión de los datos de los productos con su respectivo valor que fueron ingresados y calculados.
            Console.WriteLine("                                    PAGO TOTAL:  " + suma);
            Console.WriteLine("----------------------¡GRACIAS POR PREFERIRNOS!-----------------");

            Console.Read();

            //## GUARDAR ###########################################################################################################

            Console.WriteLine("Menú de Opciones:");
            //Implementación del Patron de diseño Command 
            //Se está instanciando el Control
            Control control = new Control(cliente);
            string eleccion;
            // variable de apoyo
            do
            {
                //Menú de opciones 
                Console.WriteLine("1.- GUARDAR");
                Console.WriteLine("2.- IMPRIMIR");
                Console.WriteLine("3.- SALIR");

                eleccion = Console.ReadLine();

                //Dependiendo de la acción que se seleccionó se invoca el método seleccionado
                //A través del control pues program lleva a cabo la invocación
                if (eleccion == "1")
                    control.Boton(0);
                if (eleccion == "2")
                    control.Boton(1);

            } while (eleccion != "3");
            //Opción diferente a 3 vamos a salir del ciclo.
            Console.WriteLine("¡Gracias por preferirnos!");
            Console.WriteLine("Saliendo...");
            Console.ReadKey();
        }
    }
}