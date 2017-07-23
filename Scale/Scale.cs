using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Scale<T> where T : IComparable<T>
{
    private T left;
    private T right;

    public Scale(T left, T right)

    {
        this.Left = left;
        this.Right = right;
    }

    public T Left
    {
        get { return this.left; }
        private set { this.left = value; }
    }
    public T Right
    {
        get { return this.right; }
        private set { this.right = value; }
    }



    public int CompareTo(T other)
    {
        throw new NotImplementedException();
    }
    public T GetHeavier()
    {
        if (left.CompareTo(right) > 0)
        {
            return left;
        }
        else if (left.CompareTo(right) < 0)
        {
            return right;
        }
        return default(T);
    }
}

