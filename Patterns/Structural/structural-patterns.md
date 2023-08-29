***Facade***

A facade is a class that provides a simple interface to a complex subsystem which contains lots of moving parts. A facade might provide limited functionality in comparison to working with the subsystem directly. However, it includes only those features that clients really care about.

<img width="494" alt="image" src="https://github.com/MelchenkoIvan/DesignPatterns/assets/72986996/b8450b90-a11e-4fd1-bdf6-145a2162e8bd">


***Proxy***

The Proxy pattern suggests that you create a new proxy class with the same interface as an original service object. Then you update your app so that it passes the proxy object to all of the original object’s clients. Upon receiving a request from a client, the proxy creates a real service object and delegates all the work to it.

<img width="573" alt="image" src="https://github.com/MelchenkoIvan/DesignPatterns/assets/72986996/1a2a2867-f8e0-440a-a1e3-64ad411228d6">

