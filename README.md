# Unity-Rotation-GameObjects-at-User-Input-on-all-Axis

The objective of this homework is to give you a hands-on approach to the Unity IDE, and the basics of creating scenes, GameObjects and C# code.

We saw a quick demo in-class on how to create primitive objects, change color and also apply C# scripts that will bring the GameObjects to life. We also looked at the properties of GameObjects and the Transform component that is inherited by all GameObjects regardless of their rendering within the scene. Thought coding, we saw how to get basic input from the user through keyboard, and based on the user input, we performed an action.

# Design a Scene with the Following Specifications

You scene is going to have the following primitive geometric shapes:

A unit Cube
A unit Sphere
A unit Capsule
A unit Plane
You are going to position the primitives in the following positions:

Cube at (0,1,0)
Sphere at (-3,1,0)
Capsule at (3,1,0)
Plane at (0,0,0)
Place and orient your camera using the following vectors:

Position <0,6,-10>
Rotation <43,0,0>
Your directional light can stay where it is as the position of the directional light is irrelevant, only the direction is important as it indicates the angles at which the light is being projected.

# Materials

You will need to create four materials, one for each geometry. 

Red <1,0,0>; apply to Sphere
Green <0,1,0>; apply to Cube
Blue <0,0,1>; apply to Capsule
Dark Gray <0.25,0.25,0.25>; apply to Plane
You will use the Albedo property of the standard shader to assign the color. Leave everything else the same.

# Camera Modification

Change the Clear Flags field under the Camera property to Solid Color. Change the Background color property to black <0,0,0>


# Coding

Ok, now that the basic scene is setup, let's go ahead and do some programming to make the scene more dynamic. You are going to create a C# script called InputManager.cs.

The script will be attached to the following GameObjects: Cube, Sphere and Capsule.

You will need to process the following inputs from the user: Up Arrow, Down Arrow, X Key, Y Key and Z Key.

The X, Y and Z keys will indicate which axis you will be rotating on. And the Up/Down Arrow will control the speed of rotation.

You capture user input using Input.GetKey(); Input.GetKeyUp(); and Input.GetKeyDown(); functions.

Use Input.GetKey() for the axis of rotation and properly apply the correct axis of rotation.

Use Input.GetKeyUp() for the speed control. Max speed is 20 and Min speed is 0, default speed is 1.

If the user keeps on pressing the Up/Down Arrow keys, you will need to do boundary checking, so if they go over or below the min max, you will need to set the speed to min or max.

Each time the speed change you will also log the speed using Debug.Log() function.
Output for log should be: Speed: <speed_value>, i.e., Speed: 3.
