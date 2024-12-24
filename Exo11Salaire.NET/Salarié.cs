using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo11Salaire.NET
{
    internal class Salarié
    {
        private int _matricule;
        private string _service;
        private string _nom;
        private int _salaire;

        public int Matricule { get => _matricule; set => _matricule = value; }
        public string Service { get => _service; set => _service = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public int Salaire { get => _salaire; set => _salaire = value; }


        public Salarié(int Matricule, string Service, string Nom, int Salaire)
        {
            _matricule = Matricule;
            _service = Service;
            _nom = Nom;
            _salaire= Salaire;
        }
    }
}
