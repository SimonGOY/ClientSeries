using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSeries.Models
{
    public class Serie
    {
        public Serie()
        {
        }

        public Serie(int _serieid, string _titre, string _resume, int _nbsaisons, int _nbepisodes, int _anneecreation, string _network)
        {
            this.Serieid = _serieid;
            this.Titre = _titre;
            this.Resume = _resume;
            this.Nbsaisons = _nbsaisons;
            this.Nbepisodes = _nbepisodes;
            this.Anneecreation = _anneecreation;
            this.Network = _network;
        }

        public int Serieid { get; set; }
        public string Titre { get; set; } = null!;
        public string Resume { get; set; }
        public int Nbsaisons { get; set; }
        public int Nbepisodes { get; set; }
        public int Anneecreation { get; set; }
        public string Network { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Serie serie &&
                   Serieid == serie.Serieid &&
                   Titre == serie.Titre &&
                   Resume == serie.Resume &&
                   Nbsaisons == serie.Nbsaisons &&
                   Nbepisodes == serie.Nbepisodes &&
                   Anneecreation == serie.Anneecreation &&
                   Network == serie.Network;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Serieid, Titre, Resume, Nbsaisons, Nbepisodes, Anneecreation, Network);
        }
    }
}
