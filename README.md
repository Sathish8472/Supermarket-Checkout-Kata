# Supermarket Checkout Kata

This project implements a supermarket checkout system with pricing rules for different items. It is a coding kata exercise that focuses on improving coding skills, problem-solving abilities, and algorithmic thinking through deliberate practice.

## Project Description

In a typical supermarket, items are identified using Stock Keeping Units (SKUs), usually represented by individual letters of the alphabet (A, B, C, etc.). Each item has an individual unit price, and some items may have special pricing offers such as "buy n of them, and they’ll cost you y pence."

For instance, an item 'A' might cost 50 pence individually, but a special offer could be "3 for 130 pence." Similarly, an item 'B' might cost 30 pence individually, but a special offer could be "2 for 45 pence." There are also items without special offers, such as 'C' and 'D' with unit prices of 20 pence and 15 pence, respectively.

The goal of this project is to implement a supermarket checkout system that can calculate the total price for a given set of items, considering their individual prices and any applicable special offers.

## Project Structure

The project is organized into the following components:

- `SupermarketCheckoutKata.Core`: Contains the main logic for the supermarket checkout and item pricing.
- `SupermarketCheckoutKata.Tests`: Contains NUnit test cases for validating the supermarket checkout logic.

## Getting Started

1. Clone this repository to your local machine.
2. Open the solution file (`SupermarketCheckoutKata.sln`) in Visual Studio or your preferred IDE.
3. Explore the `SupermarketCheckoutKata.Core` project to understand the checkout logic and item pricing.
4. Run the unit tests in the `SupermarketCheckoutKata.Tests` project to verify the functionality.

## Usage

To use the supermarket checkout system in your application:

1. Reference the `SupermarketCheckoutKata.Core` library in your project.
2. Create an instance of the `SupermarketCheckout` class and provide the necessary pricing rules.
3. Call the `CalculateTotalPrice` method with the items to calculate the total price.

## Testing

The `SupermarketCheckoutKata.Tests` project contains NUnit tests for the supermarket checkout logic. Run the tests to ensure the correctness of the implementation.

### Test-Driven Development (TDD)

This project follows a strict Test-Driven Development (TDD) approach. All features and functionality are developed through writing tests first and then implementing the corresponding code.

### Testing Framework

We use the NUnit testing framework for writing and running tests. NUnit provides a robust and flexible platform for unit testing. You can find the test cases in the `SupermarketCheckoutKata.Tests` project.
