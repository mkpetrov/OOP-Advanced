using System.Linq;
using System;
using System.Reflection;

public class HarvestingFieldsTest
    {
        public static void Main(string[] args)
        {
            var classType = typeof(HarvestingFields);

            var command = Console.ReadLine();

            while (command!="HARVEST")
            {
                switch (command)
                {
                    case "private":
                        var privateFields = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic|BindingFlags.Static);

                        foreach (var field in privateFields.Where(f=>f.IsPrivate))
                        {
                            Console.WriteLine($"private {field.FieldType.ToString().Split('.').Last()} {field.Name}");
                        }
                        break;

                    case "protected":
                        var protectedFields = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic|BindingFlags.Static);
                        foreach (var field in protectedFields.Where(f=>f.IsFamily))
                        {
                            Console.WriteLine($"protected {field.FieldType.ToString().Split('.').Last()} {field.Name}");
                        }
                        break;

                    case "public":
                        var publicFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public);

                        foreach (var field in publicFields.Where(f=>f.IsPublic))
                        {
                            Console.WriteLine($"public {field.FieldType.ToString().Split('.').Last()} {field.Name}");
                        }
                        break;

                    case "all":
                        var allFields =
                            classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);

                        foreach (var field in allFields)
                        {
                            if (field.Attributes.ToString()=="Family")
                            {
                                Console.WriteLine($"protected {field.FieldType.ToString().Split('.').Last()} {field.Name}");
                            }
                            else
                            {
                                Console.WriteLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.ToString().Split('.').Last()} {field.Name}");
                            }

                            
                        }
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
