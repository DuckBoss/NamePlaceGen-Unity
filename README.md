# RandomNamePlaceGen-Unity
- This project/package generates random names/places within a Unity Project.

## Installation :
- Open the folder as a project in the Unity Game Engine 
  OR
- Create a project in the Unity Game Engine and import the included 'RandomNamePlaceGen-Unity.unitypackage'.

## Usage : 
- Have the 'RandomNameGen' Script present in the scene.
- Generate Male/Female/Other/Place names by calling the public accessible methods in 'RandomNameGen'.


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




# License:
------------------------------
MIT License

Copyright (c) [2017] [Jason Jerome]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.


Basically this license gives permissions for:
- Commercial Use
- Distribution
- Modification
- Private Use
