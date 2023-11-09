# NHL Player 

## Project Description

NHl-Player is a project that is part of a major video game from ea sports NHL, specializing in the creation and management of players. 
It implements various design patterns to provide flexibility, extensibility, and support for various functionalities.

## Design patterns

### Singleton Pattern

- The project uses the Singleton pattern to provide a single connection point to the database.
- The singleton pattern is implemented in the HockeyPlayerDbContext class, via a lazy implementation. This means that the instance will be created directly at the time of the request.
- public static HockeyDbContext Instance => instance.Value; is a static property that provides a single instance of HockeyDbContext.
- When the Instance is accessed for the first time, the HockeyDbContext object will be created and saved in Lazy<HockeyDbContext>.
<p align="center">
      <img src="https://sun9-62.userapi.com/impg/sRdYJye6VUCyLNjfGqpSKjbJRGcXJaDHQsYZQw/74dq2fYkRyA.jpg?size=1253x528&quality=96&sign=370d771f11b4f174a30980059afd16de&type=album" height = "400" width="600">
</p>

### Factory Pattern

- The Factory pattern is used to create players in various positions (Forward, Defense, Goalie).
- The Creator is the IHockeyPlayerFactory interface, which has a createPlayer method. This method is implemented by Forward Factory, Defense Factory and GoalieFactory(Concrete Creators).
- The role of Concrete Products is inherited from the common Player class - Forward, Defense and Goalie
<p align="center">
      <img src="https://sun9-34.userapi.com/impg/TguDBD8t94ZlIQ9EqAoFh0vqauUbno04vTrrog/yXKyWY5oT54.jpg?size=1829x921&quality=96&sign=b9c605e41c11b59ae10c8119cbc505d5&type=album" height = "400" width="600">
</p>
### Decorator Pattern

- The decorator pattern is implemented to modify the grip of hockey players.
-  Classes implementing the decorator interface take Hockey Player into the constructor of the class and apply the SetHand method to it, which changes the value in the database.

<p align="center">
      <img src="https://sun9-62.userapi.com/impg/gi1nqFyCcfkRMkXvww7XQfas-W3p8MCIOXqOBQ/C_0-b9Cwepg.jpg?size=1787x670&quality=96&sign=808641b43298abe3777f2674bbfe30ab&type=album" height = "400" width="600">
      <img src="https://sun9-68.userapi.com/impg/v9dCubVYAh-zpfJrs596geW9ShI3RC6HUjnNcg/9MSXyRLoQGs.jpg?size=985x551&quality=96&sign=df4678ccb74fffc6c14fd3f5d9b4c5c7&type=album" height = "400" width="600">
</p>

### Adapter Pattern

- I implemented an adapter pattern to be able to implement an interface that does not implement the HockeyPlayer base class.
- This IHockeyPlayerInfo interface includes the methods necessary for the correct and competent display of information about players.
- This pattern is implemented in the Hockey Player Adapter class, by aggregation.
- I have implemented a base class in the adapter class to call methods from the HockeyPlayer class
  <p align="center">
      <img src="https://sun9-37.userapi.com/impg/AVdy5wKbJL7rZds_MSQkqLYAo2ABEGEZLl2gPA/RySVxWhhjHw.jpg?size=1091x697&quality=96&sign=86f646ea33c3beccfd95610712cc8613&type=album" height = "400" width="600">
</p>

### Strategy Pattern

- The strategy pattern is implemented through the installation of a specific tactic (strategy) for each player.
- The Hockey Player class has a private iPlayer Strategy _strategy field.
-  I created three classes implementing one interface with the Follow Tactic method, so the Hockey Player class can call its method without thinking about which strategy was applied.
  <p align="center">
      <img src="https://sun9-27.userapi.com/impg/8KZDJIy0UMk-dwrAS84dQQ6S0AcWSp6AkYJy9g/P5FxcTGkk5s.jpg?size=425x202&quality=96&sign=5a9366e40dc53fd02478ee1611d791cf&type=album" height = "400" width="600">
</p>

### Observer Pattern

- The observer pattern is implemented to notify coaches of all players about the upcoming training session.
- Subscribers are all players in the database. They are all required to attend training, so we have to notify them.
- The publisher implements the IObservable interface which has methods for working with subscribers.
- We can notify all players, specify the name of the coach and details.
  <p align="center">
      <img src="https://sun9-76.userapi.com/impg/Z13Pwx8F9MyapNqwSdBtavyfeEHRa2EJIFoPQw/LB92aXINjw8.jpg?size=1477x425&quality=96&sign=22ffdfd94e988f74cdcf1f2b103f8bfa&type=album" height = "400" width="600">
      <img src="https://sun9-3.userapi.com/impg/3s_N_RNJj3GLdK2TISVwxII8NniV2kk4Ygx6Zg/p9xoahiUc_8.jpg?size=982x206&quality=96&sign=8c1fd67bc4cc94d1b8fc6097fe4db41c&type=album" height = "400" width="600">
</p>
## Project Structure

