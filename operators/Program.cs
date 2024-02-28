

using System;

class Program
{
    static void Main(string[] args)
    {
        // Integer data types
        int int1 = 10;
        int int2 = 5;
        int productInt = int1 * int2;
        int sumInt = int1 + int2;
        int maxInt = Math.Max(int1, int2);
        int minInt = Math.Min(int1, int2);
        bool isInt1Greater = int1 > int2;

        Console.WriteLine($"The max of {int1} and {int2} is {maxInt}. The min of {int1} and {int2} is {minInt}.");
        Console.WriteLine($"{int1} is greater than {int2}, {isInt1Greater}");

        // Short data types
        short short1 = 100;
        short short2 = 50;
        short productShort = (short)(short1 * short2);
        short sumShort = (short)(short1 + short2);
        short maxShort = Math.Max(short1, short2);
        short minShort = Math.Min(short1, short2);
        bool isShort1Greater = short1 > short2;

        Console.WriteLine($"The max of {short1} and {short2} is {maxShort}. The min of {short1} and {short2} is {minShort}.");
        Console.WriteLine($"{short1} is greater than {short2}, {isShort1Greater}");

        // Long data types
        long long1 = 10000000000;
        long long2 = 5000000000;
        long productLong = long1 * long2;
        long sumLong = long1 + long2;
        long maxLong = Math.Max(long1, long2);
        long minLong = Math.Min(long1, long2);
        bool isLong1Greater = long1 > long2;

        Console.WriteLine($"The max of {long1} and {long2} is {maxLong}. The min of {long1} and {long2} is {minLong}.");
        Console.WriteLine($"{long1} is greater than {long2}, {isLong1Greater}");

        // Float data types
        float float1 = 10.5f;
        float float2 = 5.3f;
        float productFloat = float1 * float2;
        float sumFloat = float1 + float2;
        float maxFloat = Math.Max(float1, float2);
        float minFloat = Math.Min(float1, float2);
        bool isFloat1Greater = float1 > float2;

        Console.WriteLine($"The max of {float1} and {float2} is {maxFloat}. The min of {float1} and {float2} is {minFloat}.");
        Console.WriteLine($"{float1} is greater than {float2}, {isFloat1Greater}");

        // Double data types
        double double1 = 10.5;
        double double2 = 5.3;
        double productDouble = double1 * double2;
        double sumDouble = double1 + double2;
        double maxDouble = Math.Max(double1, double2);
        double minDouble = Math.Min(double1, double2);
        bool isDouble1Greater = double1 > double2;

        Console.WriteLine($"The max of {double1} and {double2} is {maxDouble}. The min of {double1} and {double2} is {minDouble}.");
        Console.WriteLine($"{double1} is greater than {double2}, {isDouble1Greater}");

        // Decimal data types
        decimal decimal1 = 10.5m;
        decimal decimal2 = 5.3m;
        decimal productDecimal = decimal1 * decimal2;
        decimal sumDecimal = decimal1 + decimal2;
        decimal maxDecimal = Math.Max(decimal1, decimal2);
        decimal minDecimal = Math.Min(decimal1, decimal2);
        bool isDecimal1Greater = decimal1 > decimal2;

        Console.WriteLine($"The max of {decimal1} and {decimal2} is {maxDecimal}. The min of {decimal1} and {decimal2} is {minDecimal}.");
        Console.WriteLine($"{decimal1} is greater than {decimal2}, {isDecimal1Greater}");

    }
}