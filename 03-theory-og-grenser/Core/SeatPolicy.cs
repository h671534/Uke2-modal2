namespace SpaceAcademy;

public static class SeatPolicy
{
    public static bool CanReserve(int requested, int available)
    {
        // TODO: Finn grensefeilen ved hjelp av testene.
        return requested > 0 && requested <= available;
    }
}


// 3 ønskede seter, 4 ledige seter. gir T (3,4,t) canResrve gir true (Forvente er T, actual er T)
// 4 ønskede seter, 4 ledige seter.  F fordi   return requested > 0 && requested < available;  Men   med <= blir T     [InlineData(4, 4, true)] blir(forv er T, actual er T) da bestå i testen.
// 5 ønskede seter, 4 ledige seter.  F
// Etter endre  betingelsen slik at den følger kravet til setereservasjonen med <= da gir i test
// Test summary: total: 7; failed: 0; succeeded: 7; skipped: 0
