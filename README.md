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


## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 