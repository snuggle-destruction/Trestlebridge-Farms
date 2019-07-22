# Description

User is now able to add ostrich to a given grazing field - user can also add a duck house and subsequently ducks.
There is a bug that I'd like to go over with everyone.
Before I could make it possible for the user to add a duck, I had to change the logic in "purchase stock option".
This means that if a user has a duck house but no grazing field, it's still possible for the user to enter the
"purchase stock" option. At which point the program breaks if the user tries to purchase any grazing animals.
If you guys look at the switch case to purchase a duck I've added logic that tells the user they can't purchase a duck
without a duck house - and returns them to the main menu. We could implement this for all case numbers but
I wanted everyone to see it first in case there's a more effiecient way - one thought I had was a dynamically populated
list that would only include options that fit what resources the user has. but idk.


Fixes # user can purchase - ostrich, ducks, duckhouse

## Type of change

Please delete options that are not relevant.

- [ ] New feature (non-breaking change which adds functionality)
- [ ] Breaking change (fix or feature that would cause existing functionality to not work as expected)

# Testing Instructions

Testing would include purchasing a facility either for duck or ostrich. And then placing a duck or ostrich
respectively. Existing bug listed in description. Purchasing a duck house lets the user into purchase stock,
if anything that belongs in a grazing field is selected program breaks.



# Checklist:

- [ ] My code follows the style guidelines of this project
- [ ] I have performed a self-review of my own code
- [ ] I have commented my code, particularly in hard-to-understand areas
- [ ] My changes generate no new warnings or errors
- [ ] I have added test instructions that prove my fix is effective or that my feature works
