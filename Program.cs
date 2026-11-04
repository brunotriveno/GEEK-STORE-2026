namespace GEEK_STORE_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tienda GeekStore = new Tienda();
            Console.WriteLine("BIENVENIDO A GEEK STORE...    ");
            while (true)
            {
                Console.WriteLine(" \n      MENU DE OPCIONES    \n ");
                Console.WriteLine("1. Ver Inventario y Saldo de Caja");
                Console.WriteLine("2. Añadir un nuevo comic al sistema");
                Console.WriteLine("3. Añadir nuevo Merchandising al sistema");
                Console.WriteLine("4. Realizar una venta");
                Console.WriteLine("5. Salir");
                Console.Write("\n Seleccione una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        GeekStore.MostrarInventario();
                        Console.WriteLine($" SALDO ACTUAL: {GeekStore.SaldoCaja}");
                        Console.WriteLine("\nVolviendo al menu anterior...");
                        break;
                    case "2":
                        Console.Write("Ingrese el ID del comic: ");
                        int idComic = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el nombre del comic: ");
                        string nombreComic = Console.ReadLine();
                        Console.Write("Ingrese el precio de costo del comic: ");
                        double precioCostoComic = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el precio de venta del comic: ");
                        double precioVentaComic = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el volumen del comic: ");
                        int volumenComic = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese si es variante (true/false): ");
                        bool esVarianteComic = Convert.ToBoolean(Console.ReadLine());
                        Comic comic = new Comic(idComic, nombreComic, precioCostoComic, precioVentaComic, 0, volumenComic, esVarianteComic);
                        Console.Write("Ingrese la cantidad a comprar: ");
                        int cantidadAComprarComic = Convert.ToInt32(Console.ReadLine());
                        GeekStore.AgregarAlInventario(comic, cantidadAComprarComic);
                        Console.WriteLine("\nVolviendo al menu anterior...");
                        break;
                    case "3":
                        Console.Write("Ingrese el ID del merchandising: ");
                        int idMerchandising = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el nombre del merchandising: ");
                        string nombreMerchandising = Console.ReadLine();
                        Console.Write("Ingrese el precio de costo del merchandising: ");
                        double precioCostoMerchandising = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el precio de venta del merchandising: ");
                        double precioVentaMerchandising = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el tipo de merchandising: ");
                        string tipoMerchandising = Console.ReadLine();
                        Console.Write("Ingrese la talla del merchandising: ");
                        string tallaMerchandising = Console.ReadLine();
                        Merchandising merchandising = new Merchandising(idMerchandising, nombreMerchandising, precioCostoMerchandising, precioVentaMerchandising, 0, tipoMerchandising, tallaMerchandising);
                        Console.Write("Ingrese la cantidad a comprar: ");
                        int cantidadAComprarMerchandising = Convert.ToInt32(Console.ReadLine());
                        GeekStore.AgregarAlInventario(merchandising, cantidadAComprarMerchandising);
                        Console.WriteLine("\nVolviendo al menu anterior...");
                        break;
                    case "4":
                        Console.Write("Ingrese el ID del artículo a vender: ");
                        int idArticuloAVender = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese la cantidad a vender: ");
                        int cantidadAVender = Convert.ToInt32(Console.ReadLine());
                        GeekStore.VenderArticulo(idArticuloAVender, cantidadAVender);
                        Console.WriteLine("\nVolviendo al menu anterior...");
                        break;
                    case "5":
                        Console.WriteLine("Gracias por usar Geek Store. ¡Hasta luego!");
                        return;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        Console.WriteLine("\nVolviendo al menu anterior...");
                        break;
                }
            }
        }
    }
}