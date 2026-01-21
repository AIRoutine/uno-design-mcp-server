# Desktop Design Patterns

**Purpose:** Design patterns optimized for keyboard, mouse, large screens, and productivity contexts.

---

## Desktop Interaction Fundamentals

### Mouse Interactions

**Cursor States:**
| Cursor | Meaning |
|--------|---------|
| Default (arrow) | Normal navigation |
| Pointer (hand) | Clickable element |
| Text (I-beam) | Text selection |
| Move (4-arrows) | Draggable element |
| Resize (↔ ↕) | Resizable edge |
| Loading (spinner) | Processing |
| Not-allowed (⊘) | Disabled action |

**Hover States:**
Essential for desktop - every interactive element needs hover feedback.

```
Button States:
Default  →  Hover  →  Pressed  →  Disabled
[  ]        [bg]      [dark]      [faded]
```

### Click Behaviors

| Action | Behavior |
|--------|----------|
| Single click | Select/activate |
| Double click | Open/edit |
| Right click | Context menu |
| Middle click | Open in new tab (links) |
| Ctrl+click | Add to selection |
| Shift+click | Range select |

---

## Keyboard Navigation

### Focus Management

```
Tab order:
┌────────────────────────────────────────┐
│ [1: Search] ─────────────────  [2: ?]  │
├────────────────────────────────────────┤
│ [3: Nav 1] [4: Nav 2] [5: Nav 3]       │
├────────────────────────────────────────┤
│           [6: First input]             │
│           [7: Second input]            │
│           [8: Submit button]           │
└────────────────────────────────────────┘
```

**Rules:**
- Logical left-to-right, top-to-bottom order
- Skip decorative/non-interactive elements
- Trap focus in modals
- Return focus after modal closes

### Keyboard Shortcuts

