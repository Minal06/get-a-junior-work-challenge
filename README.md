# get-a-junior-work-challenge

This is a testing project made from scratch. It's based on different tasks from university tests.

It's mainly code related, with a few features from Unity itself.

## Table of Contents
 * [First task](https://github.com/Minal06/get-a-junior-work-challenge/blob/main/README.md#first-task)
 * [Second task](https://github.com/Minal06/get-a-junior-work-challenge/blob/main/README.md#second-task)

### First task:

* I create platform, where NPC are randomly spawning and moving
* Programmed a behaviour where if two npcs collide with each other, they are losing 1 life from their total life pool of 3.
* If their total life reaches 0 they dissapear from the map. 
* basic information window, you can also click on NPC and check their current HP, I also added a graphical representation of marked unit.

##### Gameplay
![cloneWars](https://user-images.githubusercontent.com/94176489/178111901-983934d5-0462-4af3-820d-ac277a34d2c3.gif)


### Second Task:

There was also prepared Optimization folder. Scene there spawn a lot of different game objects, that slow down game drastically.

My task was to optimalize scene with use of Unity Profiler.
With *Profiler.BeginSample();* and *EndSample();* I manage to find and solve the issue in the **OptimUnit** script.

##### Optimalization task
![Optimalization](https://user-images.githubusercontent.com/94176489/177877824-f5b20e70-a271-4342-acd7-fa1c23539a53.gif)
