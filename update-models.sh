DOCS_DEFINITION_FOLDER="${PWD}/../DocumentReader-web-openapi"  \
\
&& ENUM_MAPPINGS="TextFieldType=int,GraphicFieldType=int,Scenario=string,DocumentFormat=int,\
Light=int,Result=int,VerificationResult=int,RfidLocation=int,\
DocumentTypeRecognitionResult=int,ProcessingStatus=int,Source=string,CheckResult=int,\
LCID=int,DocumentType=int,MeasureSystem=int,SecurityFeatureType=int,CheckDiagnose=int,\
Critical=int,Visibility=int,AuthenticityResultType=int,ImageQualityCheckType=int,\
LogLevel=string,MRZFormat=string,TextPostProcessing=int"\
\
&& docker run --user "$(id -u):$(id -g)" --rm -v "${PWD}:/client" -v "${DOCS_DEFINITION_FOLDER}:/definitions" \
openapitools/openapi-generator-cli:v5.0.0-beta2 generate \
-i /definitions/index.yml -g csharp -o /client/ \
-c /client/csharp-generator-config.json \
--import-mappings $ENUM_MAPPINGS
