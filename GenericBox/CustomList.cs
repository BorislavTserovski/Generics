using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CustomList<T> where T : IComparable<T>
{
    private List<T> values;

    public CustomList()
    {
        this.Values = new List<T>();
    }

    public List<T> Values
    {
        get { return this.values; }
        private set { this.values = value; }
    }

    public void Add(T element)
    {
        this.Values.Add(element);
    }

    public void Remove(int index)
    {
       // T element = this.Values[index];
        this.Values.RemoveAt(index);
       // return element;
    }

    public bool Contains(T element)
    {
        return this.Values.Contains(element);
    }

    public void Swap(int indexOne, int indexTwo)
    {
        T temp = this.Values[indexOne];
        this.Values[indexOne] = this.Values[indexTwo];
        this.Values[indexTwo] = temp;
    }

    public int CountGreaterThan(T element)
    {
        int counter = 0;

        foreach (var i in this.Values)
        {
            if (i.CompareTo(element) > 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public T Max()
    {
        return this.Values.Max();
    }

    public T Min()
    {
        return this.Values.Min();
    }

  //
       
}

