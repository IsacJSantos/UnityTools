# Data saver
A utility to save and recover serializable data.


## How to use

### Saving data
First thing first, create a serializable class with data that you want to save.

![image](https://user-images.githubusercontent.com/53667441/180339185-8f0b0ac1-ce20-4e0c-8e82-544af8642546.png)

In your own script, create an instance of this class with their data:

![image](https://user-images.githubusercontent.com/53667441/180339267-dba3c452-6407-41ec-a061-b0f26b03494f.png)

And so, call the static function "SaveData" from the class "SaveSerial" passing the object and a file name:

![image](https://user-images.githubusercontent.com/53667441/180338714-22d87140-394d-4aeb-aef0-9978cac18bcd.png)

### Recovering data
To load your serialized file, create an instance of the serialized class and call the static "LoadData" function of the "SaveSerial" class passing the same name as the saved file.

![image](https://user-images.githubusercontent.com/53667441/180339060-c9e21955-a0e8-4da4-864a-c873c167ac77.png)

Enjoy :)


