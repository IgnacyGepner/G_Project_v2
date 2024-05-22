using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Project_v2
{
    public class Entity
    {
        private string Name { get; set; }
        private string Genere { get; set; }

        private Image BtnImg { get; set; }

        public string GetName()
        {
            return Name;
        }
        public string GetGen()
        {
            return Genere;
        }


        public Entity(string name, string genere, Image image)
        {
        Name = name;
        Genere = genere; 
        BtnImg = image;
        
        }

    }
}
