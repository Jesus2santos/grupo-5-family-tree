﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class Node<T>
    {
        private T data;
        private List<Node<T>> children = new List<Node<T>>();

        public T Data
        {
            get { return this.data; }
        }

        public ReadOnlyCollection<Node<T>> Children
        {
            get { return this.children.AsReadOnly(); }
        }

        public Node(T data)
        {
            this.data = data;
        }

        public void AddChildren(Node<T> child)
        {
            this.children.Add(child);
        }

        public void Accept(IVisitor<T> visitor)
        {
            visitor.Visit(this);
            foreach (var child in this.children)
            {
                child.Accept(visitor);
            }
        }
    }
}