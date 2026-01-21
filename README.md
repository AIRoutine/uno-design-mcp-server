# Uno Design MCP Server

A Model Context Protocol (MCP) server providing **UI/UX design principles and guidelines** for Uno Platform applications. This server focuses on design thinking, not code generation.

## Purpose

This MCP server helps AI assistants provide expert-level UI/UX design guidance for:
- Mobile app design (iOS, Android)
- Desktop app design (Windows, macOS, Linux)
- Cross-platform responsive design
- Accessibility and inclusive design

## Tools Available

| Tool | Description |
|------|-------------|
| `design_principles` | Core UI/UX principles (hierarchy, consistency, feedback, accessibility, simplicity, affordance) |
| `layout_patterns` | Layout composition guidelines (navigation, grids, responsive, spacing) |
| `component_guidelines` | Design guidelines for UI components (buttons, inputs, cards, lists, dialogs, navigation, forms) |
| `color_guidelines` | Color theory, palettes, semantic colors, contrast, dark mode |
| `typography_guidelines` | Type scale, hierarchy, readability, font pairing, responsive typography |
| `user_flow_patterns` | Common user flow patterns (onboarding, authentication, settings, search, CRUD) |
| `mobile_patterns` | Mobile-specific patterns (touch targets, gestures, bottom navigation, swipe actions) |
| `desktop_patterns` | Desktop-specific patterns (keyboard navigation, mouse interactions, window management, menus) |
| `design_checklist` | Design review checklists (wireframe, visual design, prototype, final review) |
| `accessibility_guidelines` | Comprehensive accessibility guidelines (visual, motor, cognitive, screen readers) |

## Installation

### Prerequisites

- Python 3.10 or higher
- pip (Python package manager)

### Setup

```bash
# Clone or navigate to the repository
cd /path/to/uno-design-mcp-server

# Create virtual environment (optional but recommended)
python -m venv .venv
source .venv/bin/activate  # Linux/macOS
# or
.venv\Scripts\activate  # Windows

# Install dependencies
pip install -r requirements.txt
```

## Configuration

### Claude Desktop Configuration

Add to your Claude Desktop configuration (`claude_desktop_config.json`):

```json
{
  "mcpServers": {
    "uno-design": {
      "command": "python",
      "args": ["/path/to/uno-design-mcp-server/server.py"],
      "env": {}
    }
  }
}
```

### VS Code / Claude Code Configuration

Add to your settings:

```json
{
  "claude.mcpServers": {
    "uno-design": {
      "command": "python",
      "args": ["${workspaceFolder}/server.py"]
    }
  }
}
```

## Usage Examples

Once configured, you can ask Claude questions like:

**Design Principles:**
- "What are the core principles of visual hierarchy?"
- "How do I ensure consistency in my app design?"
- "What feedback mechanisms should I implement?"

**Layout & Patterns:**
- "What layout patterns work best for mobile apps?"
- "How should I structure navigation for a desktop app?"
- "What are the best practices for responsive design?"

**Components:**
- "What are the guidelines for designing buttons?"
- "How should I design form inputs?"
- "What makes a good card component?"

**Mobile/Desktop Specific:**
- "What touch target sizes should I use for mobile?"
- "How do I implement swipe gestures correctly?"
- "What keyboard shortcuts are standard?"

**Accessibility:**
- "What contrast ratios do I need for accessibility?"
- "How do I make my app keyboard-navigable?"
- "What screen reader considerations should I have?"

## Directory Structure

```
uno-design-mcp-server/
├── server.py                 # Main MCP server
├── pyproject.toml           # Python project config
├── requirements.txt         # Dependencies
├── README.md               # This file
├── docs/
│   ├── principles/         # Core design principles
│   │   ├── all.md
│   │   ├── visual-hierarchy.md
│   │   ├── consistency.md
│   │   ├── feedback.md
│   │   ├── simplicity.md
│   │   ├── affordance.md
│   │   ├── accessibility-all.md
│   │   └── checklist-all.md
│   ├── patterns/           # Layout & interaction patterns
│   │   ├── mobile-all.md
│   │   ├── desktop-all.md
│   │   └── layout-all-both.md
│   ├── components/         # Component guidelines
│   │   └── all.md
│   └── flows/              # User flow patterns
│       └── all.md
├── resources/
│   ├── colors/             # Color guidelines
│   │   └── all.md
│   └── typography/         # Typography guidelines
│       └── all.md
└── examples/
    ├── mobile/
    ├── desktop/
    └── responsive/
```

## Key Design Focus Areas

### For Mobile Apps
- Touch-friendly interactions (44x44pt minimum targets)
- Bottom navigation and thumb-zone design
- Gesture-based interactions with button fallbacks
- Pull-to-refresh and swipe actions

### For Desktop Apps
- Keyboard navigation and shortcuts
- Hover states and mouse interactions
- Multi-pane layouts and window management
- Context menus and toolbar patterns

### Cross-Platform
- Responsive layouts that adapt
- Consistent design language
- Platform-appropriate conventions
- Accessibility for all users

## Contributing

To add new design guidelines:

1. Create a new markdown file in the appropriate directory
2. Follow the existing documentation format
3. Update the `server.py` if adding new tools
4. Test the tool responses

## Philosophy

This MCP server embodies the perspective of an experienced UI/UX designer:

- **User-centered**: Always prioritize user needs and mental models
- **Platform-aware**: Respect platform conventions while maintaining brand consistency
- **Accessibility-first**: Design for everyone from the start
- **Practical**: Actionable guidelines, not just theory
- **Visual**: Uses ASCII diagrams and examples extensively

## License

MIT License
