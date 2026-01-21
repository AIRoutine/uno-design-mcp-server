# Mobile Design Patterns

**Purpose:** Design patterns optimized for touch interaction, small screens, and mobile usage contexts.

---

## Touch Interaction Fundamentals

### Touch Target Sizes

**Minimum sizes:**
| Platform | Minimum | Recommended |
|----------|---------|-------------|
| iOS      | 44pt    | 48-60pt     |
| Android  | 48dp    | 56dp        |
| General  | 44px    | 48px+       |

**Spacing between targets:** 8px minimum

**Edge targets:** Add 4-8px extra padding

### Touch Zones

```
┌─────────────────────────────┐
│         Hard to reach       │  ← Top area: Navigation, non-frequent actions
│                             │
├─────────────────────────────┤
│                             │
│      Natural reach          │  ← Middle: Primary content
│                             │
├─────────────────────────────┤
│      Easy reach (thumb)     │  ← Bottom: Primary actions, navigation
└─────────────────────────────┘
```

**Design principle:** Most important actions at bottom.

---

## Mobile Gestures

### Standard Gestures

| Gesture | Action | Use Case |
|---------|--------|----------|
| Tap | Select/Activate | Buttons, list items |
| Double-tap | Zoom/Expand | Images, maps |
| Long-press | Context menu | Additional options |
| Swipe horizontal | Navigate/Action | Dismiss, reveal actions |
| Swipe vertical | Scroll | Content navigation |
| Pull down | Refresh | Update content |
| Pinch | Zoom | Images, maps |

### Gesture Guidelines

1. **Discoverability:** Provide visual hints for hidden gestures
2. **Alternatives:** Always provide button fallback
3. **Feedback:** Confirm gesture with animation/haptic
4. **Consistency:** Same gesture = same action app-wide

### Swipe Actions

```
← Swipe Left reveals:
┌─────────────────────────────────────────┐
│  List Item                 [Edit][Delete]│
└─────────────────────────────────────────┘

→ Swipe Right reveals:
┌─────────────────────────────────────────┐
│[Archive]                      List Item  │
└─────────────────────────────────────────┘
```

**Best practices:**
- Destructive actions require confirmation
- Show only 2-3 actions
- Use consistent icons and colors
- Provide visual hint (peek edge color)

---

## Navigation Patterns

### Bottom Navigation

```
┌─────────────────────────────┐
│                             │
│         Content             │
│                             │
├─────────────────────────────┤
│  🏠    📋    ➕    🔔    👤  │
│ Home  List  Add  Alerts Me  │
└─────────────────────────────┘
```

**Guidelines:**
- 3-5 items maximum
- Always visible
- Highlight current location
- Use icons + labels
- FAB can integrate with bottom bar

### Tab Bar

```
┌─────────────────────────────┐
│  [Tab 1] [Tab 2] [Tab 3]    │  ← Scrollable if > 4 tabs
├─────────────────────────────┤
│                             │
│      Tab Content            │
│                             │
└─────────────────────────────┘
```

**Guidelines:**
- Use for content categories within a section
- Swipe between tabs is expected
- Show indicator line under active tab
- Scrollable tabs for > 4 items

### Navigation Drawer

```
┌─────────────────────────────┐
│ ☰ App Title                 │
├─────────────────────────────┤
│ 👤 Profile                  │
├─────────────────────────────┤
│ 🏠 Home                     │
│ 📊 Dashboard                │
│ ⚙️ Settings                 │
│ ❓ Help                     │
├─────────────────────────────┤
│ 🚪 Logout                   │
└─────────────────────────────┘
```

**Guidelines:**
- For 6+ navigation destinations
- Opened via hamburger menu (☰)
- Can also open via swipe from edge
- Group related items with dividers

---

## Mobile Content Patterns

### Pull-to-Refresh

```
     ↓ Pull to refresh
         ○
         ↓
┌─────────────────────────────┐
│     Content Item 1          │
│     Content Item 2          │
│     Content Item 3          │
└─────────────────────────────┘
```

