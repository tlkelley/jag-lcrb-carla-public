﻿Feature: CRSApplicationTransferOwnership
    As a logged in business user
    I want to submit a CRS Application for different business types
    And transfer ownership for the approved application

@e2e @cannabis @indigenousnation @crstransfer2
Scenario: Indigenous Nation Transfer Ownership
    Given I am logged in to the dashboard as an indigenous nation
    And the account is deleted
    And I am logged in to the dashboard as an indigenous nation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for a Cannabis Retail Store
    And I pay the licensing fee for Cannabis
    And I request a transfer of ownership
    And the account is deleted
    Then I see the login page

@e2e @cannabis @partnership @crstransfer
Scenario: Partnership Transfer Ownership
    Given I am logged in to the dashboard as a partnership
    And the account is deleted
    And I am logged in to the dashboard as a partnership
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for a Cannabis Retail Store
    And I pay the licensing fee for Cannabis
    And I request a transfer of ownership
    And the account is deleted
    Then I see the login page

@e2e @cannabis @privatecorporation @crstransfer
Scenario: Private Corporation Transfer Ownership
    Given I am logged in to the dashboard as a private corporation
    And the account is deleted
    And I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for a Cannabis Retail Store
    And I pay the licensing fee for Cannabis
    And I request a transfer of ownership
    And the account is deleted
    Then I see the login page

@e2e @cannabis @publiccorporation @crstransfer2
Scenario: Public Corporation Transfer Ownership
    Given I am logged in to the dashboard as a public corporation
    And the account is deleted
    And I am logged in to the dashboard as a public corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for a Cannabis Retail Store
    And I pay the licensing fee for Cannabis
    And I request a transfer of ownership
    And the account is deleted
    Then I see the login page

@e2e @cannabis @society @crstransfer2
Scenario: Society Transfer Ownership
    Given I am logged in to the dashboard as a society
    And the account is deleted
    And I am logged in to the dashboard as a society
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for a Cannabis Retail Store
    And I pay the licensing fee for Cannabis
    And I request a transfer of ownership
    And the account is deleted
    Then I see the login page

@e2e @cannabis @soleproprietorship @crstransfer
Scenario: Sole Proprietorship Transfer Ownership
    Given I am logged in to the dashboard as a sole proprietorship
    And the account is deleted
    And I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for a Cannabis Retail Store
    And I pay the licensing fee for Cannabis
    And I request a transfer of ownership
    And the account is deleted
    Then I see the login page