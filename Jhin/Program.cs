namespace Jhin
{
    internal class Program
    {
        /**********************************
         * Klasa Cztery
         * opis: sprawdzanie czy liczba jest czworkowa
         * pola: isCzworkowa - tablica przechowujaca informacje czy liczba jest czworkowa
         * autor: Jhin
         *********************************/
        public class Cztery
        {
            private bool[] isCzworkowa = new bool[10000];

            /************************************************************
             *  Konstruktor klasy Cztery - inicjalizuje tablicę isCzworkowa
             *  Sprawdza dla każdej liczby od 1 do 10000, czy jest czworkowa
             *  Wpierw sprawdza czy cyfra zawiera cyfre 4
             *  Następnie oblicza sumę cyfr liczby i sprawdza czy ostatnia cyfra sumy jest równa 4
             *******************************************************/
            public Cztery()
            {
                for (int i = 1; i < 10000; i++)
                {
                    string lastOfNum = i.ToString();
                    if (lastOfNum.Contains('4'))
                        isCzworkowa[i] = true;
                    else
                    {
                        int sum = 0;

                        for (int j = 0; j < i.ToString().Length; j++)
                        {
                            sum += i.ToString()[j] - '0';

                        }
                        int dlugosc = sum.ToString().Length;
                        string lastOfSumOfNum = sum.ToString();
                        if (lastOfSumOfNum[dlugosc - 1] == '4')
                            isCzworkowa[i] = true;
                        else
                            isCzworkowa[i] = false;

                    }
                }
            }
        
        /************************************************************
         *  Metoda CzyCzworkowa(n) zwraca true, jeśli n jest liczbą czworkową.
         *  Liczba jest czworkowa, jeśli spełnia jeden z warunków:
         *  - zawiera cyfre 4
         *  - suma jej cyfr ma ostatnią cyfrę równą 4
         *******************************************************/
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
              Console.WriteLine(cztery.CzyCzworkowa(21));
        }
    }
}
