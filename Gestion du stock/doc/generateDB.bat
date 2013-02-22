@echo off
echo GENERATION DU FICHIER stock.db pour SQLite NE PAS FERMER
echo =================================================

del ..\data\stock.db
echo .read mpd.sql | sqlite3.exe ..\data\stock.db


echo =================================================
echo Fichier stock.db genere, Ok

:_eof
pause