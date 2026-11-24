# Arbeidslogg – Forsyninger: fra krav til testeksempler

## 1. Forventet og faktisk resultat

Fyll inn **Forventet** før du kjører programmet. Etter at du har kjørt alle fem tilfellene, fyller du inn **Faktisk** og om resultatene stemte.

| Inndata Forventet   | Faktisk  | Stemte det? |
| ------------------- | -------- | ----------- |
| 3 personer, 4 dager | 24 24 ja |
| 0 personer, 4 dager | 0 0 ja   |

| 3 personer, 0 dager | 0 0 ja
| 1 person, 1 dag | 2 2 ja
| 20 personer, 30 dager | 1200 1200 ja

Hvordan fant du frem til de forventede resultatene?

med formen: crewCount _ days _ 2;

## 2. Prøv å innføre en feil

Endre multiplikatoren fra 2 til 3, og kjør programmet på nytt.
Det oppstår en feil når endre ffra 2 til 3, fordi vi får ulike resultat, Forventet ikke stamme med Faktisk
24-36 \ 2-3 \ 1200 -1800 .

**Hvilke tilfeller avslørte feilen?**

**Hvilke tilfeller ga fortsatt riktig resultat?**

0-4 \ 3-0

**Hvorfor kan nulltilfellene gi riktig resultat selv om multiplikatoren er feil?**
vi jobber
med formen: crewCount _ days _ 2;

Fordi vi får 0 uavhengig at å være crewcount 0 eller day 0 vi får likevel 0(Forv=Fakt) , her bytte av verdier 2 spiller ingen rolle i dette telfellet,men andre caser kan påvirke på resultat.

Husk å endre multiplikatoren tilbake til 2.

## 3. Refleksjon

Hvorfor er det ikke nok at programmet skriver ut et resultat, for å avgjøre om en test består?
fordi vi har grenceverdei for personer og day ,[0-20] [0-30] og hvis en utenforgrence,det skjer en feil.
derfor det er viktig å sammenligne det faktiske resultatet med det forventede resultatet kan vi finne feil i programmet.

## 4. Endringer

Hvilke filer endret du, og hvorfor?
