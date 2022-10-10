using SOA3;

CalculationSaver calculationSaver = new CalculationSaver();
int Add(int a, int b) => a + b;
int Sub(int a, int b) => a - b;

//Console.WriteLine(calculationSaver.CalculateAndSave(Add, 3, 2));
Console.WriteLine(calculationSaver.CalculateAndSave(Sub, 3, 2));
