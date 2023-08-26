using _Logger_.Library;

var log = new ConsoleLog();
log.LogError("Test error");
log.LogInfo("Test info");
log.LogSuccess("Test success");
log.LogCustom("WARNING", "Test custom");