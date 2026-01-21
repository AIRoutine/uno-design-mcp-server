using System.ComponentModel;
using ModelContextProtocol.Server;
using UnoDesignMcpServer.Services;

namespace UnoDesignMcpServer.Tools;

/// <summary>
/// MCP Tools for Monochrome Efficiency Design System.
/// All tools are parameter-free - this is THE opinionated design system.
/// </summary>
[McpServerToolType]
public class DesignGuidelinesTools
{
    private readonly ContentLoaderService _loader;

    public DesignGuidelinesTools(ContentLoaderService loader)
    {
        _loader = loader;
    }

    // ═══════════════════════════════════════════════════════════════════════════
    // CORE EFFICIENCY TOOLS (Auto-trigger for ANY UI design)
    // ═══════════════════════════════════════════════════════════════════════════

    [McpServerTool(Name = "efficiency_principles")]
    [Description("REQUIRED: Consult FIRST when designing ANY UI. Provides click-budget guidelines (daily tasks: 1-2 clicks, weekly: 3-4, rare: 5+), lean design philosophy, and the efficiency manifesto. Auto-use for: home screens, dashboards, main user flows, any new page design.")]
    public string GetEfficiencyPrinciples()
    {
        return _loader.LoadDocs("philosophy/efficiency-first.md");
    }

    [McpServerTool(Name = "ux_laws")]
    [Description("REQUIRED: Consult when designing navigation, buttons, menus, or option lists. Provides Hick's Law (max 5-7 choices), Fitts's Law (targets 48dp+), Miller's Law (chunk into 4±1 groups), Doherty Threshold (<400ms response). Auto-use for: menus, toolbars, forms, interactive elements.")]
    public string GetUxLaws()
    {
        return _loader.LoadDocs("laws/all.md");
    }

    [McpServerTool(Name = "cognitive_load")]
    [Description("REQUIRED: Consult when designing forms, wizards, settings, or multi-step flows. Provides progressive disclosure patterns, chunking strategies, and the 4-question framework (Remove, Automate, Combine, Hide). Auto-use for: registration, onboarding, data entry, configuration.")]
    public string GetCognitiveLoad()
    {
        var loadReduction = _loader.LoadDocs("cognitive/load-reduction.md");
        var progressiveDisclosure = _loader.LoadDocs("cognitive/progressive-disclosure.md");
        return loadReduction + "\n\n---\n\n" + progressiveDisclosure;
    }

    // ═══════════════════════════════════════════════════════════════════════════
    // MONOCHROME DESIGN SYSTEM (The only visual system)
    // ═══════════════════════════════════════════════════════════════════════════

    [McpServerTool(Name = "monochrome_system")]
    [Description("REQUIRED: The monochrome palette and philosophy. Returns the fixed 12-stop grayscale (#FFFFFF to #000000), usage rules, contrast requirements, and the monochrome manifesto. This is THE color system - no alternatives. Auto-use for: any visual design, color decisions, theming.")]
    public string GetMonochromeSystem()
    {
        var manifesto = _loader.LoadDocs("philosophy/monochrome-manifesto.md");
        var palette = _loader.LoadResources("monochrome/palette.md");
        return manifesto + "\n\n---\n\n" + palette;
    }

    [McpServerTool(Name = "contrast_system")]
    [Description("REQUIRED: Contrast rules for monochrome design. Provides WCAG AAA compliant contrast ratios, text hierarchy (Black for headlines, Gray-700 for body), surface layering, and focus indicator guidelines. Auto-use for: text styling, accessibility checks, dark mode.")]
    public string GetContrastSystem()
    {
        return _loader.LoadDocs("monochrome/contrast-system.md");
    }

    [McpServerTool(Name = "shape_language")]
    [Description("REQUIRED: Form-based visual hierarchy without color. Provides shape meanings (rectangles, pills, circles), border weights (1-4px), corner radius scale (0-999dp), shadow elevation (5 levels), and pattern alternatives for color-coded categories. Auto-use for: component design, visual differentiation.")]
    public string GetShapeLanguage()
    {
        return _loader.LoadDocs("monochrome/shape-language.md");
    }

    // ═══════════════════════════════════════════════════════════════════════════
    // LAYOUT & RESPONSIVE SYSTEM
    // ═══════════════════════════════════════════════════════════════════════════

    [McpServerTool(Name = "responsive_system")]
    [Description("REQUIRED: Breakpoints and responsive design. Provides fixed breakpoints (Compact 0-599px, Medium 600-839px, Expanded 840-1199px, Large 1200px+), touch target minimums (44-48dp), and adaptive layout rules. Auto-use for: any responsive layout, cross-platform screens.")]
    public string GetResponsiveSystem()
    {
        var breakpoints = _loader.LoadDocs("responsive/breakpoints.md");
        var touchTargets = _loader.LoadDocs("responsive/touch-targets.md");
        return breakpoints + "\n\n---\n\n" + touchTargets;
    }

    [McpServerTool(Name = "layout_patterns")]
    [Description("REQUIRED: Layout composition and spacing. Provides navigation patterns, content area organization, grid systems, and the 4dp/8dp spacing scale. Auto-use for: page structure, navigation design, content organization.")]
    public string GetLayoutPatterns()
    {
        return _loader.LoadDocs("patterns/layout-all-both.md");
    }

    // ═══════════════════════════════════════════════════════════════════════════
    // TYPOGRAPHY & COMPONENTS
    // ═══════════════════════════════════════════════════════════════════════════

    [McpServerTool(Name = "typography_system")]
    [Description("REQUIRED: Typography for monochrome hierarchy. Without color, type weight and size carry meaning. Provides type scale, hierarchy rules (Display to Caption), readability guidelines, and font pairing. Auto-use for: text styling, heading hierarchy, readability.")]
    public string GetTypographySystem()
    {
        return _loader.LoadResources("typography/all.md");
    }

    [McpServerTool(Name = "component_guidelines")]
    [Description("REQUIRED: UI component patterns for monochrome design. Provides button styles (primary black, secondary outlined), input states, card variations, list patterns, and dialog guidelines - all in grayscale. Auto-use for: building UI components, interaction design.")]
    public string GetComponentGuidelines()
    {
        return _loader.LoadDocs("components/all.md");
    }
}
