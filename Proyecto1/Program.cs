using System;
using System.IO;
namespace Proyecto1
{
    class Program
    {
        String name = "history";
        String init = "init";
        String compass = "compass";
        
        static void Main(string[] args)
        {
            Program p= new Program();
            string dir= @"c:\"+p.name+"begin", comando,ruta;
            bool op=false;


            do
            {
                Console.WriteLine("Inicializar el programa");
                p.init = Console.ReadLine();

                do
                {

                    Console.WriteLine("ingrese comando inicial:");
                    comando = Console.ReadLine();
                    comando = comando.Replace(" ", "");//elimina espacios
                    if (comando != "exit")
                        if ((comando.Length > dir.Length))
                        {
                            if (comando.Substring(0, dir.Length).Equals(dir))
                            {
                                //verificar que existe la ubicacion 
                                ruta = comando.Remove(0, dir.Length);
                                if (Directory.Exists(ruta))
                                {
                                    op = true;
                                    Console.WriteLine("se encontró la ruta especificada: " + ruta);
                                    TextWriter archivo;
                                    archivo = new StreamWriter(ruta + @"\.txt");

                                    /*listaDeArchivos.recorrer(archivo);*/
                                    archivo.Close();
                                    Console.Clear();
                                    Console.WriteLine("se ha guardado el archivo");
                                    Log olog = new Log(ruta);
                                    olog.Add(ruta);
                                }
                                else { Console.WriteLine("ruta no encontrada"); }
                            }
                            else { Console.WriteLine("valor inválido"); }
                        }
                        else { Console.WriteLine("valor inválido"); }

                } while (comando != "exit" && !op);
            } while (p.init != "init");
            
            do { 
            int counter = 0;
            string line;
            // Read the file and display it line by line.  
                Console.WriteLine("Ingrese comando para ver bitacora");
                p.compass = Console.ReadLine();
                using (StreamReader file = new System.IO.StreamReader(@"C:\Users\alvar\OneDrive\Escritorio\UMG\log_2021_3_29.txt"))/*lee el .txt de la bitacora*/
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        System.Console.WriteLine(line);
                        counter++;
                    }
                    file.Close();
                    System.Console.WriteLine("There were {0} lines.", counter);
                    // Suspend the screen.  
                    System.Console.ReadLine();
                }
            } while (p.compass!="compass");
        }//main

        static int opcion(String pr) 
        {
            
            Program p = new Program();
            if (pr.Length> p.name.Length) 
            {
                pr = pr.Replace(" ","");
                if (p.name.Equals(pr.Substring(0, p.name.Length))) {
                    
                    
                }
            }
            return 0;
        }
    }//class




    

}
