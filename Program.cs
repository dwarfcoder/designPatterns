
using DesignPatterns;

// Factory Method run
IRunner fmRunner = new DesignPatterns.FactoryMethod.Runner();
await fmRunner.RunAsync();

// Singleton run
IRunner sngltnRunner = new DesignPatterns.Singleton.Runner();
await sngltnRunner.RunAsync();