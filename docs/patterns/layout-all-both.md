# Layout & Composition Guidelines

**Purpose:** Create balanced, functional layouts that work across mobile and desktop platforms.

---

## Layout Fundamentals

### The Grid System

**Why grids matter:**
- Consistent alignment
- Easier responsive design
- Visual harmony
- Faster design decisions

**Column Grids:**
```
Mobile (1-2 columns):
┌───────────────────┐
│ [    Content    ] │
└───────────────────┘

Tablet (2-3 columns):
┌─────────┬─────────┐
│ Content │ Content │
└─────────┴─────────┘

Desktop (4-12 columns):
┌───┬───┬───┬───┬───┬───┐
│   │   │   │   │   │   │
└───┴───┴───┴───┴───┴───┘
```

### Spacing System

**Use consistent spacing multiples:**
```
4px  - Minimal (between related elements)
8px  - Compact (internal padding)
16px - Standard (general spacing)
24px - Comfortable (section separation)
32px - Spacious (major sections)
48px - Large (page-level separation)
64px - Extra large (hero sections)
```

**Rule:** Pick 4-6 values and use only those.

---

## Layout Patterns

### Z-Pattern Layout

```
┌─────────────────────────────────┐
│ Logo ─────────────────── Action │  1 → 2
│                                 │    ↘
│         Hero Content            │
│                                 │    ↙
│ Info ────────────────────  CTA  │  3 → 4
└─────────────────────────────────┘
```

**Use for:** Landing pages, marketing pages, simple UIs

### F-Pattern Layout

```
┌─────────────────────────────────┐
│ Header ─────────────────────────│ ← Scan
├─────────────────────────────────┤
│ Title ──────────────            │ ← Scan
│ Content Content Content Content │
│ Subheading ───────              │ ← Scan
│ Content Content Content Content │
└─────────────────────────────────┘
```

**Use for:** Content-heavy pages, articles, dashboards

### Card Grid Layout

```
┌─────────────────────────────────────────┐
│ ┌─────────┐ ┌─────────┐ ┌─────────┐     │
│ │  Card   │ │  Card   │ │  Card   │     │
│ └─────────┘ └─────────┘ └─────────┘     │
│ ┌─────────┐ ┌─────────┐ ┌─────────┐     │
│ │  Card   │ │  Card   │ │  Card   │     │
│ └─────────┘ └─────────┘ └─────────┘     │
└─────────────────────────────────────────┘
```

**Use for:** Dashboards, galleries, product listings

### Split Layout

```
┌─────────────────┬─────────────────┐
│                 │                 │
│   Left Panel    │   Right Panel   │
│    (Fixed)      │   (Content)     │
│                 │                 │
└─────────────────┴─────────────────┘
```

**Use for:** Login pages, onboarding, email clients

---

## Responsive Strategies

### Stack on Mobile

Desktop:
```
┌───────────┬───────────┬───────────┐
│  Column 1 │  Column 2 │  Column 3 │
└───────────┴───────────┴───────────┘
```

Mobile:
```
┌─────────────────────┐
│      Column 1       │
├─────────────────────┤
│      Column 2       │
├─────────────────────┤
│      Column 3       │
└─────────────────────┘
```

### Reflow Content

Desktop:
```
┌─────────────────────────────────────┐
│ Image │ Title and description text  │
│       │ that wraps across multiple  │
│       │ lines next to the image.    │
└─────────────────────────────────────┘
```

Mobile:
```
┌─────────────────────┐
│       Image         │
├─────────────────────┤
│ Title and desc      │
│ text below image    │
└─────────────────────┘
```

### Hide/Show Elements

**Desktop shows more:**
- Sidebar navigation
- Preview panes
- Extended information
- More columns

**Mobile hides/simplifies:**
- Sidebar → hamburger menu
- Preview → navigate to detail
- Extended info → expandable
- Many columns → swipeable

---

## Content Areas

### Header

```
┌─────────────────────────────────────────────┐
│ [Logo]  Navigation...           [User] [☰]  │
└─────────────────────────────────────────────┘
```

