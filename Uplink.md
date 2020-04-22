## Uplink Release Notes
This file contains the release notes for Uplink Stratagem development. Change and release notes should be logged from latest to oldest (DESC).


### Changes 20042022_1
	- State management for Wizard
	- Added customerwizardstate table
	- Added spManageCustomerWizardState stored procedure
	- Added spGetCustomerWizardState stored procedure
	- Added passing of step to API for state saving
	- Missing Integration Logs Tab

### Changes 20042021_3
	- State management for Wizard
	- Added customerwizardstate table
	- Added spManageCustomerWizardState stored procedure
	- Added spGetCustomerWizardState stored procedure
	- Added passing of step to API for state saving


### Changes 20042021_2
	- State management for Wizard
	- Fixed Defect - Edit of customer not loading

### Changes 20042021_1
- Create customer wizard saving:
	- Step 5 (Documents) completed (No validation required here)
	- Applied layout changes for Step 6 (Completion of onboarding)
	- Completed step 6 saving


### Changes 20042020_2
- Create customer wizard saving:
	- Step one completed
	- Positive saving of devices completed
	- Fixed incorrect error message on failure
	- Step two and Three completed
	- Step 4 completed

### Changes 20042020_1
- Create customer wizard saving:
	- Fixed customer number not showing after initial save - Create Wizard
	- Added title to warning icon with text to indicate that there is a problem with the current wizard step
	- Made detailsCreate method async to wait for response before deciding next action
	- Fixed flow between incomplete and completed steps

### Changes 15042020
- Created branch develop-rs-cstakeon-sp1 (API and Portal)
- Pushed to git
- latest dev db restore for local development

### Changes 16042020
 - Create customer wizard saving
        - Step 1 complete
### Changes 17042020_1
- Create customer wizard saving
       - Validated data pushed for Step 1
       - When creating new customer all steps set back to 1
       - Fixed statusbar not resetting after data saved
       - Added a initialization statusbar function to highlight first step on load

### Changes 17042020_2
- Create customer wizard saving:
       - Forced Director and contact details to be expanded - to indicate these fields are mandatory on form load (Done in JSON on attributetemplates table)

### Changes 19042020_2
- Create customer wizard saving:
		- Added warning icon style
		- Added warning icon image
		- Added logic to prevent from next step if current step is incomplete
