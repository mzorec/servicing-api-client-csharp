.PHONY: release_build debug_build clean test

release_build:
	@ dotnet build --configuration Release

debug_build:
	@ dotnet build --configuration Debug

clean:
	@ dotnet clean

test:
	@ dotnet test
