using ClientSeries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSeries.Services
{
    internal interface IService
    {
        Task<List<Serie>> GetSeriesAsync(string nomControleur);
    }
}
