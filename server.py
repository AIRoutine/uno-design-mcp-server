#!/usr/bin/env python3
"""
Uno Design MCP Server - UI/UX Design Principles for Uno Platform Apps

This MCP server provides design guidelines, patterns, and principles
for creating beautiful and user-friendly Uno Platform applications.

IMPORTANT FOR AI ASSISTANTS:
This server acts as a DESIGN KNOWLEDGE BASE. When a user asks to design,
create, or build any UI screen, page, or component, you MUST automatically
consult the relevant tools to apply proper design principles. Do NOT wait
for explicit requests - proactively gather design knowledge before creating UI.

Workflow when user requests a UI screen:
1. efficiency_principles → Get click budget and lean design rules
2. platform_efficiency → Get platform-specific patterns (mobile/desktop)
3. ux_laws → Get interaction design constraints (Hick's, Fitts's, Miller's)
4. responsive_system → Get breakpoints and touch targets
5. code_templates → Get implementation templates
"""

import json
import logging
from pathlib import Path
from typing import Any

from mcp.server import Server
from mcp.server.stdio import stdio_server
from mcp.types import Tool, TextContent

# Configure logging
logging.basicConfig(level=logging.INFO)
logger = logging.getLogger(__name__)

# Server instance
server = Server("uno-design-mcp-server")

# Base path for documentation
DOCS_PATH = Path(__file__).parent / "docs"
RESOURCES_PATH = Path(__file__).parent / "resources"


def load_markdown(file_path: Path) -> str:
    """Load markdown content from file."""
    if file_path.exists():
        return file_path.read_text(encoding="utf-8")
    return f"Documentation not found: {file_path}"


def load_json(file_path: Path) -> dict:
    """Load JSON content from file."""
    if file_path.exists():
        return json.loads(file_path.read_text(encoding="utf-8"))
    return {}


