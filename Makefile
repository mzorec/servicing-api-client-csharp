.PHONY: release_build debug_build clean test

release_build:
	@./.tools/flubu build.release

debug_build:
	@./.tools/flubu build.debug

clean:
	@./.tools/flubu clean

test_generated:
	@./.tools/flubu run.tests  

test_examples:
	@./.tools/flubu run.generated

generate:
	@echo Updating Client from latest schema
	@make clean
	@./update_client.sh $V
	@make debug_build
	@make test_generated
	@make release_build	

setup_flubu:
	@dotnet tool install FlubuCore.GlobalTool --tool-path .tools