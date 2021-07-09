Logging implemeted for console, service, webapi.

Appenders : 
	log4net.Appender.ConsoleAppender - implemented
	log4net.Appender.FileAppender - implemented
	RollingFileAppender - implemented
	log4net.Appender.AdoNetAppender - not implemented, DB connectionString issues

ServiceTemplateMethod implemented.

DTO's and Response class serielized to JSON using Newtonsoft.Json package