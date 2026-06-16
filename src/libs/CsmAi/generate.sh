#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained (no public spec from CSM AI)
# Source references:
#   - https://docs.csm.ai/
#   - https://github.com/CommonSenseMachines/csm-ai (official Python SDK)
install_autosdk_cli
rm -rf Generated

autosdk generate openapi.yaml \
  --namespace CsmAi \
  --clientClassName CsmAiClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
