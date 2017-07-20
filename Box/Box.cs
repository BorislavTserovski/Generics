using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Box<T>
{
    private IList<T> items;

    public Box()
    {
        this.items = new List<T>();
    }

    public int Count
    {
        get { return this.items.Count; }
    }

    public void Add(T element)
    {
        this.items.Add(element);
    }

    public T Remove()
    {
        var reminder = items.LastOrDefault();
        this.items.RemoveAt(items.Count - 1);
        return reminder;
    }
}

