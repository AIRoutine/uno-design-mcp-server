# Accessibility Guidelines

**Purpose:** Ensure everyone can use your application effectively, regardless of ability.

---

## Why Accessibility Matters

- **15%+ of population** has some form of disability
- **Legal requirements** in many regions (ADA, WCAG)
- **Better UX for everyone** (curb cut effect)
- **SEO benefits** for web applications
- **It's the right thing to do**

---

## Core Accessibility Principles (POUR)

### 1. Perceivable
Information must be presentable in ways users can perceive.

### 2. Operable
Interface must be operable by all users.

### 3. Understandable
Information and operation must be understandable.

### 4. Robust
Content must work with current and future technologies.

---

## Visual Accessibility

### Color Contrast

**WCAG Requirements:**
- Normal text: 4.5:1 minimum
- Large text (18pt+ or 14pt bold): 3:1 minimum
- UI components: 3:1 minimum
- Focus indicators: 3:1 minimum

**Tools to check:**
- WebAIM Contrast Checker
- Stark plugin (Figma)
- Accessibility Insights

### Color Independence

**Never rely solely on color:**
```
BAD:  Green = success, Red = error (color only)
GOOD: ✓ Success (green) / ✗ Error (red) with icons and text
```

**Add secondary indicators:**
- Icons alongside color
- Patterns or textures
- Text labels
- Shapes or borders

### Text & Typography

**Minimum sizes:**
- Body text: 16px minimum (14px absolute minimum)
- Touch labels: 12px minimum
- Line height: 1.5 for body text

**Readability:**
- Left-align body text (not justified)
- Limit line length to 80 characters
- Provide sufficient line spacing
- Use readable fonts

---

## Motor Accessibility

### Touch Targets

**Minimum sizes:**
- iOS: 44x44 points
- Android: 48x48 dp
- Desktop: 24x24 pixels minimum

**Spacing:**
- At least 8px between targets
- Edge targets need extra size

### Keyboard Navigation

**Requirements:**
- All functionality via keyboard
- Visible focus indicators
- Logical tab order
- Skip links for navigation

**Focus Indicators:**
```
Visible:    2px solid outline
Color:      High contrast with background
Shape:      Follows element shape
Offset:     2-4px from element edge
```

### Gesture Alternatives

Every gesture needs a button alternative:
```
Gesture              Button Alternative
─────────────────    ─────────────────────
Swipe to delete   →  Delete button
Pull to refresh   →  Refresh button
Pinch to zoom     →  Zoom +/- buttons
Long press        →  ... menu button
```

---

## Cognitive Accessibility

### Simplify

- Clear, simple language
- One idea per paragraph
- Bullet points over walls of text
- Consistent navigation

### Support Memory

- Show current location (breadcrumbs)
- Remember user preferences
- Auto-save form progress
- Provide history/recent items

### Reduce Errors

- Clear labels and instructions
- Inline validation with guidance
- Confirmation for destructive actions
- Easy undo/redo

### Manage Time

- No time limits when possible
- Warn before timeout
- Allow time extensions
- Save progress automatically

---

## Screen Reader Support

### Semantic Structure

```xml
<!-- Use proper heading hierarchy -->
<TextBlock Style="{StaticResource TitleLargeTextBlockStyle}">Page Title</TextBlock>
<TextBlock Style="{StaticResource TitleMediumTextBlockStyle}">Section</TextBlock>

<!-- Use semantic elements -->
<Button>Action</Button>          <!-- Not just clickable text -->
<HyperlinkButton>Link</HyperlinkButton>
```

### Labels & Descriptions

```xml
<!-- Provide accessible names -->
<Button AutomationProperties.Name="Submit form">
    <SymbolIcon Symbol="Accept"/>
</Button>

<!-- Describe images -->
<Image AutomationProperties.Name="Company logo"
       Source="logo.png"/>

<!-- Hide decorative elements -->
<Image AutomationProperties.AccessibilityView="Raw"
       Source="decorative-line.png"/>
```

### Live Regions

Announce dynamic content changes:
```xml
<TextBlock AutomationProperties.LiveSetting="Polite"
           Text="{x:Bind StatusMessage}"/>
```

### Reading Order

Ensure logical reading sequence matches visual layout.

---

## Testing Checklist

### Automated Testing
- [ ] Run accessibility scanner
- [ ] Check color contrast
- [ ] Validate heading structure
- [ ] Test with linting tools

### Manual Testing
- [ ] Keyboard-only navigation
- [ ] Screen reader walkthrough
- [ ] Zoom to 200%
- [ ] High contrast mode
- [ ] Reduced motion setting

### User Testing
- [ ] Test with users who have disabilities
- [ ] Include diverse abilities in research
- [ ] Document and fix issues

---

## Quick Reference

| Element | Requirement |
|---------|-------------|
| Text contrast | 4.5:1 (normal), 3:1 (large) |
| Touch target | 44x44pt minimum |
| Focus indicator | Visible, 3:1 contrast |
| Alt text | All meaningful images |
| Heading structure | Logical hierarchy |
| Form labels | Associated with inputs |
| Error messages | Clear and helpful |
| Keyboard access | All functionality |
| Animation | Respects reduced motion |
| Time limits | Adjustable or none |

---

## Resources

- WCAG 2.1 Guidelines: w3.org/WAI/WCAG21/quickref
- Apple Accessibility: developer.apple.com/accessibility
- Android Accessibility: developer.android.com/accessibility
- Windows Accessibility: docs.microsoft.com/accessibility
