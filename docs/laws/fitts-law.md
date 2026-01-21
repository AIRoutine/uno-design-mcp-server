# Fitts's Law

> **The time to acquire a target is a function of the distance to and size of the target.**

Named after psychologist Paul Fitts, who established this principle in 1954.

---

## The Formula

```
MT = a + b * log2(D/W + 1)

MT = Movement Time
a  = Start/stop time (device dependent)
b  = Inherent speed (device dependent)
D  = Distance to target center
W  = Width of target (along axis of movement)
```

**Key Insight:** Doubling the size of a target reduces acquisition time more than halving the distance.

---

## Visual Representation

```
HARD TO HIT:                          EASY TO HIT:
┌────────────────────────────┐        ┌────────────────────────────┐
│                            │        │                            │
│  ●                         │        │  ●                         │
│  │                         │        │  │                         │
│  │                    [S]  │        │  │   ┌────────────────┐    │
│  │                         │        │  │   │                │    │
│  └─────────────────────→   │        │  └──→│  Large Target  │    │
│    Long distance + Small   │        │      │                │    │
│                            │        │      └────────────────┘    │
└────────────────────────────┘        └────────────────────────────┘
     ~800ms acquisition                     ~300ms acquisition
```

---

## Minimum Target Sizes

### Touch Interfaces (Mobile)

| Element | Minimum | Recommended | Notes |
|---------|---------|-------------|-------|
| Touch target | 44x44 dp | 48x48 dp | Apple HIG |
| Touch target | 48x48 dp | 56x56 dp | Material Design |
| Icon button | 40x40 dp | 48x48 dp | With padding |
| List item | 48dp height | 56-72dp | Full width |
| Spacing between targets | 8dp | 12dp | Prevents mis-taps |

### Pointer Interfaces (Desktop)

| Element | Minimum | Recommended | Notes |
|---------|---------|-------------|-------|
| Click target | 24x24 px | 32x32 px | Mouse precision |
| Button | 32px height | 40px height | Comfortable |
| Menu item | 32px height | 36px height | Easy scanning |
| Toolbar icon | 24x24 px | 32x32 px | With padding |

---

## Strategic Placement

### 1. Prime Pixel Areas

Screen edges and corners are "infinitely" wide - the cursor can't overshoot.

```
┌─────────────────────────────────────────────┐
│ [Logo]                         [×] Close    │ ← Corner = easy
│                                             │
│                                             │
│                                             │
│                                             │
│                                             │
│                                             │
│ [Previous]                        [Next]    │ ← Edges = easy
└─────────────────────────────────────────────┘
  ↑ Edge                           Edge ↑
```

### 2. Frequent Actions Near Current Position

```
GOOD: Actions near content        BAD: Actions far from content
┌─────────────────────────┐       ┌─────────────────────────┐
│ [Edit] [Delete] [Share] │       │ Content here...         │
│ ─────────────────────── │       │                         │
│ Content here...         │       │                         │
│                         │       │                         │
│                         │       │ [Edit] [Delete] [Share] │
└─────────────────────────┘       └─────────────────────────┘
```

### 3. Primary Actions Should Be Larger

```
┌─────────────────────────────────────────────┐
│                                             │
│        ┌─────────────────────────┐          │
│        │                         │          │
│        │     Submit Order        │  ← Large │
│        │                         │          │
│        └─────────────────────────┘          │
│                                             │
│              [Cancel]               ← Small │
│                                             │
└─────────────────────────────────────────────┘
```

---

## Mobile Thumb Zones

```
┌─────────────────────────┐
│ HARD    │ OK    │ HARD  │
│─────────┼───────┼───────│
│         │       │       │
│   OK    │ EASY  │  OK   │
│         │       │       │
│─────────┼───────┼───────│
│  EASY   │ EASY  │ EASY  │  ← Primary actions here
└─────────────────────────┘
       Right-handed user
```

**Placement Strategy:**
- Primary actions: Bottom third (easy thumb reach)
- Secondary actions: Middle area
- Rare actions: Top (requires hand repositioning)

---

## Common Patterns

### Full-Width Buttons on Mobile
```
┌─────────────────────────────┐
│                             │
│ ┌─────────────────────────┐ │
│ │    Continue to Checkout │ │  ← Full width = hard to miss
│ └─────────────────────────┘ │
│                             │
└─────────────────────────────┘
```

### Floating Action Button (FAB)
```
┌─────────────────────────────┐
│                             │
│                             │
│                             │
│                             │
│                             │
│                       ┌───┐ │
│                       │ + │ │  ← Large, accessible position
│                       └───┘ │
└─────────────────────────────┘
```

### Context Menus Near Click
```
Click here: ●
             ↓
           ┌──────────────┐
           │ Edit         │  ← Menu appears at click point
           │ Copy         │
           │ Delete       │
           └──────────────┘
```

---

## Anti-Patterns

### 1. Tiny Touch Targets
```
BAD:                          GOOD:
┌────────────────────┐        ┌────────────────────┐
│ [x] Accept terms   │        │ ┌──┐               │
│                    │        │ │✓ │ Accept terms  │
│ (checkbox: 16x16)  │        │ └──┘ (44x44 tap)   │
└────────────────────┘        └────────────────────┘
```

### 2. Targets Too Close Together
```
BAD:                          GOOD:
┌────────────────────┐        ┌────────────────────┐
│ [Save][Cancel][Del]│        │ [Save]   [Cancel]  │
│ (no spacing)       │        │                    │
│                    │        │          [Delete]  │
└────────────────────┘        └────────────────────┘
```

### 3. Important Actions in Hard-to-Reach Areas
```
BAD:                          GOOD:
┌────────────────────┐        ┌────────────────────┐
│ [Submit]           │        │                    │
│                    │        │                    │
│                    │        │                    │
│                    │        │                    │
│ Form content...    │        │ Form content...    │
│                    │        │                    │
│                    │        │ [Submit]           │
└────────────────────┘        └────────────────────┘
```

---

## Checklist

- [ ] Touch targets are at least 44x44dp (48x48dp preferred)
- [ ] Spacing between targets is at least 8dp
- [ ] Primary actions are larger than secondary actions
- [ ] Frequent actions are placed near natural hand positions
- [ ] Mobile primary actions are in bottom third of screen
- [ ] Desktop actions leverage screen edges where appropriate
- [ ] Context menus appear near the triggering action
