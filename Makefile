
help:
	@echo "help                     Print this help"
	@echo ""
	@echo "setup_flubu              Setup the Fluent Builder Tool"
	@echo ""
	@echo "clean                    Clean Build Output"
	@echo "release_build            Trigger a Release Build"
	@echo "debug_build              Trigger a Debug Build"
	@echo ""
	@echo "test_generated           Execute the Generated Unit Tests"
	@echo "test_examples            Execute the Example Usage Tests"
	@echo ""
	@echo "generate                 Download the latest API Schema and regenerate the Client"
	@echo ""


.PHONY: release_build debug_build clean test_generated test_examples generate setup_flubu

refresh_nuget:
	@./.tools/flubu nuget.restore

release_build:
	@./.tools/flubu build.release

debug_build:
	@./.tools/flubu build.debug

clean:
	@./.tools/flubu clean

test_generated:
	@./.tools/flubu run.tests  

test_examples:
	@./.tools/flubu run.examples

generate:
	@echo Updating Client from latest schema
	@make clean
	@./update_client.sh
	@make debug_build
	@make test_generated
	@make release_build	

setup_flubu:
	@dotnet tool uninstall FlubuCore.GlobalTool --tool-path .tools
	@dotnet tool install FlubuCore.GlobalTool --tool-path .tools