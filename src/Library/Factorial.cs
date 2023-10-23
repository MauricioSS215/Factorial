namespace Library;

public class Factoriales
{
    public static int Calcular(int num){


        int Factorial = 1;
        for (int i = 1 ; i <= num; i++)
        {
            Factorial = Factorial * i;
        }
        return Factorial;

    }
}
