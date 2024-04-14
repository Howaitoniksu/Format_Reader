using ConsoleApp2.models;

namespace ConsoleApp2
{
    internal class Program
    {
        static List<Games> listGames = new();
        static List<Smithery> listSmith = new ();
        static CSV.CSVWrite objCSVWrite = new ();
        static CSV.CSVRead objCSVRead = new ();
        static JSON.JsonWrite objJSONWrite = new ();
        static JSON.JsonRead objJSONRead = new();
        static XML.Readxml objReadXml = new();
        static XML.Writexml objWriteXml = new();
        static YAML.Readyaml objReadYaml = new();
        static YAML.Writeyaml objWriteYaml = new ();
        /// <summary>
        /// Входной статический метод с выбором действия.
        /// </summary>
        private static void Main()
        {
            listGames.Add(new Games("The Legend of Zelda", "RPG", 3000));
            listGames.Add(new Games("Смута", "RPG", 100000000));
            listGames.Add(new Games("Ведьмак 3", "RPG", 1000));
            listGames.Add(new Games("Limbus Company", "Strategy", 1000));
            listGames.Add(new Games("Library of Ruina", "Strategy", 1000));

            listSmith.Add(new Smithery("Цвайхандер", "Незаточенная часть клинка, называвшаяся «сильной», обычно была самой толстой и прочной частью клинка, которую использовали для постановки блоков без боязни повредить клинок (не опасаясь зазубрин на лезвии), за эту же часть клинка нередко брались второй рукой для усиления удара, в связи с чем и существовала малая гарда, при этом часть клинка между гардами порой для удобства дополнительно обматывали кожей.", "Sword", 3, 46000));
            listSmith.Add(new Smithery("Катана ", "По форме клинка катана напоминает шашку, однако рукоять у неё прямая и длинная, что позволяет использовать двуручный хват. Навершие отсутствует. Небольшой изгиб клинка и острый конец позволяют наносить также и колющие удары. ", "Sword", 1, 900000));
           
            bool retrive = true;
            while (retrive)
            {
                try
                {
                    Console.WriteLine("Выберите действие:");
                    Console.WriteLine("1. Считывание с файла 2.\t Запись в файл  \t 0. Выход из программы");
                    int selector = Convert.ToInt32(Console.ReadLine());
                    switch (selector)
                    {
                        case 1: Read(); break;
                        case 2: Write(); break;
                        case 0: retrive = false; break;
                        default: Console.WriteLine("Такого варианта нет"); break;
                    }
                }
                catch (Exception except)
                {
                    Console.WriteLine(except.Message);
                }

            }
        }
        static void Write()
        {
            Console.WriteLine("Выбор листа: 1. Игры 2.\t Кузнечное дело");
            int listChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выбрано чтение из файла:");
            Console.WriteLine("Выберите формат файла: \t 1.CSV \t 2.JSON\t 3.XML\t 4.YAML");
            var formatSelect = Convert.ToInt32(Console.ReadLine());
            switch (formatSelect)
            {
                case 1: WriteCSV(listChoice); break;
                case 2: WriteJSON(listChoice); break;
                case 3: WriteXML(listChoice); break;
                case 4: WriteYAML(listChoice); break;
            }
        }
        static void Read()
        {
            Console.WriteLine("Выбор листа: 1. Игры 2.\t Кузнечное дело");
                    int listChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выбрано чтение из файла:");
            Console.WriteLine("Выберите формат файла: \t 1.CSV \t 2.JSON\t 3.XML\t 4.YAML");
            var formatSelect = Convert.ToInt32(Console.ReadLine());
            switch (formatSelect)
            {
                case 1: ReadCSV(listChoice); break;
                case 2: ReadJSON(listChoice); break;
                case 3: ReadXML(listChoice); break;
                case 4: ReadYAML(listChoice); break;
            }
        }

        static void WriteCSV(int listChoise)
        {
            Console.Write("Введите имя файла: ");
            var path = Console.ReadLine();
            switch (listChoise)
            {
                case 1:
                   
                    objCSVWrite.WriteCSV(listGames, path);
                    break;
                case 2:
                    objCSVWrite.WriteCSV(listSmith, path);
                    break;
            }
           

        }
        static void ReadCSV(int listChoise)
        {
            Console.Write("Введите имя файла: ");
            var path = Console.ReadLine();
            switch (listChoise)
            {
                case 1:
                    List<Games> newGamesList = new List<Games>();
                    newGamesList = objCSVRead.ReadCsv<Games>(path);
                    ShowGamesList(newGamesList);
                    break;
                case 2:
                    List<Smithery> newSmithList = new List<Smithery>();
                    newSmithList = objCSVRead.ReadCsv<Smithery>(path);
                    ShowSmithList(newSmithList);
                    break;
            }
            
        }

