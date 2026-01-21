# Cognitive Load Reduction

**Goal:** Minimize the mental effort required to use your interface.

---

## Types of Cognitive Load

```
┌─────────────────────────────────────────────────────────────────┐
│                    TOTAL COGNITIVE LOAD                         │
├─────────────────────┬─────────────────────┬─────────────────────┤
│   INTRINSIC LOAD    │  EXTRANEOUS LOAD    │   GERMANE LOAD      │
│   (Unavoidable)     │  (Eliminate this!)  │   (Desirable)       │
├─────────────────────┼─────────────────────┼─────────────────────┤
│ Complexity of the   │ Bad design adding   │ Learning & building │
│ task itself         │ unnecessary effort  │ mental models       │
│                     │                     │                     │
│ • Tax form is       │ • Confusing layout  │ • Understanding     │
│   complex           │ • Unclear labels    │   patterns          │
│ • Medical records   │ • Hidden features   │ • Building skills   │
│   are detailed      │ • Inconsistent UI   │ • Gaining expertise │
└─────────────────────┴─────────────────────┴─────────────────────┘
         ↓                      ↓                      ↓
    Can't reduce          REDUCE THIS!           Keep/encourage
```

---

## The Four Questions

For every UI element, ask:

```
┌─────────────────────────────────────────────────────────────────┐
│ 1. Can it be REMOVED?                                           │
│    - Is this element necessary?                                 │
│    - Does removing it hurt the user?                            │
│                                                                 │
│ 2. Can it be AUTOMATED?                                         │
│    - Can the system decide for the user?                        │
│    - Can we use smart defaults?                                 │
│                                                                 │
│ 3. Can it be COMBINED?                                          │
│    - Can multiple steps become one?                             │
│    - Can fields be merged?                                      │
│                                                                 │
│ 4. Can it be HIDDEN?                                            │
│    - Can it appear only when needed?                            │
│    - Is progressive disclosure appropriate?                     │
└─────────────────────────────────────────────────────────────────┘
```

---

## Reduction Strategies

### 1. Remove Unnecessary Elements

```
BEFORE:
┌─────────────────────────────────────────────────────────────┐
│ Welcome to Our Amazing Platform! We're so glad you're here. │
│ Please fill out this quick form to get started on your      │
│ journey with us. Don't worry, it only takes a moment!       │
│                                                             │
│ First Name*:        [_______________]                       │
│ Middle Name:        [_______________]                       │
│ Last Name*:         [_______________]                       │
│ Preferred Name:     [_______________]                       │
│ Email*:             [_______________]                       │
│ Confirm Email*:     [_______________]                       │
│ How did you hear about us? [dropdown___________]            │
│                                                             │
│ [ ] I agree to the terms (required to continue)             │
│                                                             │
│            [Create Account]                                 │
└─────────────────────────────────────────────────────────────┘

AFTER:
┌─────────────────────────────────────────────────────────────┐
│ Create Account                                              │
│                                                             │
│ Name:     [_______________]                                 │
│ Email:    [_______________]                                 │
│                                                             │
│ [Create Account]                                            │
│                                                             │
│ By creating an account, you agree to our Terms.             │
└─────────────────────────────────────────────────────────────┘

REMOVED:
- Marketing fluff
- Middle/preferred name (ask later if needed)
- Confirm email (show what they typed)
- "How did you hear" (analytics can track this)
- Checkbox (link is sufficient)
```

### 2. Automate Decisions

```
MANUAL:                              AUTOMATED:
┌──────────────────────────┐         ┌──────────────────────────┐
│ Select your country:     │         │ Country: Germany 🇩🇪      │
│ [dropdown with 200+]     │         │ (detected) [change]      │
│                          │         │                          │
│ Select currency:         │         │ Prices shown in EUR      │
│ [dropdown]               │         │                          │
│                          │         │                          │
│ Select language:         │         │ Language: Deutsch        │
│ [dropdown]               │         │ [change]                 │
└──────────────────────────┘         └──────────────────────────┘

AUTO-DETECTED:
- Location from IP/GPS
- Currency from location
- Language from browser
- Date format from locale
- Time zone from device
```

### 3. Combine Steps

```
MULTI-STEP:                         COMBINED:
┌────────────────────┐              ┌────────────────────┐
│ Step 1: Enter name │              │                    │
│ [___________]      │              │ Daniel             │
│      [Next]        │              │ daniel@email.com   │
├────────────────────┤              │ ••••••••           │
│ Step 2: Enter email│       ->     │                    │
│ [___________]      │              │ [Create Account]   │
│      [Next]        │              │                    │
├────────────────────┤              └────────────────────┘
│ Step 3: Password   │              1 step instead of 3
│ [___________]      │
│      [Submit]      │
└────────────────────┘
```

### 4. Hide Until Needed (Progressive Disclosure)

