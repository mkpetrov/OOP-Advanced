using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string nameOfClass, params string[] namesOfFields)
    {
        var classType = Type.GetType(nameOfClass);

        var classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

        var sb = new StringBuilder();

        var classIstance = Activator.CreateInstance(classType, new object[] { });

        sb.AppendLine($"Class under investigation: {nameOfClass}");

        foreach (var field in classFields.Where(f => namesOfFields.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classIstance)}");
        }

        return sb.ToString();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        var classType = Type.GetType(className);

        var classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

        var classPublickMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        var classNonPublickMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        var sb = new StringBuilder();

        foreach (var field in classFields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }

        foreach (var method in classNonPublickMethods.Where(m => m.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} have to be public!");
        }

        foreach (var method in classPublickMethods.Where(m => m.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} have to be private!");
        }

        return sb.ToString();
    }

    public string RevealPrivateMethods(string className)
    {
        var classType = Type.GetType(className);

        var classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        var sb=new StringBuilder();

        sb.AppendLine($"All Private Methods of Class: {className}");
        sb.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (var method in classNonPublicMethods)
        {
            sb.AppendLine($"{method.Name}");
        }
        return sb.ToString();
    }

    public string CollectGettersAndSetters(string className)
    {
        var classType = Type.GetType(className);

        var classMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

        var sb=new StringBuilder();

        foreach (var method in classMethods.Where(m=>m.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} will return {method.ReturnType}");
        }
        foreach (var method in classMethods.Where(m=>m.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
        }

        return sb.ToString();
    }
}