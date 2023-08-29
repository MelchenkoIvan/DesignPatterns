***Builder***

The Builder pattern suggests that you extract the object construction code out of its own class and move it to separate objects called builders. The pattern organizes object construction into a set of steps (buildWalls, buildDoor, etc.). To create an object, you execute a series of these steps on a builder object. The important part is that you don’t need to call all of the steps. You can call only those steps that are necessary for producing a particular configuration of an object.

<img width="544" alt="image" src="https://github.com/MelchenkoIvan/DesignPatterns/assets/72986996/21c4df7b-6367-4b49-9120-0f42b4129b12">

***Factory***

Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

<img width="605" alt="image" src="https://github.com/MelchenkoIvan/DesignPatterns/assets/72986996/432819f3-71ef-44fc-8c0b-99946208068e">

As a result, you will end up with pretty nasty code, riddled with conditionals that switch the app’s behavior depending on the class of transportation objects.

***Prototype***

Prototype is a creational design pattern that lets you copy existing objects without making your code dependent on their classes.

<img width="611" alt="image" src="https://github.com/MelchenkoIvan/DesignPatterns/assets/72986996/cf35ba4d-48a9-4fbb-a20a-681d1fe23927">

***Singleton**

Singleton is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.

<img width="597" alt="image" src="https://github.com/MelchenkoIvan/DesignPatterns/assets/72986996/50f09312-2313-4ff7-8392-cd1d66f6b363">
