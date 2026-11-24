using SpaceAcademy;

int actual = FuelCalculator.Calculate(3, 4);
Console.WriteLine($"Forventet: 24. Faktisk: {actual}");

int actual1 = FuelCalculator.Calculate(0, 4);
Console.WriteLine($"Forventet: 0. Faktisk: {actual1}");

int actual2 = FuelCalculator.Calculate(3, 0);
Console.WriteLine($"Forventet: 0. Faktisk: {actual2}");


int actual3 = FuelCalculator.Calculate(1, 1);
Console.WriteLine($"Forventet: 2. Faktisk: {actual3}");

int actual4 = FuelCalculator.Calculate(20, 30);
Console.WriteLine($"Forventet: 1200. Faktisk: {actual4}");






// TODO: Kjør de andre eksemplene og noter resultatene.
