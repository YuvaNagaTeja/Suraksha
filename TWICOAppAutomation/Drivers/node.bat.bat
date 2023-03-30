title node
TIMEOUT /T 5
java -Dwebdriver.chrome.driver=%CHROME_DRIVER_FILE_PATH% -jar %SSS% -role webdriver -nodeConfig nodeConfig.json -hub %IP%:%WD_PORT%/grid/register

