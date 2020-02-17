
help:
	@echo "help                     Print this help"
	@echo ""
	@echo "setup_flubu              Setup the Fluent Builder Tool"
	@echo ""
	@echo "clean                    Clean Build Output"
	@echo "release_build            Trigger a Release Build"
	@echo "debug_build              Trigger a Debug Build"
	@echo "package                  Create NuGet Package"
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

package:
	@./.tools/flubu pack

generate:
	@./update_client.sh

setup_flubu:
	@rm -rf .tools
	@dotnet tool install FlubuCore.GlobalTool --tool-path .tools