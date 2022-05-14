Func<long, bool> isEven = (n) => n % 2 == 0;
Action<long> algoritmoCollatz = null;
 algoritmoCollatz = (n) =>
{
    Console.WriteLine(n);
    long resultado = 0;
    if (isEven(n))
    {
        resultado = n / 2; //SE OPERA n SI ES PAR
    }
    else
    {
        resultado = (n * 3) + 1; //SE OPERA n SI ES IMPAR
    }

    /*
     * REFACTORIZAR EL ALGORITMO
     * if (n != 1)
       collatz(isEven(n)? n/2 : (n*3)+1 );
     */

    if (resultado!=1)
    algoritmoCollatz(resultado);
    else
    {
        Console.WriteLine(resultado);
    }
};

algoritmoCollatz(13);
Console.WriteLine("\n");
algoritmoCollatz(10520124451);
Console.WriteLine("\n");
algoritmoCollatz(918741918981981781);
