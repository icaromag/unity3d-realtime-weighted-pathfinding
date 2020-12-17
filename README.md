# Adaptative Weighted Pathfinding in Urban Environments

Computational modeling and simulations in dynamic urban environments are complex problems that require significant amounts of resources.
This project brings an interactive adaptative pathfinding simulation tool that can be executed in real time and used within the Unity 3D Game Engine.

## Pictures
My neighborhood's map was digitalized using Blender to create a heightmap that is used to test the solution.

![MangabeiraMap](https://github.com/icaromagalhaes/realtime-weighted-pathfinding-unity3d/blob/master/Assets/Images/image03.png)

The entities represented as vehicles are able to avoid zones marked in red. This happens due to the height applied to these nodes. Different zones can be created and weights can be applied as the user wishes. If two or more zones colide, the intersection will have the sum of the weights.

![RedZones](https://github.com/icaromagalhaes/realtime-weighted-pathfinding-unity3d/blob/master/Assets/Images/image02.png)

The streets are represented as a matrix / graph. Weights are not applied in regions white nodes. These nodes are ignored by the pathfinding algorithm and the entities can't go through them.

![MapGrid](https://github.com/icaromagalhaes/realtime-weighted-pathfinding-unity3d/blob/master/Assets/Images/image01.png)

Different weights are applied all over the map's surface, and the entities behave and move along accordingly.

![Weights](https://github.com/icaromagalhaes/realtime-weighted-pathfinding-unity3d/blob/master/Assets/Images/image00.png)

## Contributors
Ícaro Magalhães - icaro.lmag@gmail.com
