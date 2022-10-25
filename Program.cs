using Practica1Beca;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduzca una cadena superior a 40 caracteres:");
        string cadena = Console.ReadLine();
        while (cadena.Length < 40)
        {
            Console.WriteLine("La cadena introducida posee únicamente "+ cadena.Length +" caracteres.Por favor, introduzca una nueva cadena con más de 40 caracteres:\r\n");
            cadena = Console.ReadLine();
        }
        Cadena claseCadena = new Cadena(cadena);
      
        string userSelection;
        while(true){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************");
            Console.WriteLine("* Seleccione una acción *");
            Console.WriteLine("*************************");

            Console.WriteLine("1º Sustituir una palabra por otra");
            Console.WriteLine("2º Buscar texto en la cadena");
            Console.WriteLine("3º Buscar texto de inicio en la cadena");
            Console.ForegroundColor = ConsoleColor.White;

            userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    string[] aux;
                    do
                    {
                        Console.WriteLine("Introduzca dos palabras separadas por un espacio.");
                        string cadenapalabras = Console.ReadLine();
                        aux = (cadenapalabras != null) ? cadenapalabras.Split(" ") : null;
                    } while (aux.Length != 2 || aux == null);
                    claseCadena.sustituir(aux[0], aux[1]);                    
                    Console.WriteLine(claseCadena.getCadena());

                    break;
                case "2":
                    string? texto;
                    do
                    {
                        Console.WriteLine("Introduzca un texto para buscar en la cadena");
                        texto = Console.ReadLine();
                        
                    } while (texto == null || texto.Length == 0);
                    if (claseCadena.findText(texto)!=-1)
                    {
                        Console.WriteLine("La cadena contiene la búsqueda");
                    }
                    else
                    {
                        Console.WriteLine("La cadena no contiene la búsqueda");
                    }
                    break;
                case "3":
                    string? textoInicio;
                    do
                    {
                        Console.WriteLine("Introduzca un texto para buscar al inicio de la cadena");
                        textoInicio = Console.ReadLine();
                    } while (textoInicio == null || textoInicio.Length == 0);
                    if (claseCadena.findIni(textoInicio))
                    {

                        Console.WriteLine("La cadena empieza por el texto.");
                    }
                    else
                    {
                        Console.WriteLine("La cadena no empieza por el texto.");
                    }

                    break;
                default:
                    break;
            }

        }
        




    }
}