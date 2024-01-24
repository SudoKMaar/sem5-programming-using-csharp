internal abstract class Program
{
    public static void Main()
    {
        ContactCreation contactCreation = new ContactCreation();
        contactCreation[0] = "Abhishek Kumar";
        contactCreation[1] = "Dillin Nair";
        contactCreation[2] = "Gaurav Pal";

        Console.WriteLine($"First Contact Name = {contactCreation[0]}");
        Console.WriteLine($"Second Contact Name = {contactCreation[1]}");
        Console.WriteLine($"Third Contact Name = {contactCreation[2]}");
    }
}
internal class ContactCreation
{
    private string[] name = new string[3];
    public string this[int index]
    {
        get
        {
            return name[index];
        }
        set
        {
            name[index] = value;
        }
    }
}