using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Project_v2
{
    public class Entity
    {
        private string Name;
        private string Genere;
        private Image BtnImg;
        private DateTime Born;
        private int Wh;
        private int Long;

        public string GetName(){return Name;}
        public string GetGen(){return Genere;}
        public DateTime GetBorn(){return Born;}
        public int getWh(){return Wh;}
        public int GetLong() { return Long; }


        public Entity(string name, string genere, Image image,int wh, int elong, DateTime born)
        {
        Name = name;
        Genere = genere; 
        BtnImg = image;
        Long = elong;        
        Born = born;
        Wh = wh;
        }
    }
}
