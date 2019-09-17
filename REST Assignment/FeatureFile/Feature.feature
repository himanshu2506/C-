Feature:REST Feature

Scenario Outline: Register a  User with valid Username and password
When user sends a request
And Register a  User with '<usernam>'  and '<passwor>' 
Then Registration is successful
And Token is generated

Examples:
|   usernam                |   passwor    |
|eve.holt@reqres.in        |   pistol     |

Scenario Outline:Register a new user with Invalid combination
When user sends a request
And Register a new user with '<username>' and '<password>' 
Then Registration is not successful 
And Token is not generated

Examples:
| username             | password    |
| vibhum.2506@gmail.m  |  pistol     |
| httl.rept@reqres.in  |             |

Scenario: List of all users
When user sends a request on users
Then user will get list of users

