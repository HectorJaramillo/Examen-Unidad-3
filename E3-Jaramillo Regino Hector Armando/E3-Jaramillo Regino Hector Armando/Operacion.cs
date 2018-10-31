using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E3_Jaramillo_Regino_Hector_Armando

{
    public class Operacion
    {
        LinkedList<int> ListaLigada = new LinkedList<int>();
        List<int> Lista = new List<int>();

        Stack Pila = new Stack();
        Queue Cola = new Queue();

        List<Clase2> ListaAlumnos = new List<Clase2>();
        Clase Class = new Clase();

        public void Ejercicio1()
        {
            //¿Qué valores se devuelven durante la siguiente serie de operaciones de pila,
            //si se ejecutan en una pila inicialmente vacía ?
            //push(5), push(3), pop(), push(2), push(8),
            //pop(), pop(), push(9), push(1), pop(), push(7), push(6), pop(), pop(), push(4),
            //pop(), pop()
            Pila.Push(5);
            Pila.Push(3);
            Pila.Pop();
            Pila.Push(2);
            Pila.Push(8);
            Pila.Pop();
            Pila.Pop();
            Pila.Push(9);
            Pila.Push(1);
            Pila.Pop();
            Pila.Push(7);
            Pila.Push(6);
            Pila.Pop();
            Pila.Pop();
            Pila.Push(4);
            Pila.Pop();
            Pila.Pop();
            Console.WriteLine("Los numeros que aun estan en la Pila son: ");
            foreach (var item in Pila)
            {
                Console.WriteLine(item);
            }

        }
            //Escriba en este metodo un modulo que pueda leer  y almacenar palabras reservadas en una lista enlazada 
            //e identificadores y literales en Otra lista enlazada.
            //Cuando el programa haya terminado de leer la entrada, mostrar
            //Los contenidos de cada lista enlazada.
            //Revise que es un Identificador y que es un literal

        List<string> Reservadas = new List<string>();
        public void LLenarListaPalabrasReservadas()
        {
            Reservadas.Add("ABSTRACT");
            Reservadas.Add("AS");
            Reservadas.Add("BASE");
            Reservadas.Add("BOOL");
            Reservadas.Add("BREAK");
            Reservadas.Add("BYTE");
            Reservadas.Add("CASE");
            Reservadas.Add("CATCH");
            Reservadas.Add("CHAR");
            Reservadas.Add("CHECKED");
            Reservadas.Add("CLASS");
            Reservadas.Add("CONST");
            Reservadas.Add("CONTINUE");
            Reservadas.Add("DECIMAL");
            Reservadas.Add("DEFAULT");
            Reservadas.Add("DELEGATE");
            Reservadas.Add("DO");
            Reservadas.Add("DOUBLE");
            Reservadas.Add("ELSE");
            Reservadas.Add("ENUM");
            Reservadas.Add("EVENT");
            Reservadas.Add("EXPLICIT");
            Reservadas.Add("EXTERN");
            Reservadas.Add("FALSE");
            Reservadas.Add("FINALLY");
            Reservadas.Add("FIXED");
            Reservadas.Add("FLOAT");
            Reservadas.Add("FOR");
            Reservadas.Add("FOREACH");
            Reservadas.Add("GOTO");
            Reservadas.Add("IF");
            Reservadas.Add("IMPLICIT");
            Reservadas.Add("IN");
            Reservadas.Add("INT");
            Reservadas.Add("INTERFACE");
            Reservadas.Add("INTERNALE");
            Reservadas.Add("IS");
            Reservadas.Add("LOCK");
            Reservadas.Add("LONG");
            Reservadas.Add("NAMESPACE");
            Reservadas.Add("NEW");
            Reservadas.Add("NULL");
            Reservadas.Add("OBJECT");
            Reservadas.Add("OPERATOR");
            Reservadas.Add("OUT");
            Reservadas.Add("OVERRIDE");
            Reservadas.Add("PARAMS");
            Reservadas.Add("PRIVATE");
            Reservadas.Add("PROTECTED");
            Reservadas.Add("PUBLIC");
            Reservadas.Add("READONLY");
            Reservadas.Add("REF");
            Reservadas.Add("RETURN");
            Reservadas.Add("SBYTE");
            Reservadas.Add("SEALED");
            Reservadas.Add("SHORT");
            Reservadas.Add("SIZEOF");
            Reservadas.Add("STACKALLOC");
            Reservadas.Add("STATIC");
            Reservadas.Add("STRING");
            Reservadas.Add("STRUCT");
            Reservadas.Add("SWITCH");
            Reservadas.Add("THIS");
            Reservadas.Add("THROW");
            Reservadas.Add("TRUE");
            Reservadas.Add("TRY");
            Reservadas.Add("TYPEOF");
            Reservadas.Add("UINT");
            Reservadas.Add("ULONG");
            Reservadas.Add("UCHECKED");
            Reservadas.Add("UNSAFE");
            Reservadas.Add("USHORT");
            Reservadas.Add("USING");
            Reservadas.Add("VIRTUAL");
            Reservadas.Add("VOID");
            Reservadas.Add("WHILE");
        }
        LinkedList<string> PalabrasNoImportantes = new LinkedList<string>();
        public void Ejercicio2()
        {
            Console.Clear();
           
            LLenarListaPalabrasReservadas();
            LinkedList<String> PalabrasReservadas = new LinkedList<string>(); 
            string Opcion = "";
            do
            {
                Console.Write("Introduzca una palabra (Ya sea reservada o no): ");
                string Palabra = Console.ReadLine().ToUpper();
                if (true == Reservadas.Contains(Palabra))
                {
                    PalabrasReservadas.AddLast(Palabra);
                }
                else
                {
                    PalabrasNoImportantes.AddLast(Palabra);
                }
                Console.WriteLine("Desea ingresar mas palabras? (SI/NO)");
                Opcion = Console.ReadLine().ToUpper();
            } while (Opcion == "SI");
            Console.WriteLine("\nPulse una tecla para continuar...");
            Console.ReadKey();
            Console.WriteLine("Lista de palabras reservadas ingresadas: ");
            foreach (var item in PalabrasReservadas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nLista de palabras No Importantes ingresadas: ");
            foreach (var item in PalabrasNoImportantes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
            public void Ejercicio3()
        {
            //mida el tiempo entre Un lista ligada y una lista normal en el tiempo de ejecucion de 9876 elementos agregados.
            Stopwatch Tiempo = new Stopwatch();
            Tiempo.Start();
            
            for (int i = 0; i < 9877; i++)
            {
                ListaLigada.AddLast(i);               
            }
            Tiempo.Stop();
            Console.WriteLine("Tiempo que tardo en ejecutarse ListaLigada: {0}", Tiempo.Elapsed.ToString());
            Tiempo.Start();

            for (int i = 0; i < 9877; i++)
            {
                Lista.Add(i);
            }
            Tiempo.Stop();
            Console.WriteLine("Tiempo que tardo en ejecutarse Lista: {0}", Tiempo.Elapsed.ToString());
        }

        public void Ejercicio4()
        {
            // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
            // en un solo curso.Incluir métodos que calculen la nota media, la
            //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
            //implementación. Minimo 30 Calificaciones, de 30 alumnos.
            AgregarCalificaciones();
            CalculosEjercicio4();

        }
       // List<Clase> Alumnos = new List<Clase>();
        //List<int> Calificaciones = new List<int>();
        int Mayor = 0, Menor = 100;
        public void AgregarCalificaciones()
        {
            Clase clase = new Clase();
            Console.WriteLine("Ingrese el nombre del Maestro: ");
            clase.Maestro = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la materia: ");
            clase.NombreClase=Console.ReadLine();
            Console.Clear();
            Console.WriteLine("");
            for (int i = 0; i < 30; i++)
            {
                Clase2 clase2 = new Clase2();
                Console.WriteLine("Ingrese el nombre del Alumno "+(i+1));
                clase2.Alumno = Console.ReadLine();
                Console.WriteLine("Ingrese la calificacion");
                clase2.Calificacion = int.Parse(Console.ReadLine());
                ListaAlumnos.Add(clase2);
                if(clase2.Calificacion>Mayor)
                {
                    Mayor = clase2.Calificacion;
                }
                if (clase2.Calificacion <Menor)
                {
                    Menor = clase2.Calificacion;
                }

            }

        }
        int SumaCalificaciones = 0;
        double Promedio = 0;
        public void CalculosEjercicio4()
        {
            foreach (var item in ListaAlumnos)
            {
                SumaCalificaciones += item.Calificacion;
                Promedio = SumaCalificaciones / ListaAlumnos.Count;
            }
            Console.WriteLine("El promedio es: {0}", Promedio);
            Console.WriteLine("El la calificion mas alta es: {0}", Mayor);
            Console.WriteLine("El la calificion mas baja es: {0}", Menor);
        }      
    }
}