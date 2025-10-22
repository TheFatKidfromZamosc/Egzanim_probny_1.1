namespace Jhin
{
    internal class Program
    {
        public class Cztery
        {
            private bool[] isCzworkowa = new bool[10000];
            
            public Cztery()
            {
                for (int i = 1; i < isCzworkowa.Length; i++)
                {
                    int dlugosc = i.ToString().Length;
                    string lastOfNum = i.ToString();
                    if (lastOfNum[dlugosc-1] == '4')
                        isCzworkowa[i] = true; 
                    else
                    {
                        int sum = 0;
                        
                        for (int j =0; j < i.ToString().Length; j++)
                        {
                            sum += i.ToString()[j] - '0';
                       
                        }
                        dlugosc = sum.ToString().Length;
                        string lastOfSumOfNum = sum.ToString();
                        if (lastOfSumOfNum[dlugosc-1] == '4')
                            isCzworkowa[i] = true;
                        else
                            isCzworkowa[i] = false;

                    }
                }
            }
            public bool CzyCzworkowa(int n)
            {
                if(n >=10000 || n < 1)
                    throw new ArgumentOutOfRangeException("n musi byc z zakresu 1-10000");
                else
                    return isCzworkowa[n];
            }
        }
        static void Main(string[] args)
        {
           Cztery cztery = new Cztery();
              Console.WriteLine(cztery.CzyCzworkowa(67));
        }
    }
}
