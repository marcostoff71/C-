using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Listas_A_fondo
{
    class Cvalida
    {

        public int validaInt(string mensaje)
        {
            int nuFinal;
            bool valor;
            do
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out nuFinal);
            } while (!valor);
            return nuFinal;
        }
        public double validaDouble(string mensaje)
        {
            double nuFinal;
            bool valor;
            do
            {
                Console.Write(mensaje);
                valor = double.TryParse(Console.ReadLine(), out nuFinal);
            } while (!valor);
            return nuFinal;
        }

    }
    class Producto
    {
        public int id=0;
        public string nombre="";
        public double precio=0;
        public int cantidad=0;
    }

    class CInventario
    {
        Cvalida vali1 = new Cvalida();
        //Producto producto = new Producto();
        List<Producto> productos = new List<Producto>();
        public void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            int op = 0;
            Console.WriteLine(".......:::Menu:::......");
            do
            {
                Console.WriteLine("1. Agregar un producto");
                Console.WriteLine("2. Mostrar los productos");
                Console.WriteLine("3. Eliminar todo");
                Console.WriteLine("4. Buscar un producto");
                Console.WriteLine("5. Modificar un producto");
                Console.WriteLine("6. Eliminar un producto");
                Console.WriteLine("7. Salir");
                do
                {
                    op = vali1.validaInt("Escogue una opcion: ");
                } while (op < 1 || op > 7);
                switch (op)
                {
                    case 1:
                        Console.WriteLine();
                        Agregar();
                        break;
                    case 2:
                        Console.WriteLine();
                        Mostrar();
                        break;
                    case 3:
                        Console.WriteLine();
                        EliminarTodo();
                        break;
                    case 4:
                        Console.WriteLine();
                        BuscarProducto();
                        break;
                    case 5:
                        Console.WriteLine();
                        ModificarProducto();
                        break;
                    case 6:
                        Console.WriteLine();
                        EliminarUnProducto();
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Presiona una tecla para contiuar");
                Console.ReadKey();
                Console.Clear();
            } while (op != 7);
        }
        public void Agregar()
        {
            int id;
            string nombre = "";
            double precio = 0;
            int cantidad = 0;



            do
            {
                Console.Write("Dame el nombre del producto: ");
                nombre = Console.ReadLine();
                nombre = nombre.Trim();
            } while (nombre == "");
            do
            {
                precio = vali1.validaDouble("Dame el precio: ");
            } while (precio < 0.1);
            do
            {
                cantidad = vali1.validaInt("Dame la cantidad: ");
            } while (cantidad < 1);


            if (productos.Count == 0)
            {
                id = productos.Count + 1;
                productos.Add(new Producto() { nombre = nombre, precio = precio, cantidad = cantidad, id = id });
            }
            else
            {
                bool valor=false;
                Producto p1 = productos.Find(i => { if (i.nombre == nombre) { valor = true; return true; } else return false; } );
                if (valor)
                {
                    Console.WriteLine("Producto existente");

                }
                else
                {
                    id = productos.Count + 1;
                    productos.Add(new Producto() { nombre = nombre, precio = precio, cantidad = cantidad, id = id });
                }
            }




        }
        public void Mostrar()
        {
            if (productos.Count > 0)
            {
                //productos.ForEach(i =>
                //{
                //    Console.WriteLine("Nombre: {0} Precio: {1} Cantidad: {2}", i.nombre, i.precio, i.cantidad);
                //});
                foreach (Producto i in productos)
                {
                    Console.WriteLine("Id: {0} Nombre: {1} Precio: {2} Cantidad: {3}", i.id, i.nombre, i.precio, i.cantidad);
                }
            }
            else
            {
                Console.WriteLine("Inventario vacio");
            }
        }
        public void EliminarTodo()
        {
            productos.Clear();
        }
        public void BuscarProducto()
        {
            int cont = 0;
            string nombreB = "";
            if (productos.Count > 0)
            {

                do
                {
                    Console.Write("Dame el nombre del producto: ");
                    nombreB = Console.ReadLine();
                    nombreB = nombreB.Trim();
                } while (nombreB == "");

                List<int> indices = new List<int>();
                indices.Clear();
                for (int i = 0; i < productos.Count; i++)
                {

                    if (productos[i].nombre == nombreB)
                    {
                        cont++;
                        indices.Add(i);
                    }
                }
                if (cont > 0)
                {
                    if (cont == 1)
                    {
                        Console.WriteLine("Producto encontrado: {0} con id: {1} ", nombreB, indices[0] + 1);
                    }
                    else
                    {
                        Console.WriteLine("Productos encontrados");
                        indices.ForEach(i => Console.WriteLine("Producto: {0} encontrado con el id: {1}", nombreB, i + 1));
                    }
                }
                else
                {
                    Console.WriteLine("Producto no encontrado");
                }
            }


        }
        public void ModificarProducto()
        {
            if (productos.Count > 0)
            {
                string nombre = "";
                double precio = 0;
                int cantidad = 0;
                string nombreB = "";
                int cont = 0;
                do
                {
                    Console.Write("Dame el nombre del producto: ");
                    nombreB = Console.ReadLine();
                    nombreB = nombreB.Trim();
                } while (nombreB == "");

                List<int> indices = new List<int>();
                indices.Clear();
                for (int i = 0; i < productos.Count; i++)
                {

                    if (productos[i].nombre == nombreB)
                    {
                        cont++;
                        indices.Add(i);
                    }
                }
                if (cont > 0)
                {
                    if (cont == 1)
                    {
                        Console.WriteLine("\nProducto encontrado");

                        do
                        {
                            Console.Write("Dame el nombre del producto: ");
                            nombre = Console.ReadLine();
                            nombre = nombre.Trim();
                        } while (nombre == "");
                        do
                        {
                            precio = vali1.validaDouble("Dame el precio: ");
                        } while (precio < 0.1);
                        do
                        {
                            cantidad = vali1.validaInt("Dame la cantidad: ");
                        } while (cantidad < 1);

                        productos[indices[0]].nombre = nombre;
                        productos[indices[0]].precio = precio;
                        productos[indices[0]].cantidad = cantidad;



                    }
                    else
                    {
                        Console.WriteLine("\nProductos encontrado");
                        foreach (int i in indices)
                        {
                            Console.WriteLine("Producto en indice: " + (i + 1));
                            do
                            {
                                Console.Write("Dame el nombre del producto: ");
                                nombre = Console.ReadLine();
                                nombre = nombre.Trim();
                            } while (nombre == "");
                            do
                            {
                                precio = vali1.validaDouble("Dame el precio: ");
                            } while (precio < 0.1);
                            do
                            {
                                cantidad = vali1.validaInt("Dame la cantidad: ");
                            } while (cantidad < 1);

                            productos[i].nombre = nombre;
                            productos[i].precio = precio;
                            productos[i].cantidad = cantidad;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Producto no encontrado");
                }
            }
        }
        public void EliminarUnProducto()
        {
            int cont = 0;
            string nombreB = "";
            if (productos.Count > 0)
            {

                do
                {
                    Console.Write("Dame el nombre del producto: ");
                    nombreB = Console.ReadLine();
                    nombreB = nombreB.Trim();
                } while (nombreB == "");

                int indice = 0;

                for (int i = 0; i < productos.Count; i++)
                {

                    if (productos[i].nombre == nombreB)
                    {
                        cont++;
                        indice = i;
                    }
                }
                if (cont > 0)
                {


                    productos.RemoveAt(indice);

                    Console.WriteLine("Eliminado correctamente id: {0}", indice + 1);
                }
                else
                {
                    Console.WriteLine("Producto no encontrado");
                }
            }
        }
    }
}
