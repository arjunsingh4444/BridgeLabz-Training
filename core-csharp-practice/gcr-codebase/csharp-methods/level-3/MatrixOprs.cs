using System;

class MatrixOprs
{
    // Method to create a random matrix
    public static double[,] CreateRandomMatrix(int rows, int cols)
    {
        double[,] matrix = new double[rows, cols];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                matrix[i, j] = random.Next(1, 10); // small numbers

        return matrix;
    }

    // Method to display a matrix
    public static void DisplayMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i, j] + "\t");

            Console.WriteLine();
        }
        Console.WriteLine();
    }

    // Method to add two matrices
    public static double[,] AddMatrices(double[,] a, double[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = a[i, j] + b[i, j];

        return result;
    }

    // Method to subtract two matrices
    public static double[,] SubtractMatrices(double[,] a, double[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = a[i, j] - b[i, j];

        return result;
    }

    // Method to multiply two matrices
    public static double[,] MultiplyMatrices(double[,] a, double[,] b)
    {
        int rows = a.GetLength(0);
        int cols = b.GetLength(1);
        int common = a.GetLength(1);

        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                for (int k = 0; k < common; k++)
                    result[i, j] += a[i, k] * b[k, j];

        return result;
    }

    // Method to find transpose of a matrix
    public static double[,] TransposeMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] transpose = new double[cols, rows];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                transpose[j, i] = matrix[i, j];

        return transpose;
    }

    // Determinant of 2x2 matrix
    public static double Determinant2x2(double[,] m)
    {
        return (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
    }

    // Determinant of 3x3 matrix
    public static double Determinant3x3(double[,] m)
    {
        return
            m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) -
            m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]) +
            m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);
    }

    // Inverse of 2x2 matrix
    public static double[,] Inverse2x2(double[,] m)
    {
        double det = Determinant2x2(m);
        double[,] inverse = new double[2, 2];

        inverse[0, 0] = m[1, 1] / det;
        inverse[0, 1] = -m[0, 1] / det;
        inverse[1, 0] = -m[1, 0] / det;
        inverse[1, 1] = m[0, 0] / det;

        return inverse;
    }

    // Main Method
    static void Main()
    {
        double[,] matrixA = CreateRandomMatrix(2, 2);
        double[,] matrixB = CreateRandomMatrix(2, 2);

        Console.WriteLine("Matrix A:");
        DisplayMatrix(matrixA);

        Console.WriteLine("Matrix B:");
        DisplayMatrix(matrixB);

        Console.WriteLine("Addition:");
        DisplayMatrix(AddMatrices(matrixA, matrixB));

        Console.WriteLine("Subtraction:");
        DisplayMatrix(SubtractMatrices(matrixA, matrixB));

        Console.WriteLine("Multiplication:");
        DisplayMatrix(MultiplyMatrices(matrixA, matrixB));

        Console.WriteLine("Transpose of A:");
        DisplayMatrix(TransposeMatrix(matrixA));

        Console.WriteLine("Determinant of A:");
        Console.WriteLine(Determinant2x2(matrixA));

        Console.WriteLine("\nInverse of A:");
        DisplayMatrix(Inverse2x2(matrixA));
    }
}
