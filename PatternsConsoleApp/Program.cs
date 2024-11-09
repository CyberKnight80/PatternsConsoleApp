namespace PatternsConsoleApp
{
    public class Program
    {
        static void Strategy()
        {
            WarLord stalin = new WarLord(new Blitzkrieg());
            stalin.StartWar();

            WarLord newStalin = new WarLord(new ColdWar());
            newStalin.StartWar();
        }

        static void Observer()
        {
            IObservable UN = new UN();

            IObserver russia = new Russia();
            IObserver usa = new USA();

            UN.AddObserver(russia);
            UN.AddObserver(usa);

            UN.Notify("Oil`s storages is empty");
        }

        static void Command()
        {
            Soldier soldier = new Soldier();

            soldier.Execute(new PaintGrass());
            soldier.Execute(new DigTrench());
        }

        static void Template()
        {
            Sergeant sergeant = new Sergeant(new DressOn(), new PaintFloor());

            sergeant.WakeUp();
        }

        public static void Iterator()
        {
            MatrixList<int> matrix = new MatrixList<int>(3);

            matrix.values = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; 

            for(int i = 0; i < 9; i++)
            {
                Console.WriteLine(matrix.GetCurrent());

                matrix.MoveNext();
            }
        }

        static void Main(string[] args)
        {
            //Strategy();

            //Observer();

            //Command();

            //Template();

            Iterator();
        }
    }
}
