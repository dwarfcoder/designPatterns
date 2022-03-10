using DesignPatterns.Models;

namespace DesignPatterns.Builder;

public interface IConcreteBuilder {
    Message Construct();
}