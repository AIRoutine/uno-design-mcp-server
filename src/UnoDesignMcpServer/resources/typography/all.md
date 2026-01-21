# Typography Guidelines

**Purpose:** Create clear, readable, and hierarchical text that enhances the user experience.

---

## Typography Fundamentals

### Type Anatomy

```
                    Ascender
                        │
      ┌─────────────────┼─────────────────┐
      │     T  y  p  o  │  g  r  a  p  h  y│
      └─────────────────┼─────────────────┘
             │          │          │
        Cap height   x-height  Baseline
                                   │
                              Descender
```

### Key Terms

| Term | Description |
|------|-------------|
| Font Family | The typeface (Roboto, SF Pro, Segoe UI) |
| Font Weight | Thickness (Light, Regular, Bold) |
| Font Size | Height of characters |
| Line Height | Vertical space between lines |
| Letter Spacing | Space between characters |

---

## Type Scale

### Recommended Scale (1.25 ratio - Minor Third)

```
Display:     40px / 48px line-height
Heading 1:   32px / 40px line-height
Heading 2:   26px / 32px line-height
Heading 3:   20px / 28px line-height
Body Large:  18px / 28px line-height
Body:        16px / 24px line-height
Body Small:  14px / 20px line-height
Caption:     12px / 16px line-height
```

### Platform Defaults

| Platform | Body Size | Font Family |
|----------|-----------|-------------|
| iOS | 17px | SF Pro |
| Android | 16sp | Roboto |
| Windows | 14px | Segoe UI |
| Web | 16px | System fonts |

---

## Type Hierarchy

### Creating Hierarchy

```
┌────────────────────────────────────────────┐
│ Page Title (Display)                       │  ← Largest, boldest
│ 32-40px, Bold                              │
├────────────────────────────────────────────┤
│ Section Heading (H2)                       │  ← Clear section break
│ 24-26px, Semibold                          │
├────────────────────────────────────────────┤
│ Subsection (H3)                            │  ← Sub-grouping
│ 18-20px, Medium                            │
├────────────────────────────────────────────┤
│ Body Text (Body)                           │  ← Primary content
│ 16px, Regular                              │
├────────────────────────────────────────────┤
│ Supporting Text (Body Small)               │  ← Secondary info
│ 14px, Regular, Gray                        │
├────────────────────────────────────────────┤
│ Metadata (Caption)                         │  ← Timestamps, labels
│ 12px, Regular, Gray                        │
└────────────────────────────────────────────┘
```

### Hierarchy Through Style

| Level | Size | Weight | Color | Use |
|-------|------|--------|-------|-----|
| 1 | Large | Bold | Dark | Titles |
| 2 | Medium | Semibold | Dark | Headings |
| 3 | Regular | Medium | Dark | Subheadings |
| 4 | Regular | Regular | Dark | Body |
| 5 | Small | Regular | Gray | Secondary |
| 6 | Small | Regular | Light Gray | Metadata |

---

## Readability

### Line Length

```
OPTIMAL: 50-75 characters per line (66 ideal)

Too Short:              Too Long (hard to track):
┌─────────────┐        ┌──────────────────────────────────────────────────────────────┐
│ Text here   │        │ Text that spans so far across the screen that readers lose   │
│ is narrow   │        │ their place when returning to the start of the next line.    │
│ and choppy. │        │ This makes reading exhausting and slow.                      │
└─────────────┘        └──────────────────────────────────────────────────────────────┘

Just Right:
┌───────────────────────────────────────────┐
│ Text at this width is comfortable to      │
│ read without losing your place.           │
└───────────────────────────────────────────┘
```

**Implementation:**
- Set max-width on text containers
- 600-700px for body text
- 800-900px for wider content with larger type

### Line Height

