# UI Project 

## Description 
This project covers the topics covered so far (tokenizer, extensions, graphics) 
by building an application that has two pages
 1. Source page
 2. Design page
 
 both are consider inputs and outputs
one is used for editing the code and the resulted drawings will be reflected in the design page, and when a shape been drawn in design page the mirroring code will be added to the source code.


 ## *.drw* file
the supported *.drw* syntax are as follows, shape name and four positive integer values separated by a comma, and multiple shapes are separated by hyphen e.g. 
	

    cir 106,77,169,143 - 
    line 35,34,239,53

## *.drw* keywords 
### *cir* 
***cir*** keyword is the mapped syntax to draw a circle on board, and the values after the keyword are
	
    cir x,y,width, height  
  

> width and height are for the rectangle that the circle will be drawn inside.
### *rect* 
***rect*** keyword is the mapped syntax to draw a rectangle on board, and the values after the keyword are
	
    rect x,y,width, height  
  

### *line* 
***line*** keyword is the mapped syntax to draw a line on board, and the values after the keyword are
	
    line x1,y1,x2, y2
 

> (x1,y1) first point , (x2,y2) end point 


### To run 
    # Clone this repository
    $ git clone https://github.com/ThamerBootcamp/UI-Project
    
    # Go into the Release directory
	$ cd UI-Project/net5.0-windows
    
    # Execute the program
    $ start UI-Project.exe
   > pen style and colors aren't supported by the .drw editor.




### Develepors 
 - Thamer Mashni
