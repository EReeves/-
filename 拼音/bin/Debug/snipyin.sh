#!/bin/bash
#modified snippy

#store clipboard
CLIPBOARD=`xsel -b`

# read the abbreviation
sleep 0.1s

modprobe -r usbhid #disable keyboard

if [ "$1" = "vowel" ]
	then
		xdotool key --delay 1 --clearmodifiers shift+Left
		xdotool key --delay 1 --clearmodifiers shift+Left
		FILE=~/.snipyin/.vowels

else
		xdotool key --delay 1 --clearmodifiers control+shift+Left
		FILE=~/.snipyin/.mandarin
		sleep 0.1s
fi

xdotool key ctrl+x

SELECTION=`xsel -b`

# read snippet file
#xsel -b -i < ~/.snipyin/${SELECTION}
TEXT=`grep -m 1 "\[${SELECTION}\]" $FILE | sed "s/\[${SELECTION}\] //"`
echo -n ${TEXT} | xsel -b -i

# paste snippet
xdotool key ctrl+v

#restore clipboard
echo $CLIPBOARD > /tmp/snippytemp
sleep 0.1s
xsel -b -i < /tmp/snippytemp

modprobe usbhid #enable keyboard
