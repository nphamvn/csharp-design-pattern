# Builder Design Pattern
## Explanation
- A creational design pattern to create an object one step at time.
- Often used when creating a complex object.
- Create different parts of an object, step by step, and then connect all parts together.
- Can avoid complex constructor with lots of parameters.

## Example
Create a stock report for all the products in store.

`Product` class<br>
Store some basic data about a single product.

`ProductStockReport` class<br>
A stock report cotains 3 parts: Header, body and footer.
Each part is should be built with each action.
Use Builder design pattern to build *ProductStockReport* object.

`IProductStockReportBuilder` interface<br>
An interface to organize the building of *ProductStockReport* class.

`ProductStockReportBuilder` class<br>
Receive all the products required for report and instantiate the *ProductStockReport* object.
Then, create all the parts of the object and finally return it.

`ProductStockReportDirector` class<br>
A client class of *IProductStockReportBuilder* interface, to build *ProductStockReport* object.