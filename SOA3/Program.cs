using SOA3;

CalculationSaver calculationSaver = new CalculationSaver();
CalculationSaver.Operation operation = CalculationSaver.Operation.Sub;
Console.WriteLine(calculationSaver.CalculateAndSave(3, 2, operation));
