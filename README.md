# Decorator Design Pattern

## Explanation
- Structural C# design pattern
- Allows to extend the behavior of objects by placing these objects into a special wrapper class. 
Help to dynamically add behaviors to the wrapped objects.
- Often used when have a need to add additional behavior to objects.  When it is too complicated to use inheritance.

## Example
Calculate the total order price in shop. 
If a buyer orders products in a preorder period, give a 10 percent discount.<br>
1. `OrderBase` class<br>
A *Component* class.