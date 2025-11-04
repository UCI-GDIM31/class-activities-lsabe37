# in-class-activities
## Devlogs
### W1
"Hello World!"

### W2
1. The r g b values are floats because the values have number(s) after the decimal point.
2. The bounce variable is a int because bounces are counted in whole numbers.
3. The error I got in Step 4 was due to a lack of a semi colon at the end of the code. The error message was helpful since it told me which line the error was on and also that a semi colon is expected.

### W3
Table 13

Methods Discussion Activity

The input would include an int for the friendship level and bool for whether or not the player knows the character's secret. The output would be a string. The output string that will be given will depend on whether the bool is true or false and the value of the int.

MonoBehavior Coding Activity 

Classes are like different attires and components are like people. Just like how people wear different attires for different occassions, components are assigned different classes to fit their roles. Methods and member variables are like special tools and abilities that people of specific occupations have and perform.
The balls get extremely bright because the brightness keeps getting multiplied each time they bounce in a short period of time, the speed of the ball increases. 

## W4
Table 13

Describing Code Activity

Line 17 is creating a bool variable called _isGrounded and is setting it to true.
Line 28 is an if statement which will cause the code within it to run if both its conditions are true. The two conditions are if the space bar was pressed and if _isGrounded is true. This line of code is used to check if the cat is in a state that will allow it to jump.
Line 32 is assigning the bool _isGrounded to false. This line is used to prevent the cat from jumping in the air.

Collision Activity

1. We decided to add Rigidbodies to the cat and ball since these two objects need to be able to move and bounce. We decided to make the goal Is Trigger since the ball needs to detect when it collides with this game object.

2. Intially, I had the ball set to Is Trigger. However, this caused the ball to fall through the ground. To fix this, I added another collider which did not have the Is Trigger checked in order to have the ball stay on the ground. However, I then realized that it was the goal that needed the Is Trigger since it is the object that is being checked.

## W5

Activity 1:

Q. What is the point of using "[SerializeField] private" instead of "public" when creating variables.
A. uhh not answered :(

Q. How do we know which script's Update method is called first?
A. The order is rather random and there is no guarantee which one gets called before which one. However, the difference is miniscule so it will not affect anything for this class.

Activity 2:
The Deerw5 class should need a [SerializeField] for the deer's Rigidbody, NavMeshAgent, and the transform of the target. It will also need a Start() function to get the components of the rigidbody and NavMeshAgent. Finally, it will need an Update function to move the deer using the NavMeshAgent method called SetDestination.

## w6

Activity 1:

I mainly worked on the Unity Engine and Unity Coding sections.

Activty 2:

The BatW6 component will need a [SerializeField] private float called "speed" which will determine the speed at which the bats move. It will also need a [SerializeField] Transform called "target" to act as the reference for what (the player) the bats should chase. This component will need two methods. The first will be a private void called chasePlayer() which will get the bats to chase the player when called. Inside the method, there should be an if statement that will use transform.position to move the bats towards the target if the bat's transform.position is not equal to the player's transform.position. The second method will be a private void called endChase(). This method will disable this script when called.

Here is the link: [Week 6: Activity 1](https://docs.google.com/document/d/1wrY73yJ_km0ig2SehlUSuSx3rOOu84QnORwQ0mV305o/edit?usp=sharing)

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 