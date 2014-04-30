using System;
using System.Collections.Generic;
using System.Text;
using HackerSharpAPI;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace HackerReader.Portable.Repository
{
    public interface IRepository
    {
        Task<ObservableCollection<HackerItem>> GetAllArticles();
        Task<ObservableCollection<HackerItem>> GetNextArticles();
    }
}
