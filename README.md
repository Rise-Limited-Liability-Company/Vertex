# Vertex
## What is Vertex?
Vertex is a game engine that is used to make retro games.
## Pros
- Easy To Understanding
- Free Examples
- Fast Compiler
- Editable Version Control
## Cons
- Old User Interfaces
- Only 10 Objects Available
- Only 10 Events Available In Each Object
## VTA (Vertex Application)
VTA is a programming language that is used to control the application data. (Not the same as VTSD.)
### Syntaxes
VTA had easy syntaxes, here is an example.
```
Anything that isn't in its syntaxes will works like a comment.
Here is an example of string special types.
- [ns] (New space)
- [nl] (New line)
"d1", "d2", "d3", "d4", "d5", "d6", "d7", "d8", "d9", "d10" are data objects.
There's 5 types of data objects: Active, String, Counter, Button and Editbox.
"value" inside that is inside the data object meaning different when comparing to other types of data object.
"value" in Active means the path of the image file.
"value" in String means the string of the text.
"value" in Counter means the value of the counter.
"value" in Button means the string of the text.
"value" in Editbox means the string of the text.
name: Hello[ns]World[ns]Program
d1-type: String
d1-width: 512
d1-height: 512
d1-value: Hello[ns]World!
d1-x: 0
d1-y: 0
d1-transparency: 1
d1-visible: true
```
If you want to fully understand the language, open the pong.vta (In text editor) file. 
### VTSD (Vertex Save Data)
VTSD is a save file that is used to save the application data. (Not the same as VTA.)
VTSD also had easy syntaxes, here is an example.
```
Anything that isn't in its syntaxes will works like a comment.
import: vta
int: wins
set: wins d1
if-1: wins > 99
then-1: wins = 0
if-2: wins < 0
then-2: wins = 0
```
#### Version
To find what is the current version in command, type command: "Vertex"
## Credits
- Ry Chester (Programmer)
- ??? (Artist)
- Vice Twice (Tester)