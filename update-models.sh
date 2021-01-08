DOCS_DEFINITION_FOLDER="${PWD}/../DocumentReader-web-openapi"  \
\
&& ENUM_MAPPINGS="TextFieldType=int,GraphicFieldType=int,Scenario=string,DocumentFormat=int,\
Light=int,Result=int,VerificationResult=int,RfidLocation=int,\
DocumentTypeRecognitionResult=int,ProcessingStatus=int,Source=string,CheckResult=int,\
LCID=int,DocumentType=int" \
\
&& docker run --user "$(id -u):$(id -g)" --rm -v "${PWD}:/client" -v "$DOCS_DEFINITION_FOLDER:/definitions" \
openapitools/openapi-generator-cli:v5.0.0 generate \
-i /definitions/index.yml -g csharp -o /client/ \
-c /client/csharp-generator-config.json -t /client/generator-templates/ \
\
&& docker run --user "$(id -u):$(id -g)" --rm -v "${PWD}:/client" -v "${DOCS_DEFINITION_FOLDER}:/definitions" \
openapitools/openapi-generator-cli:v5.0.0 generate \
-i /definitions/index.yml -g csharp -o /client/ \
-c /client/csharp-generator-config.json -t /client/generator-templates/ \
--import-mappings $ENUM_MAPPINGS