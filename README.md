# RandomNamePlaceGen-Unity
- This project/package generates random names/places within a Unity Project.

[![GitHub release](https://img.shields.io/badge/Build-1.0-brightgreen.svg)](https://github.com/DuckBoss/NamePlaceGen-Unity/releases/latest)
[![Packagist](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/DuckBoss/NamePlaceGen-Unity/blob/master/LICENSE)


## Installation :
- Open the folder as a project in the Unity Game Engine 
  OR
- Create a project in the Unity Game Engine and import the included 'RandomNamePlaceGen-Unity.unitypackage'.

## Usage : 
- Have the 'RandomNameGen' Script present in the scene.
- Generate Male/Female/Other/Place names by calling the public accessible methods in 'RandomNameGen'.
- I HIGHLY RECOMMEND PRE-CACHING THE NAMES YOU WISH TO USE AT RUNTIME FOR PERFORMANCE REASONS

## Examples:
```
using UnityEngine;
using JJ_RandomNameGen;
public testClass : Monobehavior {
    private RandomNameGen genScript;
    
    private void Start() {
        genScript = new RandomNamePlaceGen();
        string MaleFirstName = genScript.GenerateFirstNameMale();
        string FemaleFirstName = genScript.GenerateFirstNameFemale();
        string Place = genScript.GeneratePlace();
    }
    ...
}
```

## Extra Information:
------------------------------
- Check the 'Example' folder for a demo scene.
- The script is fully documented.
