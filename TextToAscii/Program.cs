// See https://aka.ms/new-console-template for more information
using Figgle;

using System.Reflection;

Console.WriteLine("Enter the text for ASCII");

var msg = Console.ReadLine();
Type myType = typeof(FiggleFonts);

// Get all static properties of MyClass
PropertyInfo[] properties = myType.GetProperties(BindingFlags.Public | BindingFlags.Static);

// Iterate through properties and invoke Render() method if available
foreach (PropertyInfo property in properties)
{
    // Check if the property has a method named Render
    Console.WriteLine(property.Name);
    var intance = property.GetValue(null);
    MethodInfo renderMethod = property.PropertyType.GetMethod("Render");
    if (renderMethod != null)
    {
        try
        {
            var aa = renderMethod.Invoke(intance, new object[] { msg, null }).ToString();
            // Invoke the Render method
            Console.WriteLine(aa);
        }
        catch
        {
            // Console.WriteLine(ex.Message);
        }
    }
}

//foreach (var property in typeof(FiggleFonts).GetProperties())
//{
//    MethodInfo renderMethod = property.GetMethod("Render", BindingFlags.Public | BindingFlags.Static);
//    if (renderMethod != null)
//    {
//        // Invoke the Render method
//        renderMethod.Invoke(null, null);
//    }
//}
////};
//Console.WriteLine(
//FiggleFonts.Standard.Render("Hello, World!"));