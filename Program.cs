internal class Program
{
    private static void Main(string[] args)
    {
        int par = 0, impar = 0;
        Console.WriteLine("Ingrese cantidad de elementos: ");
        int n = int.Parse(Console.ReadLine());
        int[] numeros = new int[n];
        Random ran = new Random();
        for (int x = 0; x < n; x++)
        {
            numeros[x] = ran.Next(50, 91);
            if (numeros[x]%2==0)
            {
                par++;
            } else
            {
                impar++;    
            }
        }
        Console.WriteLine("Le gustan p/i: ");
        char r = char.Parse(Console.ReadLine().ToLower());
        if (r == 'p')
        {
            string todos = String.Join(" , ", numeros);
            Console.WriteLine($"numeros: {todos}");
            Console.WriteLine($"Los numero pares son: {par}");
        } 
        if (r == 'i')
        {
            string todos = String.Join(" , ", numeros);
            Console.WriteLine($"numeros: {todos}");
            Console.WriteLine($"Los numeros impares son: {impar}");
        }
        
    }     
    Console.WriteLine("Viva eL Per(U)")
    
}