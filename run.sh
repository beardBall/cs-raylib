
clear
[ -e bin/debug/net8.0/new.dll ] && rm  bin/debug/net8.0/new.dll
dotnet build
dotnet bin/debug/net8.0/new.dll

