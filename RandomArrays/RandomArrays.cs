namespace RandomArrays;

public class RandomArrays
{

    public static int[] ArrayRandom(int Largo, int InitRandom, int EndRandom)
    {
        int[] UniArr = new int[Largo];
		Random random = new();
		for (int i = 0; i < UniArr.Length; i++)
		{
			UniArr[i] = random.Next(InitRandom, EndRandom);
		}
		return UniArr;
    }
    	// Metodo para generar un array Bi-dimensional con numeros random
    public static int[,] BiArrayRandom(int Filas, int Columnas, int InitRandom, int EndRandom)
    {
        int[,] BiArr = new int[Filas,Columnas];
		Random random = new();
		for (int i = 0; i < BiArr.Length; i++)
		{
            for (int j = 0; j < BiArr.Length; j++)
            {
			    BiArr[i,j] = random.Next(InitRandom, EndRandom);
            }
		}
		return BiArr;
    }
}
