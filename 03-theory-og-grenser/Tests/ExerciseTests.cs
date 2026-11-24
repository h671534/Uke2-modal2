using Xunit;
using SpaceAcademy;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Theory]
    [InlineData(1, 4, true)]  // parameteriserte tester (Theories).tar argumenter som parmeter i test metode  CanReserve_ReturnsExpectedDecision,tester flere ganger med ullike data
                              // [InlineData]  Brukes til å sende inn testdata til en [Theory]-test.

    [InlineData(4, 4, true)]//den forste feil,gir feil i test,fordi (forvente er false, actual er true) requested = available,men må være re < ava,derfor må være  avvist.
                            //for gir bestå test må true være false//Test summary: total: 7; failed: 1; succeeded: 6\den er feiler og andre bestå
    [InlineData(5, 4, false)] //(false,false) gir riktig test

    [InlineData(3, 4, true)]  //(T,T)

    [InlineData(0, 4, false)] //(F,F)
    [InlineData(-1, 4, false)] //(F,F)
    [InlineData(1, 0, false)] //(F,F)     (Forvente er F, actual er 1,0 gir F )




    public void CanReserve_ReturnsExpectedDecision(int requested, int available, bool expected)
    {

        bool actual = SeatPolicy.CanReserve(requested, available);

        Assert.Equal(expected, actual);
    }
    // TODO: Legg til null, negativ bestilling og tom shuttle.
}
