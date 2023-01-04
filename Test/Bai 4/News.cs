using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    class News : INews
    {
        private int id;
        private String title, publishDate, author, content;
        private float averageRate;

        int[] rateList = new int[3];

        //get set id
        public int GetId()
        {
            return id;
        }
        public void SetId(int _id)
        {
            id = _id;
        }
        //get set title
        public String GetTitle()
        {
            return title;
        }
        public void SetTitle(String _title)
        {
            title = _title;
        }
        // get set publishDate
        public String GetPublishDate()
        {
            return publishDate;
        }
        public void SetPublishDate(String _publishDate)
        {
            publishDate = _publishDate;
        }
        //get set author
        public String GetAuthor()
        {
            return author;
        }
        public void SetAuthor(String _author)
        {
            author = _author;
        }

        // get set content
        public String GetContent()
        {
            return content;
        }
        public void SetContent(String _content)
        {
            content = _content;
        }

        //get averageRate
        public float GetAverageRate()
        {
            return averageRate;
        }

        public void display()
        {
            Console.WriteLine("Title: " + GetTitle());
            Console.WriteLine("Publish Date: " + GetPublishDate());
            Console.WriteLine("Author: " + GetAuthor());
            Console.WriteLine("Content: " + GetContent());
            Console.WriteLine("Average Rate: " + GetAverageRate());
        }
        public void caculate()
        {
            float tong = 0;
            for(int i=0; i<3; i++)
            {
                tong += rateList[i];
            }
            averageRate = tong / 3;
            Console.WriteLine("Rate: "+averageRate);
        }

        public void EnterRate()
        {
            Console.WriteLine("Enter rate: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Rate [" + i + "]= ");
                rateList[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
