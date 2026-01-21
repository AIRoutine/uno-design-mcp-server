# Monochrome Efficiency MCP Server

**An opinionated MCP server for black/white/grayscale UI design with efficiency-first principles.**

No color choices. No design options. One system. Maximum efficiency.

---

## Philosophy

> "Perfection is achieved not when there is nothing more to add, but when there is nothing left to take away."

This MCP server enforces a strict monochrome design system:
- **12-stop grayscale only** (#FFFFFF to #000000)
- **No accent colors** - meaning through form, not color
- **Efficiency-first** - click budgets, cognitive load reduction
- **WCAG AAA contrast** - accessibility by default

---

## Tools (10 Fixed, No Parameters)

| Tool | Purpose |
|------|---------|
| `efficiency_principles` | Click budgets, lean design manifesto |
| `ux_laws` | Hick's, Fitts's, Miller's, Doherty Threshold |
| `cognitive_load` | Progressive disclosure, chunking strategies |
| `monochrome_system` | The grayscale palette and manifesto |
| `contrast_system` | WCAG AAA contrast rules, text hierarchy |
| `shape_language` | Form-based hierarchy, borders, shadows |
| `responsive_system` | Breakpoints, touch targets |
| `layout_patterns` | Navigation, grids, spacing |
| `typography_system` | Type scale, weight-based hierarchy |
| `component_guidelines` | Buttons, inputs, cards in grayscale |

**All tools auto-trigger** based on context. No manual invocation needed.

---

## Installation

### Claude Desktop

Add to your `claude_desktop_config.json`:

```json
{
  "mcpServers": {
    "monochrome-design": {
      "command": "dotnet",
      "args": ["run", "--project", "/path/to/uno-design-mcp-server/src/UnoDesignMcpServer"]
    }
  }
}
```

### Build from Source

```bash
cd src/UnoDesignMcpServer
dotnet build
dotnet run
```

---

## The Monochrome Palette

```
WHITE     #FFFFFF   Primary backgrounds
Gray-50   #FAFAFA   Subtle backgrounds
Gray-100  #F5F5F5   Card surfaces
Gray-200  #EEEEEE   Borders, dividers
Gray-300  #E0E0E0   Disabled backgrounds
Gray-400  #BDBDBD   Placeholder text
Gray-500  #9E9E9E   Secondary text
Gray-600  #757575   Icons
Gray-700  #616161   Body text
Gray-800  #424242   Headlines
Gray-900  #212121   Primary text
BLACK     #000000   Maximum contrast
```

---

## Efficiency Principles

### Click Budgets
- **Daily tasks**: 1-2 clicks
- **Weekly tasks**: 3-4 clicks
- **Rare tasks**: 5+ clicks acceptable

### The 4-Question Framework
1. Can this be **removed**?
2. Can this be **automated**?
3. Can this be **combined**?
4. Can this be **hidden** until needed?

### UX Laws Applied
- **Hick's Law**: Max 5-7 choices per menu
- **Fitts's Law**: Touch targets 48dp minimum
- **Miller's Law**: Chunk into 4±1 groups
- **Doherty Threshold**: Response < 400ms

---

## Directory Structure

```
uno-design-mcp-server/
├── src/UnoDesignMcpServer/    # C# MCP Server
│   ├── Program.cs
│   ├── Tools/
│   │   └── DesignGuidelinesTools.cs
│   └── Services/
│       └── ContentLoaderService.cs
├── docs/
│   ├── philosophy/            # Efficiency + Monochrome manifesto
│   ├── monochrome/            # Contrast, shape language
│   ├── laws/                  # UX laws
│   ├── cognitive/             # Load reduction
│   ├── responsive/            # Breakpoints, touch targets
│   ├── patterns/              # Layout patterns
│   └── components/            # Component guidelines
└── resources/
    ├── monochrome/            # Grayscale palette
    └── typography/            # Type system
```

---

## License

MIT
