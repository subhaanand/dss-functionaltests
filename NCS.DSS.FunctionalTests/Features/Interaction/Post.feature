﻿Feature: Post



	Background: Create Adviser
	Given I post an adviser with the following details:
		| Field						 | Value				|
		| AdviserName				 | BillyAdviser			|
		| AdviserContactNumber		 | 98798678967967		|
	And I post a Customer with the following details:
		| Field                      | Value                |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |

	Scenario: Post Valid Interaction with all Fields
		Given I post an Interaction with the following details:
		| Field                    | Value                                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z                 |
		| Channel                  | 2                                    |
		| InteractionType          | 2                                    |
		| LastModifiedDate         | 2018-06-22T16:52:10Z                 |
		Then there should be a 201 response
		And the response body should contain:
		| Field                    | Value                                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z                 |
		| Channel                  | 2                                    |
		| InteractionType          | 2                                    |
		| LastModifiedDate         | 2018-06-22T16:52:10Z                 |





	Scenario: Post Interaction with missing Channel
		Given I post an Interaction with the following details:
		| Field                    | Value                                |
		| AdviserDetailsID         | 6eed4005-4364-4bcb-affb-170ee402d1aa |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z                 |
		| InteractionType          | 2                                    |
		| LastModifiedDate         | 2018-06-22T16:52:10Z                 |
		Then there should be a 422 response
		#And the error message should be "The Channel Field is required."


	Scenario: Post Interaction with missing InteractionType
		Given I post an Interaction with the following details:
		| Field                    | Value                                |
		| AdviserDetailsID         | 6eed4005-4364-4bcb-affb-170ee402d1aa |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z                 |
		| Channel		           | 2                                    |
		| LastModifiedDate         | 2018-06-22T16:52:10Z                 |
		Then there should be a 422 response
		#And the error message should be "The InteractionType Field is required."


	Scenario: Post Interaction with invalid AdviserDetailsID
		Given I post an Interaction with the following details:
		| Field                    | Value                                |
		| AdviserDetailsID         | 6eed4005-4364-4bcb-affb-170ee		 |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z                 |
		| Channel                  | 2                                    |
		| InteractionType          | 2                                    |
		| LastModifiedDate         | 2018-06-22T16:52:10Z                 |
		Then there should be a 422 response
		#And the error message should be "Could not cast or convert from System.String to System.Guid"


	Scenario: Post Interaction with invalid DateandTimeOfInteraction
		Given I post an Interaction with the following details:
		| Field                    | Value                                |
		| AdviserDetailsID         | 6eed4005-4364-4bcb-affb-170ee402d1aa |
		| DateandTimeOfInteraction | 2033-06-25T11:21:00Z                 |
		| Channel                  | 2                                    |
		| InteractionType          | 2                                    |
		| LastModifiedDate         | 2018-06-22T16:52:10Z                 |
		Then there should be a 422 response
		#And the error message should be "Date and Time Of Interaction must be less the current date/time"



	Scenario: Post Interaction with invalid Channel
			Given I post an Interaction with the following details:
		| Field                    | Value                                |
		| AdviserDetailsID         | 6eed4005-4364-4bcb-affb-170ee402d1aa |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z                 |
		| Channel                  | 11                                   |
		| InteractionType          | 2                                    |
		| LastModifiedDate         | 2018-06-22T16:52:10Z                 |
		Then there should be a 422 response
		#And the error message should be "Please supply a valid Channel"


	Scenario: Post Interaction with invalid InteractionType
		Given I post an Interaction with the following details:
		| Field                    | Value                                |
		| AdviserDetailsID         | 6eed4005-4364-4bcb-affb-170ee402d1aa |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z                 |
		| Channel                  | 1	                                  |
		| InteractionType          | 55                                   |
		| LastModifiedDate         | 2018-06-22T16:52:10Z                 |
		Then there should be a 422 response
		#And the error message should be "Please supply a valid Interaction Type"



	Scenario: Post Interaction with invalid LastModifiedDate
		Given I post an Interaction with the following details:
		| Field                    | Value                                |
		| AdviserDetailsID         | 6eed4005-4364-4bcb-affb-170ee402d1aa |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z                 |
		| Channel                  | 1	                                  |
		| InteractionType          | 55                                   |
		| LastModifiedDate         | 2033-06-22T16:52:10Z                 |
		Then there should be a 422 response
		#And the error message should be "Last Modified Date must be less the current date/time"





