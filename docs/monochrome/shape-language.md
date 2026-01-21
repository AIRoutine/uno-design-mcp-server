# Shape Language for Monochrome Design

**When color is absent, form carries meaning.**

---

## Shape Hierarchy

### Primary Shapes and Their Meanings

```
┌─────────────────┐     Rectangle (Sharp)
│                 │     = Structure, formal, container
│                 │     Use: Cards, panels, inputs
└─────────────────┘

┌─────────────────┐     Rectangle (Rounded 4-8dp)
│                 │     = Friendly, interactive, clickable
│                 │     Use: Buttons, chips, tags
╰─────────────────╯

╭─────────────────╮     Rectangle (Rounded 12-16dp)
│                 │     = Soft, approachable, modal
│                 │     Use: Dialogs, tooltips, cards
╰─────────────────╯

      ╭────╮            Pill (Full radius)
      │    │            = Action, token, removable
      ╰────╯            Use: Tags, filters, badges

        ●               Circle
                        = Avatar, status, icon container
                        Use: Profile pics, radio buttons, FAB
```

---

## Border Language

### Line Weight Meanings

| Weight | Meaning | Use Case |
|--------|---------|----------|
| 1px | Subtle, decorative | Dividers, inactive borders |
| 2px | Standard, interactive | Buttons, inputs, cards |
| 3px | Emphasis, important | Selected states, focus rings |
| 4px | Critical, blocking | Error states, warnings |

### Border Styles

```
Solid ─────────────   Standard containers, buttons
Dashed - - - - - -    Drop zones, optional areas
Dotted ···········    Help indicators, guides
Double ═══════════    Reserved, special sections
```

---

## Corner Radius Scale

```
0dp    Sharp       Data tables, code blocks, technical UI
4dp    Subtle      Input fields, standard buttons
8dp    Friendly    Cards, containers, dialogs
12dp   Soft        Modals, notifications
16dp   Rounded     Feature cards, hero elements
999dp  Pill        Tags, badges, chips, avatar masks
```

**Rule:** Pick ONE radius per element type and use it consistently.

---

## Elevation Through Shadows

Without color, depth comes from shadows:

### Shadow Scale (Monochrome)

```
Level 0: None
         Flat elements, inline content

Level 1: 0 1px 2px rgba(0,0,0,0.10)
         Subtle lift, hover states

Level 2: 0 2px 4px rgba(0,0,0,0.12)
         Cards, dropdowns

Level 3: 0 4px 8px rgba(0,0,0,0.14)
         Modals, popovers

Level 4: 0 8px 16px rgba(0,0,0,0.16)
         Dialogs, overlays

Level 5: 0 16px 32px rgba(0,0,0,0.20)
         Full-screen overlays, critical modals
```

---

## Patterns for Differentiation

When you need to distinguish categories without color:

### Fill Patterns

```
Solid     ████████████   Primary, active
Lines-H   ════════════   Secondary category
Lines-V   ║║║║║║║║║║║║   Tertiary category
Diagonal  ╲╲╲╲╲╲╲╲╲╲╲╲   Warning, attention
Dots      ● ● ● ● ● ●   Disabled, inactive
Cross     ╬╬╬╬╬╬╬╬╬╬╬╬   Blocked, unavailable
```

### Visual Encoding Alternatives

| Instead of Color | Use |
|-----------------|-----|
| Red/Green/Blue categories | Shape: Square/Circle/Triangle |
| Color-coded status | Icon + Text label |
| Colored badges | Border weight + Fill pattern |
| Accent highlights | Invert (black bg, white text) |

---

## Icon Guidelines

### Stroke Weight Consistency

```
Small icons (16-20dp):  1.5px stroke
Medium icons (24dp):    2px stroke
Large icons (32-48dp):  2.5px stroke
```

### Icon States

| State | Treatment |
|-------|-----------|
| Default | Gray-600 #757575 |
| Hover | Gray-900 #212121 |
| Active | Black #000000 |
| Disabled | Gray-400 #BDBDBD |
| Selected | Black fill (inverted) |

---

## Size Hierarchy

Without color emphasis, size carries weight:

```
              ┌─────────────────────────────────────┐
              │     HERO ELEMENT                    │
              │     Most important                  │
              └─────────────────────────────────────┘
        ┌──────────────────────┐  ┌──────────────────────┐
        │  Primary Card        │  │  Primary Card        │
        │  Important           │  │  Important           │
        └──────────────────────┘  └──────────────────────┘
  ┌────────────┐ ┌────────────┐ ┌────────────┐ ┌────────────┐
  │ Secondary  │ │ Secondary  │ │ Secondary  │ │ Secondary  │
  │ Less imp.  │ │ Less imp.  │ │ Less imp.  │ │ Less imp.  │
  └────────────┘ └────────────┘ └────────────┘ └────────────┘
```

**Rule:** Importance = Size. No exceptions.

---

## Applying Shape Language

### Buttons

```
Primary:    ┌─────────────┐   Black fill, white text, 4dp radius
            │   ACTION    │
            └─────────────┘

Secondary:  ┌─────────────┐   White fill, black border (2px), 4dp radius
            │   ACTION    │
            └─────────────┘

Tertiary:      ACTION        No background, underline on hover

Destructive:┌─────────────┐   Black fill, white text, 4px border
            ║   DELETE    ║   (thicker border = danger)
            └─────────────┘
```

### Cards

```
Standard:   ┌─────────────────────────────────┐
            │ Content                         │
            │                                 │
            └─────────────────────────────────┘
            1px border, 8dp radius, Level 1 shadow

Featured:   ╔═════════════════════════════════╗
            ║ Featured Content                ║
            ║                                 ║
            ╚═════════════════════════════════╝
            2px border, 12dp radius, Level 2 shadow
```

### Inputs

```
Default:    ┌─────────────────────────────────┐
            │ Placeholder text                │
            └─────────────────────────────────┘
            1px Gray-300 border, 4dp radius

Focused:    ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓
            ┃ Input text                      ┃
            ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛
            2px Black border, 4dp radius

Error:      ┌─────────────────────────────────┐
            │ Invalid input                   │
            └─────────────────────────────────┘
            ⚠ Error message below
            2px border (dashed), icon indicator
```
