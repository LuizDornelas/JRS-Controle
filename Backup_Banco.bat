SET PGPASSWORD=Jrs@1900
pg_dump.exe -h 34.95.196.148 -p 5432 -U postgres -F c -b -v -f "D:\Backup_JRS\DadosJRS.backup" DadosJRS
xcopy "D:\Backup_JRS\DadosJRS.backup" "D:\OneDrive - MS365" /E/Y/C/H/D