﻿Feature: Patch





	Background: Create Adviser
	Given I post an adviser with the following details:
		| Field						 | Value				|
		| AdviserName				 | BillyAdviser			|
		| AdviserContactNumber		 | 98798678967967		|
	And I post a Customer with the following details:
		| Field                      | Value                |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |


	Scenario: Patch Date
		Given I post an Interaction with the following details:
		| Field                    | Value                                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z                 |
		| Channel                  | 2                                    |
		| InteractionType          | 2                                    |
		When I patch the following:
		| Field                    | Value                                |
		| DateandTimeOfInteraction | 2018-06-26T11:21:00Z                 |
		Then there should be a 200 response
		And the response body should contain:
		| Field                    | Value                                |
		| DateandTimeOfInteraction | 2018-06-26T11:21:00Z                 |
		| Channel                  | 2                                    |
		| InteractionType          | 2                                    |


	Scenario: Patch channel
		Given I post an Interaction with the following details:
		| Field                    | Value                                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z                 |
		| Channel                  | 2                                    |
		| InteractionType          | 2                                    |
		When I patch the following:
		| Field                    | Value                                |
		| Channel                  | 1                                    |
		Then there should be a 200 response
		And the response body should contain:
		| Field                    | Value                                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z                 |
		| Channel                  | 1                                    |
		| InteractionType          | 2                                    |


	Scenario: Patch InteractionType
		Given I post an Interaction with the following details:
		| Field                    | Value                                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z                 |
		| Channel                  | 2                                    |
		| InteractionType          | 2                                    |
		When I patch the following:
		| Field                    | Value                                |
		| InteractionType          | 1                                    |
		Then there should be a 200 response
		And the response body should contain:
		| Field                    | Value                                |
		| DateandTimeOfInteraction | 2018-06-25T11:21:00Z                 |
		| Channel                  | 2                                    |
		| InteractionType          | 1                                    |