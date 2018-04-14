@echo off
Title Debloat.bat
echo *******************************************************
echo Auther:			JJakaJonas
echo Script Name:		Debloat.bat
echo Script Type:		Windows Batch Script.
echo Script revision:	12 April 2018 - Virsion 1.0.3.0
Echo *******************************************************
echo Script is starting...
Echo *******************************************************
echo Jumping to F:\ Drive.
cd F:\
echo Show folders and files on drive F:\
dir
echo Deleting .DS_STORE Files.
pause
del /s /q /f /a .DS_STORE
echo Done!
echo Exit Script.
echo *******************************************************
pause
Exit