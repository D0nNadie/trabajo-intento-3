using System;
class Program
{

    static string[] nombres = new string[]
{
            "Ana", "Bruno", "Carlos", "Diana", "Elena", "Felipe", "Gabriela", "Hector", "Isabel", "Jorge",
            "Karla", "Luis", "Marta", "Nestor", "Olga", "Pablo", "Queta", "Roberto", "Sandra", "Tomas",
            "Ursula", "Victor", "Wendy", "Ximena", "Yolanda", "Zacarias", "Andrea", "Benjamin", "Camila", "David",
            "Eva", "Federico", "Gloria", "Hernan", "Ines", "Jaime", "Laura", "Manuel", "Nina", "Oscar"
};


    static string[] direcciones = new string[]
    {
            "Calle A #1", "Calle B #2", "Calle C #3", "Calle D #4", "Calle E #5", "Calle F #6", "Calle G #7", "Calle H #8", "Calle I #9", "Calle J #10",
            "Calle K #11", "Calle L #12", "Calle M #13", "Calle N #14", "Calle O #15", "Calle P #16", "Calle Q #17", "Calle R #18", "Calle S #19", "Calle T #20",
            "Calle U #21", "Calle V #22", "Calle W #23", "Calle X #24", "Calle Y #25", "Calle Z #26", "Calle AA #27", "Calle BB #28", "Calle CC #29", "Calle DD #30",
            "Calle EE #31", "Calle FF #32", "Calle GG #33", "Calle HH #34", "Calle II #35", "Calle JJ #36", "Calle KK #37", "Calle LL #38", "Calle MM #39", "Calle NN #40"
    };


    static string[] telefonos = new string[]
    {
            "555-0101", "555-0102", "555-0103", "555-0104", "555-0105", "555-0106", "555-0107", "555-0108", "555-0109", "555-0110",
            "555-0111", "555-0112", "555-0113", "555-0114", "555-0115", "555-0116", "555-0117", "555-0118", "555-0119", "555-0120",
            "555-0121", "555-0122", "555-0123", "555-0124", "555-0125", "555-0126", "555-0127", "555-0128", "555-0129", "555-0130",
            "555-0131", "555-0132", "555-0133", "555-0134", "555-0135", "555-0136", "555-0137", "555-0138", "555-0139", "555-0140"
    };


    static string[] nivelesEstudio = new string[]
    {
            "Primaria", "Secundaria", "Bachillerato", "Universidad", "Maestría", "Doctorado", "Primaria", "Secundaria", "Bachillerato", "Universidad",
            "Maestría", "Doctorado", "Primaria", "Secundaria", "Bachillerato", "Universidad", "Maestría", "Doctorado", "Primaria", "Secundaria",
            "Bachillerato", "Universidad", "Maestría", "Doctorado", "Primaria", "Secundaria", "Bachillerato", "Universidad", "Maestría", "Doctorado",
            "Primaria", "Secundaria", "Bachillerato", "Universidad", "Maestría", "Doctorado", "Primaria", "Secundaria", "Bachillerato", "Universidad"
    };



    // datos del segundo ejercisio.


    static string[] titulos = new string[]
    {
        "El Quijote", "Cien Años de Soledad", "1984", "Orgullo y Prejuicio", "La Odisea",
        "Crimen y Castigo", "El Gran Gatsby", "Matar a un Ruiseñor", "Guerra y Paz", "En Busca del Tiempo Perdido",
        "Don Juan Tenorio", "El Retrato de Dorian Gray", "Los Hermanos Karamazov", "El Señor de los Anillos", "Ulises",
        "Madame Bovary", "El Proceso", "Fahrenheit 451", "Lolita", "El Amor en los Tiempos del Cólera",
        "Drácula", "La Metamorfosis", "Moby Dick", "Jane Eyre", "La Divina Comedia",
        "Las Mil y Una Noches", "Frankenstein", "Hamlet", "Romeo y Julieta", "Los Miserables",
        "El Nombre de la Rosa", "Cumbres Borrascosas", "Anna Karenina", "La Isla del Tesoro", "Los Viajes de Gulliver",
        "El Príncipe", "La Iliada", "El Viejo y el Mar", "Robinson Crusoe", "El Lobo Estepario"
    };

    static string[] autores = new string[]
   {
        "Miguel de Cervantes", "Gabriel García Márquez", "George Orwell", "Jane Austen", "Homero",
        "Fiódor Dostoyevski", "F. Scott Fitzgerald", "Harper Lee", "León Tolstói", "Marcel Proust",
        "José Zorrilla", "Oscar Wilde", "Fiódor Dostoyevski", "J.R.R. Tolkien", "James Joyce",
        "Gustave Flaubert", "Franz Kafka", "Ray Bradbury", "Vladimir Nabokov", "Gabriel García Márquez",
        "Bram Stoker", "Franz Kafka", "Herman Melville", "Charlotte Brontë", "Dante Alighieri",
        "Anónimo", "Mary Shelley", "William Shakespeare", "William Shakespeare", "Victor Hugo",
        "Umberto Eco", "Emily Brontë", "León Tolstói", "Robert Louis Stevenson", "Jonathan Swift",
        "Nicolás Maquiavelo", "Homero", "Ernest Hemingway", "Daniel Defoe", "Hermann Hesse"
   };

