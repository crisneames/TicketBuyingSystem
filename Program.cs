// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
using System;
using System.Text;
{
    Console.WriteLine("________  __            __                    __            __       __                        __                                          _______                           __                     \r\n/        |/  |          /  |                  /  |          /  \\     /  |                      /  |                                        /       \\                         /  |                    \r\n$$$$$$$$/ $$/   _______ $$ |   __   ______   _$$ |_         $$  \\   /$$ |  ______    _______  _$$ |_     ______    ______    _______       $$$$$$$  |  ______   _____  ____  $$/   _______   ______  \r\n   $$ |   /  | /       |$$ |  /  | /      \\ / $$   |        $$$  \\ /$$$ | /      \\  /       |/ $$   |   /      \\  /      \\  /       |      $$ |  $$ | /      \\ /     \\/    \\ /  | /       | /      \\ \r\n   $$ |   $$ |/$$$$$$$/ $$ |_/$$/ /$$$$$$  |$$$$$$/         $$$$  /$$$$ | $$$$$$  |/$$$$$$$/ $$$$$$/   /$$$$$$  |/$$$$$$  |/$$$$$$$/       $$ |  $$ |/$$$$$$  |$$$$$$ $$$$  |$$ |/$$$$$$$/ /$$$$$$  |\r\n   $$ |   $$ |$$ |      $$   $$<  $$    $$ |  $$ | __       $$ $$ $$/$$ | /    $$ |$$      \\   $$ | __ $$    $$ |$$ |  $$/ $$      \\       $$ |  $$ |$$    $$ |$$ | $$ | $$ |$$ |$$      \\ $$    $$ |\r\n   $$ |   $$ |$$ \\_____ $$$$$$  \\ $$$$$$$$/   $$ |/  |      $$ |$$$/ $$ |/$$$$$$$ | $$$$$$  |  $$ |/  |$$$$$$$$/ $$ |       $$$$$$  |      $$ |__$$ |$$$$$$$$/ $$ | $$ | $$ |$$ | $$$$$$  |$$$$$$$$/ \r\n   $$ |   $$ |$$       |$$ | $$  |$$       |  $$  $$/       $$ | $/  $$ |$$    $$ |/     $$/   $$  $$/ $$       |$$ |      /     $$/       $$    $$/ $$       |$$ | $$ | $$ |$$ |/     $$/ $$       |\r\n   $$/    $$/  $$$$$$$/ $$/   $$/  $$$$$$$/    $$$$/        $$/      $$/  $$$$$$$/ $$$$$$$/     $$$$/   $$$$$$$/ $$/       $$$$$$$/        $$$$$$$/   $$$$$$$/ $$/  $$/  $$/ $$/ $$$$$$$/   $$$$$$$/ \r\n                                                                                                                                                                                                     \r\n                                                                                                                                                                                                     \r\n                                                                                                                                                                                                     ");
    Console.Write("Enter Your Name: ");
    string name = Console.ReadLine();

    while (String.IsNullOrWhiteSpace(name))
    {
        Console.Clear();
        Console.Write("Please Enter A Name: ");
        name = Console.ReadLine();
    }

    Console.WriteLine($"Hello, {name}");


    Console.WriteLine($"How many tickets would you like, {name}?");
    string numberOfTickets = Console.ReadLine();
    int numericValue;
    bool isNumber = int.TryParse(numberOfTickets, out numericValue);
    while (isNumber == false)
    {
        Console.Clear();
        Console.Write("Please enter a number: ");
        numberOfTickets = Console.ReadLine();
        isNumber = int.TryParse(numberOfTickets, out numericValue);

    }

    Console.WriteLine($"Thank you for purchasing {numberOfTickets} tickets! ");

    //choose between a selection of shows

    List<string> shows = new List<string> { "T Swift", "DAYGLOW", "Weezer" };

    string joinedShows = String.Join(", ", shows);

    Console.WriteLine("Choose The Show");


    //StringBuilder showString = new StringBuilder();

    //foreach (string show in shows) 
    //{
    //    showString.Append(show);

    //}

    Console.WriteLine(joinedShows);
    Console.ReadLine();

}