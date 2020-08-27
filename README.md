# Currency to Words


The library provides two extension methods:

1. `NumberToWordExtensions.ToWords` to convert a number into its form written out in English words
2. `CurrencyToWords.CurrencyToWords` to convert a number into a dollar written out in English words

The function accepts numbers between 0 and 1000. It throws an ArgumentException if these preconditions are not met.

The fractional cents are ignored (eg. 0.003 would be translated to "zero dollars")

# Notes

The library was written in a TDD (test-first) manner with small implementation steps.

If you explore the commit history you can get a rough idea how I was thinking and what small steps were taken to implement the solution.

Because this is a test task, it was implemented in a way that I did not use any external libraries. 

In the real world I would be using the [Humanizer](https://github.com/Humanizr/Humanizer) library and would not implement inflections or `ToWords` method myself.
