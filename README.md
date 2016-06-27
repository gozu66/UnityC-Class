# UnityC-Class
Fundamentals of C# in Unity


Notes:

Unity C# - fundamentals

OOP

Classes, Inheritance & Monobehaviour: 

A class is a group of related data, held in code. Classes are used for organising and structuring code. A class has 2 major components 1] fields (variables) and 2] Methods (functions). A class can be attached to a gameobject as a component, just like a rigidbody or a transform component. 

A class can inherit from a base class, and it will automatically receive all fields and methods available from the base class, you can nest inheritance, (example) : class C can inherit from Class B, where class B inherits from Class A. Class C will receive all fields and methods from Classes a & B.

By default, a C# script/class in Unity will inherit from the  MonoBehaviour class, this is what give it access to methods like Update() and Start(), and allow the script to be attached to gameobjects.

The Singleton
	
A singleton is a pattern used in programming when a single global reference to something is needed. We store a static reference to the script inside itself, and that way, any other class can very quickly call and public methods or variables inside the singleton class. 
Important : Do not overuse, to many of these creates unstable dependencies and will create more work going forward that it will solve.

Class MyClass : MonoBehaviour
{
	Public static MyClass instance;

	Void Awake()
{
//check if singleton already exists, if so delete this object, if not make this object the singleton
}
}

Using data  in classes/scripts

Bool	:	True or False, can be used as a switch.
Int	:	Whole number
Float	:	floating point number (has decimal point)
Enum	:	A data Type, a set of Named Values (inc. switch() )
	
Const	:	Means Constant, apply to data type to that will not change at runtime


Using Methods

Calling methods : 

Methods with return type ‘void’ will not return anything and can be called with methodName(); They will just execute the code inside the method. 


Returning values : 

Methods with a return type will execute the code inside the method and then return something back to the point where we call the method. In this way we can assign a variable to be the result of a method. 

Calling return in a method will end that method. Return can be called even when there is no return type, it will just end the method.

Declare like so : 
int FindXValue()
{
	//Calculate x
	return x;
}

Call like so:
Int x = FindXValue();

Loops & Arrays

Arrays
	Declared with Type[ ]
	Must be initialized to avoid null ref exception 
		-GameObject[] golist = new Gameobject[ length ];
	Work in conjunction with loops
	Number in array is called the ‘index’ (eg: myGameObjects[x]; //x == index)

Lists
	Need to import generic namespace 
Using System.Collections.Generic;
	Like an array but easy to resize at runtime
	Must be initialized to avoid null ref exception 
List <GameObject> myGameObjects = new List <GameObject>();
	Work in conjunction with loops
Can be edited
myGameObjects .Add(item); 		//Add to end of list
myGameObjects.Insert(0, item);	//insert at specified index (0)
myGameObjects.Remove(item);	//Remove from List
myGameObjects.Clear();	//Empty out List

For Loop
for(int i = 0, i <= 100, i++){ }
Declare int & set value				(int i = 0)
If middle statement is true, continue looping. 		(i <= 100)
At end of each loop, execute final command 		(i++)


Foreach Loop
Loop through each array element of a certain type (GameObject, Transform, myScript etc.)
foreach(Transform myTrans in transformsArray) { }

While Loop
	while(statement){ }
Loop until statement is false
Warning, Prone to infinite loops if used incorrectly (causes soft crash)
while(x < 100) { }

Keywords
	Break
Break out of a loop. Loop will stop execution altogether. Good for when you have found what you want and wish to stop looping before the rest of the loop is executed
 
	Continue
Move on to next iteration of loop. All code hereafter is not run this loop, the loop continues on. 


Co-Routines

Co Routines allow you to execute code over several frames. They can pause themselves and allow the rest of the frame and the rest of the code to execute as normal, picking up again when a certain amount of time / frames have passed. This can be very useful for moving an object over several frames, or for optimising a process to occur over several frames.

Wait for seconds
yield return new waitforseconds(amountOfSeconds);
Pauses for real-time seconds

Wait for 1 Frame
Yield return null
Pauses for 1 frame, picks up again next frame.
Very useful in conjunction with loops

