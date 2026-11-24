using Xunit;
using SpaceAcademy;
using Microsoft.VisualBasic;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{


    [Fact]
    public void Constructor_StartsEmpty()
    {
        var bay = new CargoBay(); //CargoBay-objektet i Act i test metode

        Assert.Equal(0, bay.Count); //kontrollerer testen at Count er 0 , bay.count

    }// Test summary: total: 1; failed: 0; succeeded: 1; skipped: 0; duration: 5,0s //(0=0)


    [Fact]
    public void TestCargoBay_Førsteinnlegging()
    {
        // Given
        string m = "mat";


        // When
        var bay = new CargoBay();

        bool actual = bay.TryAdd(m);




        // Then

        Assert.NotNull(bay);
        Assert.Equal(1, bay.Count);
        Assert.True(actual);
    }

    [Fact]
    public void TestTestCargoBay_Nyttlasterommedénenhet()
    {
        // Given
        string m1 = "mat";
        string m2 = "vann";
        // When
        var bay = new CargoBay();
        bool actual = bay.TryAdd(m2);
        bool actual2 = bay.TryAdd(m1);

        // Then

        Assert.Equal(2, bay.Count);
        Assert.True(actual);
        Assert.True(actual2);


    }

    [Fact]
    public void TestTestTestCargoBay_Nyttlasterommedtoenhete()
    {
        // Given
        string m1 = "mat ";
        string m2 = "vann";
        string m3 = "verktøy";
        // When
        var bay = new CargoBay();

        bay.TryAdd(m1);
        bay.TryAdd(m2);

        bool actal3 = bay.TryAdd(m3);


        // Then
        Assert.Equal(2, bay.Count);
        Assert.False(actal3);
    }//
    // teste resultat er Test summary: total: 4; failed: 0; succeeded: 4; skipped: 0; duration: 3,3s.

    [Fact]
    public void TestToforskjellige_CargoBay()
    {
        // Given
        string v = "Pc";
        string v2 = "skjerme";
        // When
        var object1 = new CargoBay();
        var object2 = new CargoBay();  //den tom fordi Kontrollere at det andre fortsatt har Count == 0.
        object1.TryAdd(v);
        // object2.TryAdd(v2);

        // Then
        Assert.Equal(1, object1.Count);
        Assert.Equal(0, object2.Count);

    }//resultat test est summary: total: 5; failed: 0; succeeded: 5; skipped: 0; duration: 2,6s
     // resultat av kjøre siste metode alene__ Test summary: total: 1; failed: 0; succeeded: 1; skipped: 0; duration: 2,4s
     // etter set alle sammen__Test summary: total: 5; failed: 0; succeeded: 5; skipped: 0; duration: 2,7s

}
