
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class CubeFilter
{
    public static int cube(int x)
    {
        return x * x * x;
    }

    public static int[] cubes(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = cube(xs[i]);
        }
        return result;
    }

    public static int[] fact(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            int multiply;
            // check for 0 
            if (xs[i] > 1)
            {
                multiply = xs[i] - 1;
            }
            else
            {
                multiply = xs[i];
            }

            //check for negative number, if so make it 0
            if(xs[i] < 0)
            {
                xs[i] = 0;
            }

            // calcuate the factorial
            for (; multiply > 0; multiply--)
            {
                xs[i] = xs[i] * multiply;
            }
            result[i] = xs[i];
        }
        return result;
    }
}