```
LEVEL 1 - Always visible:
┌─────────────────────────────────────────────────────────────┐
│ Font Size:  [Small ▼]                                       │
│ ▸ More formatting options                                   │
└─────────────────────────────────────────────────────────────┘

LEVEL 2 - On expand:
┌─────────────────────────────────────────────────────────────┐
│ Font Size:  [Small ▼]                                       │
│ ▾ More formatting options                                   │
│   ┌─────────────────────────────────────────────────────┐   │
│   │ Line Height: [1.5 ▼]                                │   │
│   │ Letter Spacing: [Normal ▼]                          │   │
│   │ ▸ Advanced typography                               │   │
│   └─────────────────────────────────────────────────────┘   │
└─────────────────────────────────────────────────────────────┘

LEVEL 3 - Deep options:
┌─────────────────────────────────────────────────────────────┐
│   │ ▾ Advanced typography                               │   │
│   │   ┌─────────────────────────────────────────────┐   │   │
│   │   │ Font Feature Settings: [___]                │   │   │
│   │   │ Text Rendering: [Auto ▼]                    │   │   │
│   │   └─────────────────────────────────────────────┘   │   │
└─────────────────────────────────────────────────────────────┘
```

---

## Visual Complexity Reduction

### Reduce Visual Noise

```
NOISY:                              CLEAN:
┌─────────────────────────┐         ┌─────────────────────────┐
│ ╔═══════════════════╗   │         │                         │
│ ║ IMPORTANT BOX     ║   │         │ Section Title           │
│ ╚═══════════════════╝   │         │ ─────────────           │
│ ┌───────────────────┐   │         │                         │
│ │ Another box       │   │         │ Content here            │
│ │ with border       │   │         │                         │
│ └───────────────────┘   │         │                         │
│ ▸ Arrow bullet          │         │ • Simple bullet         │
│ ★ Star bullet           │         │ • Another item          │
│ ➤ Another arrow         │         │ • Third item            │
└─────────────────────────┘         └─────────────────────────┘
```

### Use Consistent Patterns

```
INCONSISTENT:                       CONSISTENT:
┌─────────────────────────┐         ┌─────────────────────────┐
│ [Save] (Cancel)         │         │ [Save]  [Cancel]        │
│                         │         │                         │
│ <Delete>  |Confirm|     │         │ [Delete] [Confirm]      │
│                         │         │                         │
│ {Submit}  [Reset]       │         │ [Submit] [Reset]        │
└─────────────────────────┘         └─────────────────────────┘
```

### Establish Clear Hierarchy

```
NO HIERARCHY:                       CLEAR HIERARCHY:
┌─────────────────────────┐         ┌─────────────────────────┐
│ Text                    │         │ MAIN HEADING            │
│ More text               │         │                         │
│ Even more text          │         │ Supporting text that    │
│ Text text text          │         │ explains the heading.   │
│ Link                    │         │                         │
│ Another link            │         │ [Primary Action]        │
│ Button                  │         │                         │
│ Another button          │         │ Secondary link          │
└─────────────────────────┘         └─────────────────────────┘
```

---

## Content Simplification

### Writing for Low Cognitive Load

| Instead of | Write |
|------------|-------|
| "In order to proceed with the completion of your transaction..." | "To complete your order..." |
| "Please be advised that your session will be terminated..." | "Your session will end..." |
| "Authentication credentials" | "Password" |
| "Utilize" | "Use" |
| "Commence" | "Start" |
| "Terminate" | "End" |

### Structure for Scanning

```
HARD TO SCAN:
The system will process your request and send a confirmation
email to the address you provided within 24 hours. If you
don't receive the email, please check your spam folder or
contact support at support@example.com.

EASY TO SCAN:
✓ Request received
✓ Confirmation email sent within 24 hours

No email? Check spam or contact support@example.com
```

---

## Measuring Cognitive Load

### Quantitative Signals

| Metric | High Load Indicator |
|--------|---------------------|
| Time on task | Much longer than expected |
| Error rate | >10% of users make mistakes |
| Abandonment | Users leave mid-task |
| Help requests | Frequent "how do I" questions |
| Rage clicks | Multiple rapid clicks on same element |

### Qualitative Signals

- Users say "this is confusing"
- Users ask "what does this mean?"
- Users hesitate before acting
- Users miss important elements
- Users take wrong paths frequently

---

## Cognitive Load Checklist

### Before Launch
- [ ] Every element serves the user's goal
- [ ] Default values are provided where possible
- [ ] Advanced options are hidden
- [ ] Language is simple and clear
- [ ] Visual hierarchy guides attention
- [ ] Patterns are consistent throughout
- [ ] Actions are reversible (undo available)

### Ongoing
- [ ] Monitor error rates
- [ ] Track task completion times
- [ ] Analyze abandonment points
- [ ] Review support tickets for confusion patterns
- [ ] Test with new users regularly
