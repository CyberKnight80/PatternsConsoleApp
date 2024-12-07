using PatternsConsoleApp.ProxyPattern;
using System.Security.Cryptography.X509Certificates;

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

        public static void State()
        {
            Water bonAqua = new Water();

            bonAqua.WarmUp();
            bonAqua.WarmUp();
            bonAqua.WarmUp();
        }

        public static void ResponsabilityChain()
        {
            StepA stepA = new StepA();
            StepB stepB = new StepB();

            stepA.NextStep = stepB;

            stepA.Success("Did astral step");
        }

        public static void Mediator()
        {
            Headman headman = new Headman();
            Student student = new Student();
            student.headman = headman;
            Teacher teacher = new Teacher();
            teacher.headman = headman;

            student.Notice("Ya progulyau");
            student.Notice("Ya zabolel");
            student.Notice("Ya rabotau");

            teacher.Notice("Ya ne pridu");
            teacher.Notice("Zavtra kr");
            teacher.Notice("Posle zavtra pari ne budet");

            List<string> data = student.GetNotice();

            PrintList(data);

            data = teacher.GetNotice();

            PrintList(data);
        }

        public static void PrintList(List<string> data)
        {
            foreach (string item in data)
            {
                Console.WriteLine(item);    
            }
            Console.WriteLine();
        }

        public static void Memento()
        {
            Hero hero = new Hero();
            hero.BulletNumber = 30;
            hero.HealthNumber = 20;

            hero.Save();

            hero.FallDown();

            hero.Fire();
            hero.Fire();
            hero.Fire();
            hero.Fire();
            hero.Fire();
            hero.Fire();

            Console.WriteLine(hero.BulletNumber);
            Console.WriteLine(hero.HealthNumber);

            hero.LoadLastSave();

            Console.WriteLine(hero.BulletNumber);
            Console.WriteLine(hero.HealthNumber);
        }
        static void Decorator()
        {
            Computer computer = new Computer();
            computer.RunGame();
            ComputerDecorator computerDecorator = new ComputerDecorator(computer);
            computerDecorator.RunGame();
        }

        public static void Facade()
        {
            MotherBoard motherBoard = ComputerFacade.Build1();
            motherBoard.Start();
        }
        static void Composer()
        {
            ComposerPattern composer = new ComposerPattern();
            Node palm = composer.ComposePalmTree();
            Node pine = composer.ComposePineTree();
        }

        static void ProxyPattern()
        {
            ProxyPattern.Student testSt = new ProxyPattern.Student();
            testSt.GetWeather();
        }
        
        static void BridgePattern()
        {
            BridgePattern.Student st = new BridgePattern.Student();
            st.GoTo("Globus");
        }

        static void Main(string[] args)
        {
            //Strategy();

            //Observer();

            //Command();

            //Template();

            //Iterator();

            //State();

            //ResponsabilityChain();

            //Mediator();

            //Memento();

            //Decorator();

            //Facade();

            //Composer();

            // ProxyPattern();

            BridgePattern();
        }
    }
}
