# Component Design Guidelines

**Purpose:** Design guidelines for common UI components to ensure consistency, usability, and accessibility.

---

## Buttons

### Button Hierarchy

```
Primary:    ████████████████  (Solid fill, accent color)
Secondary:  ┌──────────────┐  (Outlined or light fill)
Tertiary:   Text Button       (Text only, no border)
```

### Button States

```
Default   Hover     Pressed   Disabled  Loading
[     ]   [ bg  ]   [dark ]   [fade ]   [⟳   ]
```

### Button Sizing

| Size | Height | Padding | Font | Use Case |
|------|--------|---------|------|----------|
| Small | 32px | 12px H | 14px | Dense UIs, tables |
| Medium | 40px | 16px H | 14px | Default |
| Large | 48px | 20px H | 16px | Primary CTAs |

### Button Content

**Do:**
- Use action verbs: "Save", "Send", "Create"
- Be specific: "Add to Cart" not "Add"
- Keep labels short (1-3 words)
- Use sentence case

**Don't:**
- "Click here", "Submit"
- ALL CAPS (except branding)
- Long phrases

### Button with Icon

```
Icon left:  [🔍 Search    ]  - Icon clarifies action
Icon right: [Continue  →  ]  - Arrow indicates direction
Icon only:  [    🔧       ]  - Requires tooltip
```

---

## Input Fields

### Input Anatomy

```
┌─────────────────────────────────────────┐
│ Label                                   │
│ ┌─────────────────────────────────────┐ │
│ │ 🔍 │ Placeholder text...        [✕] │ │
│ └─────────────────────────────────────┘ │
│ ⓘ Helper text or error message         │
└─────────────────────────────────────────┘

Parts:
- Label (always visible)
- Input container
- Leading icon (optional)
- Placeholder (disappears on input)
- Clear button (optional)
- Helper/Error text
```

### Input States

```
Default:    ┌─────────────┐  Gray border
Hover:      ┌─────────────┐  Darker border
Focused:    ┌─────────────┐  Accent border + glow
Filled:     ┌─────────────┐  Normal border, content visible
Error:      ┌─────────────┐  Red border + error message
Disabled:   ┌─────────────┐  Faded, no interaction
```

### Input Types

| Type | Features |
|------|----------|
| Text | Standard text entry |
| Password | Hidden characters, show/hide toggle |
| Number | Numeric keyboard, +/- steppers |
| Search | Clear button, search icon |
| Multiline | Expandable, character count |

### Labels & Placeholders

**Labels:** Always visible, describe the field
**Placeholders:** Example format, disappear on focus

```
GOOD:
Label: Phone Number
Placeholder: (123) 456-7890

BAD:
Label: (none)
Placeholder: Enter your phone number here
```

---

## Cards

### Card Anatomy

```
┌─────────────────────────────────────┐
│ ┌─────────────────────────────────┐ │
│ │           Media Area            │ │
│ └─────────────────────────────────┘ │
│                                     │
│   Title Text                        │
│   Subtitle or metadata              │
│                                     │
│   Body content or description       │
│   text that can span multiple       │
│   lines as needed.                  │
│                                     │
│   [Secondary]          [Primary]    │
│                                     │
└─────────────────────────────────────┘
```

### Card Types

**Basic Card:** Content grouping
**Interactive Card:** Entire card is clickable
**Action Card:** Has explicit action buttons
**Selection Card:** Can be selected (checkbox, radio)

### Card Guidelines

- Consistent border radius (8-16px)
- Consistent elevation (shadow)
- Consistent internal spacing
- Maximum 2 actions visible
- Overflow actions in menu

---

## Lists

### List Item Anatomy

```
┌─────────────────────────────────────────────┐
│ [Avatar] Title Text                    [>]  │
│          Supporting text               [⋮]  │
└─────────────────────────────────────────────┘

Parts:
- Leading visual (avatar, icon, checkbox)
- Primary text (title)
- Secondary text (subtitle, metadata)
- Trailing content (icon, action, badge)
```

### List Types

**Simple List:**
```
│ Item 1                                      │
│ Item 2                                      │
│ Item 3                                      │
```

