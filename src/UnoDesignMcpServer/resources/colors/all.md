# Color Guidelines

**Purpose:** Use color strategically to create hierarchy, convey meaning, and enhance user experience.

---

## Color Theory Basics

### Primary Colors

```
Red     Yellow    Blue
 ●        ●        ●
```

### Secondary Colors (mixing primaries)

```
Orange    Green    Purple
  ●         ●        ●
```

### Color Properties

**Hue:** The color itself (red, blue, green)
**Saturation:** Color intensity (vivid ↔ muted)
**Lightness/Value:** Light vs dark

```
High Saturation        Low Saturation
     ●                      ○
  (Vivid)               (Muted/Gray)
```

---

## Building a Color Palette

### Brand Colors

**Primary:** Main brand color (1 color)
**Secondary:** Supporting brand color (1-2 colors)

```
Example:
Primary:   ████ #0066CC (Blue)
Secondary: ████ #00AA66 (Teal)
```

### Functional/Semantic Colors

**Always include:**
```
Success:  ████ Green  - Completed, confirmed, positive
Warning:  ████ Yellow/Orange - Attention needed, caution
Error:    ████ Red    - Errors, destructive actions
Info:     ████ Blue   - Informational, neutral alerts
```

### Neutral Colors

**Create a gray scale:**
```
Gray 900: ████ #111111 - Headings, primary text
Gray 700: ████ #333333 - Body text
Gray 500: ████ #666666 - Secondary text
Gray 300: ████ #999999 - Placeholder, disabled
Gray 100: ████ #EEEEEE - Borders, dividers
Gray 50:  ████ #F8F8F8 - Backgrounds
White:    ████ #FFFFFF - Cards, surfaces
```

### Accent/Highlight

**For emphasis:**
```
Accent: ████ Vibrant color for CTAs, links, selections
```

---

## Color Usage Guidelines

### Hierarchy Through Color

```
Most Important:  Accent/Primary color
Important:       Dark text
Less Important:  Gray text
Least Important: Light gray text
```

### Backgrounds

```
┌─────────────────────────────────────┐
│ Surface (White/Light)               │
│ ┌─────────────────────────────────┐ │
│ │ Card (White + elevation)        │ │
│ └─────────────────────────────────┘ │
│                                     │
│ Background (Light gray)             │
└─────────────────────────────────────┘
```

**Layer order:**
1. Page background (lightest gray)
2. Surface/container (white)
3. Interactive elements (color)

### Text on Backgrounds

| Background | Text Color | Contrast |
|------------|------------|----------|
| White | Dark gray (#333) | 12:1 |
| Light gray | Dark gray (#333) | 10:1 |
| Brand color | White | 4.5:1+ |
| Dark | White | 4.5:1+ |

---

## Contrast Requirements

### WCAG Guidelines

| Element | Minimum Ratio |
|---------|---------------|
| Normal text | 4.5:1 |
| Large text (18pt+) | 3:1 |
| UI components | 3:1 |
| Focus indicators | 3:1 |

### Testing Contrast

```
GOOD:  Black text on white    (21:1)  ✓
GOOD:  #333 on white          (12:1)  ✓
OK:    #666 on white          (5.7:1) ✓
BAD:   #999 on white          (2.8:1) ✗
```

**Tools:**
- WebAIM Contrast Checker
- Stark (Figma plugin)
- Chrome DevTools

---

## Color and Meaning

### Never Rely on Color Alone

```
BAD:
Required fields are marked in red.
(Color blind users can't see this)

GOOD:
Required fields are marked with * and red border.
(Multiple indicators)
```

### Semantic Consistency

Use colors consistently for meaning:

```
✓ Green  = Success, go, positive
● Yellow = Warning, caution
✕ Red    = Error, stop, danger
ⓘ Blue   = Information, neutral
```

### Cultural Considerations

| Color | Western | Eastern |
|-------|---------|---------|
| Red | Danger, error | Luck, prosperity |
| White | Purity, clean | Mourning (some) |
| Green | Go, success | Varies |
| Yellow | Caution | Royalty (some) |

---

## Dark Mode

### Principles

```
Light Mode:              Dark Mode:
┌────────────────┐      ┌────────────────┐
│ Dark on Light  │  →   │ Light on Dark  │
└────────────────┘      └────────────────┘
```

### Implementation

**Don't just invert:**
- Adjust saturation (reduce for dark mode)
- Adjust elevation (use lighter surfaces for elevation)
- Test contrast in dark mode

**Surface layers:**
```
Dark Mode Surfaces:
Background:  #121212 (darkest)
Surface 1:   #1E1E1E
Surface 2:   #232323
Surface 3:   #282828
Overlay:     #333333 (lightest)
```

**Text on dark:**
```
Primary:   #FFFFFF (87% opacity) - High emphasis
Secondary: #FFFFFF (60% opacity) - Medium emphasis
Disabled:  #FFFFFF (38% opacity) - Disabled
```

### Color Adjustments

```
Light Mode Accent:  #0066CC (Saturated)
Dark Mode Accent:   #4499FF (Lighter, less saturated)
```

---

## Color Palette Template

### Minimal Palette (Start Here)

```
Brand:
  Primary:     ████ #[color]

Semantic:
  Success:     ████ #22C55E
  Warning:     ████ #F59E0B
  Error:       ████ #EF4444
  Info:        ████ #3B82F6

Neutral:
  Text:        ████ #1F2937
  Secondary:   ████ #6B7280
  Border:      ████ #E5E7EB
  Background:  ████ #F9FAFB
  Surface:     ████ #FFFFFF

Accent:
  Interactive: ████ #[brand or distinct]
```

### Extended Palette (When Needed)

Each color with shades:
```
Blue:
  50:  ████ #EFF6FF
  100: ████ #DBEAFE
  200: ████ #BFDBFE
  300: ████ #93C5FD
  400: ████ #60A5FA
  500: ████ #3B82F6 (Base)
  600: ████ #2563EB
  700: ████ #1D4ED8
  800: ████ #1E40AF
  900: ████ #1E3A8A
```

---

## Common Mistakes

1. **Too many colors:** Stick to 3-5 colors max
2. **Poor contrast:** Always test ratios
3. **Color as only indicator:** Add icons, text, patterns
4. **Inconsistent semantics:** Red means danger everywhere
5. **Ignoring dark mode:** Plan for both from start
6. **Vibrating colors:** Avoid pure complementary touching
