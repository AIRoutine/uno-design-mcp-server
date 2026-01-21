# Doherty Threshold

> **Productivity soars when a computer and its users interact at a pace (<400ms) that ensures neither has to wait on the other.**

Named after Walter J. Doherty, who published research in 1982 showing that response times under 400ms dramatically increased productivity and user satisfaction.

---

## The Threshold

```
RESPONSE TIME IMPACT:
┌──────────────────────────────────────────────────────────────┐
│ Time        │ Perception      │ User State                   │
├─────────────┼─────────────────┼──────────────────────────────┤
│ 0-100ms     │ Instantaneous   │ Feels like direct control    │
│ 100-300ms   │ Immediate       │ Smooth, no frustration       │
│ 300-400ms   │ Fast            │ Slight awareness of delay    │
│ ═══════════════════════════════════════════════════════════ │
│             │ DOHERTY THRESHOLD (400ms)                      │
│ ═══════════════════════════════════════════════════════════ │
│ 400ms-1s    │ Noticeable      │ Attention starts to wander   │
│ 1-5s        │ Slow            │ Frustration builds           │
│ 5-10s       │ Very slow       │ May abandon task             │
│ 10s+        │ Broken          │ Assumes error, leaves        │
└──────────────────────────────────────────────────────────────┘
```

---

## Visual Feedback Requirements

| Response Time | Required Feedback | Example |
|---------------|-------------------|---------|
| <100ms | None needed | Button press highlight |
| 100-400ms | Subtle feedback | Ripple effect, color change |
| 400ms-1s | Loading indicator | Spinner, "Loading..." |
| 1-5s | Progress indicator | Progress bar |
| 5s+ | Progress + estimate | "Loading... 45% (about 10s)" |
| 10s+ | Progress + cancel option | Allow user to abort |

---

## Feedback Patterns

### Instant Feedback (<100ms)

```
BUTTON PRESS:
┌──────────────┐     ┌──────────────┐
│    Submit    │ --> │   [pressed]  │
│              │     │    Submit    │
└──────────────┘     └──────────────┘
   Normal              Pressed state
```

### Subtle Feedback (100-400ms)

```
RIPPLE EFFECT:
┌──────────────┐     ┌──────────────┐     ┌──────────────┐
│    Submit    │ --> │    Submit    │ --> │    Submit    │
│              │     │      ●       │     │              │
└──────────────┘     └──────────────┘     └──────────────┘
   Tap                 Ripple grows        Ripple fades
```

### Loading Indicator (400ms-1s)

```
SPINNER:
┌──────────────────────────────────────┐
│                                      │
│            ○ Loading...              │
│                                      │
└──────────────────────────────────────┘
```

### Progress Bar (1-5s)

```
DETERMINATE PROGRESS:
┌──────────────────────────────────────┐
│ Uploading file...                    │
│ ████████████░░░░░░░░░░░░░░  45%      │
│                                      │
└──────────────────────────────────────┘
```

### Progress with Estimate (5s+)

```
DETAILED PROGRESS:
┌──────────────────────────────────────┐
│ Processing your request...           │
│ ████████████████░░░░░░░░░░  65%      │
│ About 12 seconds remaining           │
│                          [Cancel]    │
└──────────────────────────────────────┘
```

---

## Techniques to Meet the Threshold

### 1. Optimistic Updates

Show success immediately, rollback if it fails.

```
USER CLICKS "LIKE":

Traditional:                    Optimistic:
┌─────────────────┐            ┌─────────────────┐
│ Click ♡         │            │ Click ♡         │
│       ↓         │            │       ↓         │
│ Send to server  │            │ Show ♥ (filled) │ ← Instant
│       ↓         │            │       ↓         │
│ Wait 500ms      │            │ Send to server  │
│       ↓         │            │       ↓         │
│ Show ♥ (filled) │            │ (If fail: ♡)    │
└─────────────────┘            └─────────────────┘
   ~500ms delay                    ~0ms perceived
```

### 2. Skeleton Screens

Show the layout while content loads.

```
LOADING:                       LOADED:
┌─────────────────┐            ┌─────────────────┐
│ ░░░░░░░░░░░░░░  │            │ User Name       │
│ ░░░░░░░░░       │            │ @username       │
│                 │     -->    │                 │
│ ░░░░░░░░░░░░░░░ │            │ This is the     │
│ ░░░░░░░░░░░░    │            │ actual content  │
└─────────────────┘            └─────────────────┘
```

### 3. Progressive Loading

Load and show content as it arrives.

```
STEP 1:          STEP 2:          STEP 3:
┌───────────┐    ┌───────────┐    ┌───────────┐
│ [Header]  │    │ [Header]  │    │ [Header]  │
│           │    │ [Hero]    │    │ [Hero]    │
│           │    │           │    │ [Cards]   │
│           │    │           │    │ [Footer]  │
└───────────┘    └───────────┘    └───────────┘
   0ms             200ms            500ms
```

### 4. Preloading

Anticipate what the user will need next.

```
USER ON PAGE 1:
┌───────────────────────────────────────┐
│ Page 1 Content                        │
│                                       │
│ [Next Page →]                         │
└───────────────────────────────────────┘
        ↓
   While user reads Page 1,
   preload Page 2 in background
        ↓
   When user clicks "Next",
   Page 2 appears instantly
```

### 5. Caching

Store frequently accessed data locally.

```
FIRST LOAD:              SUBSEQUENT LOADS:
┌────────────────┐       ┌────────────────┐
│ Request server │       │ Check cache    │
│      ↓         │       │      ↓         │
│ Wait ~500ms    │       │ Found? Display │
│      ↓         │       │      ↓         │
│ Display data   │       │ Update in bg   │
└────────────────┘       └────────────────┘
   Slow                     Instant
```

---

## Measuring Response Time

### Key Metrics

| Metric | Target | Description |
|--------|--------|-------------|
| Time to First Byte (TTFB) | <200ms | Server response start |
| First Contentful Paint (FCP) | <1.8s | First visible content |
| Largest Contentful Paint (LCP) | <2.5s | Main content loaded |
| Time to Interactive (TTI) | <3.8s | Page fully usable |
| First Input Delay (FID) | <100ms | Response to first interaction |

### User Actions to Measure

- Button click to response
- Form submission to feedback
- Navigation to page render
- Search to results
- Scroll to content load

---

## Platform-Specific Considerations

### Mobile
- Network latency is higher
- Processing power is lower
- Users expect instant response
- Offline capability is crucial

### Desktop
- More tolerance for complex operations
- Background processing is acceptable
- Keyboard shortcuts should be instant
- Hover states need immediate response

---

## Checklist

- [ ] All user interactions respond within 400ms
- [ ] Actions taking >400ms show loading indicators
- [ ] Actions taking >1s show progress indicators
- [ ] Long operations can be cancelled
- [ ] Optimistic updates are used where safe
- [ ] Skeleton screens are used during page loads
- [ ] Frequently used data is cached
- [ ] Next likely actions are preloaded
