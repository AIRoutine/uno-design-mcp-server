# Monochrome Palette

**The Complete Grayscale System - No Alternatives**

---

## The 12-Stop Grayscale

```
WHITE     #FFFFFF   rgb(255,255,255)   Primary backgrounds, empty space
Gray-50   #FAFAFA   rgb(250,250,250)   Subtle backgrounds, hover states
Gray-100  #F5F5F5   rgb(245,245,245)   Card backgrounds, surfaces
Gray-200  #EEEEEE   rgb(238,238,238)   Borders, dividers, separators
Gray-300  #E0E0E0   rgb(224,224,224)   Disabled backgrounds, inactive
Gray-400  #BDBDBD   rgb(189,189,189)   Placeholder text, disabled icons
Gray-500  #9E9E9E   rgb(158,158,158)   Secondary text, captions
Gray-600  #757575   rgb(117,117,117)   Icons, tertiary text
Gray-700  #616161   rgb(97,97,97)      Body text
Gray-800  #424242   rgb(66,66,66)      Subheadings
Gray-900  #212121   rgb(33,33,33)      Primary text, headings
BLACK     #000000   rgb(0,0,0)         Maximum contrast, emphasis
```

---

## Usage Rules

### Text Hierarchy

| Level | Color | Use Case |
|-------|-------|----------|
| Display | Black #000000 | Hero text, major headlines |
| Headline | Gray-900 #212121 | Page titles, section headers |
| Subhead | Gray-800 #424242 | Subsection titles |
| Body | Gray-700 #616161 | Paragraph text, descriptions |
| Secondary | Gray-500 #9E9E9E | Captions, helper text |
| Disabled | Gray-400 #BDBDBD | Inactive labels |

### Surface Hierarchy

```
┌──────────────────────────────────────────────┐
│ Background: Gray-50 #FAFAFA                  │
│ ┌──────────────────────────────────────────┐ │
│ │ Card: White #FFFFFF                      │ │
│ │ ┌──────────────────────────────────────┐ │ │
│ │ │ Nested/Elevated: Gray-100 #F5F5F5    │ │ │
│ │ └──────────────────────────────────────┘ │ │
│ └──────────────────────────────────────────┘ │
└──────────────────────────────────────────────┘
```

### Interactive Elements

| State | Background | Border | Text |
|-------|------------|--------|------|
| Default | White | Gray-200 | Gray-900 |
| Hover | Gray-50 | Gray-300 | Gray-900 |
| Pressed | Gray-100 | Gray-400 | Gray-900 |
| Focused | White | Black (2px) | Gray-900 |
| Disabled | Gray-100 | Gray-200 | Gray-400 |

### Border Weights

```
Subtle:    1px Gray-200   Light dividers, card edges
Standard:  1px Gray-300   Input fields, buttons
Emphasis:  2px Gray-400   Active states, focus
Strong:    2px Black      Selected items, current state
```

---

## Contrast Ratios (WCAG AAA)

| Combination | Ratio | Use |
|-------------|-------|-----|
| Black on White | 21:1 | Headlines, critical text |
| Gray-900 on White | 15.2:1 | Primary text |
| Gray-800 on White | 9.7:1 | Subheadings |
| Gray-700 on White | 6.3:1 | Body text |
| Gray-600 on White | 4.6:1 | Secondary text (min) |
| Gray-500 on White | 3.5:1 | Decorative only |
| White on Black | 21:1 | Inverted buttons |
| White on Gray-800 | 9.7:1 | Dark surfaces |

---

## Semantic Alternatives

**Without color, meaning through form:**

| Semantic | Traditional | Monochrome Alternative |
|----------|-------------|----------------------|
| Error | Red | Icon (!) + Bold text + Thick border |
| Success | Green | Icon (✓) + Text confirmation |
| Warning | Yellow/Orange | Icon (⚠) + Background Gray-100 |
| Info | Blue | Icon (i) + Standard styling |
| Active/Selected | Accent color | Black border (2px) + Gray-50 fill |
| Link | Blue underline | Underline + Bold on hover |

---

## Dark Mode Variant

**Same system, inverted:**

```
Surface:     #121212 (near-black)
Surface+1:   #1E1E1E
Surface+2:   #232323
Surface+3:   #2C2C2C
Surface+4:   #383838

Text Primary:   #FFFFFF (87% opacity)
Text Secondary: #FFFFFF (60% opacity)
Text Disabled:  #FFFFFF (38% opacity)

Borders:     #383838
Dividers:    #2C2C2C
```

---

## Do Not Use

- Any hue (red, blue, green, etc.)
- Any saturation (only pure grays)
- Transparency below 38% for text
- Gray-500 or lighter for body text
- Color for meaning without icon backup
