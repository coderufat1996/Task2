namespace massivler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Massivi daxil edin-");
            //int mas = int.Parse(Console.ReadLine());
            //int[] mas = new int[mas];
            //bool ededi silsiledir = true;
            //for (int i = 0; i < mas.length; i++)
            //{
            //    Console.Write($"Mas[(i)]=");
            //    mas[i] = int.Parse(Console.ReadLine());
            //}
            //int ededi silsile1;
            //int ededi silsile = (int)(mas[1] - mas[int]);
            //if (ededi silsile != ededi silsile1)
            //    {
            //    Console.WriteLine("mas ededi silsile deyil");
            //    ededi silsiledir = false;
            //    break;
            //    if (ededi silsiledir)
            //        Console.WriteLine("mas ededi silsiledir");

            //}
            //Console.WriteLine("Hello, World!");

            //}
            Console.Write("Massivi daxil edin:");
            int maas = int.Parse(Console.ReadLine());
            int[] mas = new int[maas];
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"Massiv[(i)]=");
                mas[i] = int.Parse(Console.ReadLine());
                if (mas[i] % 2 == 1) 
                        {
                    Console.WriteLine(mas[i]);
                        }
            }
        }
    }
}