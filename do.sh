start() {
    dotnet watch run --environment "Development"
}

clean() {
    dotnet clean
}

build() {
    dotnet build
}

restore() {
    dotnet restore
}

startMigration() {
    dotnet ef migrations add InitialCreate
}

updateMigration() {
    dotnet ef database update
}

removeMigration() {
    dotnet ef migrations remove
}

$*