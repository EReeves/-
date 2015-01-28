#!/bin/bash
rm /usr/bin/snipyin.sh

echo "Input username for install: "
read USER
sudo -u $USER mono 拼音.exe --install-snippets

mono 拼音.exe --install-bin

chmod +x /usr/bin/snipyin.sh

