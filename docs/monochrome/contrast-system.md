# Monochrome Contrast System

**Hierarchy Through Light and Dark - WCAG AAA Compliant**

---

## The Contrast Scale

In monochrome design, contrast IS the design system.

```
Maximum:  BLACK on WHITE         21:1    Headlines, CTAs, critical
High:     Gray-900 on WHITE      15:1    Primary text, titles
Strong:   Gray-800 on WHITE      9.7:1   Subheadings, labels
Standard: Gray-700 on WHITE      6.3:1   Body text, paragraphs
Moderate: Gray-600 on WHITE      4.6:1   Secondary text, captions
Subtle:   Gray-500 on WHITE      3.5:1   Hints, decorative (large only)
```

**Minimum Requirements:**
- Body text: 7:1 (WCAG AAA)
- Large text (18pt+): 4.5:1 (WCAG AAA)
- UI components: 3:1

---

## Text Contrast Hierarchy

### Headlines & Titles

```
┌────────────────────────────────────────────────────────┐
│  DISPLAY HEADLINE                                      │
│  Black #000000 on White                                │
│  Font: Bold, 32-48px                                   │
│  Contrast: 21:1                                        │
└────────────────────────────────────────────────────────┘

┌────────────────────────────────────────────────────────┐
│  Page Title                                            │
│  Gray-900 #212121 on White                             │
│  Font: Semi-bold, 24-32px                              │
│  Contrast: 15.2:1                                      │
└────────────────────────────────────────────────────────┘

┌────────────────────────────────────────────────────────┐
│  Section Header                                        │
│  Gray-800 #424242 on White                             │
│  Font: Medium, 18-24px                                 │
│  Contrast: 9.7:1                                       │
└────────────────────────────────────────────────────────┘
```

### Body & Supporting Text

```
Body Text (Gray-700 #616161)
This is the standard text color for paragraphs, descriptions,
and general content. It provides excellent readability at 6.3:1
contrast while being softer than pure black.

Secondary Text (Gray-500 #9E9E9E)
Captions, timestamps, helper text - less prominent
but still legible. Use at 14px+ only. Contrast: 3.5:1

Disabled (Gray-400 #BDBDBD)
Intentionally low contrast to indicate non-interactive state.
Never use for important information.
```

---

## Surface Contrast Layers

### Light Mode Surfaces

```
Layer 0 - Background
┌──────────────────────────────────────────────────────────────┐
│  Gray-50 #FAFAFA                                             │
│                                                              │
│    Layer 1 - Primary Surface                                 │
│    ┌──────────────────────────────────────────────────────┐  │
│    │  White #FFFFFF                                       │  │
│    │                                                      │  │
│    │    Layer 2 - Elevated Content                        │  │
│    │    ┌──────────────────────────────────────────────┐  │  │
│    │    │  Gray-50 #FAFAFA (or shadow for elevation)   │  │  │
│    │    └──────────────────────────────────────────────┘  │  │
│    │                                                      │  │
│    └──────────────────────────────────────────────────────┘  │
│                                                              │
└──────────────────────────────────────────────────────────────┘
```

### Dark Mode Surfaces (Inverted System)

```
Layer 0 - Background
┌──────────────────────────────────────────────────────────────┐
│  #121212 (Near Black)                                        │
│                                                              │
│    Layer 1 - Primary Surface                                 │
│    ┌──────────────────────────────────────────────────────┐  │
│    │  #1E1E1E                                             │  │
│    │                                                      │  │
│    │    Layer 2 - Elevated Content                        │  │
│    │    ┌──────────────────────────────────────────────┐  │  │
│    │    │  #232323                                     │  │  │
│    │    └──────────────────────────────────────────────┘  │  │
│    │                                                      │  │
│    └──────────────────────────────────────────────────────┘  │
│                                                              │
└──────────────────────────────────────────────────────────────┘

Text on Dark:
Primary:   White at 87% opacity (#DEDEDE effective)
Secondary: White at 60% opacity (#999999 effective)
Disabled:  White at 38% opacity (#616161 effective)
```

---

## Interactive Element Contrast

### Buttons

```
Primary Button (Inverted for prominence):
┌──────────────────────────────────────┐
│  ████████████████████████████████████ │  Background: Black
│  ██      BUTTON TEXT           ██████ │  Text: White
│  ████████████████████████████████████ │  Contrast: 21:1
└──────────────────────────────────────┘

Secondary Button (Outlined):
┌──────────────────────────────────────┐
│  ┌────────────────────────────────┐  │  Background: White
│  │       BUTTON TEXT              │  │  Border: Black 2px
│  └────────────────────────────────┘  │  Text: Black
└──────────────────────────────────────┘  Contrast: 21:1
```

### Form Inputs

```
State        Border          Background    Text
─────────────────────────────────────────────────────
Default      Gray-300        White         Gray-700
Focused      Black (2px)     White         Gray-900
Filled       Gray-400        White         Gray-900
Error        Black (2px)     Gray-50       Gray-900
Disabled     Gray-200        Gray-100      Gray-400
```

### Focus Indicators

**Must be highly visible - 3:1 minimum against adjacent colors**

```
Focus Ring Options:
1. Solid: 2px Black outline, 2px offset
2. Double: 2px Black + 2px White (for any background)
3. Invert: Swap foreground/background colors
```

---

## Contrast Calculation Reference

```
Relative Luminance Formula:
L = 0.2126 × R + 0.7152 × G + 0.0722 × B

Contrast Ratio:
CR = (L1 + 0.05) / (L2 + 0.05)
where L1 = lighter color, L2 = darker color
```

### Quick Reference Table

| Foreground | Background | Ratio | WCAG |
|------------|------------|-------|------|
| #000000 | #FFFFFF | 21.0:1 | AAA |
| #212121 | #FFFFFF | 15.2:1 | AAA |
| #424242 | #FFFFFF | 9.7:1 | AAA |
| #616161 | #FFFFFF | 6.3:1 | AAA |
| #757575 | #FFFFFF | 4.6:1 | AA |
| #9E9E9E | #FFFFFF | 3.5:1 | Large only |
| #BDBDBD | #FFFFFF | 2.2:1 | Fail |
| #FFFFFF | #121212 | 18.1:1 | AAA |
| #FFFFFF | #1E1E1E | 15.5:1 | AAA |
| #FFFFFF | #424242 | 9.7:1 | AAA |

---

## The Golden Rules

1. **Body text minimum: Gray-700 on White** (6.3:1)
2. **Headlines: Gray-900 or Black** (15:1+)
3. **Never use Gray-400 or lighter for readable text**
4. **Focus states must be visible on any background**
5. **Test in bright light and dim conditions**
6. **When in doubt, increase contrast**
