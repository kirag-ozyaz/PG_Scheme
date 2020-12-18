echo "Копируем файлы для веббраузера"
cd ..\..\..
set TargetDirWeb=%cd%
echo TargetDirWeb = %TargetDirWeb% 
xcopy.exe %TargetDirWeb%"\WebBrowserN2\LIBs\include" "$(TargetDir)" /E /R /Y