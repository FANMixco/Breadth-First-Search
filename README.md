# Binary-First-Search
Breadth-first search (BFS) is an algorithm for traversing or searching tree or graph data structures.

Given a matrix of N*M order. Find the shortest distance from a source cell to a destination cell, traversing through limited cells only. Also you can move only up, down, left and right. If found output the distance else -1.

- 3 represents ‘source’
- 4 represents ‘destination’
- 0 represents cell you can travel
- 1 represents cell you can not travel

Examples:

Input : 

        {1, 0, 1, 3},

        {0, 1, 0, 0},
        
        {1, 0, 0, 0},
        
        {4, 0, 0, 0}

Output : 6

Input : 

         {1, 0, 1, 3},
         
         {0, 1, 0, 0},
         
         {1, 0, 0, 0},
         
         {4, 1, 1, 1}

Output :  -1

This is a C# implementation based on:

https://www.geeksforgeeks.org/shortest-distance-two-cells-matrix-grid
