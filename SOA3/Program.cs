using SOA3;

CalculationSaver calculationSaver = new CalculationSaver();
Console.WriteLine(calculationSaver.CalculateAndSave(3, 2, CalculationSaver.Operation.Sub));
