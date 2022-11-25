sleep 180s

/opt/mssql-tools/bin/sqlcmd -S localhost \
                            -U SA \
                            -P $SA_PASSWORD \
                            -d master \
                            -i create-database.sql
