#!/bin/bash
#modified snippy

# read the abbreviation
xdotool key shift+Left
xdotool key shift+Left
xdotool key ctrl+x
sleep 0.3s # to work reliably in Firefox
SELECTION=`xsel -b`
# read snippet file
xsel -b -i < ~/.snippy/${SELECTION}
# paste snippet
xdotool key ctrl+v
#xdotool key BackSpace # delete the last blank line, so we stay inline