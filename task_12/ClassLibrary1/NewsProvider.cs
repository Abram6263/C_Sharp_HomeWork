using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class NewsProvider
    {
        delegate void MyDelegate();
        event MyDelegate MailingNewsEvent;
        public void SportNews()
        {
            Console.WriteLine("Спортивные новости");
        }
        public void Incidents()
        {
            Console.WriteLine("новости и просходящем в стране");
        }
        public void News()
        {
            Console.WriteLine("всемирные новости");
        }
        public void Weather()
        {
            Console.WriteLine( "все о погоде");
        }
        public void Humor()
        {
            Console.WriteLine("новости из мира юмора");
        }

        public void Mailing(List<string> list)
        {
            
            foreach(var i in list)
            {
                if(i == "SportNews")
                {
                   MailingNewsEvent += SportNews;
                }
                if(i == "Incidents")
                {
                    MailingNewsEvent += Incidents;
                }
                if(i == "News")
                {
                    MailingNewsEvent += News;
                }
                if(i == "Weather")
                {
                    MailingNewsEvent += Weather;
                }
                if(i == "Humor")
                {
                    MailingNewsEvent += Humor;
                }
            }
            MailingNewsEvent();
        }
    }
}
