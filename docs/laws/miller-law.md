# Miller's Law

> **The average person can only keep 7 (plus or minus 2) items in their working memory.**

Based on George A. Miller's 1956 paper "The Magical Number Seven, Plus or Minus Two."

---

## The Concept

```
WORKING MEMORY CAPACITY:
┌───┬───┬───┬───┬───┬───┬───┬───┬───┐
│ 1 │ 2 │ 3 │ 4 │ 5 │ 6 │ 7 │ 8 │ 9 │
└───┴───┴───┴───┴───┴───┴───┴───┴───┘
          ↑               ↑
       Minimum         Maximum
       (5 items)       (9 items)

       Average: 7 items
```

**Note:** This is about short-term/working memory, not a UI design rule for "always use 7 items."

---

## Chunking: The Solution

Break information into meaningful groups (chunks) to work within memory limits.

### Example: Phone Numbers

```
WITHOUT CHUNKING:              WITH CHUNKING:
5551234567                     555-123-4567
(10 individual digits)         (3 chunks)

Memory load: 10 items          Memory load: 3 items
Hard to remember               Easy to remember
```

### Example: Credit Card Numbers

```
WITHOUT CHUNKING:              WITH CHUNKING:
4532789012345678              4532-7890-1234-5678
(16 digits)                    (4 chunks of 4)

Memory load: 16 items          Memory load: 4 items
```

---

## Application in UI Design

### 1. Form Sections

```
BAD (15 fields in one form):
┌─────────────────────────────────────┐
│ First Name: ______                  │
│ Middle Name: ______                 │
│ Last Name: ______                   │
│ Email: ______                       │
│ Phone: ______                       │
│ Street: ______                      │
│ City: ______                        │
│ State: ______                       │
│ Zip: ______                         │
│ Country: ______                     │
│ Company: ______                     │
│ Job Title: ______                   │
│ Department: ______                  │
│ ... (overwhelming)                  │
└─────────────────────────────────────┘

GOOD (chunked into sections):
┌─────────────────────────────────────┐
│ PERSONAL INFORMATION                │
│ ─────────────────────               │
│ Name: ______                        │
│ Email: ______                       │
│ Phone: ______                       │
├─────────────────────────────────────┤
│ ADDRESS                             │
│ ─────────────────────               │
│ Street: ______                      │
│ City: ______ State: ____ Zip: _____ │
├─────────────────────────────────────┤
│ WORK DETAILS                        │
│ ─────────────────────               │
│ Company: ______                     │
│ Job Title: ______                   │
└─────────────────────────────────────┘
```

### 2. Navigation Grouping

```
BAD (flat list):
┌─────────────────┐
│ Dashboard       │
│ Products        │
│ Orders          │
│ Customers       │
│ Analytics       │
│ Reports         │
│ Settings        │
│ Users           │
│ Permissions     │
│ Integrations    │
│ Billing         │
│ Support         │
└─────────────────┘

GOOD (grouped):
┌─────────────────┐
│ MAIN            │
│ · Dashboard     │
│ · Products      │
│ · Orders        │
│ · Customers     │
├─────────────────┤
│ INSIGHTS        │
│ · Analytics     │
│ · Reports       │
├─────────────────┤
│ ADMIN           │
│ · Settings      │
│ · Users         │
│ · Billing       │
└─────────────────┘
```

### 3. Content Organization

```
BAD (wall of text):
┌─────────────────────────────────────┐
│ Lorem ipsum dolor sit amet,         │
│ consectetur adipiscing elit. Sed    │
│ do eiusmod tempor incididunt ut     │
│ labore et dolore magna aliqua.      │
│ Ut enim ad minim veniam, quis       │
│ nostrud exercitation ullamco        │
│ laboris nisi ut aliquip ex ea       │
│ commodo consequat...                │
└─────────────────────────────────────┘

GOOD (structured with chunks):
┌─────────────────────────────────────┐
│ OVERVIEW                            │
│ Brief introduction paragraph.       │
│                                     │
│ KEY BENEFITS                        │
│ • Benefit one explained             │
│ • Benefit two explained             │
│ • Benefit three explained           │
│                                     │
│ HOW IT WORKS                        │
│ Step-by-step explanation...         │
└─────────────────────────────────────┘
```

---

## Chunking Guidelines by Context

| Context | Chunk Size | Example |
|---------|------------|---------|
| Phone numbers | 3-4 digits | 555-123-4567 |
| Credit cards | 4 digits | 4532-7890-1234-5678 |
| Dates | Day/Month/Year | 21/01/2024 |
| Form sections | 3-5 fields | Personal Info, Address, Payment |
| Navigation groups | 3-5 items | Main, Settings, Help |
| List items (visible) | 5-7 items | Then scroll/pagination |
| Steps in process | 3-5 steps | Cart → Shipping → Payment → Confirm |

---

## Visual Chunking Techniques

### 1. Whitespace
```
┌─────────────────────────────────────┐
│ Item 1                              │
│ Item 2                              │
│ Item 3                              │
│                                     │  ← Whitespace creates groups
│ Item 4                              │
│ Item 5                              │
│ Item 6                              │
└─────────────────────────────────────┘
```

### 2. Borders/Dividers
```
┌─────────────────────────────────────┐
│ Group A items                       │
│─────────────────────────────────────│
│ Group B items                       │
│─────────────────────────────────────│
│ Group C items                       │
└─────────────────────────────────────┘
```

### 3. Background Colors
```
┌─────────────────────────────────────┐
│ ████████████████████████████████████│ Group A (shaded)
│                                     │ Group B (white)
│ ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░│ Group C (light gray)
└─────────────────────────────────────┘
```

### 4. Headers/Labels
```
┌─────────────────────────────────────┐
│ [SECTION HEADER]                    │
│ Content belonging to this section   │
│                                     │
│ [ANOTHER SECTION]                   │
│ Content for this section            │
└─────────────────────────────────────┘
```

---

## Common Mistakes

### 1. Using "7 items" as a Hard Rule
Miller's Law is about memory, not UI limits. Sometimes 3 items are too many, sometimes 10 are fine.

### 2. Random Grouping
Chunks must be meaningful - arbitrary groups don't help memory.

### 3. Too Many Chunks
5 groups of 5 items (25 total) is still overwhelming. Consider hierarchy.

---

## Checklist

- [ ] Long forms are divided into logical sections
- [ ] Each section has 3-5 fields maximum
- [ ] Navigation is grouped by category
- [ ] Numbers/codes are formatted with separators
- [ ] Content uses headings to create chunks
- [ ] Visual cues (whitespace, borders) reinforce grouping
- [ ] Groupings are meaningful, not arbitrary
