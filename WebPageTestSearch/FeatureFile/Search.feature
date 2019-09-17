Feature: Search
	

@mytag
Scenario Outline: select flight
When user launch the browser
And User is on HomePage
Then user select flight
And select multi city
Then add another flight
Then Search for flights between different airport <FIRSTFLIGHT>,<SECONDFLIGHT>,<THIRDFLIGHT> on dates <DateOne>,<DateTwo>,<DateThree>  for <number>  adults
And click on search option
Then select the flight

Examples:
| FIRSTFLIGHT	| SECONDFLIGHT |THIRDFLIGHT | DateOne     | DateTwo    | DateThree   | number |
| MLA           | LON          | ROME       | 07/10/2020  | 07/15/2020 |07/20/2020   |   4    |



