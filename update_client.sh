rm schema.json
touch schema.json
curl https://api.loan-street.com:8443/v1/api-docs >> schema.json

openapi-generator generate -g csharp-netcore -i schema.json -c config.json

