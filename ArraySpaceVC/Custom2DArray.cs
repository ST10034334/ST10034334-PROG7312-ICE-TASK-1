namespace ArraySpaceVC
{
    //Creates a class called Custom2DArray with a type parameter of T meaning that this class can be used with any data type.
    //DotNetTutorials (2024) demonstrates 2D Arrays.
    internal class Custom2DArray<T>
    {
        //Declares private field of an array of type T. This will hold the elements of the array.
        private T[,] inner2DArray;
        //Declares private field of type integer. This will keep track of number of elements stored in the array.
        private int row;
        private int column;

        //CustomArray constructor to initialize fields.
        public Custom2DArray(int row, int column)
        {
            inner2DArray = new T[row, column];
            this.row = row;
            this.column = column;
        }

        //Custom2DArray Methods
        public int arrayRowLength => inner2DArray.GetLength(0);
        public int arrayColumnLength => inner2DArray.GetLength(1);

        //Add() method adds an element to the custom 2D array.
        public void Add(int r, int c, T element)
        {
            if (r >= 0 && r < row && c >= 0 && c < column)
            {
                inner2DArray[r, c] = element;
            }
        }

        //GetAt() method returns an element by its index.
        public T GetAt(int rowIndex, int colIndex)
        {
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    return inner2DArray[rowIndex, colIndex];
                }
            }
            return default;
        }

        public void updatePosition(int newRow, int newColumn, T element)
        {
            if (element != null)
            {
                var result = indexOf(element);

                if (result.row != -1 && result.col != -1)
                {
                    inner2DArray[result.row, result.col] = inner2DArray[newRow, newColumn];
                }
            }


        }

        public (int row, int col) indexOf(T element)
        {
            for (int r = 0; r < arrayRowLength; r++)
            {
                for (int c = 0; c < arrayColumnLength; c++)
                {
                    if (inner2DArray[r, c] != null && inner2DArray[r, c].Equals(element))
                    {
                        return (r, c);
                    }

                }
            }
            return (-1, -1);
        }
    }

}
//REFERENCE LIST:
//DotNetTutorials. 2024. 2D Arrays in C# (Version 1.0)
//[Source code] https://dotnettutorials.net/lesson/two-dimensional-array-in-csharp/
//(Accessed 22 July 2024).