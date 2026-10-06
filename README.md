# Banking Kata

A simple bank account application developed in C# using Test-Driven Development (TDD).

## Features

- Deposit money into an account
- Withdraw money from an account
- Record each transaction with its date and amount
- Print a bank statement
- Display the running balance after each transaction
- Display transactions in reverse chronological order

## Example Statement

DATE | AMOUNT | BALANCE  
14/01/2026 | -500 | 2500  
13/01/2026 | 2000 | 3000  
10/01/2026 | 1000 | 1000  

## Technical Approach

The solution was developed incrementally using TDD:

1. Write a failing test
2. Implement the minimum code required to make the test pass
3. Refactor when necessary
4. Repeat for the next business requirement

The implementation focuses on simple, maintainable and testable code while avoiding unnecessary complexity.

## Technologies

- C#
- .NET
- xUnit

## Running the Tests

Run the following command from the solution directory:

dotnet test