**Two-Line List:**
```
│ Primary Text                                │
│ Secondary supporting text                   │
├─────────────────────────────────────────────┤
│ Primary Text                                │
│ Secondary supporting text                   │
```

**Three-Line List:**
```
│ Primary Text                                │
│ Secondary text line 1                       │
│ Secondary text line 2                       │
├─────────────────────────────────────────────┤
```

### List Interactions

- Tap/click: Primary action (navigate, select)
- Swipe: Reveal secondary actions
- Long press: Multi-select mode
- Trailing button: Explicit action

---

## Dialogs

### Dialog Anatomy

```
┌─────────────────────────────────────────────┐
│ Title                                  [✕]  │
├─────────────────────────────────────────────┤
│                                             │
│   Dialog content. This explains what        │
│   the dialog is for and what will happen.   │
│                                             │
├─────────────────────────────────────────────┤
│                    [Cancel]    [Confirm]    │
└─────────────────────────────────────────────┘
```

### Dialog Types

**Alert:** Information, single "OK" button
**Confirmation:** Action confirmation, Cancel/Confirm
**Choice:** Selection from options
**Form:** Input collection
**Full-screen (mobile):** Complex tasks

### Dialog Guidelines

- Clear, descriptive title
- Concise content
- Clearly labeled buttons
- Cancel on left, confirm on right
- Escape to dismiss
- Destructive actions should be explicit ("Delete" not "OK")

---

## Navigation

### Tab Bar (Mobile Bottom)

```
┌───────────────────────────────────────┐
│ [🏠]  [📋]  [➕]  [🔔]  [👤]          │
│ Home  Tasks  Add  Alerts Profile      │
└───────────────────────────────────────┘
```

**Guidelines:**
- 3-5 items
- Icons + labels
- Active state highlighted
- Fixed at bottom

### Navigation Rail (Desktop Side)

```
┌───┬────────────────────────────────────┐
│🏠 │                                    │
│📋 │                                    │
│📊 │          Content                   │
│⚙️ │                                    │
└───┴────────────────────────────────────┘
```

**Guidelines:**
- Collapsed by default or expanded
- Can show labels on hover/expand
- Section dividers for groups

### Tabs

```
┌─────────────────────────────────────────────┐
│ [ Tab 1 ] [ Tab 2 ] [ Tab 3 ]               │
│     ▬▬▬▬▬                                   │
├─────────────────────────────────────────────┤
│                                             │
│              Tab Content                    │
│                                             │
└─────────────────────────────────────────────┘
```

**Guidelines:**
- Related content only
- Use indicator line for active
- Swipeable on mobile
- Scrollable if > 4 tabs

---

## Forms

### Form Layout

```
┌─────────────────────────────────────────────┐
│ Form Title                                  │
├─────────────────────────────────────────────┤
│ Section Header                              │
│                                             │
│ Label                                       │
│ ┌─────────────────────────────────────────┐ │
│ │ Input                                   │ │
│ └─────────────────────────────────────────┘ │
│                                             │
│ Label                                       │
│ ┌─────────────────────────────────────────┐ │
│ │ Input                                   │ │
│ └─────────────────────────────────────────┘ │
│                                             │
├─────────────────────────────────────────────┤
│               [Cancel]   [Submit]           │
└─────────────────────────────────────────────┘
```

### Form Guidelines

**Layout:**
- Single column on mobile
- Label above input (not inline on mobile)
- Group related fields
- Required fields marked (asterisk or "optional" label)

**Validation:**
- Validate on blur (not on every keystroke)
- Show errors inline near the field
- Summarize errors at top for long forms
- Keep valid input when showing errors

**Progress:**
- Save progress automatically
- Show completion status for long forms
- Break long forms into steps

---

## Component Sizing Reference

| Component | Mobile Touch | Desktop Click |
|-----------|--------------|---------------|
| Button (min) | 44x44px | 32x32px |
| Input height | 48px | 40px |
| List item | 56-72px | 48-56px |
| Tab height | 48px | 48px |
| Icon button | 44x44px | 32x32px |
| Checkbox/Radio | 24x24px (44px touch) | 20x20px |
