#!/bin/bash
#modified snippy

#store clipboard
CLIPBOARD=`xsel -b`

# read the abbreviation
sleep 0.1s
xdotool key shift+Left
xdotool key shift+Left

xdotool key ctrl+x
sleep 0.1s # to work reliably in Firefox
SELECTION=`xsel -b`

# read snippet file
xsel -b -i < ~/.snipyin/${SELECTION}

# paste snippet
xdotool key ctrl+v

#restore clipboard
echo $CLIPBOARD > /tmp/snippytemp
sleep 0.1s
xsel -b -i < /tmp/snippytemp

