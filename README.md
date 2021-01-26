# Rust Furnace Calculator
 A calculator for using large furnaces in the game Rust

General Info:

This calculator assumes you are using 12 slots for smelting ores in the large furnace. This number was choosen as an ideal number for speed to efficiency tradeoff.

You can only smelt one type of ore at a time. If you need to smelt multiple types of ore just open multiple instances of the program.

This calculator assumes you will be leaving the furnaces unattended therefore if it detects that overflow will happen it will tell you about it. That being said, if you still want to smelt that much it won't stop you just know you'll have to monitor the furnaces yourself.

The stack size box either gives an exact number of ore that will go into each of the 12 assumed slots or if this isn't exact it will tell you a range of stack sizes.
(e.g. if you smelt 12 ore each slot gets 1 ore and it will read "1". However if you smelt 13 ore you will have 11 slots with 1 ore and 1 slot with 2 ore. So the range will read "1 - 2")
If you're splitting between multiple furnaces my suggestion is to fill all of them with the lower number and then whatever is left over you can disperse between any of the current stacks making sure not to go over the higher number.


Using the Calculator:

1. Type in how many furnaces you want to split the ore between. If you only want to use 1 just leave it as default.

2. Type in the amount of ore you want to smelt in one of the 3 ore type boxes. (Or if you just want the maximum safe amount of ore click on the "Total Metal", "Total Sulfur", or "Total HQM" labels to automatically fill in the number of ore; and skip step 3.)

3. Press the Calculate button, or hit enter. The output boxes will fill in with the info you need.

4. Use the number(s) in the Stack Size box to manually split the ore into 12 slots in each furnace. (Select the ore in your inventory and right click the split number to type in your own split size.)

5. Put the required wood in each furnace.

6. After you have stocked your furnace(s) with the measured amount of ore and wood and started the furnace(s) you can click the Start Timer button and this will start counting down the amount of time till your ore will be done smelting. Once it is done it will say "Smelting Complete!"

7. At any point during this process if you wish to cancel or start over you can either:
    a. Press the Reset button which will reset all boxes back to the default value and stop the timer if it's running
    or
    b. Change whatever you need to change and click the Calculate button again. This will recalculate the values and stop the timer if it's running.
