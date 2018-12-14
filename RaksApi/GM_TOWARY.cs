//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RaksApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class GM_TOWARY
    {
        public GM_TOWARY()
        {
            this.GM_TOWARY1 = new HashSet<GM_TOWARY>();
        }
    
        public int ID { get; set; }
        public int GRUPA { get; set; }
        public int ID_TOWARU { get; set; }
        public short ARCHIWALNY { get; set; }
        public string TYP { get; set; }
        public short LICENCJA { get; set; }
        public string SKROT { get; set; }
        public string SKROT2 { get; set; }
        public string NAZWA { get; set; }
        public Nullable<int> CENAKAT { get; set; }
        public Nullable<int> RABAT { get; set; }
        public Nullable<int> ID_MAGAZYNU { get; set; }
        public Nullable<int> LOKALIZACJA { get; set; }
        public int STAWKAVAT { get; set; }
        public int JEDNOSTKA { get; set; }
        public short PODZIELNOSC { get; set; }
        public string KOD_KRESKOWY { get; set; }
        public string CECHY { get; set; }
        public Nullable<int> CECHA1 { get; set; }
        public Nullable<int> CECHA2 { get; set; }
        public Nullable<int> CECHA3 { get; set; }
        public Nullable<int> CECHA4 { get; set; }
        public Nullable<int> CECHA5 { get; set; }
        public Nullable<int> TERMINDNI { get; set; }
        public Nullable<decimal> STANMIN { get; set; }
        public Nullable<decimal> STANMAX { get; set; }
        public string PKWIU { get; set; }
        public string PCN { get; set; }
        public string GTIN { get; set; }
        public Nullable<decimal> WAGAN { get; set; }
        public Nullable<decimal> WAGAB { get; set; }
        public Nullable<decimal> PROWIZJA { get; set; }
        public Nullable<int> OPAKOWANIE { get; set; }
        public Nullable<decimal> SZTOPAK { get; set; }
        public short OSTRZCENAZAK { get; set; }
        public string KOD_CN { get; set; }
        public Nullable<int> JM_CN { get; set; }
        public decimal PRZELICZNIK_CN { get; set; }
        public short BEZ_MASY { get; set; }
        public short INTRASTAT { get; set; }
        public Nullable<int> KOD_KRAJU_POCHODZENIA { get; set; }
        public Nullable<int> DOSTAWCA { get; set; }
        public Nullable<int> PRODUCENT { get; set; }
        public string KONTOFK { get; set; }
        public Nullable<int> RYSUNEK { get; set; }
        public Nullable<int> UWAGI { get; set; }
        public string OPERATOR { get; set; }
        public System.DateTime DATAREJESTRACJI { get; set; }
        public string ZMIENIL { get; set; }
        public System.DateTime DATAZMIANY { get; set; }
        public string GUID { get; set; }
        public decimal MIN_ILOSC_PSP { get; set; }
        public decimal MIN_ILOSC_ZD { get; set; }
        public decimal MIN_ILOSC_ZK { get; set; }
        public decimal MIN_ILOSC_PR { get; set; }
        public Nullable<int> ID_FUNDUSZU_PROMOCJI { get; set; }
        public short WYMAGAJ_TERMIN_PRZYD { get; set; }
        public short WYMAGAJ_NR_SER_DOST { get; set; }
        public short WYMAGAJ_NR_SER_SPRZED { get; set; }
    
        public virtual GM_WARTOSCI_CECH GM_WARTOSCI_CECH { get; set; }
        public virtual GM_WARTOSCI_CECH GM_WARTOSCI_CECH1 { get; set; }
        public virtual GM_WARTOSCI_CECH GM_WARTOSCI_CECH2 { get; set; }
        public virtual GM_WARTOSCI_CECH GM_WARTOSCI_CECH3 { get; set; }
        public virtual GM_WARTOSCI_CECH GM_WARTOSCI_CECH4 { get; set; }
        public virtual R3_CONTACTS R3_CONTACTS { get; set; }
        public virtual ICollection<GM_TOWARY> GM_TOWARY1 { get; set; }
        public virtual GM_TOWARY GM_TOWARY2 { get; set; }
        public virtual R3_CONTACTS R3_CONTACTS1 { get; set; }
    }
}
