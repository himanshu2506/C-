 Feature: SignIn
	
Scenario Outline: SignIn With Different parameter
	When Click on Sign In
	And User enter <email_id> and <password>
	When user Click on Sign In Button    
	Then An email address required should be visible
Examples:
|     email_id               | password |
|  vibhum.2506@gmail.com     |          |
|                            |          |
|                            | wsxedcrf |
| vibhum.2506@gmail.com      |wsxedcrf  | 
 

