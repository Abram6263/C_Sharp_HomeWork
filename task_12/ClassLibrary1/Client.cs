using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Client
    {
        NewsProvider provider;
        List<string> listSubscribes;
        public Client(string news1)
        {
            provider = new NewsProvider();
            listSubscribes = new List<string>() {news1};
        }
        public Client(string news1, string news2)
        {
            provider = new NewsProvider();
            listSubscribes = new List<string>() { news1, news2 };
        }
        public Client(string news1, string news2, string news3)
        {
            provider = new NewsProvider();
            listSubscribes = new List<string>() { news1, news2, news3 };
        }
        public Client(string news1, string news2, string news3, string news4)
        {
            provider = new NewsProvider();
            listSubscribes = new List<string>() { news1, news2, news3, news4 };
        }
        public Client(string news1, string news2, string news3, string news4, string news5)
        {
            provider = new NewsProvider();
            listSubscribes = new List<string>() { news1, news2, news3, news4, news5 };
        }

        public void AddSubscribe(string nameCategory)
        {
            listSubscribes.Add(nameCategory);
        }

        public void StartMailing()
        {
            provider.Mailing(listSubscribes);
        }
    }
}
