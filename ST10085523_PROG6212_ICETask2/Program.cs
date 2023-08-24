namespace ST10085523_PROG6212_ICETask2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Console.WriteLine("Manufactoring process started!" + "\n");

            Console.WriteLine("Alligning The Chasis...");
            string message = await AlignChasis();
            Console.WriteLine(message);

            string movemessage = await MoveToNext();
            Console.WriteLine(movemessage);


            Console.WriteLine("Installing Engine...");
            string message2 = await InstallEngine();
            Console.WriteLine(message2);


            string movemessage2 = await MoveToNext();
            Console.WriteLine(movemessage2);


            Console.WriteLine("Adding Chairs and Axels...");
            string message3 = await CharisAndAxels();
            Console.WriteLine(message3);

            string movemessage3 = await MoveToNext();
            Console.WriteLine(movemessage3);


            Console.WriteLine("Painting Car...");
            string message4 = await PaintCar();
            Console.WriteLine(message4);

            string movemessage4 = await MoveToNext();
            Console.WriteLine(movemessage4);



            Console.WriteLine("Fitting Tyres");
            string message5 = await FitTyre1();
            Console.WriteLine(message5);
            string message6 = await FitTyre2();
            Console.WriteLine(message6);
            string message7 = await FitTyre3();
            Console.WriteLine(message7);
            string message8 = await FitTyre4();
            Console.WriteLine(message8);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Car Complete!");
            Console.ResetColor();

            Console.ReadLine();
        }

        static async Task<string> AlignChasis()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5_000);
                return "Alignment Complete! Moving To Engine Install..." + "\n";
            });
        }
        static async Task<string> InstallEngine()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5_000);
                return "Engine Install Complete! Moving to Chairs and Axel fitting..." + "\n";
            });
        }

        static async Task<string> CharisAndAxels()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5_000);
                return "Chair and axel fitting complete! Moving to Paint process..." + "\n";
            });
        }

        static async Task<string> PaintCar()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5_000);
                return "Painting Complete! Moving to tyre fitting..." + "\n";
            });
        }

        static async Task<string> FitTyre1()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5_000);
                return "Fitting Tyre 1";
            });
        }
        static async Task<string> FitTyre2()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(0_500);
                return "Fitting Tyre 2";
            });
        }
        static async Task<string> FitTyre3()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(0_500);
                return "Fitting Tyre 3";
            });
        }
        static async Task<string> FitTyre4()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(0_500);
                return "Fitting Tyre 4" + "\n";

            });
        }
        static async Task<string> MoveToNext()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5_000);
                return "\n";

            });
        }



    }
}
