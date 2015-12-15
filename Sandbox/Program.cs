using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Sandbox.SerializationExamples;
using Sandbox.SingletonImplementation;
using Sandbox.SortingAlgorithms;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton.SayHi();
            //var instance = Singleton.Instance;
            //var instance2 = Singleton.Instance; 

            var sorting = new Sorting();
            sorting.BubbleSort();
            //Console.WriteLine("****Fun With Objects Serialization*****\n");
            //var jBC = new JamesBondCar();
            //jBC.canFly = true;
            //jBC.canSubmerge = false; 
            //jBC.theRadio.stationPresets = new double[] { 89.3, 105.1, 97.1 };
            //jBC.theRadio.hasTweeters = true;

            //SaveInBinaryFormat(jBC);

            //LoadFromBinaryFormat();

            //SaveInSoapFormat(jBC); 

            //LoadFromSoapFormat();

            //var xmlFormat = new XmlSerializer(typeof (JamesBondCar), new Type[] {typeof (Radio), typeof (Car)});

            //using (Stream fileStream = new FileStream("CarData.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            //{
            //    xmlFormat.Serialize(fileStream, jBC);
            //} 

            //Console.WriteLine("=> Saved car in XML format!\n"); 

            Console.ReadKey(); 
        }

        private static void LoadFromBinaryFormat()
        {
            var bF = new BinaryFormatter();
            using (Stream fileStream = File.OpenRead("CarData.dat"))
            {
                var carFromDisk = (JamesBondCar) bF.Deserialize(fileStream);
                Console.WriteLine("Can this car fly? : {0}\n", carFromDisk.canFly);
            }
        }

        private static void LoadFromSoapFormat()
        {
            var sF = new SoapFormatter();
            using (Stream fileStream = File.OpenRead("CarData.soap"))
            {
                var carFromDisk = (JamesBondCar) sF.Deserialize(fileStream);
                Console.WriteLine("Can this car fly? : {0}\n", carFromDisk.canFly);
            }
        }

        private static void SaveInBinaryFormat(JamesBondCar jBC)
        {
            var binFormatter = new BinaryFormatter();

            using (Stream fStream = new FileStream("CarData.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormatter.Serialize(fStream, jBC);
            }

            Console.WriteLine("=> Saved car in binary format!\n");
        }

        private static void SaveInSoapFormat(JamesBondCar jBC)
        {
            var soapFormatter = new SoapFormatter();

            using (Stream fStream = new FileStream("CarData.soap", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormatter.Serialize(fStream, jBC);
            }

            Console.WriteLine("=> Saved car in soap format!\n");
        }
    }
}
