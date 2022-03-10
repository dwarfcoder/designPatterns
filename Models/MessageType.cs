namespace DesignPatterns.Models;

[Flags]
public enum MessageType : short {
    Email,
    Text,
    PhoneCall,
    All
}