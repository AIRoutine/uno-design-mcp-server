# Affordance in UI Design

**Purpose:** Make interactive elements look interactive, so users intuitively know how to use them.

---

## What is Affordance?

Affordance is the quality of an object that suggests how it should be used.

**Real world examples:**
- Door handles afford pulling
- Flat plates afford pushing
- Chairs afford sitting
- Buttons afford pressing

**Digital examples:**
- Raised buttons afford clicking
- Text fields with borders afford typing
- Sliders afford dragging
- Checkboxes afford toggling

---

## Types of Affordances

### 1. Explicit Affordance
Clearly shows how to interact.

```
┌─────────────────┐
│   Click Here    │  ← Button shape + label
└─────────────────┘
```

### 2. Pattern Affordance
Uses learned conventions.

```
☰  ← Hamburger menu (learned pattern)
🔍  ← Search (universal symbol)
✕  ← Close (standard convention)
```

### 3. Hidden Affordance
Revealed on interaction.

```
Hover: Tooltip appears
Long press: Context menu
Swipe: Delete action reveals
```

### 4. False Affordance (Anti-pattern)
Looks interactive but isn't.

```
Underlined text that's not a link  ← Confusing
Image that looks like a button    ← Frustrating
```

---

## Visual Cues for Affordance

### Buttons

**Make buttons look pressable:**

```
GOOD: Elevated/shadowed
┌──────────────────┐
│      Save       │  + shadow
└──────────────────┘

GOOD: Filled with contrast
████████████████████
█      Save        █
████████████████████

GOOD: Bordered
┌──────────────────┐
│      Save        │
└──────────────────┘

BAD: Flat, no distinction
      Save            ← Looks like text
```

**State changes:**
```
Default:  Normal appearance
Hover:    Slightly elevated/lighter (desktop)
Pressed:  Depressed/darker
Disabled: Faded, no shadow
```

### Input Fields

**Make fields look fillable:**

```
GOOD: Clear boundary
┌─────────────────────────┐
│ Enter your name...      │
└─────────────────────────┘

GOOD: Underlined (Material style)
Enter your name...
────────────────────────────

BAD: No boundary
Enter your name...         ← Is this editable?
```

### Links

**Make links look clickable:**

```
GOOD: Underlined + colored
Learn more about our services

GOOD: Colored + icon
Learn more →

BAD: Just colored (color-blind unfriendly)
Learn more about our services

BAD: No visual distinction
Learn more about our services  ← Is this a link?
```

### Draggable Elements

**Show drag affordance:**

```
GOOD: Grip handle
⋮⋮ Item name                    ← Dots suggest dragging

GOOD: Move cursor on hover
(cursor: move when hovering)

GOOD: Visual lift on drag
Item appears elevated during drag
```

### Toggles & Switches

**Show state clearly:**

```
ON:   ●━━━━━━━━━━━●  (filled, right)
OFF:  ○━━━━━━━━━━━○  (empty, left)

Checkboxes:
☑ Selected    (filled)
☐ Unselected  (empty)
```

---

## Platform Conventions

### iOS
- Rounded rectangles for buttons
- Blue for interactive elements
- Swipe gestures standard
- Bottom tab navigation

### Android (Material)
- FAB (Floating Action Button)
- Ripple effect on touch
- Elevation/shadow system
- Navigation drawer

### Windows (Fluent)
- Acrylic/transparency
- Reveal highlight on hover
- Command bars
- Hamburger navigation

### Web
- Underlined links
- Cursor changes
- Hover states
- Focus outlines

---

## Common Affordance Mistakes

### 1. Invisible Actions

```
BAD:  Empty space that's actually a button
GOOD: Visible button with clear boundaries
```

### 2. Misleading Visuals

```
BAD:  Image that looks clickable but isn't
GOOD: Decorative images should look decorative
```

### 3. Hidden Gestures

```
BAD:  Only way to delete is swipe (no visual hint)
GOOD: Swipe reveals delete, OR visible delete button
```

### 4. Inconsistent Patterns

```
BAD:  Some cards clickable, some not (look same)
GOOD: Clickable cards have visual distinction
```

### 5. Disabled Without Indication

```
BAD:  Button looks normal but doesn't work
GOOD: Disabled button is visually muted
```

---

## Affordance Audit

For every interactive element, ask:

1. **Can users see it's interactive?**
   - Is there visual distinction?
   - Does it follow conventions?

2. **Do users know what will happen?**
   - Is the action clear?
   - Is there a label or icon?

3. **Is the current state visible?**
   - Can users see if it's on/off?
   - Can they see if it's selected?

4. **Is feedback immediate?**
   - Does it respond to hover?
   - Does it respond to press?

---

## Testing Affordance

### First-Click Test
Show design to new users, ask them to complete a task.
Where do they click first?

### 5-Second Test
Show design for 5 seconds.
Can users identify the main action?

### Observation
Watch users interact.
Do they hesitate? Click wrong things?

### Cursor Tracking
Where do users move their mouse?
What do they hover over?

---

## Quick Reference

| Element | Affordance Cues |
|---------|-----------------|
| Button | Shadow, fill, border, shape |
| Link | Underline, color, icon |
| Input | Border, placeholder, label |
| Toggle | Track, thumb, state color |
| Drag | Handle, grip dots, cursor |
| Slider | Track, handle, value |
| Dropdown | Arrow indicator |
| Tab | Selection indicator |
