using System.Reflection; // To use Assembly, TypeName, and so on.


//WriteLine($"Computer named {Env.MachineName} says \"No.\"");

System.Data.DataSet ds = new();
HttpClient client = new();

// #2 Get the assembly that is the entry point for this app.
Assembly? myApp = Assembly.GetEntryAssembly();

// #3 If the previous line returned nothing then end the app.
if (myApp is null) return;

// #4 Loop through the assemblies that my app references.
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    // #5 Load the assembly so we can read its details.
    Assembly a = Assembly.Load(name);

    // #6 Declare a variable to count the number of methods.
    int methodCount = 0;

    // #7 Loop through all the types in the assembly.
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // #8 Add up the counts of all the methods.
        methodCount += t.GetMethods().Length;
    }
    #region N0 is uppercase N followed by the digit zero. It is not uppercase N followed by uppercase O. It means “format a number(N) with zero(0) decimal places.”
    // #9 Output the count of types and their methods.
    WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name);
    #endregion
}