```
Too Tight (1.0):       Too Loose (2.0):       Just Right (1.5):
┌──────────────────┐  ┌──────────────────┐  ┌──────────────────┐
│ Lines of text    │  │ Lines of text    │  │ Lines of text    │
│ touching each    │  │                  │  │                  │
│ other makes      │  │ with so much     │  │ with comfortable │
│ reading hard     │  │                  │  │                  │
│ and unpleasant.  │  │ space look       │  │ spacing are easy │
└──────────────────┘  │                  │  │                  │
                      │ disconnected.    │  │ to follow.       │
                      └──────────────────┘  └──────────────────┘
```

**Guidelines:**
- Body text: 1.4-1.6 (140-160%)
- Headings: 1.1-1.3 (110-130%)
- UI labels: 1.2 (120%)

### Letter Spacing

```
Tight (-0.5px):  TRACKING
Normal (0):      TRACKING
Loose (+1px):    T R A C K I N G
```

**Guidelines:**
- Large headings: Slightly tighter (-1 to -2%)
- Body text: Normal (0)
- All caps: Slightly looser (+2 to +5%)
- Small text: Slightly looser (+1%)

---

## Font Pairing

### Safe Combinations

**Sans-serif + Serif:**
```
Headings: Georgia, Times (Serif)
Body: Arial, Helvetica (Sans-serif)

OR

Headings: Open Sans (Sans-serif)
Body: Merriweather (Serif)
```

**Same Family Different Weights:**
```
Headings: Roboto Bold
Body: Roboto Regular
```

### Pairing Rules

1. **Contrast:** Pair fonts that are different enough
2. **No more than 2-3:** Too many fonts = chaos
3. **Similar x-height:** Fonts look better together
4. **Same mood:** Both modern OR both classic

---

## Responsive Typography

### Scaling Approaches

**Fixed scale with breakpoints:**
```
Mobile:    Body 16px, H1 28px
Tablet:    Body 16px, H1 32px
Desktop:   Body 16px, H1 40px
```

**Fluid typography (CSS clamp):**
```
H1: scales smoothly from 28px to 40px
Body: stays at 16px
```

### Mobile Considerations

- Minimum body text: 16px (prevents zoom)
- Larger touch targets for links
- Shorter lines (full width is fine)
- Consider thumb reach for important text

---

## Text Styling

### Emphasis

```
Bold:       Important terms, labels
Italic:     Titles, foreign words, subtle emphasis
Underline:  Links only (never for emphasis)
CAPS:       Short labels, acronyms (sparingly)
Color:      Links, semantic meaning
```

### Alignment

```
Left:       Default for body text (most readable)
Center:     Headings, short phrases, CTAs
Right:      Numbers in tables, dates
Justified:  Avoid (creates uneven spacing)
```

### Text Do's and Don'ts

**Do:**
- Use consistent heading hierarchy
- Keep paragraphs short (3-5 sentences)
- Use bullet points for lists
- Provide adequate whitespace

**Don't:**
- Use ALL CAPS for long text
- Underline non-link text
- Mix too many fonts
- Center long paragraphs
- Use light gray on light backgrounds

---

## Typography Checklist

- [ ] Body text is 16px minimum
- [ ] Line height is 1.4-1.6 for body
- [ ] Line length is 50-75 characters
- [ ] No more than 2-3 fonts
- [ ] Heading hierarchy is clear
- [ ] Color contrast passes WCAG
- [ ] Scales appropriately on mobile
- [ ] Left-aligned for body text
- [ ] Adequate spacing between sections
- [ ] Links are visually distinct

---

## System Fonts Stack

**Modern system fonts (best performance):**
```css
font-family:
  -apple-system,           /* iOS, macOS */
  BlinkMacSystemFont,      /* macOS Chrome */
  "Segoe UI",              /* Windows */
  Roboto,                  /* Android */
  "Helvetica Neue",        /* Older macOS */
  Arial,                   /* Fallback */
  sans-serif;              /* Final fallback */
```

**Monospace:**
```css
font-family:
  ui-monospace,
  SFMono-Regular,
  Menlo,
  Monaco,
  Consolas,
  monospace;
```
