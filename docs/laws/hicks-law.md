# Hick's Law

> **The time it takes to make a decision increases with the number and complexity of choices.**

Named after British psychologist William Edmund Hick and American psychologist Ray Hyman.

---

## The Formula

```
RT = a + b * log2(n)

RT = Reaction Time
a  = Time not related to decision (motor response)
b  = Empirically derived constant (~150ms per bit)
n  = Number of equally probable choices
```

---

## Visual Impact

```
2 CHOICES:              8 CHOICES:              16 CHOICES:
┌─────────────┐         ┌─────────────┐         ┌─────────────┐
│ Yes │ No    │         │ A │ B │ C │ D│        │ 1  2  3  4  │
└─────────────┘         │ E │ F │ G │ H│        │ 5  6  7  8  │
                        └─────────────┘         │ 9  10 11 12 │
~300ms decision         ~600ms decision         │ 13 14 15 16 │
                                                └─────────────┘
                                                ~900ms decision
```

---

## Practical Guidelines

### Navigation Menus

**GOOD (5 items):**
```
┌─────────────────────────────────────┐
│ Home  Products  About  Blog  Contact│
└─────────────────────────────────────┘
Decision time: ~500ms
```

**BAD (12 items):**
```
┌────────────────────────────────────────────────────────┐
│ Home Products Services About Blog Contact FAQ Support  │
│ Careers Partners Press Events                          │
└────────────────────────────────────────────────────────┘
Decision time: ~800ms + cognitive overload
```

### Breaking Down Large Sets

```
INSTEAD OF 20 FLAT OPTIONS:

Use categories:
┌─────────────┐
│ Category A  │────→ ┌─────────────┐
│ Category B  │      │ Option A1   │
│ Category C  │      │ Option A2   │
│ Category D  │      │ Option A3   │
└─────────────┘      │ Option A4   │
                     └─────────────┘
4 choices → 4-5 choices = manageable
```

---

## Mobile vs Desktop

| Platform | Recommended Max Items | Reason |
|----------|----------------------|--------|
| Mobile (bottom nav) | 4-5 | Thumb reach, small screen |
| Mobile (hamburger) | 6-8 | Scrollable, focused |
| Desktop (main nav) | 5-7 | Eye scanning pattern |
| Desktop (dropdown) | 8-10 | Can include search |

---

## Strategies to Reduce Decision Time

### 1. Highlight the Recommended Option
```
┌─────────────────────────────────────────┐
│   Basic        ★ Pro (Most Popular)     │
│   $9/mo          $19/mo                 │
│                                         │
│   Enterprise                            │
│   Contact us                            │
└─────────────────────────────────────────┘
```

### 2. Progressive Disclosure
Show basic options first, advanced on demand.
```
┌─────────────────────────────────────────┐
│ Font Size:  [ Small ▼ ]                 │
│                                         │
│ ▸ Advanced Options                      │
└─────────────────────────────────────────┘
```

### 3. Smart Defaults
Pre-select the most common choice.
```
┌─────────────────────────────────────────┐
│ Shipping:                               │
│ ○ Standard (5-7 days) - Free            │
│ ● Express (2-3 days) - $9.99  ← Default │
│ ○ Overnight - $24.99                    │
└─────────────────────────────────────────┘
```

### 4. Search for Large Sets
When options exceed 10-15, provide search.
```
┌─────────────────────────────────────────┐
│ Select Country                          │
│ ┌─────────────────────────────────────┐ │
│ │ 🔍 Search countries...              │ │
│ └─────────────────────────────────────┘ │
│ Popular:                                │
│ United States                           │
│ United Kingdom                          │
│ Germany                                 │
└─────────────────────────────────────────┘
```

---

## When Hick's Law Doesn't Apply

1. **Expert Users**: Familiar users bypass decision-making
2. **Emergency Situations**: Stress overrides normal processing
3. **Unequal Probabilities**: When one option is clearly expected
4. **Sequential Decisions**: Multiple small decisions vs one big one

---

## Checklist

- [ ] Main navigation has ≤7 items
- [ ] Categories are used for large option sets
- [ ] Recommended/default options are highlighted
- [ ] Search is available for 10+ items
- [ ] Advanced options are hidden by default
