using System;
using Sandbox.KeyedCollectionExample;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Singleton.SayHi();
            //var instance = Singleton.Instance;
            //var instance2 = Singleton.Instance; 

            //var sorting = new Sorting();
            //sorting.BubbleSort();
            //Console.WriteLine("****Fun With Objects Serialization*****\n");
            //var jBC = new JamesBondCar();
            //jBC.canFly = true;
            //jBC.canSubmerge = false; 
            //jBC.theRadio.stationPresets = new double[] { 89.3, 105.1, 97.1 };
            //jBC.theRadio.hasTweeters = true; 

            //var xmlFormat = new XmlSerializer(typeof (JamesBondCar), new Type[] {typeof (Radio), typeof (Car)});

            //using (Stream fileStream = new FileStream("CarData.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            //{
            //    xmlFormat.Serialize(fileStream, jBC);
            //} 

            //Console.WriteLine("=> Saved car in XML format!\n"); 

            var team = new Team(); 
            team.Roster.Add(new Player("Bryant", 8)); 
            team.Roster.Add(new Player("James", 23)); 
            Console.WriteLine(team.Roster[0].Number);
            Console.WriteLine(team.Roster["James"].Number);
            team.Roster["Bryant"].Name = "Russel"; 
            Console.WriteLine(team.Roster["Russel"].Number); 

            Console.ReadKey(); 
        } 
    }
}
