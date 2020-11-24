# Development

Models generation based on [openapi spec](https://github.com/regulaforensics/DocumentReader-api-openapi). 

## Enums
Instead of using enums, generator produces static constants. 

## 2-cycle generation
1. Generate enums as constants
2. Generate normal models with substituted by primitive values enums


To regenerate models from openapi definition, 
clone [latest open api definitions](https://github.com/regulaforensics/DocumentReader-api-openapi)
and use next command from the project root.
```bash
./update-models.sh
```
