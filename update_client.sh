#!/usr/bin/env bash

# Location to download Schema file
OPENAPI_SCHEMA_URL=https://api.loan-street.com:8443/v1/api-docs # https://localhost:8443/v1/api-docs
# Final output 
SCHEMA_FILE=schema.json
# Temp file to support formatting json with jq
UNFORMATTED_SCHEMA_FILE=schema_raw.json

BOLD='\033[1m'
GREEN='\033[0;32m'
RESET='\033[0m'
REVERSE='\033[7m'
RED='\033[0;31m'

print_divider() {
    str=$(printf "%80s")
    echo -e "${1}${BOLD}${str// /=}${RESET}"
}

print_header() {
    print_divider $GREEN
    echo -e "${GREEN}${BOLD}$1${RESET}"
    print_divider $GREEN   
}

print_error() {
    print_divider $RED
    echo -e "${RED}${BOLD}$1${RESET}"
    print_divider $RED
}

print_header "Downloading Latest Schema..."

# Clean old schema downloads
rm -f $UNFORMATTED_SCHEMA_FILE 
rm -f $SCHEMA_FILE

curl -s --fail --show-error $OPENAPI_SCHEMA_URL -o $UNFORMATTED_SCHEMA_FILE

if test -f "$UNFORMATTED_SCHEMA_FILE"; then
    echo "Successfully downloaded latest OpenAPI Schema!"
else
    print_error "Failed to download OpenAPI Schema!"
    exit 1
fi
 
cat $UNFORMATTED_SCHEMA_FILE | jq . > $SCHEMA_FILE
rm -f $UNFORMATTED_SCHEMA_FILE

print_header "Cleaning Generated Code"

make clean

# Purge existing generated code
rm -rf src/LoanStreet.LoanServicing/Api
rm -rf src/LoanStreet.LoanServicing/Client
rm -rf src/LoanStreet.LoanServicing/Model
rm -rf src/LoanStreet.LoanServicing.Test/Api
rm -rf src/LoanStreet.LoanServicing.Test/Model


print_header "Generating new client from schema..."

# openapi-generator generate -g csharp-netcore -i schema.yaml -c config.json
openapi-generator generate -g csharp-netcore -i $SCHEMA_FILE -c config.json

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

print_header "Debug Build"
make debug_build

print_header "Execute generated Unit Tests"
make test_generated

print_header "Execute Integration Tests"
make test_examples

print_header "Release Build"
make release_build

print_header "Creating NuGet Package"
make package