**States:**
1. Idle: Normal list
2. Pull: Indicator appears, follows finger
3. Release: Loading spinner
4. Complete: Content updates, indicator hides

### Infinite Scroll

```
┌─────────────────────────────┐
│     Content Item 1          │
│     Content Item 2          │
│     Content Item 3          │
├─────────────────────────────┤
│       Loading...            │
├─────────────────────────────┤
│     Content Item 4          │
│     Content Item 5          │
└─────────────────────────────┘
```

**Guidelines:**
- Load 10-20 items per page
- Show loading indicator
- Provide "Load More" button as fallback
- Consider pagination for precise navigation

### Cards

```
┌─────────────────────────────┐
│ ┌─────────────────────────┐ │
│ │       Image             │ │
│ ├─────────────────────────┤ │
│ │ Title                   │ │
│ │ Description text...     │ │
│ │                         │ │
│ │ [Action 1] [Action 2]   │ │
│ └─────────────────────────┘ │
└─────────────────────────────┘
```

**Guidelines:**
- Full-width on mobile
- Consistent card structure
- Touch entire card or specific actions
- Limit to 2 actions per card

---

## Mobile Forms

### Input Considerations

**Keyboard types:**
- Text: Default keyboard
- Email: @ symbol easy access
- Phone: Numeric pad
- URL: / and .com access
- Search: Search/Go button

**Auto-features:**
- Auto-capitalize (sentences, words, none)
- Auto-correct (on/off)
- Auto-complete (suggestions)

### Form Layout

```
┌─────────────────────────────┐
│ Field Label                 │
│ ┌─────────────────────────┐ │
│ │ Input value...          │ │
│ └─────────────────────────┘ │
│ Helper text                 │
├─────────────────────────────┤
│ Field Label                 │
│ ┌─────────────────────────┐ │
│ │ Input value...          │ │
│ └─────────────────────────┘ │
├─────────────────────────────┤
│ ┌─────────────────────────┐ │
│ │       Submit            │ │
│ └─────────────────────────┘ │
└─────────────────────────────┘
```

**Guidelines:**
- Single column layout
- Label above input
- Full-width inputs
- Full-width submit button
- Fixed button at bottom for long forms

---

## Mobile Specific Components

### Floating Action Button (FAB)

```
                        ┌───┐
                        │ + │  ← Primary action
                        └───┘
```

**Guidelines:**
- One primary action per screen
- Bottom-right position (or center)
- Avoid for destructive actions
- Can expand to reveal related actions

### Bottom Sheets

```
┌─────────────────────────────┐
│         Content             │
├━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┤
│         ━━━                 │  ← Drag handle
│   Bottom Sheet Title        │
│   ─────────────────────     │
│   Option 1                  │
│   Option 2                  │
│   Option 3                  │
│   [Cancel]                  │
└─────────────────────────────┘
```

**Use cases:**
- Share options
- Filter/sort options
- Additional actions
- Mini players

### Modal vs Full-screen

**Modal (overlay):**
- Quick tasks
- Confirmations
- Simple forms
- 1-3 inputs

**Full-screen:**
- Complex tasks
- Multi-step flows
- Content creation
- Many inputs

---

## Performance Considerations

### Perceived Performance

1. **Skeleton screens:** Show structure while loading
2. **Optimistic UI:** Update immediately, sync later
3. **Progressive loading:** Load visible content first
4. **Placeholder images:** Show while images load

### Touch Response

- Touch feedback: < 100ms
- Animations: 200-300ms
- Screen transitions: 300ms
- Always show loading state for > 1s

---

## Mobile Anti-Patterns

1. **Too small touch targets:** Under 44pt
2. **Hidden navigation:** No clear way to navigate
3. **Desktop patterns on mobile:** Hover-dependent features
4. **Keyboard issues:** Wrong keyboard type, no auto-features
5. **Unreachable actions:** Primary actions at top
6. **No offline handling:** Broken state without network
7. **Excessive scrolling:** Important content too far down
