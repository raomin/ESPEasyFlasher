# ESPEasyFlasher

Small and super light UI for easy flashing/backing up ESP8266 and ESP32 with esptool.

Now supports firmware backup and flash operation, so easy cloning of your running ESP!

It works by backing up and flashing the whole flash each time. It's a bit slow but easy, and makes complete backup/copy.

![Screenshot](screenshot.png)

## Installation

Go to the [latest release](./releases/latest) and get the ZIP file.

Unzip all in one folder (the FlashESP8266.exe and esp-tool.exe must be in the same folder).

## Usage

Launch FlashESP8266.exe.

To Backup pay attention that the Filname must be in .bin to appear in the Flash section.

Some ESP8266 only supports transfer speed of 115200 bauds max when Reading (backup).
