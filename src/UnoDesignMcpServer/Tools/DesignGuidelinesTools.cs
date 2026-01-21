using System.ComponentModel;
using ModelContextProtocol.Server;
using UnoDesignMcpServer.Services;

namespace UnoDesignMcpServer.Tools;

/// <summary>
/// MCP Tools for UI/UX design guidelines for Uno Platform applications.
/// </summary>
[McpServerToolType]
public class DesignGuidelinesTools
{
    private readonly ContentLoaderService _loader;

    public DesignGuidelinesTools(ContentLoaderService loader)
    {
        _loader = loader;
    }

    [McpServerTool(Name = "design_principles")]
    [Description("Get core UI/UX design principles for Uno Platform apps. Topics: visual-hierarchy, consistency, feedback, accessibility, simplicity, affordance, all")]
    public string GetDesignPrinciples(
        [Description("Design principle topic: visual-hierarchy, consistency, feedback, accessibility, simplicity, affordance, or all")]
        string topic)
    {
        return _loader.LoadDocs($"principles/{topic}.md");
    }

    [McpServerTool(Name = "layout_patterns")]
    [Description("Get layout patterns and composition guidelines. Categories: navigation, content-areas, grids, responsive, spacing, all")]
    public string GetLayoutPatterns(
        [Description("Layout pattern category: navigation, content-areas, grids, responsive, spacing, or all")]
        string category,
        [Description("Target platform: mobile, desktop, or both (default: both)")]
        string platform = "both")
    {
        return _loader.LoadDocs($"patterns/layout-{category}-{platform}.md");
    }

    [McpServerTool(Name = "component_guidelines")]
    [Description("Get design guidelines for UI components. Components: buttons, inputs, cards, lists, dialogs, navigation, forms, all")]
    public string GetComponentGuidelines(
        [Description("UI component type: buttons, inputs, cards, lists, dialogs, navigation, forms, or all")]
        string component)
    {
        return _loader.LoadDocs($"components/{component}.md");
    }

    [McpServerTool(Name = "color_guidelines")]
    [Description("Get color theory and palette guidelines for app design.")]
    public string GetColorGuidelines(
        [Description("Color aspect: theory, palettes, semantic, contrast, dark-mode, or all")]
        string aspect)
    {
        return _loader.LoadResources($"colors/{aspect}.md");
    }

    [McpServerTool(Name = "typography_guidelines")]
    [Description("Get typography best practices and type scale recommendations.")]
    public string GetTypographyGuidelines(
        [Description("Typography aspect: type-scale, hierarchy, readability, pairing, responsive, or all")]
        string aspect)
    {
        return _loader.LoadResources($"typography/{aspect}.md");
    }

    [McpServerTool(Name = "user_flow_patterns")]
    [Description("Get common user flow patterns and interaction design guidelines.")]
    public string GetUserFlowPatterns(
        [Description("Type of user flow: onboarding, authentication, checkout, settings, search, crud, or all")]
        string flowType)
    {
        return _loader.LoadDocs($"flows/{flowType}.md");
    }

    [McpServerTool(Name = "mobile_patterns")]
    [Description("Get mobile-specific design patterns and touch interaction guidelines.")]
    public string GetMobilePatterns(
        [Description("Mobile pattern category: touch-targets, gestures, bottom-navigation, pull-refresh, swipe-actions, or all")]
        string pattern)
    {
        return _loader.LoadDocs($"patterns/mobile-{pattern}.md");
    }

    [McpServerTool(Name = "desktop_patterns")]
    [Description("Get desktop-specific design patterns for keyboard, mouse, and window management.")]
    public string GetDesktopPatterns(
        [Description("Desktop pattern category: keyboard-navigation, mouse-interactions, window-management, menu-patterns, toolbar-patterns, or all")]
        string pattern)
    {
        return _loader.LoadDocs($"patterns/desktop-{pattern}.md");
    }

    [McpServerTool(Name = "design_checklist")]
    [Description("Get a design review checklist for evaluating UI/UX quality.")]
    public string GetDesignChecklist(
        [Description("Design phase to check: wireframe, visual-design, prototype, final-review, or all")]
        string phase)
    {
        return _loader.LoadDocs($"principles/checklist-{phase}.md");
    }

