using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarManager2
{
    class Layer    //создаем наш "лист" истории - это класс
    {
        public FileSystemInfo[] Content //у него есть такой параметр как КОнтент типа ФайлИлиПапка
        {
            get;//онпозволяет считать и изменить информацию
            set;
        }

        int selectedItem; //это новая переменная для создания нового сетера гетера типа целочисленного
        
        public int SelectedItem //она означает номер строки которую выбирает пользователь
        {
            get
            {
                return selectedItem;//гетер возвращает полученное из сетера значение строки
            }
            set
            {
                if (value < 0)//если пользователь вышел выше 1 или ниже последней строки, то мы "зацикливаем" 
                {
                    selectedItem = Content.Length - 1;//переключаем на последнюю
                }
                else if (value >= Content.Length)
                {
                    selectedItem = 0;//если пытается ниже, то на 1
                }
                else
                {
                    selectedItem = value;//если ни то, ни другое, то значение сохраняется изначальным
                }
            }
        }

        public void Draw() //это метод который помогает нам с формлением слоя
        {
            Console.BackgroundColor = ConsoleColor.Black;// фон черный
            Console.Clear();//каждый раз очищение предыдущего вывода на экран для нового слоя
            for (int i = 0; i < Content.Length; ++i)// здесь цикл от 0 до последней строчки
            {
                if (i == SelectedItem)//когда итератор равен номеру выбранной строки
                {
                    Console.BackgroundColor = ConsoleColor.Blue;//фон строки становится голубым
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;//если нет, то он черный
                }
                Console.WriteLine(Content[i].Name);//а на слое написан список папок и файлов в данной директории
            }
        }
    }

    enum FarMode //это функция, заменяющая присваивание номеров различным вариантам
    {
        FileView, //если файл то номер 0
        DirectoryView//если папка то 1
    }

    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo root = new DirectoryInfo(@"C:\Users\ASUS\Desktop\PP2\Week3\Path");//получаем информацию из нужной папки
            Stack<Layer> history = new Stack<Layer>();//создаем новый пустой стек типа "слой"
            FarMode farMode = FarMode.DirectoryView;//фармод работает с enum и сейчас переменная равна 1

            history.Push( //добавляем в стек новый слой
                new Layer
                {
                    Content = root.GetFileSystemInfos(),//где информация считывается с выбранной директории
                    SelectedItem = 0//а курсор на 0 - 1 строка
                });

            while (true) //здесь слои рисуются до тех пор
            {
                if (farMode == FarMode.DirectoryView)// пока фамод равно 1, то есть мы находимся в папке
                {
                    history.Peek().Draw();
                }

                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();//данная переменная считывает определенные горячие клавиши, введенные пользователем

                switch (consoleKeyInfo.Key)//позволяет рассматривать несколько вариантов
                {
                    case ConsoleKey.UpArrow://стрелка вверх
                        history.Peek().SelectedItem--;//берет из стека слой верхний, меняет номер выбранной строки на 1 меньше и рисует новый слой с миней полосой на новом номере строки
                        break;
                    case ConsoleKey.DownArrow:
                        history.Peek().SelectedItem++;//аналогично но номер строки+1
                        break;
                    case ConsoleKey.Enter://вхождение в папку или файл

                        int x = history.Peek().SelectedItem;//узнаем номер выбранной строки
                        FileSystemInfo fileSystemInfo = history.Peek().Content[x];//по номеру строки узнаем инфу выбранной папки или файла

                        if (fileSystemInfo.GetType() == typeof(DirectoryInfo))//если это папка
                        {
                            DirectoryInfo d = fileSystemInfo as DirectoryInfo;//используем в дальнейшем только "папковую часть"
                            history.Push(new Layer { Content = d.GetFileSystemInfos(), SelectedItem = 0 });//создаем новый слой истории, где контент из новоизбранной пользователем папки, а курсор снова на 1 строке
                        }
                        else//если это файл
                        {
                            farMode = FarMode.FileView;//фармод теперь равен 0, значит новый слой не рисуется
                            using (FileStream fs = new FileStream(fileSystemInfo.FullName, FileMode.Open, FileAccess.Read))
                            {//здесь мы используем файл стрим и стримридер для открытия файла и его чтения)
                                using (StreamReader sr = new StreamReader(fs))
                                {
                                    Console.BackgroundColor = ConsoleColor.White;//фон белый
                                    Console.ForegroundColor = ConsoleColor.Black;//шрифт черный
                                    Console.Clear();//всё что было написано до стирается
                                    Console.WriteLine(sr.ReadToEnd());//пишется содержимое стримридера - содержимое файла до конца
                                }
                            }
                        }
                        break;
                    case ConsoleKey.Backspace:// кнопка "назад"
                        if (farMode == FarMode.DirectoryView)//если фармод 1, то есть папка
                        {
                            history.Pop();//то мы просто убираем верхний слой стека - получаем предыдущий путь
                        }
                        else if (farMode == FarMode.FileView)//а если мы открыли файл
                        {
                            farMode = FarMode.DirectoryView;//присваиваем ему значение папки в которой сейчас находимся - отрисовывается история верхнего слоя
                            Console.ForegroundColor = ConsoleColor.White;//меняем цвет шрифта на белый
                        }
                        break;
                    case ConsoleKey.Delete://удаление
                        int x2 = history.Peek().SelectedItem;//узнаем номер строки
                        FileSystemInfo fileSystemInfo2 = history.Peek().Content[x2];//узнаем информацию о файле или папке
                        if (fileSystemInfo2.GetType() == typeof(DirectoryInfo))//если папка
                        {
                            DirectoryInfo d = fileSystemInfo2 as DirectoryInfo;//далее используем d как информацию о выбранной папке
                            Directory.Delete(fileSystemInfo2.FullName, true);//удаляем папку при значении тру чтобы не было exception
                            history.Peek().Content = d.Parent.GetFileSystemInfos();//отрисовываем новый слой, в котором измененное состояние родительской папки от d
                        }
                        else//если файл
                        {
                            FileInfo f = fileSystemInfo2 as FileInfo;//рассматриваем fileSystemInfo2 как файл
                            File.Delete(fileSystemInfo2.FullName);//удаляем
                            history.Peek().Content = f.Directory.GetFileSystemInfos();//отрисовываем слой, папка в которой находится файл обновлена
                        }
                        history.Peek().SelectedItem--; //курсор сдвигается вверх
                        break;

                    case ConsoleKey.Tab://переименование 
                        int x3 = history.Peek().SelectedItem;//номер строки
                        FileSystemInfo fileSystemInfo3 = history.Peek().Content[x3];//информация о файле или папке

                        string firstname = history.Peek().Content[x3].Name;//новая строка равна имени файла или папки
                        string secondname = Console.ReadLine();//новая строка равна введенной пользователем

                        if (firstname != secondname)
                        {
                            if (fileSystemInfo3.GetType() == typeof(DirectoryInfo))//если это папка
                            {
                                DirectoryInfo d = fileSystemInfo3 as DirectoryInfo;//рассматриваем как папку
                                string path1 = Path.GetDirectoryName(d.FullName);//ссылка на путь ДО папки
                                string extension1 = Path.GetExtension(firstname); //узнает расширение выбранной папки 
                                string end1 = path1 + '/' + secondname + extension1;//создает новый путь к новоименованной папке
                                Directory.Move(d.FullName, @end1); //перемещает=переименовывает
                                history.Peek().Content = d.Parent.GetFileSystemInfos();//отрисовывает обновленный вариант
                            }

                            else //если файл
                            {
                                FileInfo f = fileSystemInfo3 as FileInfo;//рассматриваем как файл
                                string path = f.DirectoryName;//создаем строку-ссылку на файл(без имени файла в конце)
                                string extension = Path.GetExtension(firstname); //узнает расширение выбранного файла
                                string end = path + '/' + secondname + extension;//создает путь до новоименнованного файла
                                File.Move(f.FullName, @end); //переименовывание
                                history.Peek().Content = f.Directory.GetFileSystemInfos();//отрисовывает обновление
                            }
                        }
                        else
                        {

                        }
                       break;
                }
            }
        }
    }
}