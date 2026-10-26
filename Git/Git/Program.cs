using System.Text;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Коментарі по командам гіта");

Console.WriteLine("git -v = Перевірити версію встановленого Git");
Console.WriteLine("git config--global user.name novakvova = Встановити глобальне ім'я користувача для підпису комітів");
Console.WriteLine("git config --global user.email novakvova@gmail.com = Встановити глобальну електронну пошту для підпису комітів");
Console.WriteLine("git config --global user.email = Переглянути поточну збережену пошту в налаштуваннях Git");
Console.WriteLine("git config --global user.name = Переглянути поточне збережене ім'я користувача в налаштуваннях Git");
Console.WriteLine("git status = Перевірити поточний стан репозиторію (відстежувані/невідстежувані файли, зміни)");
Console.WriteLine("git init = Ініціалізувати новий порожній локальний репозиторій Git у поточній папці");
Console.WriteLine("git status = Повторно перевірити стан репозиторію після ініціалізації");
Console.WriteLine("git add . = Додати всі нові та змінені файли до індексу (підготувати до коміту)");
Console.WriteLine("git status = Перевірити стан репозиторію (переконатися, що файли готові до коміту)");
Console.WriteLine("git commit -m\"Add Readme\" = Зафіксувати (зберегти) підготовлені зміни в історії з повідомленням \"Add Readme\"");
Console.WriteLine("git status = Перевірити стан репозиторію після створення коміту");
Console.WriteLine("git branch -M main = Перейменувати поточну гілку на main");
Console.WriteLine("git remote add origin https://github.com/novakvova/MiniPigCPP.git = Додати зв'язок з віддаленим репозиторієм на GitHub");
Console.WriteLine("git push -u origin main = Відправити (завантажити) локальні коміти на GitHub та зв'язати гілки");