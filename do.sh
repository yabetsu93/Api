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

$*