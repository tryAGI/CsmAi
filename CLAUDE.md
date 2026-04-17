# CLAUDE.md — CSM AI SDK

## Overview

Auto-generated C# SDK for [CSM AI](https://www.csm.ai/) (Common Sense Machines) — AI-powered
3D generation platform. Covers text-to-3D, image-to-3D, full 3D scene generation,
multiview-to-3D, image-to-kit (modular 3D parts from a single image), and AI retopology.

CSM's differentiator versus single-object generators (Meshy/Tripo/Meshcapade) is
**full 3D scene/world generation** (the `scene` session type on the v3 Sessions API).

## Build & Test

```bash
dotnet build CsmAi.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key auth via the `x-api-key` header. Create a key from the
[Cube Webapp](https://3d.csm.ai/) profile page.

```csharp
var client = new CsmAiClient(apiKey); // CSM_API_KEY env var
```

## Key Files

- `src/libs/CsmAi/openapi.yaml` — **Manually authored** OpenAPI spec (no public spec from CSM)
- `src/libs/CsmAi/generate.sh` — Runs autosdk on local spec (no download step)
- `src/libs/CsmAi/Generated/` — **Never edit** — auto-generated code
- `src/libs/CsmAi/Extensions/CsmAiClient.Tools.cs` — MEAI `AIFunction` tools (hand-written)
- `src/tests/IntegrationTests/Tests.cs` — Test helper with API-key auth
- `src/tests/IntegrationTests/Examples/` — Example tests (double as docs)

## API Surface

The spec covers two parallel shapes:

1. **Unified v3 Sessions API** — `POST /v3/sessions/` with a `type` discriminator
   (`image_to_3d`, `multiview_to_3d`, `text_to_image`, `image_to_kit`, `retopology`, `scene`)
   plus `GET /v3/sessions/{sessionId}`, `DELETE`, and a paginated list. This is the
   modern, recommended API.
2. **Legacy per-type endpoints** — `POST /image-to-3d-sessions`, `POST /tti-sessions`,
   and their `GET` / regenerate-spins variants. These are what the official
   [Python SDK](https://github.com/CommonSenseMachines/csm-ai) uses today and are
   kept in the generated client for compatibility.

## Spec Notes

- **No public OpenAPI spec exists** — `openapi.yaml` is manually authored, cross-referenced
  against [docs.csm.ai](https://docs.csm.ai/) and the official Python SDK source
  (`CommonSenseMachines/csm-ai`)
- API uses async session pattern: POST creates session → poll GET for status
  (`queued`/`incomplete` → `processing`/`in_progress` → `complete`/`completed` | `failed`)
- Response shapes vary between v3 (flat `SessionResponse`) and legacy (envelope with
  `data`, `statusCode`, `message`) — both are modeled
- `SessionInput`/`SessionOutput` are unions — which fields are populated depends on the
  session `type`. Marked with `additionalProperties: true` for forward-compatibility.

## MEAI Tools

Five `AIFunction` helpers in `CsmAiClient.Tools.cs`:
- `AsCreateTextTo3DTaskTool` — starts the text-to-image first stage of text-to-3D
- `AsCreateImageTo3DTaskTool` — starts an image-to-3D session
- `AsCreateSceneTaskTool` — starts a full 3D scene generation (CSM's headline capability)
- `AsGetTaskStatusTool` — polls any session by id via the unified v3 GET
- `AsListMyAssetsTool` — lists the caller's recent sessions
