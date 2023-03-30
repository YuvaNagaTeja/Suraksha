title hub
TIMEOUT /T 5
java -jar %SSS% -role hub -hubConfig gridHubConfig.json -port %PORT%
TIMEOUT /T 15
