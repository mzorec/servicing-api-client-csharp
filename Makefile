.PHONY: release_build debug_build clean test

release_build:
	@ dotnet build --configuration Release

debug_build:
	@ dotnet build --configuration Debug

clean:
	@ dotnet clean

test_generated:
	@ dotnet test src/LoanStreet.LoanServicing.Test/LoanStreet.LoanServicing.Test.csproj  

test_examples:
	@ dotnet test src/LoanStreet.LoanServicing.Examples/LoanStreet.LoanServicing.Examples.csproj

generate:
	@make clean
	@./update_client.sh
	@dotnet sln LoanStreet.LoanServicing.sln add src/LoanStreet.LoanServicing.Examples/LoanStreet.LoanServicing.Examples.csproj --in-root
	@dotnet add src/LoanStreet.LoanServicing.Examples/LoanStreet.LoanServicing.Examples.csproj reference src/LoanStreet.LoanServicing/LoanStreet.LoanServicing.csproj 
	@make debug_build
	@make test_generated
	@make release_build	
