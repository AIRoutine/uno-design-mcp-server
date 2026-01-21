# Task Flow Optimization & Click Budgets

**Goal:** Get users to their goal in the minimum number of steps.

---

## The Click Budget Concept

Every task has a "click budget" - the maximum interactions a user should need.

```
CLICK BUDGET BY TASK FREQUENCY:
┌────────────────────────────────────────────────────────────────┐
│ Task Frequency    │ Max Clicks │ Examples                      │
├───────────────────┼────────────┼───────────────────────────────┤
│ Multiple per day  │     1      │ Check notifications, refresh  │
│ Daily             │     2      │ View dashboard, send message  │
│ Weekly            │     3      │ Create new item, run report   │
│ Monthly           │    4-5     │ Update profile, export data   │
│ Rarely            │    5+      │ Account setup, advanced config│
└────────────────────────────────────────────────────────────────┘
```

---

## Analyzing Task Flows

### Step 1: Identify the User's Goal

What is the user trying to accomplish?

```
USER GOAL: "I want to send a message to my team"

Current flow:                     Optimized flow:
1. Open app                       1. Open app
2. Click "Teams"                  2. Click "New Message"
3. Select team                    3. Type message, select team
4. Click "Messages"               4. Send
5. Click "New Message"
6. Type message
7. Send

7 steps → 4 steps (43% reduction)
```

### Step 2: Map Every Step

```
TASK: Purchase an item

┌─────┐   ┌─────────┐   ┌───────┐   ┌──────────┐   ┌─────────┐
│Find │ → │ View    │ → │ Add   │ → │ Checkout │ → │ Confirm │
│Item │   │ Details │   │ Cart  │   │          │   │         │
└─────┘   └─────────┘   └───────┘   └──────────┘   └─────────┘
  ↓           ↓            ↓            ↓             ↓
Search     Read info    Click      Enter info     Review &
Browse     Check price  button     Payment        Submit
Filter     See reviews             Shipping

CLICKS:  2-5       1-2         1         5-10          2
TOTAL: 11-20 clicks for purchase
```

### Step 3: Eliminate/Combine/Automate

```
OPTIMIZATIONS:
┌──────────────────┬─────────────────────────────────────────────┐
│ Step             │ Optimization                                │
├──────────────────┼─────────────────────────────────────────────┤
│ Find Item        │ Better search, personalized recommendations │
│ View Details     │ Quick view modal instead of new page        │
│ Add to Cart      │ One-click add, visual confirmation          │
│ Checkout         │ Saved payment/shipping, express checkout    │
│ Confirm          │ Single "Place Order" with summary           │
└──────────────────┴─────────────────────────────────────────────┘

OPTIMIZED: 5-8 clicks for purchase (50%+ reduction)
```

---

## Common Flow Optimizations

### 1. Skip Unnecessary Steps

```
BEFORE:
Home → Category → Subcategory → Product → Add to Cart → Cart → Checkout

AFTER:
Home → Product (via search) → Add to Cart → Checkout
       └─ OR via recommendation
```

### 2. Combine Related Actions

```
BEFORE:                          AFTER:
┌─────────────────┐              ┌─────────────────┐
│ Select quantity │              │ [1] [+][-]      │
│ [dropdown]      │              │ [Add to Cart]   │
│                 │              │                 │
│ [Add to Cart]   │              │ (one interaction│
│                 │              │  does both)     │
└─────────────────┘              └─────────────────┘
```

### 3. Smart Defaults

```
BEFORE:                          AFTER:
┌─────────────────┐              ┌─────────────────┐
│ Select country  │              │ Country: 🇩🇪     │
│ [▼ Choose...]   │              │ (auto-detected) │
│                 │              │ [change]        │
│ Select language │              │                 │
│ [▼ Choose...]   │              │ (0 clicks for   │
│                 │              │  90% of users)  │
└─────────────────┘              └─────────────────┘
```

### 4. Inline Editing

```
BEFORE:                          AFTER:
Click "Edit" →                   Click on text →
New page loads →                 Text becomes editable →
Make changes →                   Make changes →
Click "Save" →                   Click away or Enter →
Return to original page          Auto-saved

5 interactions                   2 interactions
```

