using Xunit;
using SpaceAcademy;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Calculate_ThreeCrewForFourDays_Returns24()
    {
        // Arrange
        int crewCount = 3;
        int days = 4;

        // Act

        int actual = FuelCalculator.Calculate(crewCount, days);
        // Assert

        Assert.Equal(24, actual);    // forventede resultatet er 24  //basert på testen skal endre metode,for å være Assert sann
    }
    // TODO: Skriv to selvstendige Fact-tester.


    // Calculate(0, 4)
    [Fact]
    public void Test_ingenpersonerForfourDays_return0()
    {
        // Given
        int crewCount2 = 0;
        int days2 = 4;

        // When
        int actual2 = FuelCalculator.Calculate(crewCount2, days2);
        // Then

        Assert.Equal(0, actual2);
    }

    [Fact]
    public void TestEnpersonForOneday_gir2()    //Calculate(1, 1)	
    {
        // Given
        int crewCount3 = 1;
        int days3 = 1;
        // When
        int actual3 = FuelCalculator.Calculate(crewCount3, days3);//when ()er sann da, then() er sann
        // Then
        Assert.Equal(2, actual3);
    }


    // Se på resultatet i terminalen. Hvor mange tester ble kjørt, og besto de? 1 kjørt og 1 er succeeded
    // Test summary: total: 1; failed: 0; succeeded: 1; //det byter at testen ckeck en metode,med ingen feil.
    //Test summary: total: 3; failed: 0; succeeded: 3; skipped: 0;(for alle tre tester)


    // Test summary: total: 3; failed: 2; succeeded: 1; npr endre med 3
    // (0,4) succeeded: 1, gir 0 uanset endre til 3 .

    //(3,4) gir feil fordi (Forvente,Actual) er ulike(24,36)
    //(1,1) gir feil fordi (Forvente,Actual) er ulike(2,3)


    // etter endre tilbace til 2 gir testen er 3 bestå
    // Test summary: total: 3; failed: 0; succeeded: 3; skipped: 0; duration: 4,4s

}
