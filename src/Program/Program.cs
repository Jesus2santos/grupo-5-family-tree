using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creación de personas
            var person1 = new Person("Alice", 70);
            var person2 = new Person("Bob", 50);
            var person3 = new Person("Charlie", 45);
            var person4 = new Person("Diana", 20);
            var person5 = new Person("Eve", 18);
            var person6 = new Person("Frank", 15);
            var person7 = new Person("Grace", 10);

            // Creación del árbol genealógico
            var root = new Node<Person>(person1);
            var child1 = new Node<Person>(person2);
            var child2 = new Node<Person>(person3);
            var grandchild1 = new Node<Person>(person4);
            var grandchild2 = new Node<Person>(person5);
            var grandchild3 = new Node<Person>(person6);
            var grandchild4 = new Node<Person>(person7);

            // Estructura del árbol
            root.AddChildren(child1);
            root.AddChildren(child2);
            child1.AddChildren(grandchild1);
            child1.AddChildren(grandchild2);
            child2.AddChildren(grandchild3);
            child2.AddChildren(grandchild4);

            // Aplicación de visitantes
            var ageSumVisitor = new AgeSumVisitor();
            var oldestChildVisitor = new OldestChildVisitor();
            var longestNameVisitor = new LongestNameVisitor();

            root.Accept(ageSumVisitor);
            root.Accept(oldestChildVisitor);
            root.Accept(longestNameVisitor);

            // Resultados
            Console.WriteLine($"Suma de las edades: {ageSumVisitor.AgeSum}");
            Console.WriteLine($"Edad del hijo más grande: {oldestChildVisitor.OldestChildAge}");
            Console.WriteLine($"Nombre más largo: {longestNameVisitor.LongestName}");
        }
    }
}