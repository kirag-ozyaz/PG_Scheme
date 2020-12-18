@echo off
rem Передаем файл оперативных отключений на Peterhost
echo ---------------------------------------------------------------------_ >> log_ftp.txt
date/T >> log_ftp.txt  
time /T >> log_ftp.txt 

ftp.exe -n -s:ftp_oper_otkl.txt  >> log_ftp.txt
