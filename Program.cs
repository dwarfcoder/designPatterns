
using DesignPatterns;

// Factory Method run
IRunner runner = new DesignPatterns.FactoryMethod.Runner();
await runner.RunAsync();

// Singleton run
runner = new DesignPatterns.Singleton.Runner();
await runner.RunAsync();

// Builder run
runner = new DesignPatterns.Builder.Runner();
await runner.RunAsync();

// Memento run
runner = new DesignPatterns.Memento.Runner();
await runner.RunAsync();
