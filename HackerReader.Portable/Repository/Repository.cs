using HackerSharpAPI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerReader.Portable.Repository
{
    public class Repository : IRepository
    {
        private HackerSharp hackerSharp;

        public Repository()
        {
            hackerSharp = new HackerSharp();
        }

        public async Task<ObservableCollection<HackerItem>> GetAllArticles()
        {
            var items = new ObservableCollection<HackerItem>(await hackerSharp.News());
            return items;
        }

        public async Task<ObservableCollection<HackerItem>> GetNextArticles()
        {
            var items = new ObservableCollection<HackerItem>(await hackerSharp.News(true));
            return items;
        }
    }
}
