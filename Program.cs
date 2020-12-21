using System;


namespace labwork2
{
    class Program
    {
        static void Main(string[] args)
        {
            V2DataCollection data_collectiom = new V2DataCollection("../../../Input.txt");
            foreach(var elem in data_collectiom) {
                Console.Write(elem.ToString("0.00"));
            }
            V2MainCollection main_collection = new V2MainCollection();
            main_collection.Add(data_collectiom);
            //main_collection.AddDefaults();
            foreach (V2Data elem in main_collection) {
                Console.Write(elem.ToLongString("0.00"));
            }

            Console.WriteLine("\nTest Averege:\n" + main_collection.Averege);

            Console.WriteLine("\nTest MaxDeviation(IEnumerable<DataItem>):");
            foreach (DataItem elem in main_collection.MaxDeviation) {
                Console.Write(elem.ToString("0.00"));
            }
            V2MainCollection my_main_collection = new V2MainCollection();
            my_main_collection.Add(data_collectiom);
            my_main_collection.Add(data_collectiom);
            Console.WriteLine("\nMy test MaxDeviation(IEnumerable<DataItem>):");
            foreach (DataItem elem in my_main_collection.MaxDeviation) {
                Console.Write(elem.ToString("0.00"));
            }

            Console.WriteLine("\nTest DuplicateMeasurement(IEnumerable<Vector2>):");
            foreach (var elem in main_collection.DuplicateMeasurement) {
                Console.Write(elem.ToString("0.00"));
            }
            my_main_collection = new V2MainCollection();
            my_main_collection.Add(data_collectiom);
            Console.WriteLine("\nMyest DuplicateMeasurement(IEnumerable<Vector2>)((P.S.Empty response)):");
            foreach (var elem in my_main_collection.DuplicateMeasurement) {
                Console.Write(elem.ToString("0.00"));
            }
        }
    }
}
