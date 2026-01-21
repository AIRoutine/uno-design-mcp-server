# Laws of UX for Efficient Interface Design

A collection of psychological principles that guide the creation of efficient, user-friendly interfaces.

---

## Decision Laws (Reducing Choice Complexity)

### Hick's Law

> **The time to make a decision increases with the number and complexity of choices.**

```
DECISION TIME FORMULA:
RT = a + b * log2(n)

Where:
- RT = Reaction Time
- n  = Number of choices
- a, b = Constants
```

**Application:**

| Choices | Decision Time | Recommendation |
|---------|---------------|----------------|
| 2-3 | Fast | Ideal for quick actions |
| 4-6 | Moderate | Good for main navigation |
| 7+ | Slow | Break into categories |
| 15+ | Very slow | Use search instead |

**DO:**
```
┌─────────────────────┐
│ Main Navigation     │
├─────────────────────┤
│ Home                │
│ Products            │  <- 5 items: Fast decisions
│ Services            │
│ About               │
│ Contact             │
└─────────────────────┘
```

**DON'T:**
```
┌─────────────────────┐
│ Home | Products |   │
│ Services | About |  │
│ Contact | Blog |    │  <- 12 items: Decision paralysis
│ FAQ | Support |     │
│ Careers | News |    │
│ Partners | Press    │
└─────────────────────┘
```

**Strategies:**
1. Limit primary options to 5-7 items
2. Group related items into categories
3. Highlight recommended/default option
4. Progressive disclosure for advanced options
5. Provide search for large datasets

---

### Miller's Law

> **The average person can hold 7 (plus or minus 2) items in working memory.**

```
WORKING MEMORY CAPACITY:
┌───┬───┬───┬───┬───┬───┬───┐
│ 1 │ 2 │ 3 │ 4 │ 5 │ 6 │ 7 │  <- Comfortable
└───┴───┴───┴───┴───┴───┴───┘
          ↓
    Chunk into groups
          ↓
┌─────────┐ ┌─────────┐ ┌─────────┐
│ Group 1 │ │ Group 2 │ │ Group 3 │
│ a, b, c │ │ d, e, f │ │ g, h, i │
└─────────┘ └─────────┘ └─────────┘
```

**Application:**
- Phone numbers: 555-123-4567 (chunked) vs 5551234567 (not chunked)
- Navigation: Group related items
- Forms: Break into logical sections
- Content: Use headings and sections

**Mobile vs Desktop:**

| Context | Recommended Items | Reason |
|---------|-------------------|--------|
| Mobile nav | 4-5 | Limited screen, thumb reach |
| Desktop nav | 5-7 | More space, mouse precision |
| Dropdown | 7-10 | Scrollable, searchable |
| Card grid | 6-9 | Visual scanning |

---

### Paradox of Choice

> **More options lead to less satisfaction and higher anxiety.**

**The Problem:**
```
32 JAM OPTIONS:           6 JAM OPTIONS:
┌─────────────────┐       ┌─────────────────┐
│ ▢ ▢ ▢ ▢ ▢ ▢ ▢ ▢│       │ ▢ ▢ ▢           │
│ ▢ ▢ ▢ ▢ ▢ ▢ ▢ ▢│       │ ▢ ▢ ▢           │
│ ▢ ▢ ▢ ▢ ▢ ▢ ▢ ▢│       └─────────────────┘
│ ▢ ▢ ▢ ▢ ▢ ▢ ▢ ▢│
└─────────────────┘       3% purchased        30% purchased
```

**Solutions:**
1. Curate options (show best 3-5)
2. Provide clear recommendations
3. Allow filtering to narrow choices
4. Show "most popular" or "recommended"
5. Smart defaults based on user context

---

## Interaction Laws (Optimizing Physical Actions)

### Fitts's Law

> **The time to reach a target depends on the distance to it and its size.**

```
MOVEMENT TIME FORMULA:
MT = a + b * log2(D/W + 1)

Where:
- MT = Movement Time
- D  = Distance to target
- W  = Width of target
```

**Visual Representation:**
```
HARD TO HIT:                    EASY TO HIT:
┌─────────────────────────┐     ┌─────────────────────────┐
│                         │     │                         │
│                    [x]  │     │  ┌─────────────────┐    │
│                         │     │  │                 │    │
│ Current                 │     │  │   Large Target  │    │
│ Position                │     │  │                 │    │
│    ●─ ─ ─ ─ ─ ─ ─ ─ ─ →│     │  └─────────────────┘    │
│                         │     │         ●               │
└─────────────────────────┘     └─────────────────────────┘
     Far + Small = Slow              Near + Large = Fast
```

**Practical Guidelines:**

| Element | Minimum Size | Recommended Size |
|---------|--------------|------------------|
| Touch target (mobile) | 44x44 dp | 48x48 dp |
| Click target (desktop) | 24x24 px | 32x32 px |
| Primary button | 44px height | 48-56px height |
| Icon button | 40x40 dp | 48x48 dp |

**Edge/Corner Advantage:**
Screen edges and corners have "infinite" width - the cursor can't overshoot.

```
┌─────────────────────────────────────┐
│ [Menu]                    [Close] X │ <- Corners are easy targets
│                                     │
│                                     │
│                                     │
│                                     │
│                                     │
│ [←]                            [→]  │ <- Edges are easy targets
└─────────────────────────────────────┘
```

