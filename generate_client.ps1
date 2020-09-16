$DEFINITION_FOLDER = "D:\GitHub_work\DocumentReader-web-openapi"
$ENUM_MAPPINGS=
@"
TextFieldType=int,
GraphicFieldType=int,
Scenario=string,
DocumentFormat=int,
Light=int,
Result=int,
VerificationResult=int,
RfidLocation=int,
DocumentTypeRecognitionResult=int,
ProcessingStatus=int,
Source=string,
CheckResult=int,
LCID=int,
DocumentType=int
"@

docker run --rm -v "${PWD}:/client" -v "${DEFINITION_FOLDER}:/definitions" `
openapitools/openapi-generator-cli generate `
-i /definitions/index.yml -g csharp -o /client/client

docker run --rm -v "${PWD}:/client" -v "${DEFINITION_FOLDER}:/definitions" `
openapitools/openapi-generator-cli generate `
-i /client/docs/openapi/index.yml -g csharp -o /client/clients/csharp/client `
-i /definitions/index.yml -g csharp -o /client/client `
--import-mappings $ENUM_MAPPINGS

<#
docker run --rm -v "${PWD}:/client" -v "${DEFINITION_FOLDER}:/definitions" `
openapitools/openapi-generator-cli generate `
-i /definitions/index.yml -g csharp -o /client/client `
--import-mappings $ENUM_MAPPINGS,`
TextField=com.regula.documentreader.webclient.model.ext.TextField,`
ImagesField=com.regula.documentreader.webclient.model.ext.ImagesField `

docker run --rm -v "${PWD}:/client" -v "${DEFINITION_FOLDER}:/definitions" `
openapitools/openapi-generator-cli generate `
-i /definitions/index.yml -g csharp -o /client/client `
--import-mappings $ENUM_MAPPINGS,`
Text=com.regula.documentreader.webclient.model.ext.Text,`
Images=com.regula.documentreader.webclient.model.ext.Images
#>
