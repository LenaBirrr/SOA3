using SOA3;

CalculationSaver calculationSaver = new CalculationSaver();
int Calc(int a, int b) => a + b;

Console.WriteLine(calculationSaver.CalculateAndSave(Calc, 3, 2));
