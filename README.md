Colin McDaniel
Colin Pierce

YouTube link:
https://youtu.be/gNl-FNF0Odk




1. How does each pathfinding algorithms calculate and prioritize paths?
GBF: Greedy Best-First only wants to get closer to the target without thinking about obstacles until it hits one. As such, it prioritizes the direction towards the target first, only switching to a new direction if the old direction hits a block, it finds a way to the old direction again, or a new direction is now a straight shot to the target. It then repeats this until it reaches its destination.
BFS: Breadth-First Search prioritizes everything at the 'level' of the current node before it continues, usually by creating a queue and going to each neighboring section until it finds the best place to continue.
DFS: Depth Best-First is similar to BFS, except it prioritizes a path by simply selecting the first found path then continuing down it until it cannot go further. After, it will then go back 'up' until it hits a new path, in which it will then go 'down' again, doing so utilizing a stack data structure.
A\*: A\* calculates a path cost for each node it attempts to travel to and, will then draw a path to the target using the path it found to cost the least.
Dijkstra: Dijkstra is guaranteed to always find the shortest path to the target by using a priority queue to find said shortest path. It puts all search nodes into this priority queue, and the starting node is given a cost of 0. It will then sort the nodes by distance, so that the shortest is in front, thus finding the shortest path.
Theta\*: Theta\* functions like A\* but has the added ability to prioritize a path by using line of sight, which can create a more natural feel to movement by eliminating zig-zag patterns from A\* navigation.
JPS: An optimization of A\*, Jump Points Search acts like A\* but searches for nodes that do not contribute to the final path and simply skips them during calculations.
Hierarchical: Best for large maps, Hierarchical Pathfinding takes a large map, and abstracts it into higher and higher levels to make it easier for the algorithm to find it's target over large distances.

2. What challenges arise when dynamically updating obstacles in real-time?
The biggest issues are optimization and natural looking movement. Constantly recomputing a path can lead to high computational cost depending on how you do so, especially if you recalculate the path by scratch. Additionally, moving obstacles that cause a constant change in path could cause unnatural movement, such as random looking zig-zagging or awkwardly moving around the moving obstacle. At the same time, you could end up with an algorithm that causes the user to freeze up while moving around the obstacle if it moves too much and the user has too much built in hesitation. As such, incremental pathfinding options that partially recalculate paths help with this.

3. Which algorithm should you choose and how should you adapt it for larger grids or open-world settings?
Hierarchical pathfinding is a great choice for open-world settings and large grids as it can be used to cut down the large map into sections, which can then be abstracted. By abstracting these sections into higher levels, it makes an easier path for the user to navigate by finding a route at the highest level, then continuously replanning the route in the smaller search area of the lower levels.

4. What would your approach be if you were to add weighted cells (e.g., "difficult terrain" areas)?
Dijkstra Pathfinding is a good choice for weighted cells as it is already a cost based node system, that sorts its path into a priority queue focusing on the lowest cost path. As such, if you have weighted cells with higher costs, it will naturally attempt to avoid these.

