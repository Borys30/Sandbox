using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace Sandbox.SerializationExamples
{
    public class SerializationHelper
    {
        private static void LoadFromBinaryFormat()
        {
            var bF = new BinaryFormatter();
            using (Stream fileStream = File.OpenRead("CarData.dat"))
            {
                var carFromDisk = (JamesBondCar)bF.Deserialize(fileStream);
                Console.WriteLine("Can this car fly? : {0}\n", carFromDisk.canFly);
            }
        }

        private static void LoadFromSoapFormat()
        {
            var sF = new SoapFormatter();
            using (Stream fileStream = File.OpenRead("CarData.soap"))
            {
                var carFromDisk = (JamesBondCar)sF.Deserialize(fileStream);
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
