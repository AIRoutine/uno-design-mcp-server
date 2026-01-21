# Feedback & Response Design

**Purpose:** Acknowledge every user action immediately to create confidence and trust.

---

## Why Feedback Matters

Without feedback:
- Users wonder if their action worked
- They tap/click repeatedly (causing errors)
- They lose trust in the application
- They feel frustrated and confused

With good feedback:
- Users feel in control
- They understand system state
- They wait patiently for results
- They trust the application

---

## Types of Feedback

### 1. Visual Feedback

**Button States:**
```
Default    → Resting state
Hover      → Mouse over (desktop)
Pressed    → Active/down state
Focused    → Keyboard focus ring
Disabled   → Grayed out, no interaction
Loading    → Spinner or progress
```

**Animations:**
- Page transitions (slide, fade, scale)
- Element transitions (expand, collapse)
- Micro-interactions (checkmark, bounce)
- Progress indicators (spinner, bar, skeleton)

**Color Changes:**
- Success: Green tint/checkmark
- Error: Red tint/shake animation
- Warning: Yellow/orange tint
- Info: Blue tint

### 2. Haptic Feedback (Mobile)

**Use Cases:**
- Button taps: Light impact
- Success: Success pattern
- Error: Error pattern (double tap)
- Swipe completion: Medium impact
- Pull-to-refresh: Light on start, medium on release

**Guidelines:**
- Keep it subtle
- Match intensity to action importance
- Respect user settings
- Don't overuse

### 3. Audio Feedback (Optional)

**Use sparingly:**
- Message received
- Error alerts
- Completion sounds
- Notifications

**Always:**
- Provide mute option
- Respect system volume
- Make optional

---

## Timing Guidelines

### Immediate (0-100ms)
User perceives as instantaneous.

**Use for:**
- Button press states
- Hover effects
- Focus indicators
- Touch highlights

### Short (100-300ms)
User perceives action is happening.

**Use for:**
- Micro-animations
- State transitions
- Element transitions
- Toggle animations

### Medium (300-1000ms)
User waits but stays engaged.

**Use for:**
- Page transitions
- Loading spinners (simple)
- Skeleton screens
- Progress indication

### Long (>1000ms)
User needs progress information.

**Use for:**
- Progress bars with percentage
- Step indicators
- Estimated time remaining
- Background task status

---

## Loading States

### Skeleton Screens
Show the structure before content loads.

```
┌─────────────────────────┐
│ ████████████            │  ← Avatar placeholder
│ ████████████████████    │  ← Title placeholder
│ ██████████████████████  │  ← Content placeholder
│ ██████████              │  ← Content placeholder
└─────────────────────────┘
```

**Best for:** Content that loads in sections

### Spinners
Circular loading indicator.

**Guidelines:**
- Use for short, indeterminate waits
- Center in the loading area
- Include text if > 3 seconds

### Progress Bars
Linear progress indicator.

**Guidelines:**
- Use for determinate progress
- Show percentage if possible
- Never go backwards

### Optimistic UI
Update UI before server confirms.

**Use for:**
- Like/favorite actions
- Message sending
- Status updates
- Non-critical data

---

## Error Feedback

### Inline Validation
Show errors immediately at the field.

```
┌─────────────────────────┐
│ Email                   │
│ ┌─────────────────────┐ │
│ │ not-an-email        │ │  ← Red border
│ └─────────────────────┘ │
│ ⚠ Please enter valid    │  ← Error message
│   email address         │
└─────────────────────────┘
```

### Toast/Snackbar
Temporary message that auto-dismisses.

**Use for:**
- Success confirmations
- Non-critical errors
- Status updates
- Undo prompts

**Guidelines:**
- Show for 3-5 seconds
- Allow dismiss
- Don't stack too many
- Position consistently

### Modal Alerts
Interrupting dialog requiring action.

**Use ONLY for:**
- Critical errors
- Data loss warnings
- Irreversible actions
- Required confirmations

---

## Best Practices

### 1. Always Acknowledge
Every tap, click, or gesture needs response.

### 2. Match Importance
Big actions = big feedback
Small actions = subtle feedback

### 3. Don't Block
Allow users to continue while background tasks run.

### 4. Show Progress
If something takes time, show that it's working.

### 5. Provide Escape
Long operations should be cancellable.

### 6. Handle Errors Gracefully
- Explain what went wrong
- Suggest how to fix
- Provide retry option

---

## Anti-Patterns

1. **No loading indicator:** User thinks app is frozen
2. **Blocking UI:** User can't do anything while waiting
3. **Mystery errors:** "Error occurred" with no details
4. **Disappearing feedback:** Message gone before read
5. **Inconsistent placement:** Errors appear randomly
6. **No confirmation:** User unsure if action completed
