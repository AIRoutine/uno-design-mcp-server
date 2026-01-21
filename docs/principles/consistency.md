# Consistency in UI/UX Design

**Purpose:** Reduce cognitive load through predictable patterns, enabling users to transfer learned behaviors across your application.

---

## Types of Consistency

### 1. Internal Consistency
Same patterns within your application.

**What to keep consistent:**
- Visual elements (colors, typography, spacing)
- Interaction patterns (how buttons work, gestures)
- Terminology (use "Delete" OR "Remove", not both)
- Information architecture (navigation structure)
- Feedback mechanisms (how errors appear)

### 2. External Consistency
Following platform conventions and user expectations.

**Platform Guidelines:**
- **iOS:** Human Interface Guidelines (HIG)
- **Android:** Material Design
- **Windows:** Fluent Design / WinUI
- **Web:** Common web patterns

**Why it matters:**
- Users already know platform patterns
- Reduces learning curve dramatically
- Feels "native" and trustworthy

### 3. Functional Consistency
Same actions produce same results everywhere.

**Examples:**
- Back button always goes back
- Swipe-to-delete works on all lists
- Pull-to-refresh updates content
- Long-press shows context menu

---

## Building a Design System

A design system ensures consistency at scale.

### Core Components

**1. Design Tokens**
```
Colors:
  primary: #0066CC
  secondary: #666666
  error: #CC0000
  success: #00AA00

Spacing:
  xs: 4px
  sm: 8px
  md: 16px
  lg: 24px
  xl: 32px

Typography:
  font-family: "Segoe UI", system-ui
  scale: 1.25 (minor third)
```

**2. Component Library**
- Buttons (primary, secondary, ghost, icon)
- Inputs (text, number, date, select)
- Cards (standard, compact, featured)
- Lists (simple, detailed, grouped)
- Navigation (tabs, sidebar, bottom bar)

**3. Patterns**
- Form layouts and validation
- Loading states
- Empty states
- Error handling
- Confirmation dialogs

---

## Consistency Checklist

### Visual
- [ ] Same colors mean same things
- [ ] Typography scale is followed
- [ ] Spacing uses defined tokens
- [ ] Icons are from same family
- [ ] Shadows/elevation are consistent
- [ ] Border radius is standardized

### Behavioral
- [ ] Same gestures work everywhere
- [ ] Transitions use same duration/easing
- [ ] Feedback timing is consistent
- [ ] Error handling follows same pattern
- [ ] Loading states look the same

### Content
- [ ] Terminology is standardized
- [ ] Tone of voice is consistent
- [ ] Date/time formats are uniform
- [ ] Number formats match locale
- [ ] Error messages follow same structure

---

## When to Break Consistency

Sometimes breaking consistency is correct:

1. **Different Context:** Destructive actions (delete) should look different
2. **Platform Requirements:** Native picker on mobile vs custom on desktop
3. **Accessibility:** Providing multiple ways to accomplish tasks
4. **User Research:** Data shows current pattern doesn't work

**Rule:** Document and justify every inconsistency.

---

## Common Mistakes

### 1. Inconsistent Button Styles
```
BAD:
[Save]          - Primary blue
[Submit]        - Green
[Confirm]       - Primary blue
[Create]        - Outlined

GOOD:
[Save]          - Primary blue
[Submit]        - Primary blue
[Confirm]       - Primary blue
[Create]        - Primary blue
```

### 2. Mixed Terminology
```
BAD:
- "Delete" on one screen
- "Remove" on another
- "Trash" on a third

GOOD:
- "Delete" everywhere (or)
- "Remove" everywhere
```

### 3. Inconsistent Spacing
```
BAD:
Card 1: 16px padding
Card 2: 20px padding
Card 3: 12px padding

GOOD:
All cards: 16px padding (md token)
```

---

## Auditing Consistency

### Regular Reviews
1. Screenshot every screen
2. Place side by side
3. Look for visual differences
4. Document inconsistencies
5. Prioritize fixes

### Automated Tools
- Design linting (Figma plugins)
- CSS linting for spacing/color
- Accessibility scanners

### User Testing
- Watch for confusion
- Note "that's different" comments
- Track error rates per screen