    static int[] anosPublicacion = new int[]
   {
        1605, 1967, 1949, 1813, -800,
        1866, 1925, 1960, 1869, 1913,
        1844, 1890, 1880, 1954, 1922,
        1857, 1925, 1953, 1955, 1985,
        1897, 1915, 1851, 1847, 1320,
        800, 1818, 1609, 1597, 1862,
        1980, 1847, 1877, 1883, 1726,
        1532, -750, 1952, 1719, 1927
   };

    static string[] generos = new string[]
    {
        "Novela", "Realismo Mágico", "Distopía", "Romance", "Épica",
        "Novela", "Novela", "Novela", "Novela", "Novela",
        "Teatro", "Novela", "Novela", "Fantasía", "Épica",
        "Novela", "Novela", "Ciencia Ficción", "Novela", "Realismo Mágico",
        "Terror", "Novela", "Novela", "Romance", "Épica",
        "Cuentos", "Terror", "Teatro", "Teatro", "Novela",
        "Novela Histórica", "Romance", "Novela", "Aventura", "Aventura",
        "Política", "Épica", "Novela", "Aventura", "Novela"
    };

    static void Main(string[] args)
    {
        bool salir = false;
        int opc = 0;

        do
        {
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║ ¡Hola! ¿Qué te gustaría hacer hoy?     ║");
            Console.WriteLine("║                                        ║");
            Console.WriteLine("║ 1. ejercisio 1                         ║");
            Console.WriteLine("║ 2. ejercisio 2                         ║");
            Console.WriteLine("║ 3. Salir                               ║");
            Console.WriteLine("║                                        ║");
            Console.WriteLine("║ Por favor, elige una opción ingresando ║");
            Console.WriteLine("║ el número correspondiente:             ║");
            Console.WriteLine("╚════════════════════════════════════════╝");

            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    ejercisio1();
                    break;
                case 2:
                    Console.Clear();
                    ejercisio2();
                    break;
                case 3:
                    Console.Clear();
                    salir = true;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("seleccione opciones disponibles");
                    break;
            }

        } while (!salir);





        void ejercisio1()
        {
            bool getOut = false;
            int opc1 = 0;

            do
            {
                Console.WriteLine("╔════════════════════════════════════════╗");
                Console.WriteLine("║ ¡Hola! ¿Qué te gustaría hacer hoy?     ║");
                Console.WriteLine("║                                        ║");
                Console.WriteLine("║ 1. Buscar un cliente                   ║");
                Console.WriteLine("║ 2. Buscar cliente con mayor gasto y    ║");
                Console.WriteLine("║     con menor gasto                    ║");
                Console.WriteLine("║ 3. Salir                               ║");
                Console.WriteLine("║                                        ║");
                Console.WriteLine("║ Por favor, elige una opción ingresando ║");
                Console.WriteLine("║ el número correspondiente:             ║");
                Console.WriteLine("╚════════════════════════════════════════╝");

                opc1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opc1)
                {
                    case 1:
                        Console.Clear();
                        caso1();
                        break;
                    case 2:
                        Console.Clear();
                        caso2();
                        break;
                    case 3:
                        Console.Clear();
                        getOut = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("seleccione opciones disponibles");
                        break;

                }
            }
            while (!getOut);



