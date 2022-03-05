namespace DesignPatterns.FactoryMethod;

[Flags]
public enum MessageType : short {
    Email,
    Text,
    PhoneCall,
    All
}