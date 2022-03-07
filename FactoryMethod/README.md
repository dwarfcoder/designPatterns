# Factory Method design pattern

This is a simple implementation of creational pattern "Factory Method"
You can find more information about it on [refactoring guru](https://refactoring.guru/design-patterns/factory-method)
Here I'd like to discuss and implement my realisation (a very simple one) of this pattern.

Let's take a closer look on it.

[Message.cs](Message.cs) is a class representing some POCO (or DTO - they have no differ for now) - an entity wich contains information about a message.
Main challenge is to send a message via properly channel of communication either it is an email or text.
Here an [IMessageSender.cs](IMessageSender.cs) was introduced. It is an interface wich shows the ability to send a message.

... to be continued. Now I really want to go to bed.