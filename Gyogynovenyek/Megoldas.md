# Megoldás

## Osztály létrehozása
 - Kétféle mód közül bármelyik: x
    - ctrl + .  x
    -  Adjunk hozzá egy osztályt x
- 5 tulajdonság x
- public get, private set x
- 1 konstruktor  x
- 1 string paraméter   x
- például "Acsalapu;levél;6;8" x
- pontosvesszővel tagolt x
- 4 adat -> 5 tulajdonság (?) x
- átadott, fájlból beolvasott sort: x
  - pontosvessző mentén tagoljuk x
  - [0] --> nev x 
  - [1] -->resz x
  - [2] -->kezd x
  - [3] -->veg x
  - idotartam --> számolás (lásd következő pont) x
    
-5-dik tulajdonság -> időtartam x
  - konstruktorban számoljuk x
  - számolása: vég - kezdet + 1 HA: vég>kezdet x 
  - de: 12 - kezdet + vég + 1 HA: vég<kezdet x

## Adatok beolvasása és eltárolása x
- Listában tároljuk az objektum példányait x
-  Olvassuk be x
   -  Using System.IO; x
   -  StreamReader x
   -  while --> amíg tart a file x
   -  Cikluson belül listához hozzáadunk egy új objektumpéldányt (beolvasott sor a paraméter) x

### 1. Feladat
- Hány növény van? lista hossza x

### 2. Feladat
- Milyen gyűjthető részek vannak?
- Hány darab van ezekből?

### 3. Feladat
- Maximumkeresés --> időtartam alapján
- növény(ek) nevét kiírni, amely(ek) a legtovább szedhetőek

### 4. Feladat
- Átlagszámítás --> időtartam