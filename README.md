**Pinyin 拼音**

A Pinyin/Chinese writing utility for linux.

This was a small hobby project, you would most likely be better off with something like fcitx which lets you use a corporation backed dictionary/algorithm like Google Pinyin.

Requires mono, xsel and xdotool

**Build/Install**

- build with mono
- cd to bin
- install with install.sh as root.

*You will need to bind your own shortcuts, how you do this depends on the distribution but usually it's under your keyboard settings.* **Note:** Modifier keys may cause some issues because of xdotool, Shift should work though. 

- For converting a vowel to pinyin bind *snipyin.sh vowel*
- For converting pinyin to chinese characters bind *snipyin.sh*

**Usage**

Diacritics can be added to vowels by typing the tone number and then pressing your vowel shortcut.
- "ni3" turns in to nǐ

You can then convert the Pinyin to Chinese characters by hitting your other shortcut. (Uses a very poor dictionary, not recommended.)
- hǎo turns in to 好 

Short example video: https://db.tt/eJrd6Pge
