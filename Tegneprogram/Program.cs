using Tegneprogram;

// Skriv dit program her.
// God fornøjelse


// Kommentar:
// Selvom det ikke var en del af opgaven, har jeg for sjov, brugt lidt energi på at prøve at lave programmet konfigurerbart
// så man kan definere antallat af cirkler. Rækkefølgen af visningen af farver ændrer sig dog med antallet.
// Man kunne også lave et array pr. linje og lægge dem ind i et fælles array til sidst til tegne metoden.

using System;

//========= Opsætning start =========
const int RammeBredde = 500;
const int Margen = 50;
const int AfstandMellem = 15;
// Definer cirkelfarver og antal af cirkler. Det skal være et ulige antal.
//string[] cirkelFarver = new string[] { "blue" };
//string[] cirkelFarver = new string[] { "blue", "black", "red" };
string[] cirkelFarver = new string[] { "blue", "black", "red", "yellow", "green"}; // den rigtige
//string[] cirkelFarver = new string[] { "blue", "black", "red", "yellow", "green", "purple", "orange" };
//========= Opsætning slut =========

// Kontroller at det er et ulige antal cirkler
if (cirkelFarver.Length % 2 == 0) {
    Console.WriteLine("Fejl: Det skal være et ulige antal cirkler.");
    return; // Afbryd program
}

// Udregning af nyttige værdier
int antalCirklerTotalt = cirkelFarver.Length;
int antalCirklerØverst = antalCirklerTotalt / 2 + 1;
int cirkelDiameter = (RammeBredde - 2 * Margen - 2 * AfstandMellem) / antalCirklerØverst;
int cirkelRadius = cirkelDiameter / 2;
int rammeHøjde = Margen * 2 + cirkelDiameter + cirkelRadius;

// Opret og konfigurer ramme
Firkant ramme = new Firkant("black");
ramme.Bredde = RammeBredde;
ramme.Hojde = rammeHøjde;
Firkant[] firkanter = new Firkant[] { ramme };

// Opret cirkler
Cirkel[] cirkler = new Cirkel[cirkelFarver.Length];
for (int i = 0; i < cirkler.Length; i++) {
    cirkler[i] = new Cirkel(cirkelFarver[i]);
    cirkler[i].Diameter = cirkelDiameter;

    // Positioner øverste række af cirkler
    if(i < antalCirklerØverst) {
        cirkler[i].X = Margen + cirkelRadius + (cirkelDiameter + AfstandMellem) * i;
        cirkler[i].Y = Margen + cirkelRadius;
    }

    // Positioner nederste række af cirkler
    else {
        cirkler[i].X = Margen + cirkelDiameter + AfstandMellem / 2 + (cirkelDiameter + AfstandMellem) * (i - antalCirklerØverst);
        cirkler[i].Y = Margen + cirkelDiameter;
    }
}


// Opret tegning og generer SVG
Tegning tegning = new();
tegning.Tegn(firkanter, cirkler);