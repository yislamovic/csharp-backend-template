What did I learn today that I didn’t know yesterday?
I learned plenty about how to setup a .Net project; i learned about the M and C in MVC- 
the model which refers to database and controller which essential where the endpoints are created.
Ontop of all that i learned about the commands that are used to do migrations, along with postgres specific commands as well as docker. In terms of alorgorithmic work I started to get back into the groove of solving 
complex problems and familiarizing my self with python syntax again. 
Problems solved: Two Sum, Valid Anagram, Best Time To Buy And Sell Stock.

Started to solve Two Sum problem @ 8:30AM
Finished around 8:50AM ~20mins to solve
-Initial struggle was trying to understand the logic how loop would progress. For some reason I had initial confusion in checking each value at index and comparing value. 
-Next programatic problem was realizing that the values can be negative but I had initial assumptions that nums[i] was going to be positive ALWAYS CHECK CONSTRAINTS!!
-I learned there are far more efficient ways to solve, I knew there was a linear time complexity solution using hash maps but there is logarithmic one using sorting!!

Started to solve Valid Anagram @ 11:10AM
Finished around 11:53AM ~ 40 mins to solve
-struggled to find a solution that use O(1) space
-I ended up using 2 dictionaries to track the frequency of letters
-3 for loops in total O(s*t) + looping through dictionary of unique letters [max is 26] which is O(1)
-There are better ways to solve it but I learned I have trouble recalling basic python syntax which will most certainly make me look bad in the live interview; had to look of some things related to dictionaries.
-I think it can be solved in O(n) using a hash implementation
-Scratch that; using dictionaries is considered a hash implementation LOL
Looks like I like I lack some important understanding I thought a hash map was related to a set 
-I can get it to O(s+t) if I loop through a single string once assuming that they are of equal length; before that I can return False if they are not equal.
-Also another point, I seem to heavily rely on testing to see if my algorithm is correct which I might not be able to do during the interview.. I will certainly loose points if I can’t account for edge cases
-Another note is that I have a hard time thinking of linear loops or algorithms as not strictly adhering to the space its iterating; it can loop through a range but also access other elements in another array or string! This is important for me to remember !! (Sometimes I overthink and get confused)
@ 2:05PM I finished making my own version of the optimized algorithm with the syntax I understand

Started to solve Best Time to Buy and Sell Stock
 @ 9:00PM
-needed help with this one because at this point my brain was fried
-two pointer logic was really confusing to me but once I got the solution I see that it makes sense.

Big O notation is essentially showing the upper bound time the algorithm can possibly take
The essential difference between a stack and a queue is that a stack is LIFO and a queue is FIFO.
Hashmaps are powerful because they use hashing to get values from keys in O(1) time; a hash is a number which is produced by a hashing function
In a hash function a given input will always produce the same output; this is considered one way as you cannot go from output to get the input
A hash table is just an array underneath!
Its O(1) because the hash function does some modulus operation on the hash to get the index of the array where the value is stored


What slowed me down?
There are some things related to project configuration and the quirks of postgress that slowed me down like figuring out the correct structure for the connection string, and checking to see the tables were migrated succesfully; among other things like giving the table and schema as well as user the correct permissions.

What part of today’s work was the most rewarding?
I really liked building the .net project from scratch understanding how all the important peices work together. Algorithm work is always rewarding when you can solve it correctly without help.

What’s one thing I want to improve tomorrow?
Tommorow i will improve on .net knowledge and try to implement more features? I will implement new algorithms and try the most efficient methods instead.