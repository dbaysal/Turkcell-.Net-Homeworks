using Graded_Homework_1.Classes;

School school = new School();
RegistrationOperations registration = new(school);
DataAccessOperations dataAccess = new(school);
ClassOperations classOperations = new(dataAccess);
SchoolManagement schoolManagement = new(registration, dataAccess, classOperations);
Menu menu = new(schoolManagement);

int selection = 0;
while (selection != -1)
{
    try
    {
        menu.DisplayMenu();
        Console.WriteLine("Lütfen bir seçenek girin");
        selection = Convert.ToInt32(Console.ReadLine());
        menu.ExecuteSelection(selection);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    
}