# Development

Models generation based on [openapi spec](https://github.com/regulaforensics/DocumentReader-api-openapi).

## Generation

To regenerate models from openapi definition, 
clone [latest open api definitions](https://github.com/regulaforensics/DocumentReader-api-openapi)
and use next command from the project root.
```bash
./update-models.sh
```

## Generator configuration Features

1. The generator does not generate long enums, the problem 
is solved by adding the edited template modelEnum.mustache.
2. When generating oneOf schemas, the generator creates its 
own abstract class, which does not look like it would like. 
The problem was solved by replacing the abstract generator 
class with ours using typeMappings in the generator config.
3. The generator sets the discriminator name incorrectly, the problem 
is solved by adding and editing the modelGeneric.mustache template.
4. Changes have also been made to modelsGeneric.mustache to exclude 
unspecified fields from JSON when serializing a class.

## Problem solving 

To solve new problems, use the generator 
settings ([csharp](https://github.com/OpenAPITools/openapi-generator/blob/master/docs/generators/csharp.md), 
[common](https://github.com/OpenAPITools/openapi-generator/blob/master/docs/customization.md)) 
and [templates](https://github.com/OpenAPITools/openapi-generator/tree/master/modules/openapi-generator/src/main/resources/csharp).

**Do not edit the generated files! They will be overwritten after generation!**