using System.Collections.Generic;

namespace ProjektoNeto.Models
{
    public interface ISamochodRepository
    {
        IEnumerable<Samochod> PobierzWszystkieSamochody();

        Samochod PobierzSamochodPoId(int samochodId);

        void DodajSamochod(Samochod samochod);

        void EdytujSamochod(Samochod samochod);

        void UsunSamochod(Samochod samochod);

        
    }
}
