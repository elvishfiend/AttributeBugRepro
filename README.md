# AttributeBugRepro

Created as a repro for https://github.com/dotnet/roslyn/issues/25589

To reproduce:
  1. Open Class1.cs
  2. Remove the Attributes on the Property and Field
  3. Start retyping the Attributes. Intellisense should show up as you navigate the namespace, but it doesn't until you reach `CsvHelper.Configuration.Attributes`
