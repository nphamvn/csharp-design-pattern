# C# Design Patterns
A collection of most used design patterns in C# with explanation and example.
All patterns include:
- What is the pattern
- When should use the pattern
- How to implement the pattern

## 1. Builder Design Pattern and Fluent Builder
## 2. Fluent Builder Interface With Recursive Generics
## 3. Faceted Builder
## 4. Factory Method
## 5. Singleton
## 6. Adapter
## 7. Composite
## 8. Decorator
## 9. Command
## 10. Strategy
## 11. Facade

## Explanation
- Is a structural design pattern that allows to compose objects into a tree structure and then work with that structure as if it is a single object. 
- Consists the following parts:
    - Component: describes operations that are common to either simple or complex elements of the tree.
    - Leaf: a single object, that doesn’t have sub-elements.
    - Composite: have sub-elements (leaves or other composite objects). Isn’t familiar with the concrete classes of its children. Communicates with its children via the Component interface.

## Example
App to calculate the total price of a gift which are being sell in a shop. The gift should be a single element, or it can be a complex gift that consists of a box with one or more elements.
