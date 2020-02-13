#!/usr/bin/env bash
rm schema.json
touch schema.json

curl https://api.loan-street.com:8443/v1/api-docs >> schema.json
# curl --insecure https://localhost:8443/v1/api-docs >> schema.json

openapi-generator generate -g csharp-netcore -i schema.json -c config.json

# Add The existing Examples project to the solution
dotnet sln LoanStreet.LoanServicing.sln add src/LoanStreet.LoanServicing.Examples/LoanStreet.LoanServicing.Examples.csproj --in-root

# Add a reference to the LoanStreet.LoanServicing Project
dotnet add src/LoanStreet.LoanServicing.Examples/LoanStreet.LoanServicing.Examples.csproj reference src/LoanStreet.LoanServicing/LoanStreet.LoanServicing.csproj

# Add Build Project to the solution
dotnet sln LoanStreet.LoanServicing.sln add src/BuildScript/BuildScript.csproj --in-root
