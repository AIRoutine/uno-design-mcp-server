# Visual Hierarchy

**Purpose:** Guide users through content by establishing clear importance levels.

## The Psychology Behind It

Users scan interfaces in predictable patterns:
- **F-Pattern:** For text-heavy pages (web, desktop)
- **Z-Pattern:** For minimal content with CTAs
- **Gutenberg Diagram:** Natural reading flow from top-left to bottom-right

Understanding these patterns helps place important content where eyes naturally go.

---

## Hierarchy Tools

### 1. Size & Scale
The most powerful hierarchy tool. Our brains process size before anything else.

**Guidelines:**
- Headlines: 2-3x body text size
- Primary content: Standard body size
- Secondary/metadata: 0.75-0.85x body size
- Scale ratio: Use 1.25 (minor third) or 1.333 (perfect fourth)

**Example Scale:**
```
Display:    32pt
H1:         24pt
H2:         20pt
H3:         16pt
Body:       14pt
Caption:    12pt
```

### 2. Color & Contrast
Color directs attention and creates emotional hierarchy.

**Primary Actions:**
- Use brand/accent color
- High saturation
- Maximum contrast with background

**Secondary Actions:**
- Muted or desaturated colors
- Lower contrast
- Often use outlined/ghost style

**Tertiary/Disabled:**
- Very low contrast
- Grayscale or very muted

### 3. Spacing & Position

**Prime Positions:**
- Top-left: First point of attention (LTR)
- Top-center: Brand, titles
- Top-right: Actions, user info
- Bottom-right: Primary CTA (Fitts's Law target)

**Spacing Rules:**
- Group related items (proximity principle)
- Separate unrelated items with whitespace
- Use consistent spacing multiples (4px, 8px, 16px, 24px, 32px)

### 4. Typography Weight
Weight creates emphasis within same-size text.

**Usage:**
- Bold (600-700): Headlines, emphasis, labels
- Medium (500): Subheadings, interactive elements
- Regular (400): Body text
- Light (300): De-emphasized, metadata

### 5. Visual Treatment
Add depth and emphasis through effects.

**Elevation/Shadow:**
- Higher elevation = more important
- Cards, modals, FABs use elevation
- Use consistently (don't mix shadow styles)

**Borders & Lines:**
- Separate content areas
- Define interactive regions
- Use sparingly to avoid visual noise

---

## Common Mistakes

1. **Too many levels:** More than 4 levels confuses users
2. **Competing elements:** Multiple items fighting for attention
3. **No clear entry point:** User doesn't know where to look first
4. **Inconsistent scale:** Random sizes without system
5. **Over-decoration:** Too many colors, shadows, effects

---

## Practical Application

### Card Design
```
[                                    ]
[  CATEGORY           12pt / muted   ]
[  Title Here         20pt / bold    ]
[  Description text   14pt / regular ]
[                                    ]
[  [Action]           accent color   ]
[                                    ]
```

### Form Layout
```
Section Title         (18pt, bold)
├── Field Label       (14pt, medium)
│   └── Input         (14pt, regular, bordered)
├── Field Label
│   └── Input
└── Helper Text       (12pt, muted)

[Submit Button]       (Primary, full-width)
```

### Navigation
```
Logo/Brand            (Largest, left)
├── Nav Items         (Equal size, medium weight)
└── User Actions      (Right aligned, icon + text)
```

---

## Testing Your Hierarchy

1. **Squint Test:** Blur your vision - what stands out?
2. **5-Second Test:** What do users remember after 5 seconds?
3. **First Click Test:** Where do users click first?
4. **Grayscale Test:** Does hierarchy work without color?
