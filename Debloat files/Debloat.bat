@echo off
Title Debloat.bat
echo *******************************************************
echo Auther:			JJakaJonas
echo Script Name:		Debloat.bat
echo Script Type:		Windows Batch Script.
echo Script revision:	12 April 2018 - Virsion 1.0.1.2
echo *******************************************************
echo Script is starting...
echo *******************************************************
echo Jumping to C:\ Drive.
cd C:\
echo Show volume name, folders and files on drive C:\
dir
echo Jumping to F:\ Drive.
cd /d F:\
echo Show volume name, folders and files on drive F:\
dir
echo Deleting .DS_STORE Files.
del /s /q /f /a .DS_STORE
echo Done!
echo Exit Script.
echo *******************************************************
Exit