        static void ReadJSON(int listChoise)
        {
            Console.Write("Введите имя файла: ");
            var path = Console.ReadLine();
            switch (listChoise)
            {
                case 1:
                    List<Games> newGamesList = new List<Games>();
                    newGamesList = objJSONRead.ReadJSON<Games>(path);
                    ShowGamesList(newGamesList);
                    break;
                case 2:
                    List<Smithery> newSmithList = new List<Smithery>();
                    newSmithList = objJSONRead.ReadJSON<Smithery>(path);
                    ShowSmithList(newSmithList);
                    break;
            }
        }

        static void WriteJSON(int listChoise)
        {
            Console.Write("Введите имя файла: ");
            var path = Console.ReadLine();
            switch (listChoise)
            {
                case 1:
                    objJSONWrite.WriteJSON(listGames, path);
                    break;
                case 2:
                    objJSONWrite.WriteJSON(listSmith, path);
                    break;
            }
        }
        static void ReadXML(int listChoise)
        {
            Console.Write("Введите имя файла: ");
            var path = Console.ReadLine();
            switch (listChoise)
            {
                case 1:
                    List<Games> newGamesList = new List<Games>();
                    newGamesList = objReadXml.ReadXML<Games>(path);
                    ShowGamesList(newGamesList);
                    break;
                case 2:
                    List<Smithery> newSmithList = new List<Smithery>();
                    newSmithList = objReadXml.ReadXML<Smithery>(path);
                    ShowSmithList(newSmithList);
                    break;
            }
        }

        static void WriteXML(int listChoise)
        {
            Console.Write("Введите имя файла: ");
            var path = Console.ReadLine();
            switch (listChoise)
            {
                case 1:
                    objWriteXml.WriteXML(listGames, path);
                    break;
                case 2:
                    objWriteXml.WriteXML(listSmith, path);
                    break;
            }
        }

        static void ReadYAML(int listChoise)
        {
            Console.Write("Введите имя файла: ");
            var path = Console.ReadLine();
            switch (listChoise)
            {
                case 1:
                    List<Games> newGamesList = new List<Games>();
                    newGamesList = objReadYaml.ReadYAML<Games>(path);
                    ShowGamesList(newGamesList);
                    break;
                case 2:
                    List<Smithery> newSmithList = new List<Smithery>();
                    newSmithList = objReadYaml.ReadYAML<Smithery>(path);
                    ShowSmithList(newSmithList);
                    break;
            }
        }

        static void WriteYAML(int listChoise)
        {
            Console.Write("Введите имя файла: ");
            var path = Console.ReadLine();
            switch (listChoise)
            {
                case 1:
                    objWriteYaml.WriteYAML(listGames, path);
                    break;
                case 2:
                    objWriteYaml.WriteYAML(listSmith, path);
                    break;
            }
        }
        static void ShowGamesList(List<Games> gamesList)
        {
            foreach (Games game in gamesList)
            {
                Console.WriteLine($"{game.Name}, {game.Genre}, {game.Price}");
            }
            Console.WriteLine("Сортируем? 1. Да");
            var chioce = Convert.ToInt32(Console.ReadLine());
            switch (chioce)
            {
                case 1:
                    SortGames(gamesList);
                    break;
            }
        }

        static void ShowSmithList(List<Smithery> smithList)
        {
            foreach (Smithery item in smithList)
            {
                Console.WriteLine($"{item.Name} \n {item.Description}\n {item.Type} \t {item.Weight} \t {item.Price}");
            }
            Console.WriteLine("Сортируем? 1. Да");
            var chioce = Convert.ToInt32(Console.ReadLine());
            switch (chioce)
            {
                case 1: 
                    SortSmith(smithList);
                    break;
            }
        }


        static void SortSmith(List<Smithery> smithList)
        {
            Console.WriteLine("Доступные параметры сортировки:");
            Console.WriteLine("1. Названиe 2. Описание. 3. Тип 4. Вес. 5. Цена");
            var i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    ShowSmithList(listSmith.OrderBy(s => s.Name).ToList());
                    break;
                case 2:
                    ShowSmithList(listSmith.OrderBy(s => s.Description).ToList());
                    break;
                case 3:
                    ShowSmithList(listSmith.OrderBy(s => s.Type).ToList());
                    break;
                case 4:
                    ShowSmithList(listSmith.OrderBy(s => s.Weight).ToList());
                    break;
                case 5:
                    ShowSmithList(listSmith.OrderBy(s => s.Price).ToList());
                    break;
            }
        }

        static void SortGames(List<Games> gamesList)
        {
            Console.WriteLine("Доступные параметры сортировки:");
            Console.WriteLine("1. Названиe 2. Жанр. 3. Цена");
            var i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    ShowGamesList(gamesList.OrderBy(s => s.Name).ToList());
                    break;
                case 2:
                    ShowGamesList(gamesList.OrderBy(s => s.Genre).ToList());
                    break;
                case 3:
                    ShowGamesList(gamesList.OrderBy(s => s.Price).ToList());
                    break;
            }
        }
    }
}