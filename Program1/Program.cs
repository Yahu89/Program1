using Program1;
using Zadania;
using System.Text;

namespace Program1
{
    class Program
    {
        
        static void Main()
        {
            //LiczbyPierwsze liczbyPierwsze = new LiczbyPierwsze();
            //liczbyPierwsze.listOfEvenNumbers();

            //DwieCyfrySilni dwieCyfrySilni = new DwieCyfrySilni();            
            //dwieCyfrySilni.CalculateDigits(dwieCyfrySilni.NumberOfCases);
            //dwieCyfrySilni.DisplayResult(1);

            //CzyUmieszPotegowac czyUmieszPotegowac = new CzyUmieszPotegowac();
            //czyUmieszPotegowac.InputData(czyUmieszPotegowac.NumberOfCases);

            //Flamaster flamaster = new Flamaster();
            //flamaster.PrepareFakeData();
            ////flamaster.InputData();
            //flamaster.Solve();

            //ZabawneDodawaniePiotrusia zdp = new ZabawneDodawaniePiotrusia();
            //zdp.InputData();
            //zdp.DisplayData();

            //StringMerge stringMerge = new StringMerge();
            //stringMerge.InputData();
            //stringMerge.DisplayData();

            //Podzielnosc podzielnosc = new Podzielnosc();
            //podzielnosc.InputData();
            //podzielnosc.DisplayData();

            //Test3 test3 = new Test3();
            //test3.WorkingTest();

            //TransponowanieMacierzy transponowanieMacierzy = new TransponowanieMacierzy();
            //transponowanieMacierzy.Solution();

            ZliczaczLiter zliczaczLiter = new ZliczaczLiter();
            zliczaczLiter.InputData();
            zliczaczLiter.CountingLetters();


            Console.ReadKey();
        }
    }
}