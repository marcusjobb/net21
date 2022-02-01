Feature: TransferTest

Background: Användaren är sugen på pizza och vill flytta pengar från
lönekontot till kortet
Given: Lönekontot innehåller 10 532 kr och pizza + läsk kostar 120 kr
When: Överföring görs från lönekonto till kortkonto
And: Lönekonto innehåller mer än 120 kr
And: Kortkonto innehåller mindre än 120 kr
Then: Överför mellanskillnaden från lönekonto till kortkonto
Then: Kortkonto bör ha 120 kr

@tag1
Scenario: Buy a pizza
	Given Checking account has 10532 SEK
	And a pizza + soda costs 120 SEK
	And card account has less than 120
	When money is transfered from checking account to card account
	Then the difference should be transfered
	And the card account will have 120
