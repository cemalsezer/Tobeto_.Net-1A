namespace Generics;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        List<string> cities = new List<string>();
        cities.Add("İzmir");
        cities.Add("Ankara");
        cities.Add("İstanbul");
        Console.WriteLine(cities.Count);
 
        MyList<string> cities2 = new MyList<string>();
        cities2.Add("İzmir");
        cities2.Add("Ankara");
        cities2.Add("İstanbul");
        cities2.Add("Antalya");
        Console.WriteLine(cities2.Count);
    }

    class MyList<T> //Generic class
    {
        T[] _array;
        private T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }


        public int Count
        {
            get { return _array.Length; }
        }

    }




}