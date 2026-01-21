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
}
