# HapticPaddle-Unity
[Video](https://vimeo.com/295884576)

Using Serial Output from HapKit as input for Unity (built with Unity 2018.2.9f1)

## Getting Started
### Arduino
- Using [Stanford Hapkit](http://hapkit.stanford.edu/) for paddle fabrication and code
- Insert a variable `int unity_count = 0;` in variable declaration
- Insert a line `if (unity_count++ % 50 == 0) Serial.println(updatedPos);   ` to throttle println statements to a rate that Unity can read

### Unity/Visual Studio
- Download or clone this repo and open Scenes/HapticPaddle.unity in Unity
- Click on the "Cube" in Hierarchy view and adjust parameters in the Inspector view for **COM Port** and **Baudrate**
- Note that you may need to tweak code in **RotateMe.cs** depending on Serial output readings from Arduino. Mine were ~[-3000,3000].
- **WARNING:** In Unity Player Settings ("Ctrl + Shift + B" -> "Player Settings" -> "Other Settings" -> "Configuration" -> "API Compatibility Level"), make sure ".NET 2.0" is selected **NOT** ".NET 2.0 subset"
- Press Play!