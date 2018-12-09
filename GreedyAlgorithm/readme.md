#ReadMe
Let's get greedy.
In greedy, our job is to play the role of a greedy cashier.
The user will tell us how much change we owe them, and then our job is to calculate the minimum number of coins that we can use to make that amount of change.
Let's start with an example.
Say the user requires $0.32 back.
We could do this by giving them 32 pennies, one cent each.
Or I could also use five coins -- by giving them three dimes, $0.10 each, and two pennies, $0.02 each.
Once the user runs the greedy program, they'll
be prompted to give the amount of change in dollars that they're owed.
And then your program will output the minimum amount of coins
that the greedy cashier would use to make that amount of change.
So now let's break this down into our subtasks.
We will change from US$ to coins as follow:
            1$ = 100cents
            1 quarter = 25cents
            1 dime = 10cents
            1 nickel = 5cents
            1 penny = 1cent
The heart of the greedy algorithm, which is always using the largest coin possible
            1. Prompt the user for an amount of change
            - The amount must make sense
            - What values are accepted
            - get_float
            2. Always use the largest coin possible
            - How many coins to be returned
            - amount to be returned
            3. Keep track of coins used
            4. Print the final number of coins
