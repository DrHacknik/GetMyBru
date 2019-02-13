## FmSelectSystem.cs 

* ~~Add proper Settings management~~
* Move all the directory preparation code to this Class. 

## FmSwitchMain.cs 

* Implement proper parsing and directory management 
* Implement a Settings specific menu for the SwitchBru homebrew.

## FmWiiUMain.cs 

* Implement proper parsing and directory management 
* Implement a Settings specific menu for the WiiUBru homebrew.

## SvcUpdate.cs

* Implement proper update `JSON` parsing. This information will be parsed through AppVeyor's own API. 
* Implement automatic updates; these will be checked through AppVeyor. 
* Implement Zip Management, and proper updating method/s. 

## BruParser.cs 

* Implement proper WiiU and Switch Bru parsing. Will be parsed using their own JSON Repo; may consider just making a wrapper for Libget. 
