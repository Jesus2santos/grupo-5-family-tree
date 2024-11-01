namespace Library
{
    public class AgeSumVisitor : IVisitor<Person>
    {
        private int ageSum = 0;

        public int AgeSum
        {
            get { return this.ageSum; }
        }

        public void Visit(Node<Person> node)
        {
            ageSum += node.Data.Age;
        }
    }
}