---

### Doherty Threshold

> **Productivity soars when response time is under 400 milliseconds.**

```
RESPONSE TIME PERCEPTION:
┌──────────────────────────────────────────────────────┐
│ 0-100ms    │ ████████████████████ │ Instant         │
│ 100-300ms  │ ████████████████     │ Fast            │
│ 300-1000ms │ ████████████         │ Noticeable      │
│ 1-10s      │ ████████             │ Slow (progress) │
│ 10s+       │ ████                 │ User gives up   │
└──────────────────────────────────────────────────────┘
```

**Implementation:**

| Response Time | User Perception | Required UI |
|---------------|-----------------|-------------|
| <100ms | Instantaneous | None needed |
| 100-400ms | Smooth | Subtle feedback (ripple) |
| 400ms-1s | Delay felt | Loading indicator |
| 1-5s | Waiting | Progress bar |
| 5s+ | Frustrated | Progress + time estimate |

**Techniques for Speed:**
1. Optimistic updates (show success immediately)
2. Skeleton screens (show layout while loading)
3. Progressive loading (show content as it arrives)
4. Preloading (anticipate user's next action)
5. Caching (store frequently used data)

---

### Goal-Gradient Effect

> **People accelerate behavior as they approach a goal.**

```
PROGRESS VISUALIZATION:
┌─────────────────────────────────────────────┐
│ Step 1    Step 2    Step 3    Step 4        │
│   ●─────────●─────────●─────────○           │
│   ✓         ✓         ✓      (current)      │
│                                             │
│ "Almost there! Just one more step."         │
└─────────────────────────────────────────────┘
```

**Application:**
- Progress bars that show completion percentage
- Checklists that show completed items
- Gamification with visible progress
- "X of Y completed" indicators

**Start with Progress:**
```
BAD:                          GOOD:
┌──────────────────────┐      ┌──────────────────────┐
│ Progress: 0%         │      │ Progress: 20%        │
│ ○○○○○○○○○○           │      │ ●●○○○○○○○○           │
│                      │      │ (Profile created!)   │
└──────────────────────┘      └──────────────────────┘
```

---

## Perception Laws (Visual Organization)

### Gestalt Principles

> **Humans perceive visual elements as organized patterns and groups.**

#### Proximity
Elements close together are perceived as related.

```
UNRELATED:                    RELATED:
┌──────────────────────┐      ┌──────────────────────┐
│ ○   ○   ○   ○   ○    │      │ ○ ○ ○    ○ ○    ○    │
│                      │      │ Group1   Group2  Single│
└──────────────────────┘      └──────────────────────┘
```

#### Similarity
Similar elements are perceived as part of the same group.

```
┌──────────────────────┐
│ ● ● ● ○ ○ ○ ○        │
│ Filled = Selected    │
│ Empty = Unselected   │
└──────────────────────┘
```

#### Continuity
Elements arranged in a line or curve are perceived as related.

```
┌──────────────────────────┐
│    ●                     │
│      ●                   │
│        ●                 │  <- Perceived as one line
│          ●               │
│            ●             │
└──────────────────────────┘
```

#### Closure
The mind completes incomplete shapes.

```
┌──────────────────────┐
│    ╭───╮             │
│    │   │   = Square  │  <- We see a complete shape
│    ╰   ╯             │
└──────────────────────┘
```

#### Common Region
Elements within a boundary are grouped together.

```
┌─────────────────────────────────┐
│ ┌─────────┐   ┌─────────┐       │
│ │ ○ ○ ○   │   │ ○ ○ ○   │       │
│ │ Group A │   │ Group B │       │
│ └─────────┘   └─────────┘       │
└─────────────────────────────────┘
```

---

### Serial Position Effect

> **People remember the first and last items in a series best.**

```
MEMORY CURVE:
┌─────────────────────────────────────────┐
│ High  ●                           ●     │
│       │ ●                       ● │     │
│       │   ●                   ●   │     │
│       │     ●     ●     ●   ●     │     │
│ Low   │       ● ●   ● ●           │     │
│       └─────────────────────────────    │
│         First  Middle Items  Last       │
│         (Primacy)           (Recency)   │
└─────────────────────────────────────────┘
```

**Application:**
- Put most important items first and last
- Key actions at start and end of menus
- Important info at beginning and end of text

---

### Von Restorff Effect (Isolation Effect)

> **Items that stand out from their surroundings are more memorable.**

```
WHICH STANDS OUT?
┌───────────────────────────────────────┐
│ ○  ○  ○  ●  ○  ○  ○                   │
│          ↑                            │
│    The different one is remembered    │
└───────────────────────────────────────┘
```

**Application:**
- Highlight primary CTA with different color
- Use visual distinction for important items
- Badges for notifications
- Different styling for current/selected state

---

## Quick Reference Table

| Law | Core Insight | Design Action |
|-----|--------------|---------------|
| Hick's | More choices = slower decisions | Limit options to 5-7 |
| Miller's | 7±2 working memory limit | Chunk information |
| Fitts's | Size and distance matter | Large, close targets |
| Doherty | <400ms feels instant | Optimize response time |
| Goal-Gradient | Progress motivates | Show completion status |
| Gestalt | We see patterns | Use proximity, similarity |
| Serial Position | First/last remembered | Important items at ends |
| Von Restorff | Different = memorable | Highlight key elements |
