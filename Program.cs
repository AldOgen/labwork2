using System;


namespace labwork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1:");
            V2DataOnGrid data_on_grid_1 = new V2DataOnGrid(0, "New V2 data on grid", new double[] { 0.01, 0.01 }, new int[] { 5, 5 });
            Console.WriteLine(data_on_grid_1.ToLongString());
            Console.WriteLine((((V2DataCollection)data_on_grid_1).ToLongString() + "\n"));
            Console.WriteLine("2:");
            V2MainCollection main_collection = new V2MainCollection();
            main_collection.AddDefaults();
            Console.WriteLine(main_collection);
            Console.WriteLine("3:");
            foreach (V2Data elem in main_collection) {
                var mas = elem.NearAverage(2.0f);
                foreach (var val in mas) {
                    Console.Write(val + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
