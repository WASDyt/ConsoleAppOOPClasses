using ConsoleAppOOPClasses;

ClsStudent studentB = new ClsStudent();
studentB.PrintToScreen();
studentB.PrintToScreen();

// создание обьекта класса через параметр
ClsStudent studentX = new ClsStudent("Хромов Андрей Юрьевич", new DateTime(2005, 08, 24), "Давыдово СИТИ", 2, "ИСП21.1A" , 1000000000);
studentX.PrintToScreen();


//ввод значений с клавиатуры
ClsStudent studentK = new ClsStudent();
studentK.GetFromKeyboard();


Console.WriteLine("Укажите имя файла для сохранения данных");
string file = Console.ReadLine();
studentB.SaveToFile(file);
studentX.SaveToFile(file);
studentK.SaveToFile(file);
