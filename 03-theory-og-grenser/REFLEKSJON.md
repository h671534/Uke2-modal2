# Arbeidslogg – Setereservasjon: Theory og grensetilfeller

## Før koding

Min forventning og begrunnelse:

## Forsøk

| Handling / testnavn | Forventet | Faktisk | Hva lærte jeg? |
| ------------------- | --------- | ------- | -------------- |

## Etterpå

Hvilke filer endret jeg, og hvorfor?

Svar på refleksjonsspørsmålene:
[Fact] – Tester ett bestemt scenario.

[Theory] – Tester flere scenarioer med samme testmetode. tar variabler i metode test som parametter.

[InlineData] – Definerer testdataene som brukes i hver kjøring. kobles til Theory via [InlineData(1, 4, true)]
Hver [InlineData] representerer én testkjøring.

Hva kontrollerer Assert.Equal(expected, actual), og hva skjer dersom verdiene er forskjellige?
At( exp=actu ) er bestå test, hvis er ulike gir feil i test.

Hvorfor en reservasjon med like mange ønskede og ledige seter skal godkjennes.?

En reservasjon skal godkjennes når: alle kravene er sann. for exs (4, 4, true) den gir true når følger metode som return requested > 0 && requested <= available; ,men hvis return requested > 0 && requested < available
sakl reservasjon (4,4,true) sakl ikke godkjennes.
