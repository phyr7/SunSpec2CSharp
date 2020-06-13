using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Schema;
using IctBaden.Framework.AppUtils;

namespace Smdx2CSharp
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SunSpec SMDX C# Class Generator");

            if (args.Length == 0)
            {
                Console.WriteLine("Please specify SMDX source directory.");
                return;
            }

            var path = args[0];
            if(!Directory.Exists(path))
            {
                Console.WriteLine("Specified SMDX source directory does not exits.");
                return;
            }

            var smdx = Path.Combine(path, "smdx.xsd");
            if(!File.Exists(smdx))
            {
                Console.WriteLine($"Could not load schema definition {smdx}.");
                return;
            }

            XmlSchema schema;
            using (var rdr = new StreamReader(smdx))
            {
                schema = XmlSchema.Read(rdr, (sender, eventArgs) =>
                {
                    Console.WriteLine(eventArgs.Message);
                });
            }
            
            var output = Path.Combine(ApplicationInfo.ApplicationDirectory, "cs");
            if(!Directory.Exists(output))
            {
                Directory.CreateDirectory(output);
            }

            var models = Directory.EnumerateFiles(path, "smdx_*.xml", SearchOption.TopDirectoryOnly);
            foreach (var model in models)
            {
                Console.WriteLine(model);
                
                var data = new XmlDocument();
                data.Schemas.Add(schema);
                data.Load(model);

                var sunSpecModels = data.ChildNodes[0];
                var generator = new ClassGenerator(output, sunSpecModels.ChildNodes.Cast<XmlNode>());
                generator.CreateModelClass();
            }

            Console.WriteLine("Class generation done.");
        }
    }
}