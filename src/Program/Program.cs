using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person persona1 = new Person  ("Carlos",41) ;
            Person persona2 = new Person  ("Carlos2",42);
            Person persona3 = new Person  ("Carlos3",43);
            Person persona4 = new Person  ("Carlos4",44);
            Person persona5 = new Person  ("Carlos5",45);
            Person persona6 = new Person  ("Carlos6",46);
            Person persona7 = new Person  ("Carlos7",47);
            Person persona8 = new Person  ("Carlos89",60);

            Node n1 = new Node(1, persona1);
            Node n2 = new Node(2, persona2);
            Node n3 = new Node(3, persona3);
            Node n4 = new Node(4, persona4);
            Node n5 = new Node(5, persona5);
            Node n6 = new Node(6, persona6);
            Node n7 = new Node(7, persona7);
            Node n8 = new Node(8, persona8);

            
            //Nodo 1 contiene a nodo 2 y 3 que a su vez contienen a todos los demas.


            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);


            // visitar el árbol aquí

            SumaEdades Edadesvisitor = new SumaEdades();
            n1.Accept(Edadesvisitor);
            int SumaDeEdades = Edadesvisitor.SumaDeEdades;
            Console.WriteLine($"La Suma de edades es : {SumaDeEdades}" );

            MayorEdad mayorEdadVisitor = new MayorEdad();
            n2.Accept(mayorEdadVisitor);
            int mayorEdad = mayorEdadVisitor.MayorNumero();
            Console.WriteLine($"El hijo más grande tiene {mayorEdad} años");
            
    
            NombreLargo nombreMasLargoVisitor = new NombreLargo();
            n3.Accept(nombreMasLargoVisitor);
            string nombreMasLargo = nombreMasLargoVisitor.LongestName;
            Console.WriteLine($"El nombre más largo es: {nombreMasLargo}");

        }
    }
}