### 5. Keyboard Shortcuts (Power Users)

```
STANDARD FLOW:          POWER USER FLOW:
Click File →            Ctrl+S
Click Save              (1 action)
(2 clicks)

Click Search →          Ctrl+K or /
Type query              Type query
(2 actions)             (1-2 actions)
```

---

## Flow Patterns by Task Type

### CRUD Operations

| Operation | Standard | Optimized |
|-----------|----------|-----------|
| Create | Navigate + Click New + Fill Form + Submit | FAB/Shortcut + Minimal Form + Auto-save |
| Read | Navigate + Click Item | Search/Filter + Quick Preview |
| Update | Navigate + Click Item + Click Edit + Change + Save | Click Item + Inline Edit + Auto-save |
| Delete | Navigate + Click Item + Click Delete + Confirm | Swipe/Select + Delete + Undo available |

### Navigation Patterns

```
HIERARCHICAL (Deep):
Home → Section → Subsection → Item → Detail
(5 levels = 4+ clicks)

FLAT (Search-based):
Home → Search → Item
(3 levels = 2 clicks)

DIRECT ACCESS:
- Favorites/Recent
- Deep links
- Keyboard shortcuts
- Command palette
```

### Form Patterns

```
MULTI-PAGE FORM:             SINGLE-PAGE FORM:
┌──────────────────┐         ┌──────────────────┐
│ Page 1 of 5      │         │ All fields       │
│ [Next]           │         │ visible          │
├──────────────────┤         │ with sections    │
│ Page 2 of 5      │         │                  │
│ [Next]           │         │ [Submit]         │
├──────────────────┤         └──────────────────┘
│ ...              │
│ [Submit]         │         Better for <10 fields
└──────────────────┘
5+ clicks                    1 click
```

---

## Measuring Flow Efficiency

### Key Metrics

| Metric | Description | Target |
|--------|-------------|--------|
| Task Completion Rate | % of users who complete | >90% |
| Time on Task | Seconds to complete | Minimize |
| Clicks to Complete | Number of interactions | Match budget |
| Error Rate | % with mistakes | <5% |
| Abandonment Point | Where users give up | Eliminate |

### Funnel Analysis

```
USER FLOW FUNNEL:
┌─────────────────────────────────────┐ 100% Start
│█████████████████████████████████████│
└─────────────────────────────────────┘
         ↓ Step 1
┌─────────────────────────────────┐ 85%
│█████████████████████████████████│
└─────────────────────────────────┘
         ↓ Step 2
┌───────────────────────────┐ 70%
│███████████████████████████│
└───────────────────────────┘
         ↓ Step 3
┌─────────────────────┐ 55%  ← Problem here!
│█████████████████████│         Large drop-off
└─────────────────────┘
         ↓ Step 4
┌──────────────────┐ 50%
│██████████████████│
└──────────────────┘
         ↓ Complete
```

---

## Quick Reference: Common Tasks

| Task | Click Budget | Optimization |
|------|--------------|--------------|
| Login | 2-3 | Biometric, "Remember me" |
| Search | 1-2 | Prominent search, auto-complete |
| Create new item | 2-3 | FAB, minimal required fields |
| Edit item | 1-2 | Inline editing, auto-save |
| Delete item | 2 | Swipe action + undo |
| Share | 1-2 | Share sheet, copy link |
| View notifications | 1 | Badge + dropdown |
| Switch accounts | 1-2 | Account picker in header |
| Access settings | 2 | Profile → Settings |
| Get help | 2 | Persistent help icon |

---

## Checklist

- [ ] Core tasks are achievable in ≤3 clicks
- [ ] Daily tasks are achievable in ≤2 clicks
- [ ] Search is always 1 click away
- [ ] Primary action is visible on every screen
- [ ] Forms have minimal required fields
- [ ] Smart defaults reduce decisions
- [ ] Power users have keyboard shortcuts
- [ ] Progress is shown for multi-step tasks
- [ ] Undo is available for destructive actions
- [ ] Error recovery doesn't restart the flow
