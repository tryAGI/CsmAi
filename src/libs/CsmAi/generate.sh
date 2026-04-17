#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained (no public spec from CSM AI)
# Source references:
#   - https://docs.csm.ai/
#   - https://github.com/CommonSenseMachines/csm-ai (official Python SDK)

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated

autosdk generate openapi.yaml \
  --namespace CsmAi \
  --clientClassName CsmAiClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
