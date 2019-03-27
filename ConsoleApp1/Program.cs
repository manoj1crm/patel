using System;
using System.Collections;
using System.Linq;

public class ReadWriteExecute
{
    public static int CalculatePermissionSum(string permString)
    {
        int octalPerm = 0;

        foreach (char permission in permString.ToLower().ToArray())
        {
            switch (permission)
            {
                case 'r':
                    octalPerm += 4;
                    break;
                case 'w':
                    octalPerm += 2;
                    break;
                case 'x':
                    octalPerm += 1;
                    break;
                case '-':
                    octalPerm += 0;
                    break;
            }
        }
        return octalPerm;
    }

    public static string SymbolicToOctal(string permString)
    {
        string octalPerm = string.Empty;
        for (int x = 0; x <= 6; x += 3)
        {

            octalPerm += CalculatePermissionSum(new string(permString.Skip(x).Take(3).ToArray())).ToString();
        }
        return octalPerm;
    }

    public static void Main(string[] args)
    {
        // Should write 752
          Console.WriteLine(ReadWriteExecute.SymbolicToOctal("Rwxr-x-w"));

        //Console.WriteLine(MathUtils.Average(-1, 1));

    }
}

public class MathUtils
{
    public static double Average(int a, int b)
    {
        return a + b / 2;
    }
}