namespace Library
{
    public class NombreLargo : IVisitor
    {
        private string nombreLargo = "";

        public string LongestName { get { return nombreLargo; } }

        public void Visit(Node node)
        {
            if (node.Persona.Name.Length > nombreLargo.Length)
            {
                nombreLargo = node.Persona.Name;
            }

            foreach (Node child in node.Children)
            {
                child.Accept(this);
            }
        }
    }
}
