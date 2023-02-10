using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GuiaDidactica_No2_AlexanderZelaya
{
    public class Venta
    {
        Client client = new Client();
        Employer employer = new Employer();
        Inmueble inmueble = new Inmueble();
        Contrato contrato = new Contrato();

        public void GenerarVenta()
        {
            try
            {
                while (true)
                {
                    Clear();
                    WriteLine("====================================\n" +
                          "       Registro de Cliente\n" +
                          "====================================");

                    WriteLine("Ingrese el DUI del cliente: ");
                    int duiClient = client.Dui = Convert.ToInt32(ReadLine());
                    WriteLine("Ingrese el nombre del cliente: ");
                    string nameClient = client.Nombre = ReadLine();
                    WriteLine("Ingrese el apellido del cliente: ");
                    string lastnameClient = client.Apellido = ReadLine();
                    WriteLine("Ingrese la edad del cliente: ");
                    int ageClient = client.Edad = Convert.ToInt32(ReadLine());
                    WriteLine("Ingrese la dirección Residencia: ");
                    string addressClient = client.Direccion = ReadLine();
                    Clear();

                    WriteLine("====================================\n" +
                              "       Registro de Empleado\n" +
                              "====================================");

                    WriteLine("Ingrese el DUI del empleado: ");
                    int duiEmployer = employer.Dui = Convert.ToInt32(ReadLine());
                    WriteLine("Ingrese el nombre del empleado: ");
                    string nameEmployer = employer.Nombre = ReadLine();
                    WriteLine("Ingrese el apellido del empleado: ");
                    string lastnameEmployer = employer.Apellido = ReadLine();
                    WriteLine("Ingrese la edad del empleado: ");
                    int ageEmployer = employer.Edad = Convert.ToInt32(ReadLine());

                    Clear();

                    WriteLine("====================================\n" +
                              "       Registro de Inmueble\n" +
                              "====================================");

                    WriteLine("Ingrese el código del inmueble: ");
                    int codeInmueble = inmueble.Codigo = Convert.ToInt32(ReadLine());
                    WriteLine("Ingrese el nombre del inmueble: ");
                    string nameInmueble = inmueble.Nombre = ReadLine();
                    WriteLine("Ingrese la descripción del inmueble: ");
                    string descriptionInmueble = inmueble.Descripcion = ReadLine();
                    WriteLine("Ingrese el precio del inmueble: ");
                    double precioInmueble = inmueble.Precio = Convert.ToDouble(ReadLine());
                    WriteLine("Ingrese el estado del Inmueble:\n" +
                              "true: activo || false: inactivo: ");
                    bool isActiveInmueble = inmueble.Estado = Convert.ToBoolean(ReadLine());

                    Clear();

                    WriteLine("====================================\n" +
                              "          Tipo de Contrato\n" +
                              "====================================");

                    WriteLine("Ingrese el tipo de contrato:");
                    string tipoContrato = contrato.TipoContrato = ReadLine();

                    ForegroundColor = ConsoleColor.Green;

                    Clear();

                    WriteLine("====================================\n" +
                              "         Venta Almacenada!\n" +
                              "====================================");

                    WriteLine("El Cliente comprador es:\n" +
                             $"DUI: {duiClient}\n" +
                             $"Nombre: {nameClient}\n" +
                             $"Apellido: {lastnameClient}\n" +
                             $"Edad: {ageClient}\n" +
                             $"Dirección: {addressClient}\n" +
                              "====================================\n" +
                              "El empleado encargado de la venta es:\n" +
                             $"DUI: {duiEmployer}\n" +
                             $"Nombre: {nameEmployer}\n" +
                             $"Apellido: {lastnameEmployer}\n" +
                             $"Edad: {ageEmployer}\n" +
                              "====================================\n" +
                              "El inmueble vendido es:\n" +
                             $"Código: {codeInmueble}\n" +
                             $"Nombre: {nameInmueble}\n" +
                             $"Descripción: {descriptionInmueble}\n" +
                             $"Precio: {precioInmueble}\n" +
                             $"Activo: {isActiveInmueble}\n" +
                              "====================================\n" +
                              "El tipo de contrato es:\n" +
                             $"Contrato: {tipoContrato}");
                    ForegroundColor = ConsoleColor.White;

                    WriteLine("==============================\n" +
                              "Guardar venta o corregirla?\n" +
                              "1. Corregir\n" +
                              "0. Guardar\n" +
                              "==============================\n" +
                              "opción: ");
                    int opcRegistro = Convert.ToInt32(ReadLine());

                    if (opcRegistro == 1)
                    {
                        Clear();
                        return;
                    }
                    else
                    if (opcRegistro == 0)
                    {
                        Clear();
                        break;
                    }
                    else
                    if (opcRegistro >= 2)
                    {
                        Clear();
                        WriteLine("==============================\n" +
                                  "  Ingrese una opción válida\n" +
                                  "==============================");
                        break;
                    }
                }
            }
            catch (Exception err)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Se ha producido un error: {err}");
            }
        }
    }

    public class Client
    {
        private int dui;
        private string nombre;
        private string apellido;
        private int edad;
        private string direccion;

        public int Dui
        {
            get => dui;
            set => dui = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }

        public int Edad
        {
            get => edad;
            set => edad = value;
        }

        public string Direccion
        {
            get => direccion;
            set => direccion = value;
        }
    }

    public class Employer
    {
        private int dui;
        private string nombre;
        private string apellido;
        private int edad;

        public int Dui
        {
            get => dui;
            set => dui = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }

        public int Edad
        {
            get => edad;
            set => edad = value;
        }

    }

    public class Inmueble
    {
        private int codigo;
        private string nombre;
        private string descripcion;
        private double precio;
        private bool estado;

        public int Codigo {
            get => codigo;
            set => codigo = value;
        }

        public string Nombre {
            get => nombre;
            set => nombre = value;
        }

        public string Descripcion {
            get => descripcion;
            set => descripcion = value;
        }

        public double Precio {
            get => precio;
            set => precio = value;
        }

        public bool Estado {
            get => estado;
            set => estado = value;
        }
    }

    public class Contrato
    {
        private string tipoContrato;

        public string TipoContrato
        {
            get => tipoContrato;
            set => tipoContrato = value;
        }
    }
}
