using System.Collections.Generic;

namespace Roleplay_Prog.Library
{
    public interface ICharacter
    {
        string Nombre {get;set;}
        int Vida{get;set;}
        IItem ItemOf{get;set;}
        IItem ItemDef{get;set;}

        void CambiarItemOf(IItem a);

        void QuitarItemOf();
        
        void CambiarItemDef(IItem a);
        
        void QuitarItemDef();

        int GetAtaque();

        void Atacar(ICharacter a);

        void Curarse();
    }
}