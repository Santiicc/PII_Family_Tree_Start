using System;

namespace Library
{
    public class MayorEdad : IVisitor
    {
        private int mayorNumero = int.MinValue;

        public int _MayorEdad()
        {
            throw new NotImplementedException();
        }

        public int MayorNumero()
        {
            return mayorNumero;
        }

        public void Visit(Node node)
        {

                int auxedad=node.Persona.Age;
                if (auxedad > mayorNumero)
                {
                    mayorNumero = auxedad;
                }
            

            foreach (Node child in node.Children)
            {
                child.Accept(this);
            }
        }

    }

}