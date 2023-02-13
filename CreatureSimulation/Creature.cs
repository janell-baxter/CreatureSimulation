using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreatureSimulation
{
    enum HideType
    {
        Fur,
        Feathers,
        Scales,
        BareSkin
    }
    public class Creature
    {
        private bool alive;
        private HideType hide = HideType.BareSkin;
        private bool awake = true;
        private string name = "";

        public bool Alive { get => alive; set => alive = value; }
        internal HideType Hide { get => hide; set => hide = value; }
        public string Name { get => name; set => name = value; }

        public Creature()
        {

        }
        public Creature(string _name)
        {
            name = _name;
        }
        public virtual string Communicate()
        {
          
            return $"The creature communicates";
        }

        public virtual void Move()
        {

        }
        public void Eat()
        {
            //throw new System.NotImplementedException();
        }

        public void Sleep()
        {
            awake = false;
            //throw new System.NotImplementedException();
        }

        public void Wake()
        {
            awake = true;
        }
    }
}