## Uplink Release Notes
This file contains the release notes for Uplink Stratagem development

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



