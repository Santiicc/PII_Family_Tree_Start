namespace Library
{
    public class SumaEdades : IVisitor
    {
        public int SumaDeEdades { get; set; }

        public void Visit(Node node)
        {
            SumaDeEdades = SumaDeEdades + node.Persona.Age;

            foreach (Node child in node.Children)
            {
                child.Accept(this);
            }
        }
    }
}