@server.list_tools()
async def list_tools() -> list[Tool]:
    """List available design tools."""
    return [
        Tool(
            name="design_principles",
            description="Get core UI/UX design principles for Uno Platform apps. Topics: visual-hierarchy, consistency, feedback, accessibility, simplicity, affordance",
            inputSchema={
                "type": "object",
                "properties": {
                    "topic": {
                        "type": "string",
                        "description": "Design principle topic",
                        "enum": ["visual-hierarchy", "consistency", "feedback", "accessibility", "simplicity", "affordance", "all"]
                    }
                },
                "required": ["topic"]
            }
        ),
        Tool(
            name="layout_patterns",
            description="Get layout patterns and composition guidelines. Categories: navigation, content-areas, grids, responsive, spacing",
            inputSchema={
                "type": "object",
                "properties": {
                    "category": {
                        "type": "string",
                        "description": "Layout pattern category",
                        "enum": ["navigation", "content-areas", "grids", "responsive", "spacing", "all"]
                    },
                    "platform": {
                        "type": "string",
                        "description": "Target platform",
                        "enum": ["mobile", "desktop", "both"],
                        "default": "both"
                    }
                },
                "required": ["category"]
            }
        ),
        Tool(
            name="component_guidelines",
            description="Get design guidelines for UI components. Components: buttons, inputs, cards, lists, dialogs, navigation, forms",
            inputSchema={
                "type": "object",
                "properties": {
                    "component": {
                        "type": "string",
                        "description": "UI component type",
                        "enum": ["buttons", "inputs", "cards", "lists", "dialogs", "navigation", "forms", "all"]
                    }
                },
                "required": ["component"]
            }
        ),
        Tool(
            name="color_guidelines",
            description="Get color theory and palette guidelines for app design",
            inputSchema={
                "type": "object",
                "properties": {
                    "aspect": {
                        "type": "string",
                        "description": "Color aspect to explore",
                        "enum": ["theory", "palettes", "semantic", "contrast", "dark-mode", "all"]
                    }
                },
                "required": ["aspect"]
            }
        ),
        Tool(
            name="typography_guidelines",
            description="Get typography best practices and type scale recommendations",
            inputSchema={
                "type": "object",
                "properties": {
                    "aspect": {
                        "type": "string",
                        "description": "Typography aspect",
                        "enum": ["type-scale", "hierarchy", "readability", "pairing", "responsive", "all"]
                    }
                },
                "required": ["aspect"]
            }
        ),
        Tool(
            name="user_flow_patterns",
            description="Get common user flow patterns and interaction design guidelines",
            inputSchema={
                "type": "object",
                "properties": {
                    "flow_type": {
                        "type": "string",
                        "description": "Type of user flow",
                        "enum": ["onboarding", "authentication", "checkout", "settings", "search", "crud", "all"]
                    }
                },
                "required": ["flow_type"]
            }
        ),
        Tool(
            name="mobile_patterns",
            description="Get mobile-specific design patterns and touch interaction guidelines",
            inputSchema={
                "type": "object",
                "properties": {
                    "pattern": {
                        "type": "string",
                        "description": "Mobile pattern category",
                        "enum": ["touch-targets", "gestures", "bottom-navigation", "pull-refresh", "swipe-actions", "all"]
                    }
                },
                "required": ["pattern"]
            }
        ),
        Tool(
            name="desktop_patterns",
            description="Get desktop-specific design patterns for keyboard, mouse, and window management",
            inputSchema={
                "type": "object",
                "properties": {
                    "pattern": {
                        "type": "string",
                        "description": "Desktop pattern category",
                        "enum": ["keyboard-navigation", "mouse-interactions", "window-management", "menu-patterns", "toolbar-patterns", "all"]
                    }
                },
                "required": ["pattern"]
            }
        ),
        Tool(
            name="design_checklist",
            description="Get a design review checklist for evaluating UI/UX quality",
            inputSchema={
                "type": "object",
                "properties": {
                    "phase": {
                        "type": "string",
                        "description": "Design phase to check",
                        "enum": ["wireframe", "visual-design", "prototype", "final-review", "all"]
                    }
                },
                "required": ["phase"]
            }
        ),
        Tool(
            name="accessibility_guidelines",
            description="Get comprehensive accessibility guidelines for inclusive design",
            inputSchema={
                "type": "object",
                "properties": {
                    "category": {
                        "type": "string",
                        "description": "Accessibility category",
                        "enum": ["visual", "motor", "cognitive", "screen-readers", "all"]
                    }
                },
                "required": ["category"]
            }
        ),
        # EFFICIENCY-FOCUSED TOOLS - AUTO-TRIGGER FOR UI DESIGN
        Tool(
            name="efficiency_principles",
            description="REQUIRED: Consult FIRST when designing ANY UI screen. Provides click-budget guidelines (daily tasks: 1-2 clicks, weekly: 3-4, rare: 5+), lean design philosophy, and efficiency metrics. Auto-use for: home screens, dashboards, main user flows, any new page design.",
            inputSchema={
                "type": "object",
                "properties": {
                    "principle": {
                        "type": "string",
                        "description": "Efficiency principle to explore",
                        "enum": ["all"]
                    }
                },
                "required": ["principle"]
            }
        ),
        Tool(
            name="ux_laws",
            description="REQUIRED: Consult when designing navigation, buttons, menus, or option lists. Provides Hick's Law (max 5-7 choices), Fitts's Law (target sizes ≥48dp), Miller's Law (chunk into 4±1 groups), Doherty Threshold (<400ms response). Auto-use for: menus, toolbars, forms, any interactive elements.",
            inputSchema={
                "type": "object",
                "properties": {
                    "law": {
                        "type": "string",
                        "description": "UX law to explore",
                        "enum": ["hicks", "fitts", "miller", "doherty", "all"]
                    }
                },
                "required": ["law"]
            }
        ),
        Tool(
            name="cognitive_load",
            description="REQUIRED: Consult when designing forms, wizards, settings, or multi-step flows. Provides progressive disclosure patterns, chunking strategies, and the 4-question framework (Remove→Automate→Combine→Hide). Auto-use for: registration, onboarding, data entry, configuration screens.",
            inputSchema={
                "type": "object",
                "properties": {
                    "aspect": {
                        "type": "string",
                        "description": "Cognitive load aspect",
                        "enum": ["reduction", "progressive-disclosure", "all"]
                    }
                },
                "required": ["aspect"]
            }
        ),
        Tool(
            name="task_optimization",
            description="REQUIRED: Consult when defining user flows or task sequences. Provides click budgets by frequency (daily/weekly/monthly), task flow analysis methods, and optimization patterns. Auto-use for: core user journeys, checkout flows, CRUD operations.",
            inputSchema={
                "type": "object",
                "properties": {
                    "task_type": {
                        "type": "string",
                        "description": "Type of task to optimize",
                        "enum": ["all"]
                    }
                },
                "required": ["task_type"]
            }
        ),
        Tool(
            name="responsive_system",
            description="REQUIRED: Consult when designing screens for multiple device sizes. Provides concrete breakpoints (Compact 0-599px, Medium 600-839px, Expanded 840-1199px, Large 1200px+) and touch target minimums (44-48dp). Auto-use for: any adaptive/responsive layout, cross-platform screens.",
            inputSchema={
                "type": "object",
                "properties": {
                    "aspect": {
                        "type": "string",
                        "description": "Responsive aspect",
                        "enum": ["breakpoints", "touch-targets", "all"]
                    }
                },
                "required": ["aspect"]
            }
        ),
        Tool(
            name="platform_efficiency",
            description="REQUIRED: Consult based on target platform. Mobile: thumb zone optimization, bottom navigation, gesture patterns. Desktop: keyboard shortcuts, multi-panel layouts, hover states. Auto-use for: platform-specific screen designs, mobile-first or desktop-first approaches.",
            inputSchema={
                "type": "object",
                "properties": {
                    "platform": {
                        "type": "string",
                        "description": "Target platform",
                        "enum": ["mobile", "desktop"]
                    }
                },
                "required": ["platform"]
            }
        )
    ]


