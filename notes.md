# Bees Solution notes.

## Part 1
* Bee properties:
  * Health - Set to 100
  * void Damage(int number) - overload
  * isDead() - overload

* Death points:
  * Worker = 70%
  * Drone = 50%
  * Queen = 20%

### Refactor

* bee classes have the same logic. Use decorator pattern to create different bees, by passing in different Death points in construtor.




## part 2

We will use a single razor page to create the front end.

* AddSington service BeesData with properties:
  * List of 10 bees.
  * DamageAll

* Inject BeesData into razor page model.
* Create 2 handles.
  1. OnGet method to display the list of bees intially.
  2. OnGetDamage - Called b a single button in html which will damage all 10 bees simultaneusly.

* Add simple styling using bootstrap and css.

