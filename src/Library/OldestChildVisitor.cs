namespace Library
{
    public class OldestChildVisitor : IVisitor<Person>
    {
        private int oldestChildAge = 0;

        public int OldestChildAge
        {
            get { return this.oldestChildAge; }
        }

        public void Visit(Node<Person> node)
        {
            if (node.Children.Count == 0) // Es una hoja
            {
                if (node.Data.Age > oldestChildAge)
                {
                    oldestChildAge = node.Data.Age;
                }
            }
        }
    }
}