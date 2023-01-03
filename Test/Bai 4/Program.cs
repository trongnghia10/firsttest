using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String title, publishDate, author, content;
            News n = new News();
            ArrayList SaveNews = new ArrayList();

            Console.WriteLine("1. Insert news");
            Console.WriteLine("2. View list news");
            Console.WriteLine("3. Average news");
            Console.WriteLine("4. Exit");
            int opt;
            do
            {
                Console.Write("Choose please!!!: ");
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:

                        Console.Write("Enter title: ");
                        title = Console.ReadLine();
                        Console.Write("Enter publishDate: ");
                        publishDate = Console.ReadLine();
                        Console.Write("Enter author: ");
                        author = Console.ReadLine();
                        Console.Write("Enter content: ");
                        content = Console.ReadLine();

                        n.SetTitle(title);
                        n.SetPublishDate(publishDate);
                        n.SetAuthor(author);
                        n.SetContent(content);

                        n.EnterRate();

                        SaveNews.Add(n);
                        Console.Read();
                        break;
                    case 2:
                        n.display();
                        break;
                    case 3:
                        n.caculate();
                        n.display();
                        break;
                    case 4:
                        break;
                }
            } while (opt <4);
            
        }
    }
}