@server.call_tool()
async def call_tool(name: str, arguments: dict[str, Any]) -> list[TextContent]:
    """Handle tool calls for design guidelines."""

    try:
        if name == "design_principles":
            content = load_markdown(DOCS_PATH / "principles" / f"{arguments['topic']}.md")
        elif name == "layout_patterns":
            platform = arguments.get("platform", "both")
            content = load_markdown(DOCS_PATH / "patterns" / f"layout-{arguments['category']}-{platform}.md")
        elif name == "component_guidelines":
            content = load_markdown(DOCS_PATH / "components" / f"{arguments['component']}.md")
        elif name == "color_guidelines":
            content = load_markdown(RESOURCES_PATH / "colors" / f"{arguments['aspect']}.md")
        elif name == "typography_guidelines":
            content = load_markdown(RESOURCES_PATH / "typography" / f"{arguments['aspect']}.md")
        elif name == "user_flow_patterns":
            content = load_markdown(DOCS_PATH / "flows" / f"{arguments['flow_type']}.md")
        elif name == "mobile_patterns":
            content = load_markdown(DOCS_PATH / "patterns" / f"mobile-{arguments['pattern']}.md")
        elif name == "desktop_patterns":
            content = load_markdown(DOCS_PATH / "patterns" / f"desktop-{arguments['pattern']}.md")
        elif name == "design_checklist":
            content = load_markdown(DOCS_PATH / "principles" / f"checklist-{arguments['phase']}.md")
        elif name == "accessibility_guidelines":
            content = load_markdown(DOCS_PATH / "principles" / f"accessibility-{arguments['category']}.md")
        # NEW EFFICIENCY-FOCUSED TOOLS
        elif name == "efficiency_principles":
            content = load_markdown(DOCS_PATH / "philosophy" / "efficiency-first.md")
        elif name == "ux_laws":
            law = arguments.get("law", "all")
            if law == "all":
                content = load_markdown(DOCS_PATH / "laws" / "all.md")
            else:
                content = load_markdown(DOCS_PATH / "laws" / f"{law}-law.md")
        elif name == "cognitive_load":
            aspect = arguments.get("aspect", "all")
            if aspect == "all" or aspect == "reduction":
                content = load_markdown(DOCS_PATH / "cognitive" / "load-reduction.md")
            elif aspect == "progressive-disclosure":
                content = load_markdown(DOCS_PATH / "cognitive" / "progressive-disclosure.md")
            else:
                content = load_markdown(DOCS_PATH / "cognitive" / "load-reduction.md")
        elif name == "task_optimization":
            content = load_markdown(DOCS_PATH / "optimization" / "task-flows.md")
        elif name == "responsive_system":
            aspect = arguments.get("aspect", "all")
            if aspect == "breakpoints":
                content = load_markdown(DOCS_PATH / "responsive" / "breakpoints.md")
            elif aspect == "touch-targets":
                content = load_markdown(DOCS_PATH / "responsive" / "touch-targets.md")
            else:
                # Combine both
                breakpoints = load_markdown(DOCS_PATH / "responsive" / "breakpoints.md")
                touch = load_markdown(DOCS_PATH / "responsive" / "touch-targets.md")
                content = breakpoints + "\n\n---\n\n" + touch
        elif name == "platform_efficiency":
            platform = arguments.get("platform", "mobile")
            content = load_markdown(DOCS_PATH / "platforms" / f"{platform}-efficiency.md")
        else:
            content = f"Unknown tool: {name}"

        return [TextContent(type="text", text=content)]

    except Exception as e:
        logger.error(f"Error in tool {name}: {e}")
        return [TextContent(type="text", text=f"Error: {str(e)}")]


async def main():
    """Run the MCP server."""
    async with stdio_server() as (read_stream, write_stream):
        await server.run(read_stream, write_stream, server.create_initialization_options())


if __name__ == "__main__":
    import asyncio
    asyncio.run(main())
