namespace Library
{
    public class LongestNameVisitor : IVisitor<Person>
    {
        private string longestName = "";

        public string LongestName
        {
            get { return this.longestName; }
        }

        public void Visit(Node<Person> node)
        {
            if (node.Data.Name.Length > longestName.Length)
            {
                longestName = node.Data.Name;
            }
        }
    }
}