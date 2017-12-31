# Change Log

**Current:** [v0.18.0.4](https://github.com/Adventurer13/ExpandedWoodworking/releases/tag/v0.18.0.4 )

## Unreleased
### Fixed
- Bundling lumber no longer includes mixed lumber as a usable ingredient.
- Fuel patch system rewritten to apply to any mod using vanilla wood in the fuel filter.
- Patches no longer repeat what Zen Garden already does to fuel filters.
- Bamboo is now a fuel source.
- Compatibility with Vegetable Garden Project; errors no longer result when using mods from VGP.
- Compatibility with Stuffed Workbenches and DeCore should no longer result in errors.
- Billiard and poker tables no longer require mixed lumber when using a different material.

### Removed
- A few patch files which only editted the fuelFilter; they are no longer needed with the new fuelFilter patch.

## [0.18.0.4] - 2017-12-19
### Fixed
- Updated Zen Garden patch to reflect updates made in Zen Garden and prevent errors.

## [0.18.0.3] - 2017-12-17
### New
- Better textures for the powered and unpowered woodworking tables.
- Updates to Zen Garden and M-13's Fuel Generators patches.
- Nature's Pretty Sweet patch.
- ModSync Ninja support.

## [0.18.0.2] - 2017-12-04
### New
- Fermenting barrel (credit to CuproPanda I believe) and brewery (credit to dismar I believe) textures.
- Texture folder restructure.
- Patch and definition updates to reflect above.
- Peg leg uses a log instead of lumber.
- Updated M13's Fuel Generators patch to include VGP woods.

## [0.18.0.1] - 2017-11-27
### New (savegame needed for B18 if coming from A17)
- Very slightly brighter color for Birch.
- Wood and lumber for Cypress, Drago (based off dragon tree), Maple, Palm (black palm from VG patch), and Willow.
- Bamboo and respective lumber (from VG and dismar).
- Moved Art, Joy, Lighting, Power, Production, Security, Temperature, and Weapons (both melee and ranged neolithic) into patching
  system for better compatibility with other mods as well as Rimworld updates editing such as well.
- Support for:
   - Hoopstone ring (uses logs)
   - Wood fired generator (fuel: logs)
   - Brewery and fermenting barrel
   - Weapons: ikwa, spear, and recurve bow (all use logs)
- Individual lumber recipies! (looking for feedback on)
- An electric woodworking table! (looking for feedback on)
- Assembly updated.
- Languages folder added. (Who wants to translate?)
- Update to M-13's Fuel Generators patch.
   
### Fixed
- Balancing for stats (door open speed, beauty, mass, market value, etc.). Looking for feedback regarding these!
- Something I likely forgot, so updates across the defs.
 
### Removed
- Original generator.
- Long sword and gladius using logs instead of lumber. (looking for feedback on these changes)
- Zen Garden patch (until cuproPanda updates it to B18).

## [0.17.0.7] - 2017-10-11
### New
- Patch for M-13's Fuel Generators. Includes compatibilty with Zen Garden too!

## [0.17.0.6] - 2017-10-3
### New
- Neolithic Bulk Goods traders will now buy and sell any logs as well as buy any lumber instead of them only buy/sell mixed lumber!
- The 'Artificial Hedge' in Zen Garden will now properly use any logs instead of only mixed lumber.  

## [0.17.0.5] - 2017-08-29
### New
- Patching capability for compatibility with other mods.
- Zen Garden patch (Steam release has Ebony commented out since it does not exist in Zen Garden on Steam).

## [0.17.0.4] - 2017-08-09
### New
- Base building def to fix 'null thingClass' errors which would occur with Edb Prepare Carefully's starting point system.
- Updates to C sharp code to iron out any issues that may be caused by old.
- Source is actually now available (Only on Github). Respect attached license!
- Including Changelog & Readme in Steam releases.

## [0.17.0.3] - 2017-07-24
### Fixed
- Duplication exploit which resulted in more lumber than was used when bundling various lumber.

## [0.17.0.2] - 2017-07-20
### New
- Added Lumber graphic created by Steam user, A talking dolphin?.
- Some minor code changes.

## [0.17.0.1] - 2017-07-20
### New
- Updated to work with A17 with some minor code changes.

## [0.16.0.5] - 2017-02-20
### New
- Saguaro cacti now drop saguaro ribs.

### Fixed
- Butcher tables no longer always require mixed lumber.
- The lumber recipe now properly looks for lumber instead of stone blocks when set to *Do Until X*.
- Removed all references to Vegetable Garden in the base version, again.
- The speed of crafting lumber has been reduced.

## [0.16.0.4] - 2017-02-17
### New
- Substantial code cleanup.
- Creating chemfuel at a refinery now requires any type of raw log.
- Wood and lumber statistics have been rebalanced to make woodtypes unique.
- Spare lumber can now be bundled together to make mixed lumber.

### Fixed
- Objects built with ironwood are no longer described as being made of willow.

## [0.16.0.3] - 2017-02-13
### New
- Log walls.
- Mixed lumber can be crafted by hand at a crafting spot.
- Woodworking tables are now stuffed for stone, wood, and metal.
- Torch lamps are now stuffed for raw logs.
- Horseshoe pines are now stuffed for raw logs.
- Passive coolers are now stuffed for raw logs.
- Campfires are now stuffed for raw logs.
- Deadfall traps are now stuffed for raw logs.
- The following neolithic weapons are now crafted with raw logs: Shivs, clubs, spears, pilas, short bows, and great bows.

## [0.16.0.2] - 2017-02-11
### Fixed
- The description of lumber recipes are now clearer.
- The mixed lumber recipe now gives the proper amount of lumber.
