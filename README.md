# Api

API services

to run the api simply type :

./do.sh start

to clean, build or restore the api simply type :
clean 
./do.sh clean

build
./do.sh build

restore 
./do.sh restore

Migrations 

to allow autocreated migration from existing database simply run first :

add migration 
./do.sh startMigration

update db upon migration
./do.sh updateMigration

remove migration
./do.sh removeMigration