**Standard shortcuts (don't override):**
| Shortcut | Action |
|----------|--------|
| Ctrl+C/V/X | Copy/Paste/Cut |
| Ctrl+Z/Y | Undo/Redo |
| Ctrl+S | Save |
| Ctrl+F | Find |
| Ctrl+A | Select all |
| Escape | Close/Cancel |
| Enter | Submit/Confirm |
| Tab/Shift+Tab | Navigate focus |

**App-specific shortcuts:**
- Document in UI (tooltips, menu items)
- Provide keyboard shortcut reference
- Allow customization for power users

### Focus Indicators

**Visible focus is mandatory:**
```
Focused button:
┌──────────────────┐
│     Action       │  ← 2px outline
└──────────────────┘

Focused input:
┌──────────────────┐
│ Text input       │  ← Border color change + glow
└──────────────────┘
```

**Guidelines:**
- 3:1 contrast ratio minimum
- Don't remove, enhance for custom styles
- Consistent style across app

---

## Desktop Navigation Patterns

### Sidebar Navigation

```
┌────────┬────────────────────────────────┐
│ Logo   │ Search...          [?] [⚙] [👤]│
├────────┼────────────────────────────────┤
│        │                                │
│ 🏠 Home │                                │
│ 📊 Dash │        Main Content           │
│ 📋 List │                                │
│ 📈 Reports│                               │
│        │                                │
├────────┤                                │
│ ⚙ Settings│                              │
│ ❓ Help │                                │
└────────┴────────────────────────────────┘
```

**Guidelines:**
- Collapsible for more content space
- Icons + labels (or icons only when collapsed)
- Highlight current section
- Group related items
- Fixed or sticky position

### Top Navigation

```
┌─────────────────────────────────────────────┐
│ Logo  [Home] [Products] [About]  [Login]    │
├─────────────────────────────────────────────┤
│                                             │
│              Main Content                   │
│                                             │
└─────────────────────────────────────────────┘
```

**Guidelines:**
- Best for < 7 primary destinations
- Dropdowns for subcategories
- Mega menus for complex navigation
- Right side: user actions, search

### Breadcrumbs

```
Home > Category > Subcategory > Current Page
```

**Guidelines:**
- Show path, not history
- All items except last are links
- Truncate middle items if too long
- Don't use as only navigation

---

## Window Management

### Responsive Layouts

**Breakpoints:**
| Name | Width | Columns |
|------|-------|---------|
| Compact | < 600px | 1 |
| Medium | 600-900px | 2 |
| Expanded | 900-1200px | 3 |
| Large | > 1200px | 4+ |

### Multi-Pane Layouts

**Master-Detail:**
```
┌──────────────┬──────────────────────────────┐
│              │                              │
│   List       │         Detail View          │
│   Items      │                              │
│              │                              │
└──────────────┴──────────────────────────────┘
```

**Three-Column:**
```
┌───────┬───────────────┬──────────────────────┐
│       │               │                      │
│ Nav   │   List        │      Detail          │
│       │               │                      │
│       │               │                      │
└───────┴───────────────┴──────────────────────┘
```

### Resizable Panes

```
┌──────────────│──────────────────────────────┐
│              ┃                              │
│   List       ┃         Detail View          │
│              ┃ ← Drag handle                │
│              ┃                              │
└──────────────│──────────────────────────────┘
```

**Guidelines:**
- Show resize cursor on hover
- Set minimum widths
- Remember user preference
- Double-click to reset

---

## Desktop Components

### Toolbars

```
┌────────────────────────────────────────────────┐
│ [📁] [💾] [↩️] [↪️]  |  [B] [I] [U]  |  [🎨▾] │
└────────────────────────────────────────────────┘
```

**Guidelines:**
- Group related tools with dividers
- Icon buttons with tooltips
- Dropdown for variants
- Can be customizable

### Menu Bar

```
┌────────────────────────────────────────────────┐
│ File   Edit   View   Help                      │
├────────┐                                       │
│ New     Ctrl+N                                 │
│ Open    Ctrl+O                                 │
│ Save    Ctrl+S                                 │
├────────┤                                       │
│ Exit                                           │
└────────┘                                       │
```

**Guidelines:**
- Standard order: File, Edit, View, Help
- Show keyboard shortcuts
- Use dividers to group
- Submenus for complex options (limit depth)

### Context Menus

```
Right-click:
┌────────────────────┐
│ Open               │
│ Open with...    ▶ │
├────────────────────┤
│ Cut          Ctrl+X│
│ Copy         Ctrl+C│
│ Paste        Ctrl+V│
├────────────────────┤
│ Delete             │
└────────────────────┘
```

**Guidelines:**
- Most common actions at top
- Show keyboard shortcuts
- Group with dividers
- Keep reasonable length (< 15 items)

### Data Tables

```
┌──────────────────────────────────────────────────────┐
│ ☐ │ Name ▲      │ Status    │ Date       │ Actions  │
├───┼─────────────┼───────────┼────────────┼──────────┤
│ ☐ │ Item 1      │ ● Active  │ 2024-01-15 │ [⋮]      │
│ ☑ │ Item 2      │ ○ Pending │ 2024-01-14 │ [⋮]      │
│ ☐ │ Item 3      │ ● Active  │ 2024-01-13 │ [⋮]      │
├───┴─────────────┴───────────┴────────────┴──────────┤
│ ◀ 1 2 3 ... 10 ▶    Showing 1-10 of 97              │
└──────────────────────────────────────────────────────┘
```

**Features:**
- Sortable columns
- Resizable columns
- Row selection (checkbox)
- Inline actions
- Pagination

---

## Dialogs & Modals

### Modal Dialog

```
┌────────────────────────────────────────┐
│ Dialog Title                      [✕]  │
├────────────────────────────────────────┤
│                                        │
│   Dialog content goes here.            │
│   Can include forms, information,      │
│   or confirmations.                    │
│                                        │
├────────────────────────────────────────┤
│               [Cancel]  [Confirm]      │
└────────────────────────────────────────┘
```

**Guidelines:**
- Clear title describing purpose
- Close button in corner
- Action buttons in footer (Cancel left, Confirm right)
- Focus trap while open
- Escape to close

### Non-Modal (Modeless)

```
┌────────────────────────────────────────┐
│ Find and Replace                  [✕]  │
├────────────────────────────────────────┤
│ Find:    [________________________]    │
│ Replace: [________________________]    │
│ [Find Next] [Replace] [Replace All]    │
└────────────────────────────────────────┘
```

**Use for:**
- Find/replace
- Properties panels
- Tool options
- Ongoing tasks while working

---

## Desktop Anti-Patterns

1. **No hover states:** Interactive elements need hover feedback
2. **Ignoring keyboard:** All actions must be keyboard accessible
3. **Fixed layouts:** Not adapting to window size
4. **Mobile patterns:** Touch-first patterns on desktop
5. **No right-click:** Missing context menus
6. **Tiny targets:** Below 24px click targets
7. **Hidden scrollbars:** Users need to see scroll position
8. **Missing shortcuts:** Common actions without keyboard shortcuts
