#!/bin/bash
#modified snippy

#store clipboard
CLIPBOARD=`xsel -b`

# read the abbreviation
sleep 0.1s
xdotool key shift+Left
xdotool key shift+Left

xdotool key ctrl+x

SELECTION=`xsel -b`

# read snippet file
#xsel -b -i < ~/.snipyin/${SELECTION}
LC_ALL=C
TEXT=`grep -F "${SELECTION}" ~/.snipyin/.vowels | sed "s/\[${SELECTION}\] //"`
echo -n ${TEXT} | xsel -b -i

# paste snippet
xdotool key ctrl+v

#restore clipboard
echo $CLIPBOARD > /tmp/snippytemp
sleep 0.1s
xsel -b -i < /tmp/snippytemp