            void caso1()
            {
                int lugar = -1;
                Console.WriteLine("Ingrese el nombre del cliente que desea buscar:");
                string nombreBuscado = Console.ReadLine();

                bool encontrado = false;
                foreach (string nombre in nombres)
                {
                    lugar++;
                    if (nombreBuscado == nombre)
                    {
                        Console.WriteLine($"Cliente encontrado: {nombre} la informacion de {nombre} es: ");
                        Console.WriteLine("Nombre= " + nombres[lugar]);
                        Console.WriteLine("Direccion= " + direcciones[lugar]);
                        Console.WriteLine("Telefono= " + telefonos[lugar]);
                        Console.WriteLine("Nivel de estudio= " + nivelesEstudio[lugar]);
                        encontrado = true;
                        break;
                    }
                }
                if (encontrado == false)
                {
                    Console.WriteLine("El nombre ingresado no se encuentra en la lista");
                }
            }
            static void caso2()
            {


                ////Cliente con Mayor y Menor Gasto: Implementar una función que
                ////identifique la persona que más ha gastado y la que menos ha gastado
                ////en la empresa. Mostrar el nombre y el monto gastado de cada uno.


                Console.WriteLine("Identificaremos quien es la persona que mas ha gastado en la empresa ");


                string[] nombres = new string[]
                        {
            "Ana", "Bruno", "Carlos", "Diana", "Elena", "Felipe", "Gabriela", "Hector", "Isabel", "Jorge",
            "Karla", "Luis", "Marta", "Nestor", "Olga", "Pablo", "Queta", "Roberto", "Sandra", "Tomas",
            "Ursula", "Victor", "Wendy", "Ximena", "Yolanda", "Zacarias", "Andrea", "Benjamin", "Camila", "David",
            "Eva", "Federico", "Gloria", "Hernan", "Ines", "Jaime", "Laura", "Manuel", "Nina", "Oscar"
                        };


                double[] dinero = new double[]
                {
1200.50, 850.75, 950.00, 1250.30, 1020.90, 1600.40, 750.60, 890.50, 1100.00,
1150.20,1300.15, 1400.45, 1500.55, 920.80, 980.95, 1350.70, 1440.10, 1550.85, 1650.20,
1050.00,1750.35, 1850.50, 1950.75, 2050.90, 2150.65, 2250.80, 2350.95, 2450.10,
2550.25, 2650.40,2750.55, 2850.70, 2950.85, 3050.00, 3150.15, 3250.30, 3350.45, 3450.60,
3550.75, 3650.90
                };

                for (int i = 0; i < nombres.Length; i++)
                {
                    for (i = 0; i < dinero.Length; i++)
                    {
                        string conjunto = nombres[i];
                        double monto = dinero[i];
                        string todo = conjunto + " " + monto;
                        Console.WriteLine("nombrees y monto  =  " + (todo));

                    }

                    int MayorGasto = EncontrarMayorGasto(dinero);
                    int MenorGasto = EncontrarMenorGasto(dinero);


                    Console.WriteLine("Cliente con mayor gasto: " + nombres[MayorGasto] + " " + "Monto: " + dinero[MayorGasto]);
                    Console.WriteLine("Cliente con menor gasto: " + nombres[MenorGasto] + " " + "Monto: " + dinero[MenorGasto]);
                }

                static int EncontrarMayorGasto(double[] dinero)
                {
                    int indiceMayor = 0;

                    for (int i = 1; i < dinero.Length; i++)
                    {
                        if (dinero[i] > dinero[indiceMayor])
                        {
                            indiceMayor = i;
                        }
                    }

                    return indiceMayor;
                }

                static int EncontrarMenorGasto(double[] dinero)
                {
                    int indiceMenor = 0;

                    for (int i = 1; i < dinero.Length; i++)
                    {
                        if (dinero[i] < dinero[indiceMenor])
                        {
                            indiceMenor = i;
                        }
                    }

                    return indiceMenor;
                }







            }







        }





    }
















    static void ejercisio2()
    {
        Console.WriteLine("Ejercicio 2:");
        Console.WriteLine("¿Qué te gustaría hacer?");
        Console.WriteLine("1. Buscar libro por título");
        Console.WriteLine("2. Buscar libro por género");
        Console.WriteLine("3. Salir");
        Console.WriteLine("Por favor, elige una opción ingresando el número correspondiente:");

        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:

                BuscarLibroPorTitulo();
                break;
            case 2:
                Console.WriteLine("Ingrese el género del libro que desea buscar:");
                string generoLibro = Console.ReadLine();

                BuscarLibrosPorGenero(generoLibro);
                break;
            case 3:
                Console.WriteLine("Tenga un buen dia");
                break;
            default:
                Console.WriteLine("Pensa antes de escribir gracias");
                break;
        }
    }

    static void BuscarLibrosPorGenero(string genero)
    {
        bool encontrados = false;
        Console.WriteLine($"Libros del género '{genero}':");

        for (int i = 0; i < generos.Length; i++)
        {
            if (generos[i] == genero)
            {
                Console.WriteLine($"- {titulos[i]}");
                encontrados = true;
            }
        }

        if (!encontrados)
        {
            Console.WriteLine("No se encontraron libros de ese género.");
        }
    }




    static void BuscarLibroPorTitulo()
    {
        Console.WriteLine("Ingrese el título del libro que desea buscar:");
        string tituloLibro = Console.ReadLine();

        bool encontrado = false;
        for (int i = 0; i < titulos.Length; i++)
        {
            if (titulos[i] == tituloLibro)
            {
                Console.WriteLine($"Libro encontrado: " + tituloLibro + " La información del libro es: ");
                Console.WriteLine("Título= " + titulos[i]);
                Console.WriteLine("Autor= " + autores[i]);
                Console.WriteLine("Año de publicación= " + anosPublicacion[i]);
                Console.WriteLine("Género= " + generos[i]);
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine($"El libro con el título " + tituloLibro + " no se encuentra en la lista.");
        }
    }















}





//minecraft 111