**Contains:** Branding, navigation, search, user actions
**Height:** 48-64px mobile, 56-72px desktop

### Main Content

```
┌─────────────────────────────────────────────┐
│                                             │
│              Primary Content                │
│                                             │
│  Maximum width: 1200-1400px (centered)      │
│  Minimum margins: 16px mobile, 24px desktop │
│                                             │
└─────────────────────────────────────────────┘
```

### Sidebar

```
┌──────┬────────────────────────────────────┐
│ Side │                                    │
│ bar  │          Main Content              │
│      │                                    │
│ Nav  │                                    │
│ or   │                                    │
│ Info │                                    │
└──────┴────────────────────────────────────┘
```

**Width:** 240-320px typically
**Behavior:** Fixed, sticky, or collapsible

### Footer

```
┌─────────────────────────────────────────────┐
│ Links    |    Links    |    Links          │
│                                             │
│ Copyright © 2024  |  Privacy  |  Terms     │
└─────────────────────────────────────────────┘
```

---

## Alignment & Balance

### Visual Balance

**Symmetrical (formal):**
```
        ┌───────────┐
        │   Title   │
        └───────────┘
    ┌────┐      ┌────┐
    │    │      │    │
    └────┘      └────┘
```

**Asymmetrical (dynamic):**
```
┌───────────────┐
│   Large       │    ┌───┐
│   Element     │    │   │
│               │    └───┘
└───────────────┘
```

### Alignment Rules

1. **Align to grid:** Elements should snap to grid lines
2. **Consistent edges:** Left edges align, right edges align
3. **Optical alignment:** Sometimes mathematical alignment looks wrong
4. **Group alignment:** Related elements share alignment

### White Space

**Types:**
- **Micro:** Between letters/words (typography)
- **Small:** Between elements in a group
- **Medium:** Between groups/sections
- **Large:** Between major page areas

**Rules:**
- More space = more importance
- Less space = more relationship
- Consistent spacing creates rhythm
- White space is not "empty" - it's design

---

## Common Layout Mistakes

### 1. Inconsistent Spacing
```
BAD:
┌──────────────────┐
│ Element          │  20px
│ Element          │  12px  ← Inconsistent
│ Element          │  24px
└──────────────────┘

GOOD:
┌──────────────────┐
│ Element          │  16px
│ Element          │  16px  ← Consistent
│ Element          │  16px
└──────────────────┘
```

### 2. No Visual Hierarchy

```
BAD:                    GOOD:
┌────────────────┐     ┌────────────────┐
│ Text           │     │ TITLE          │
│ Text           │     │ Text           │
│ Text           │     │ [Action]       │
└────────────────┘     └────────────────┘
```

### 3. Trapped White Space

```
BAD:
┌─────────────────────────────┐
│ ┌─────┐     ┌─────┐         │
│ │     │     │     │         │
│ └─────┘     └─────┘         │  ← Trapped space
│         ┌─────┐             │     looks accidental
│         │     │             │
│         └─────┘             │
└─────────────────────────────┘

GOOD:
┌─────────────────────────────┐
│ ┌─────┐ ┌─────┐ ┌─────┐     │
│ │     │ │     │ │     │     │  ← Intentional
│ └─────┘ └─────┘ └─────┘     │     alignment
└─────────────────────────────┘
```

### 4. Content Too Wide

```
BAD:  Line length > 100 characters (hard to read)
GOOD: Line length 50-75 characters (optimal)

Max-width: 600-800px for text content
```

---

## Responsive Breakpoints

**Recommended breakpoints:**
| Name | Min Width | Use Case |
|------|-----------|----------|
| Phone | 0 | Single column |
| Phone Landscape | 480px | Slightly wider |
| Tablet | 768px | Two columns |
| Desktop | 1024px | Full layout |
| Wide Desktop | 1440px | Extra space |

**Design approach:**
1. Design mobile first
2. Add complexity at each breakpoint
3. Test at each breakpoint
4. Consider orientation changes
