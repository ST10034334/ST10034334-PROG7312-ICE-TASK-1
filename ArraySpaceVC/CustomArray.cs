namespace ArraySpaceVC
{
    //Creates a class called CustomArray with a type parameter of T meaning that this class can be used with any data type.
    //GeeksForGeeks (2021) demonstrates the Array class. 
    internal class CustomArray<T>
    {
        //Declares private field of an array of type T. This will hold the elements of the array.
        private T[] innerArray;
        //Declares private field of type integer. This will keep track of number of elements stored in the array.
        private int count;

        //CustomArray constructor to initialize fields.
        public CustomArray(int size)
        {
            innerArray = new T[size];
            count = 0;
        }

        //CustomArray Methods
        public int arrayLength => innerArray.Length;

        //Add() method adds an element to the custom array.
        public void Add(T element)
        {
            innerArray[count++] = element;
        }

        //GetAt() method returns an element by its index.
        public T GetAt(int index)
        {
            return innerArray[index];
        }

        //Search() method searches for an element in the custom array based on critera of the Predicate.
        public T Search(Predicate<T> match)
        {
            foreach (T element in innerArray)
            {
                if (element != null && match(element))
                {
                    return element;
                }
            }
            return default;
        }

        //Print() method returns the full custom array.
        public T[] Print()
        {
            return innerArray;
        }

        //Resize() method resizes the length of the array to the new size with current elements copied over.
        public void Resize(int newSize)
        {
            T[] newArray = new T[newSize];
            Array.Copy(innerArray, newArray, count);
            innerArray = newArray;
        }

        //RemoveAt() method removes an element from the custom array by index.
        public void RemoveAt(int index)
        {
            if (index >= 0)
            {
                for (int i = index; i < count - 1; i++)
                {
                    innerArray[i] = innerArray[i + 1];
                }
                innerArray[count - 1] = default;
                count--;
            }
        }
    }

}
//REFERENCE LIST:
//GeeksForGeeks. 2021. C# | Array Class (Version 2.0)
//[Source code] https://www.geeksforgeeks.org/c-sharp-array-class/
//(Accessed 22 July 2024).
