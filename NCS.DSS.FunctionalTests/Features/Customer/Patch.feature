﻿Feature: Patch



	Scenario: Patch DateOfRegistration
		Given I post a Customer with the following details:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		| LastModifiedDate           | 2018-06-21T14:45:00Z |
		When I patch the following:
        | Field						 | Value                |
        | DateOfRegistration		 | 2018-07-28T16:11:00Z |
		Then there should be a 200 response
		And the response body should contain:
		| Field                      | Value                |
		| DateOfRegistration         | 2018-07-28T16:11:00Z |
		| Title                      | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |



	Scenario: Patch Title
		Given I post a Customer with the following details:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		| LastModifiedDate           | 2018-06-21T14:45:00Z |
		When I patch the following:
        | Field						 | Value                |
		| Title						 | 2                    |
		Then there should be a 200 response
		And the response body should contain:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 2                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |


	Scenario: Patch GivenName
		Given I post a Customer with the following details:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		| LastModifiedDate           | 2018-06-21T14:45:00Z |
		When I patch the following:
        | Field						 | Value                |
		| GivenName                  | Bill                 |
		Then there should be a 200 response
		And the response body should contain:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bill                 |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |

			
	Scenario: Patch FamilyName
		Given I post a Customer with the following details:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		| LastModifiedDate           | 2018-06-21T14:45:00Z |
		When I patch the following:
        | Field						 | Value                |
		| FamilyName                 | Update               |
		Then there should be a 200 response
		And the response body should contain:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Update               |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |


	Scenario: Patch DateofBirth
		Given I post a Customer with the following details:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		| LastModifiedDate           | 2018-06-21T14:45:00Z |
		When I patch the following:
        | Field						 | Value                |
		| DateofBirth                | 2005-07-27T13:45:00Z |
		Then there should be a 200 response
		And the response body should contain:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-27T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |


	Scenario: Patch Gender
		Given I post a Customer with the following details:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		| LastModifiedDate           | 2018-06-21T14:45:00Z |
		When I patch the following:
        | Field						 | Value                |
		| Gender                     | 2                    |
		Then there should be a 200 response
		And the response body should contain:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 2                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		
		
		Scenario: Patch UniqueLearnerNumber
		Given I post a Customer with the following details:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		| LastModifiedDate           | 2018-06-21T14:45:00Z |
		When I patch the following:
        | Field						 | Value                |
		| UniqueLearnerNumber        | 9876543211           |
		Then there should be a 200 response
		And the response body should contain:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543211           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		
		
		Scenario: Patch OptInUserResearch
		Given I post a Customer with the following details:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		| LastModifiedDate           | 2018-06-21T14:45:00Z |
		When I patch the following:
        | Field						 | Value                |
		| OptInUserResearch          | false                |
		Then there should be a 200 response
		And the response body should contain:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | false                |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |


		Scenario: Patch OptInMarketResearch
		Given I post a Customer with the following details:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		| LastModifiedDate           | 2018-06-21T14:45:00Z |
		When I patch the following:
        | Field						 | Value                |
		| OptInMarketResearch        | true                 |
		Then there should be a 200 response
		And the response body should contain:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | true                 |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |


	Scenario: Patch DateOfTermination
		Given I post a Customer with the following details:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		| LastModifiedDate           | 2018-06-21T14:45:00Z |
		When I patch the following:
        | Field						 | Value                |
		| DateOfTermination          | 2018-08-27T14:45:00Z |
		Then there should be a 200 response
		And the response body should contain:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |


	Scenario: Patch ReasonForTermination
		Given I post a Customer with the following details:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		| LastModifiedDate           | 2018-06-21T14:45:00Z |
		When I patch the following:
        | Field						 | Value                |
		| ReasonForTermination       | 2                    |
		Then there should be a 200 response
		And the response body should contain:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |


	Scenario: Patch IntroducedBy
		Given I post a Customer with the following details:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		| LastModifiedDate           | 2018-06-21T14:45:00Z |
		When I patch the following:
        | Field						 | Value                |
		| IntroducedBy               | 2                    |
		Then there should be a 200 response
		And the response body should contain:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 2                    |
		| IntroducedByAdditionalInfo | additional info      |


	Scenario: Patch IntroducedByAdditionalInfo
		Given I post a Customer with the following details:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		| LastModifiedDate           | 2018-06-21T14:45:00Z |
		When I patch the following:
        | Field						 | Value                |
		| IntroducedByAdditionalInfo | updated info	        |
		Then there should be a 200 response
		And the response body should contain:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | updated info	        |

		Scenario: Patch With Existing DateOfTermination
		Given I post a Customer with the following details:
		| Field                      | Value                |
		| DateOfRegistration		 | 2018-07-27T16:11:00Z |
		| Title						 | 1                    |
		| GivenName                  | Bob                  |
		| FamilyName                 | Customer             |
		| DateofBirth                | 2005-07-26T13:45:00Z |
		| Gender                     | 1                    |
		| UniqueLearnerNumber        | 9876543210           |
		| OptInUserResearch          | true                 |
		| OptInMarketResearch        | false                |
		| DateOfTermination          | 2018-07-27T14:45:00Z |
		| ReasonForTermination       | 1                    |
		| IntroducedBy               | 1                    |
		| IntroducedByAdditionalInfo | additional info      |
		| LastModifiedDate           | 2018-06-21T14:45:00Z |
		When I patch the following:
        | Field						 | Value                |
		| IntroducedByAdditionalInfo | updated info	        |
		Then there should be a 403 response