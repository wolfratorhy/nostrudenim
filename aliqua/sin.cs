var descriptionAttribute = Assembly.GetExecutingAssembly()
    .GetCustomAttributes<AssemblyDescriptionAttribute>()
    .FirstOrDefault();

if (descriptionAttribute != null)
{
    Console.WriteLine(descriptionAttribute.Description);
}
else
{
    Console.WriteLine("No description attribute found.");
}
