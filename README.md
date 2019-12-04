# A progtetélekhez kapcsolódó és néhány egyéb, széles körben ismert egyszerű algoritmus objektum orientált megvalósítása C# nyelven
[Bevezető és olvasnivaló - szócikk](https://github.com/edutainer/progtetelek/wiki/Bevezetés-a-programozási-tételek-programkódjaihoz)
## Az OOP alapjai
  [C# Osztályok és Objektumok - Bevezető és Alapfogalmak. - szócikk](https://github.com/edutainer/progtetelek/wiki/C%23-Osztályok,-objektumok---bevezető-ismeretek-és-néhány-alapfogalom)
  
  [Öröklés - szócikk](https://github.com/edutainer/progtetelek/wiki/Öröklés-(Inheritance))
  
## Néhány fontos kód snipet, melyekre szükség lesz a tételek futtatásához (is) 
### Véletlen számok
Állítsunk elő és tároljunk a véletlen számokéhoz hasonló tulajdonságokkal (?) rendelkező számokatí!
### Lemezműveletek
## Sorozatból egyetlen érték előállítására vonatkozó tételekre készített kódok
[Sorozatból egy érték előállítása - szócikk](https://github.com/edutainer/progtetelek/wiki/Sorozatb%C3%B3l-egy-%C3%A9rt%C3%A9k-el%C5%91%C3%A1ll%C3%ADt%C3%A1sa)
### Összesítés "jellegű" 
[Összesítő kódok](https://github.com/edutainer/progtetelek/blob/master/conseq/Seqvence_Sum_Cnt.cs)

- ### Megszámlálás tétele
  - A sorozat T tulajdonságú elemeinek számát adja vissza.
- ### Összegzés (és hasonlók)
  - A sorozat T tulajdonságú elemeinek összegét (szorzatát, valamely középértékét, stb. ) adja vissza
### Keresést alkalmazó
[(Keresést alkalmazó Kódok)](https://github.com/edutainer/progtetelek/blob/master/conseq/Sequence_2SingleVal.cs)
- ### Eldöntés tétele
  * #### Létezik-e elem, melyre igaz a T feltétel? (egzisztencia)
  * #### Minden elemre igaz-e a T feltétel? (univerzalitás) 
- ### Lineáris keresés ill. kiválasztás
  - A sorozat T tulajdonságú elemének indexét adja vissza.
  - Kiválasztás esetén, feltételezzük, hogy létezik a sorozatban T tulajdonságú elem. Ezért, ennek ellenkezőjére nem készítjük fel a programot.
- ### Szélsőérték keresés (Max/Min)
  - A sorozat T tulajdonságú elemé közül, a legnagyobb/legkisebb indexét adja vissza.
  - A MaxKiválasztásra hasonlót mondhatunk, mint a kiválasztás esetén mondtunk.
- ### Logaritmikus keresés
  - FIGYELEM: Ez csak rendezett sorozat esetén működik.
## Sorozatból sorozat előállítására vonatkozó tételekre készített kódok.
- ### Rendezések O(n<sup>2</sup>) lépésben - [szócikk](https://github.com/edutainer/progtetelek/wiki/Rendez%C5%91-algoritmusok)

  * #### Buborék (Bubble)
  * #### Beszúrásos (Insertion)
  * #### Kiválasztásos (Selection)
[(Kódok)](https://github.com/edutainer/progtetelek/blob/master/conseq/Sequence_2SingleValAndSingleSort.cs)
- ### Rendezések O(n log<sub>2</sub>n) lépésben
  * #### Összefésüléses (Merge)
  * #### Gyors (Quick)
[(Kódok)](https://github.com/edutainer/progtetelek/blob/master/conseq/Sequence_2SingleValAndSort.cs)
- ### Rendezett sorozat elemeiből egy közös rendezett sorozat (Unio)
  * #### Összefésülés (Merge) - O(n)



