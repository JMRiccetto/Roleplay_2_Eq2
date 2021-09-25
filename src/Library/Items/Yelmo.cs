using System;

namespace Roleplay_Prog.Library
{
    public class Yelmo : IItemDefensa
    {
        private int defensa;
        public int Defensa
        {
            get
            {
                return this.defensa;
            }
            set
            {
                if(value >=0)
                {
                    this.defensa = value;
                }
                else
                {
                    this.defensa = 0;
                } 
            }
        }

        public Yelmo(int defensa)
        {
            this.Defensa = defensa;
        }
    }
}