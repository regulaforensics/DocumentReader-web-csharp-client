DOCS_DEFINITION_FOLDER="${PWD}/../DocumentReader-web-openapi"  \
\
&& docker run --user "$(id -u):$(id -g)" --rm -v "${PWD}:/client" -v "${DOCS_DEFINITION_FOLDER}:/definitions" \
openapitools/openapi-generator-cli:v5.0.0 generate \
-i /definitions/index.yml -g csharp -o /client/ \
-c /client/csharp-generator-config.json \
--global-property models
