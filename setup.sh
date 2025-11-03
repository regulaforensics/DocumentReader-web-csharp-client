dotnet build ./src/Regula.DocumentReader.NetCoreExample -c Release

cd  ./src/Regula.DocumentReader.NetCoreExample || exit

export API_BASE_PATH="https://nightly-api.regulaforensics.com"

dotnet run
