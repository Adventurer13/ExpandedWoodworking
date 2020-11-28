# Change Log

**Current:** [v1.2.2.2](https://github.com/Adventurer13/ExpandedWoodworking/releases/tag/v1.2.2.2 )

## [1.2.2.2] - 2020-11-28
### Fixed
- Errors with "make any lumber" recipe by removing the unfinished item functionality for it.
- Decreased the sound volume of the recipes on the woodworking tables by a value of two.

## [1.2.2.1] - 2020-11-23
### New
- Spanish (Español(Castellano)) localisation (by Azarashi).
- Woodworking table graphics (Thanks to Chowder and Dr_Zhivago).
- ReGrowth compatibility (Thanks to KennethSamael).
- Advanced Biomes Patch readded in 1.1/1.2 with support for the mod: Advanced Biomes (continued).
- Dead Goat's Weapon Pack(continued) support in 1.1/1.2.
- Generic wood log for compatibility and reporting of unpatched trees in mods (Thanks to KennethSamael).
- Beauty values for each wood and lumber and consequently a balance patch for marble blocks.
- Royalty expansion patch of musical instruments.
- Biome Expansion: Redwood Forest compatibility.
- Switched support to UN-Colony (Continued) in 1.1/1.2.
- Switched support to Medical System Expansion - Revived in 1.1/1.2.
- Medieval Prosthetics support in 1.1/1.2.
- Optional RT's Weapon Pack [1.0-1.2] support in 1.1/1.2.
- Unfinished Lumber when crafting lumber.
- Gloomy mods support.
- Optional older outlined graphics for the log wall.

### Fixed
- Conditional "stuffing" and extra checks (by Dr_Zhivago).
- Errors when attempting to edit the Lost Tribe scenario.
- Woodworking tables and crafting spot use updated recipe sounds when crafting lumber. 
- Updated patches for Expanded Prosthetics and Organ Engineering in 1.1/1.2.
- War Mask requires logs instead of lumber.
- Barricade can be made out of logs as well.
- Fermenting barrel texture updated.
- PatchOperation clean-up.

## [1.1.1.0] - 2020-03-08
### New
- Assembly file using .NET Framework 4.7.2 and added UnityEngine.CoreModule as a reference.
- Folder structure separating versions 1.0 and 1.1 of Rimworld and using LoadFolders.xml for 1.1 and future versions.
- Add package Id: Adventurer.ExpandWoodwork and updated About.xml to work with the Auto-sort button.
- Modifications to log and lumber bases, workbenches, and wall to bring in-line with 1.1.
- Support for the compost barrel from Rainbeau's Fertile Fields in 1.0.
- Changed def WoodLog_Saguaro to WoodLog_Succulent in 1.1.

### Fixed
- Wood log base and pila patching for CE to be more similar to newer CE version in 1.0 (Thanks to Jinlan for base edits).
- Errors relating to outdoor penalty change with workbenches in 1.1.
- Errors relating to change of UnskilledLaborSpeed to GeneralLaborSpeed with recipes in 1.1.
- Label for wood types is now 'wood logs' instead of 'wood types'.
- Language files where labels/descriptions were changed.
- Vanilla patch within 1.1.
- Mod patches in 1.1. Included only those in which the respective mod is updated to 1.1. 

## [1.0.1.6] - 2019-12-29
### New
- Boats compatibility (spawning boats in via godmode deviates them from the author's intended appearance)

### Removed
- BuildingBase and BenchBase defs

## [1.0.1.5] - 2019-11-24
### New
- Advanced Biomes patch.
- Nature's Pretty Sweet revamp for the name of defs for logs, lumber, and recipes.
- Patch (UniMedical) for prosthetics from EPOE, MSE, and eventually other mods that also need to be modified.
- Extended correct mass statFactor when using CE to logs and lumber added by my patches for other mods.
- Cleaned-up a few patch operations in the following patches: TKKN_NPS, Z_CE, and UniFuel.
 
### Fixed
 - Russian localisation (by DiamondGrace)
 - Acacia mass statFactor not applying when using VGP and CE.
 - CE patch operations not applying because CE patch was loaded before other mod patches were loaded.

## [1.0.1.4] - 2019-06-11
### New
- Added mass statFactor for logs and lumbers for Combat Extended compatibility. (Thanks to Jinlan)
- Separated out Rim of Madness - Bones alterations into its own patch, so it can be easily deleted if unwanted.

### Fixed
- Make any lumber stockpile error.

## [1.0.1.3] - 2019-02-01
### New
- Combat Extended compatibility patch re-added.
- Realistic Planets Acacia wood log can be used as fuel.
- Compatibility patch for the mods from Lord of the Rims.

### Fixed
- Multi-version changes.
- Disabled using Saguaro in the general recipe since it doesn't have a lumber counterpart.

## [1.0.1.2] - 2018-12-17
### New
- Readded Zen Garden patch.
- Merged DrZhivago1's DocWorld Various Expanded Woodworking patches for Smoked Meat, RT's Weapon Pack Reloaded, Dead Goat's Weapon Pack, and Rim of Madness - Bones.
- Merged Realistic Planets patch by XeoNovaDan.
- Added new baobab and gum wood types to NPS and Fuel patches.

### Removed
- Old fuel patching.

## [1.0.1.1] - 2018-10-29
### New
- Readded Nature's Pretty Sweet patch.
- Basic UN-colony support. (Decided to not remove drop-down menus for doors/walls, so they have no extra support.)

## [1.0.1.0] - 2018-10-17
### New
- Updated version to 1.0 release of Rimworld.
- Updated readme to contain helpful information on bare starting scenarios.
- Added separate license file.
- Fluffy's Mod Manager support.

### Removed
- Rimworld alpha/beta version in the name.
- Nature's Pretty Sweet patch.

## [0.19.1.2] - 2018-10-06
### Fixed
- Patches not working as a result of using B18 in the name for mods.

## [0.19.1.1] - 2018-09-16
### New
- Cocoa tree producing wood and assembly update.
- Nature's Pretty Sweet patch re-added.

### Fixed
- Drago and Saguaro cactus produce their respective wood types.

## [0.19.1.0] - 2018-09-05
### New (savegame needed for B19 if coming from B18 and before)
- Many edited vanilla definitions are now through a patch versus being written over.
- Bases and Orbital bulk goods trader may trade lumber/logs.

### Fixed
- Further balancing of production tables.
- Errors caused by any relevant changes made by Ludeon with B19 update.
- Log wall no longer conflicts with log walls added by other mods.
- Wooden foot, spike trap, and watermill generator can be made out of multiple types of wood.
- Adjustments made in-line with weapon changes in B19.

### Removed
- Other mod's patch(es) (until those mods are updated).

## [0.18.0.6] - 2018-07-10
### New
- Combat Extended Patch. (Load CE before Expanded Woodworking)
- Russian localisation by lex1975 (GitHub)
- ModSync RW support

### Fixed
- Tree defintions overwriting the tree changes made by plant density mods and the vanilla tree defintions.

### Removed
- ThingDefs_Plants file and folder as it is no longer needed.

## [0.18.0.5] - 2017-12-31
### Fixed
- Bundling lumber no longer includes mixed lumber as a usable ingredient.
- Fuel patch system rewritten to apply to any mod using vanilla wood in the fuel filter.
- Patches no longer repeat what Zen Garden already does to fuel filters.
- Bamboo is now a fuel source.
- Compatibility with Vegetable Garden Project; errors no longer result when using mods from VGP.
- Compatibility with Stuffed Workbenches and DeCore should no longer result in errors.
- Billiard and poker tables no longer require mixed lumber when using a different material.

### Removed
- The M-13's Fuel Generators patch file which only edited the fuelFilter; it is no longer needed with the new patch to fuelFilters.

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
