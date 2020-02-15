#!/usr/bin/env bash

echo Cleaning

# Remove existing Package Builds
rm schema.json

# Purge existing generated code
rm -rf src/LoanStreet.LoanServicing/Api
rm -rf src/LoanStreet.LoanServicing/Client
rm -rf src/LoanStreet.LoanServicing/Model
rm -rf src/LoanStreet.LoanServicing.Test/Api
rm -rf src/LoanStreet.LoanServicing.Test/Model

echo Downloading

curl -f https://api.loan-street.com:8443/v1/api-docs | jq . > schema.json
# curl --insecure https://localhost:8443/v1/api-docs | jq . > schema.json

echo Generating

# openapi-generator generate -g csharp-netcore -i schema.yaml -c config.json
openapi-generator generate -g csharp-netcore -i schema.json -c config.json

# Add The existing Examples project to the solution
dotnet sln LoanStreet.LoanServicing.sln add src/LoanStreet.LoanServicing.Examples/LoanStreet.LoanServicing.Examples.csproj --in-root

dotnet sln LoanStreet.LoanServicing.sln add src/LoanStreet.LoanServicing.Test/LoanStreet.LoanServicing.Test.csproj --in-root

# Add a reference to the LoanStreet.LoanServicing Project
dotnet add src/LoanStreet.LoanServicing.Examples/LoanStreet.LoanServicing.Examples.csproj reference src/LoanStreet.LoanServicing/LoanStreet.LoanServicing.csproj

# Add Build Project to the solution
dotnet sln LoanStreet.LoanServicing.sln add src/BuildScript/BuildScript.csproj --in-root

# Generation Process wipes out .gitignore, re-add lines
echo ".tools" >> ./.gitignore
echo ".idea" >> ./.gitignore
echo "src/LoanStreet.LoanServicing.Examples/test_context.json" >> ./.gitignore
echo "packages" >> ./.gitignore