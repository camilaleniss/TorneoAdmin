using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    [Serializable]
    public class Escuela
    {
        //El nombre de la escuela
        public string Name { get; set; }

        //Puntuación acumulada en formas
        public int PFormas { get; set; }

        //Puntuación acumulada en sanda
        public int PSanda { get; set; }

        public Dictionary<int, List<Competidor>> DictionarySanda { get; set; }

        public Dictionary<int, List<Competidor>> DictionaryFormas { get; set; }

        public Escuela (string Name)
        {
            this.Name = Name;
            PFormas = 0;
            PSanda = 0;

            DictionarySanda = new Dictionary<int, List<Competidor>>();
            DictionaryFormas = new Dictionary<int, List<Competidor>>();
            DictionarySanda.Add(Torneo.ORO, new List<Competidor>());
            DictionaryFormas.Add(Torneo.ORO, new List<Competidor>());
            DictionarySanda.Add(Torneo.PLATA, new List<Competidor>());
            DictionaryFormas.Add(Torneo.PLATA, new List<Competidor>());
            DictionarySanda.Add(Torneo.BRONCE, new List<Competidor>());
            DictionaryFormas.Add(Torneo.BRONCE, new List<Competidor>());
        }

        public void AddWinner (Competidor c, int medalla, bool IsFormas)
        {
            if (IsFormas)
            {
                DictionaryFormas[medalla].Add(c);
            }
            else
            {
                DictionarySanda[medalla].Add(c);
            }
        }

        public void SetPuntos()
        {
            PFormas = 0;
            PSanda = 0;
            var Medallas = DictionaryFormas.Keys.ToArray();
            for(int i =0; i<Medallas.Length; i++)
                PFormas += Medallas[i] * DictionaryFormas[Medallas[i]].Count;
            
            Medallas = DictionarySanda.Keys.ToArray();

            for (int i = 0; i < Medallas.Length; i++)
                PSanda += Medallas[i] * DictionarySanda[Medallas[i]].Count;            
        }

        public void ClearDictionaries()
        {
            var Medallas = DictionaryFormas.Keys.ToArray();
            for (int i = 0; i < Medallas.Length; i++)
                DictionaryFormas[Medallas[i]].Clear();

            Medallas = DictionarySanda.Keys.ToArray();

            for (int i = 0; i < Medallas.Length; i++)
                DictionarySanda[Medallas[i]].Clear();
        }

    }
}
