using System;
using System.IO;

using StudentDataModels.Models;
using StudentDataModels.Importers;
using StudentDataModels.Exporters;

namespace StudentDataLoader
{
    class Program
    {
        static bool PollUserYN(string question)
        {
            Console.Write(question);
            string answer = Console.ReadLine()
                .ToUpper();
            return answer.StartsWith("Y");
        }

        static bool CheckArgs(string[] args)
        {
            // Currently, we just need the source and destination 
            if (args.Length < 2)
            {
                Console.WriteLine("Please provide a source and destination.");
                return false;
            }
            return true;
        }

        static string GetInputData(string[] args)
        {
            string sourceFileName = args[0];
            if (!File.Exists(sourceFileName))
                throw new ArgumentException("Source file does not exist");
            string output = File.ReadAllText(sourceFileName);
            return output;
        }

        static StudentModel ExtractData(string sourceData)
        {
            StudentModel student = MainStudentImporter.Extract(sourceData);
            return student;
        }

        static string TransformData(StudentModel student)
        {
            return MainStudentExporter.Export(student);
        }

        static void WriteData(string[] args, string data)
        {
            string destinationName = args[1];
            bool cont = true;
            if (File.Exists(destinationName))
            {
                cont = PollUserYN($"The specified file directory {destinationName} already exists, continue? Y/N ");
            }
            if(cont)
                File.WriteAllText(destinationName, data);
        }

        static void Main(string[] args)
        {
            if (!CheckArgs(args))
                return;
            string sourceData = GetInputData(args);
            StudentModel extractedData = ExtractData(sourceData);
            string outputData = TransformData(extractedData);
            WriteData(args, outputData);
        }
    }
}
