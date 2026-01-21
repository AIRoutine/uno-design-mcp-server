# Uno Design MCP Server

A Model Context Protocol (MCP) server providing UI/UX design guidelines, principles, patterns, and resources for building beautiful and consistent Uno Platform applications.

## Features

- **10 Design Tools** covering all aspects of UI/UX design
- **Cross-platform** guidance for mobile and desktop
- **Accessibility** best practices included
- **Stdio transport** for easy integration

## Available Tools

| Tool | Description |
|------|-------------|
| `design_principles` | Core UI/UX design principles (visual hierarchy, consistency, feedback, etc.) |
| `layout_patterns` | Layout and composition guidelines |
| `component_guidelines` | Design guidelines for UI components (buttons, inputs, cards, etc.) |
| `color_guidelines` | Color theory and palette guidelines |
| `typography_guidelines` | Typography best practices and type scale |
| `user_flow_patterns` | Common user flow patterns (onboarding, authentication, etc.) |
| `mobile_patterns` | Mobile-specific design patterns and touch interactions |
| `desktop_patterns` | Desktop patterns for keyboard, mouse, and window management |
| `design_checklist` | Design review checklists |
| `accessibility_guidelines` | Comprehensive accessibility guidelines |

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later

## Build

```bash
cd src/UnoDesignMcpServer
dotnet build
```

---

## Integration

### Claude Code

Add to your Claude Code MCP settings file (`~/.claude/settings.json` or project `.claude/settings.json`):

```json
{
  "mcpServers": {
    "uno-design": {
      "type": "stdio",
      "command": "dotnet",
      "args": [
        "run",
        "--project",
        "/absolute/path/to/UnoDesignMcpServer.csproj"
      ]
    }
  }
}
```

**Or using the compiled executable:**

```json
{
  "mcpServers": {
    "uno-design": {
      "type": "stdio",
      "command": "/absolute/path/to/UnoDesignMcpServer"
    }
  }
}
```

---

### Codex CLI

Add to your Codex CLI configuration (`~/.codex/config.json`):

```json
{
  "mcpServers": {
    "uno-design": {
      "type": "stdio",
      "command": "dotnet",
      "args": [
        "run",
        "--project",
        "/absolute/path/to/UnoDesignMcpServer.csproj"
      ]
    }
  }
}
```

**Or with environment variables:**

```json
{
  "mcpServers": {
    "uno-design": {
      "type": "stdio",
      "command": "dotnet",
      "args": [
        "run",
        "--project",
        "/absolute/path/to/UnoDesignMcpServer.csproj"
      ],
      "env": {
        "DOTNET_ENVIRONMENT": "Production"
      }
    }
  }
}
```

---

### Gemini CLI

Add to your Gemini CLI settings file (`~/.gemini/settings.json`):

```json
{
  "mcpServers": {
    "uno-design": {
      "type": "stdio",
      "command": "dotnet",
      "args": [
        "run",
        "--project",
        "/absolute/path/to/UnoDesignMcpServer.csproj"
      ]
    }
  }
}
```

---

### VS Code (GitHub Copilot)

Add to `.vscode/mcp.json` in your workspace:

```json
{
  "servers": {
    "uno-design": {
      "type": "stdio",
      "command": "dotnet",
      "args": [
        "run",
        "--project",
        "${workspaceFolder}/src/UnoDesignMcpServer/UnoDesignMcpServer.csproj"
      ]
    }
  }
}
```

---

## Usage Examples

Once configured, you can use the tools in your AI assistant:

```
# Get design principles
"What are the core visual hierarchy principles?"

# Get mobile patterns
"Show me touch target guidelines for mobile"

# Get component guidelines
"What are the best practices for button design?"

# Get accessibility guidelines
"How do I make my app accessible for screen readers?"
```

## Project Structure

```
src/UnoDesignMcpServer/
├── UnoDesignMcpServer.csproj    # Project file
├── Program.cs                    # MCP Server entry point
├── Services/
│   └── ContentLoaderService.cs  # Markdown file loader
├── Tools/
│   └── DesignGuidelinesTools.cs # All 10 MCP tools
├── docs/                         # Design documentation
│   ├── components/
│   ├── flows/
│   ├── patterns/
│   └── principles/
└── resources/                    # Design resources
    ├── colors/
    └── typography/
```

## License

MIT

## Links

- [Repository](https://github.com/AIRoutine/uno-design-mcp-server)
- [MCP Protocol](https://modelcontextprotocol.io/)
- [Uno Platform](https://platform.uno/)
