DOCS_DEFINITION_FOLDER="${PWD}/../DocumentReader-web-openapi"  \
\
&& ENUM_MAPPINGS="CheckDiagnose=Integer,Critical=Integer,AuthenticityResultType=Integer,Visibility=Integer,Source=String,\
CheckResult=Integer,Scenario=String,RfidLocation=Integer,Light=Integer,BarcodeType=Integer,DocumentType=Integer,\
GraphicFieldType=Integer,LCID=Integer,ParsingErrorCodes=Integer,ParsingNotificationCodes=Integer,RfidDataFileType=Integer,\
RfidDataGroupTypeTag=Integer,RFIDErrorCodes=Integer,RFIDPKDResourceType=Integer,SecurityFeatureType=Integer,\
TextFieldType=Integer,MRZFormat=String,TextPostProcessing=Integer,mrzDetectModeEnum=Integer,MeasureSystem=Integer,\
LogLevel=String,ProcessingStatus=Integer,BarCodeModuleType=Integer,DocumentTypeRecognitionResult=Integer,\
DocumentFormat=Integer,ImageQualityCheckType=Integer,VerificationResult=Integer,RfidApplicationType=Integer,\
RfidAccessControlProcedureType=Integer,RfidType=Integer,RfidAChip=Integer,RfidBaudRate=Integer,RfidPasswordType=Integer,\
RfidTerminalType=Integer,RfidAuthenticationProcedureType=Integer,RfidCertificateOrigin=Integer,RfidCertificateType=Integer" \
\
&& docker run --user "$(id -u):$(id -g)" --rm -v "${PWD}:/client" -v "${DOCS_DEFINITION_FOLDER}:/definitions" \
openapitools/openapi-generator-cli:v5.0.0 generate \
-i /definitions/index.yml -g csharp -o /client/ \
-c /client/csharp-generator-config.json \
--global-property models \
--import-mappings $ENUM_MAPPINGS