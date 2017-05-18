@echo off
setlocal ENABLEDELAYEDEXPANSION
set i=0
for /F "tokens=2" %%A in (DirectoryListing.txt) do (
	@set /A i=i + 1
    rem @set /A vidx=vidx + 1
    @set var!i!=%%A
)

set var

set i=1

:SymLoop
if defined var[%i%] ( 
   call echo %%var[%i%]%% 
   set /a "i+=1"
   GOTO :SymLoop 
)

echo "Length of var is" %i%

pause