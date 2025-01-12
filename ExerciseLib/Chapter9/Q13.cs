using System.Dynamic;

class Ch9Q13
{
    static void ans()
    {
        //the coefficient of the polynomials will be stored in an array (e.g.poly1 and poly2)
        //we first get the highest power of the polynomial to decide the length of each polynomial (e.g. polyLen1 and polyLen2)
        //then we form a matrix by method CoefficientCal. The idea will be explained below.
        Console.Write("The highest power of first polynomial: ");
        int polyLen1 = int.Parse(Console.ReadLine()) + 1;
        int[] poly1 = new int[polyLen1];

        //for loop to store the coefficientt in the poly1
        for (int i = 0; i < polyLen1; i++)
        {
            Console.Write("Enter the coefficient of X^{0}: ", polyLen1 - 1 - i);
            poly1[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("The highest power of second polynomial: ");
        int polyLen2 = int.Parse(Console.ReadLine()) + 1;
        int[] poly2 = new int[polyLen2];

        //for loop to store the coefficientt in the poly1
        for (int i = 0; i < polyLen2; i++)
        {
            Console.Write("Enter the coefficient of X^{0}: ", polyLen2 - 1 - i);
            poly2[i] = int.Parse(Console.ReadLine());
        }

        if (polyLen1 > polyLen2)
        {
            poly2 = InitialPoly(poly1, poly2, polyLen1, polyLen2);
        }
        else
        {
            poly1 = InitialPoly(poly2, poly1, polyLen2, polyLen1);
        }

        CoefficientCal(poly1, poly2);
    }

    //method InitialPoly is used to initialize the coefficient array
    //for further process in the matrix formation
    //the shorter array will be extended to the same length of the longer array
    //and therefore to form a sqaure matrix
    static int[] InitialPoly(int[] poly1, int[] poly2, int polyLen1, int polyLen2)
    {
        int diff = polyLen1 - polyLen2;
        int[] temp = new int[polyLen1];
        for (int i = 0; i < diff; i++)
        {
            temp[i] = 0;
        }
        for (int i = diff; i < polyLen1; i++)
        {
            temp[i] = poly2[i - diff];
        }
        return temp;
    }

    //the coefficient in the two array will be multiplied to each other and stored in a n x n matrix
    //the elements in the diagonal of the matrix will have the same base of x
    //e.g. for (3x^2 + x - 3) * (x - 1), the matrix will be:
    //  0x^4    3x^3    -3x^2
    //  0x^3     x^2    -x
    //  0x^2    -3x      4
    //therefore by summing up all the diagonal, we can get the coefficient of each base of x
    static void CoefficientCal(int[] poly1, int[] poly2)
    {
        int[,] coefficient = new int[poly1.Length, poly1.Length];

        //in this nested loop, i is the row and j is the column of the matrix
        //process of multiplication is done and assigned in the matrix
        for (int i = 0; i < poly1.Length; i++)
        {
            for (int j = 0; j < poly2.Length; j++)
            {
                coefficient[i, j] = poly1[i] * poly2[j];
            }
        }

        //initialization of the result array and counter is the index of it
        int[] result = new int[(poly1.Length - 1) * (poly1.Length - 1) + 1];
        int counter = 0;

        //this is the nested loop to sum up the diagonal of the first half of matrix
        //starting from the top left corner (e.g. coefficient[0,0])
        //  0x^4    3x^3    -3x^2
        //  0x^3     x^2  
        //  0x^2
        //implication as shown above
        for (int i = 0; i < poly1.Length; i++)
        {
            int row = i, col = 0;
            for (int j = 0; j <= i; j++)
            {
                result[counter] += coefficient[row, col];
                row--;
                col++;
            }
            counter++;
        }

        //now, for the second half matrix, it is calculated from the end in descending order
        //therefore, counter will be the last index of the array
        counter = (poly1.Length - 1) * (poly1.Length - 1);

        //this is the nested loop to sum up the diagonal of the second half of array
        //starting from the bottom right corner (e.g. coefficient[2,2])
        //                    
        //                  -x
        //          -3x      4
        //implication as shown above
        for (int i = poly1.Length - 1; i >= 1; i--)
        {
            int row = i, col = poly1.Length - 1;
            for (int j = i; j <= poly1.Length - 1; j++)
            {
                result[counter] += coefficient[row, col];
                row++;
                col--;
            }
            counter--;
        }

        CoefficientPrint(result);
    }

    //finally, the result is printed by method CoefficientPrint
    static void CoefficientPrint(int[] res)
    {
        Console.WriteLine("The product of the polynomial is ");
        Console.Write("({0})x^{1}", res[0], res.Length - 1);
        for (int i = 1; i < res.Length; i++)
        {
            Console.Write(" + ({0})x^{1}", res[i], res.Length - 1 - i);
        }
    }
}