    [McpServerTool(Name = "accessibility_guidelines")]
    [Description("Get comprehensive accessibility guidelines for inclusive design.")]
    public string GetAccessibilityGuidelines(
        [Description("Accessibility category: visual, motor, cognitive, screen-readers, or all")]
        string category)
    {
        return _loader.LoadDocs($"principles/accessibility-{category}.md");
    }

    // EFFICIENCY-FOCUSED TOOLS - AUTO-TRIGGER FOR UI DESIGN

    [McpServerTool(Name = "efficiency_principles")]
    [Description("REQUIRED: Consult FIRST when designing ANY UI screen. Provides click-budget guidelines (daily tasks: 1-2 clicks, weekly: 3-4, rare: 5+), lean design philosophy, and efficiency metrics. Auto-use for: home screens, dashboards, main user flows, any new page design.")]
    public string GetEfficiencyPrinciples(
        [Description("Efficiency principle: all")]
        string principle = "all")
    {
        return _loader.LoadDocs("philosophy/efficiency-first.md");
    }

    [McpServerTool(Name = "ux_laws")]
    [Description("REQUIRED: Consult when designing navigation, buttons, menus, or option lists. Provides Hick's Law (max 5-7 choices), Fitts's Law (target sizes ≥48dp), Miller's Law (chunk into 4±1 groups), Doherty Threshold (<400ms response). Auto-use for: menus, toolbars, forms, any interactive elements.")]
    public string GetUxLaws(
        [Description("UX law: hicks, fitts, miller, doherty, or all")]
        string law = "all")
    {
        if (law == "all")
            return _loader.LoadDocs("laws/all.md");
        return _loader.LoadDocs($"laws/{law}-law.md");
    }

    [McpServerTool(Name = "cognitive_load")]
    [Description("REQUIRED: Consult when designing forms, wizards, settings, or multi-step flows. Provides progressive disclosure patterns, chunking strategies, and the 4-question framework (Remove→Automate→Combine→Hide). Auto-use for: registration, onboarding, data entry, configuration screens.")]
    public string GetCognitiveLoad(
        [Description("Cognitive load aspect: reduction, progressive-disclosure, or all")]
        string aspect = "all")
    {
        if (aspect == "progressive-disclosure")
            return _loader.LoadDocs("cognitive/progressive-disclosure.md");
        return _loader.LoadDocs("cognitive/load-reduction.md");
    }

    [McpServerTool(Name = "task_optimization")]
    [Description("REQUIRED: Consult when defining user flows or task sequences. Provides click budgets by frequency (daily/weekly/monthly), task flow analysis methods, and optimization patterns. Auto-use for: core user journeys, checkout flows, CRUD operations.")]
    public string GetTaskOptimization(
        [Description("Type of task to optimize: all")]
        string taskType = "all")
    {
        return _loader.LoadDocs("optimization/task-flows.md");
    }

    [McpServerTool(Name = "responsive_system")]
    [Description("REQUIRED: Consult when designing screens for multiple device sizes. Provides concrete breakpoints (Compact 0-599px, Medium 600-839px, Expanded 840-1199px, Large 1200px+) and touch target minimums (44-48dp). Auto-use for: any adaptive/responsive layout, cross-platform screens.")]
    public string GetResponsiveSystem(
        [Description("Responsive aspect: breakpoints, touch-targets, or all")]
        string aspect = "all")
    {
        if (aspect == "breakpoints")
            return _loader.LoadDocs("responsive/breakpoints.md");
        if (aspect == "touch-targets")
            return _loader.LoadDocs("responsive/touch-targets.md");

        // Combine both for "all"
        var breakpoints = _loader.LoadDocs("responsive/breakpoints.md");
        var touchTargets = _loader.LoadDocs("responsive/touch-targets.md");
        return breakpoints + "\n\n---\n\n" + touchTargets;
    }

    [McpServerTool(Name = "platform_efficiency")]
    [Description("REQUIRED: Consult based on target platform. Mobile: thumb zone optimization, bottom navigation, gesture patterns. Desktop: keyboard shortcuts, multi-panel layouts, hover states. Auto-use for: platform-specific screen designs, mobile-first or desktop-first approaches.")]
    public string GetPlatformEfficiency(
        [Description("Target platform: mobile or desktop")]
        string platform)
    {
        return _loader.LoadDocs($"platforms/{platform}-efficiency.md");
    }
}
