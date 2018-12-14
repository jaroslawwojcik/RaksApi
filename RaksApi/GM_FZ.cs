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
    
    public partial class GM_FZ
    {
        public GM_FZ()
        {
            this.GM_PZ = new HashSet<GM_PZ>();
        }
    
        public int ID { get; set; }
        public int MAGNUM { get; set; }
        public string KOD { get; set; }
        public System.DateTime DATA_WYSTAWIENIA { get; set; }
        public short ROK { get; set; }
        public short MIESIAC { get; set; }
        public int NR { get; set; }
        public string NUMER { get; set; }
        public short BLOKADA { get; set; }
        public int ID_SPOSOBU_PLATNOSCI { get; set; }
        public System.DateTime DATA_PLATNOSCI { get; set; }
        public string NAZWA_SPOSOBU_PLATNOSCI { get; set; }
        public System.DateTime DATA_OTRZYMANIA_FAKTURY { get; set; }
        public int ID_DOSTAWCY { get; set; }
        public string NR_FAKTURY_DOSTAWCY { get; set; }
        public string NAZWA_SKROCONA_DOSTAWCY { get; set; }
        public string NIP_DOSTAWCY { get; set; }
        public string KOD_KRESKOWY { get; set; }
        public string NAZWA_PELNA_DOSTAWCY { get; set; }
        public string ULICA_DOSTAWCY { get; set; }
        public string NRLOKALU_DOSTAWCY { get; set; }
        public string KOD_DOSTAWCY { get; set; }
        public string MIEJSCOWOSC_DOSTAWCY { get; set; }
        public string PESEL_DOSTAWCY { get; set; }
        public string NUMER_DOWODU_DOSTAWCY { get; set; }
        public Nullable<System.DateTime> DATA_DOWODU_DOSTAWCY { get; set; }
        public string ORGAN_DOWODU_DOSTAWCY { get; set; }
        public short ROLNIKR { get; set; }
        public string PANSTWO_DOSTAWCY { get; set; }
        public decimal PLN_KWOTA_VAT_PO { get; set; }
        public decimal PLN_WARTOSC_BRUTTO_PO { get; set; }
        public decimal PLN_WARTOSC_NETTO_PO { get; set; }
        public string NAZWA_DOKUMENTU { get; set; }
        public string OPERATOR { get; set; }
        public System.DateTime DATAREJESTRACJI { get; set; }
        public string ZMIENIL { get; set; }
        public System.DateTime DATAZMIANY { get; set; }
        public System.DateTime DATA_DOWODU { get; set; }
        public short SPOSOB_LICZENIA { get; set; }
        public string NRDOMU_DOSTAWCY { get; set; }
        public decimal WARTOSC_ROZRACHUNKU { get; set; }
        public string SYGNATURA { get; set; }
        public string ZNACZNIKI { get; set; }
        public byte[] UWAGI { get; set; }
        public Nullable<int> ID_TABELI_KURSOWEJ { get; set; }
        public int ID_WALUTY { get; set; }
        public decimal KURS { get; set; }
        public string NUMER_TABELI_KURSOWEJ { get; set; }
        public decimal WAL_WARTOSC_NETTO_PO { get; set; }
        public decimal WAL_KWOTA_VAT_PO { get; set; }
        public decimal WAL_WARTOSC_BRUTTO_PO { get; set; }
        public short MAGAZYNOWY { get; set; }
        public string TYP_DOK_MAGAZYNOWEGO { get; set; }
        public string NUMER_SAD { get; set; }
        public System.DateTime DATA_SAD { get; set; }
        public Nullable<System.DateTime> DATA_OTRZYMANIA_SAD { get; set; }
        public string GUID { get; set; }
        public Nullable<int> ID_PODSTAWY_ZWOL_VAT { get; set; }
    
        public virtual R3_CONTACTS R3_CONTACTS { get; set; }
        public virtual ICollection<GM_PZ> GM_PZ { get; set; }
    }
}
