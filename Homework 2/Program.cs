using Homework_2;


bool isPasswordValid = false;
while (!isPasswordValid)
{
    try
    {
        Console.WriteLine("Lütfen bir şifre giriniz:");
        string passwordInput = Console.ReadLine();
        Password p = new Password(passwordInput);
        isPasswordValid = true;
    }
    catch(ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
