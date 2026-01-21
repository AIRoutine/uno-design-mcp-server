# Core UI/UX Design Principles for Uno Platform Apps

## Overview
These principles guide the creation of intuitive, beautiful, and accessible applications across all platforms (mobile, desktop, web).

---

## 1. Visual Hierarchy

**Purpose:** Guide users through content by establishing clear importance levels.

### Key Concepts
- **Size:** Larger elements attract attention first
- **Color:** High contrast and vibrant colors draw focus
- **Position:** Top-left (LTR) or top-right (RTL) gets noticed first
- **Whitespace:** Isolation increases prominence
- **Typography:** Weight and scale indicate importance

### Application
- Hero content should be 2-3x larger than supporting text
- Primary actions use accent colors; secondary actions use muted tones
- Group related elements with consistent spacing
- Maintain 3-4 levels of hierarchy maximum

---

## 2. Consistency

**Purpose:** Reduce cognitive load through predictable patterns.

### Types of Consistency
- **Internal:** Same patterns within your app
- **External:** Follow platform conventions (iOS, Android, Windows)
- **Functional:** Same actions produce same results everywhere

### Application
- Define and use a design system
- Standardize spacing, colors, and typography
- Use consistent iconography and labeling
- Maintain gesture patterns across screens

---

## 3. Feedback & Response

**Purpose:** Acknowledge every user action immediately.

### Feedback Types
- **Visual:** Button states, loading indicators, animations
- **Auditory:** Click sounds, notifications (optional)
- **Haptic:** Vibration on mobile for confirmations

### Timing Guidelines
- **Immediate (0-100ms):** Touch response, button press states
- **Short (100-300ms):** Transitions, micro-animations
- **Medium (300-1000ms):** Loading states, progress indicators
- **Long (>1000ms):** Progress bars with percentage, skeleton screens

---

## 4. Accessibility

**Purpose:** Ensure everyone can use your application effectively.

### Core Requirements
- **Contrast:** 4.5:1 for normal text, 3:1 for large text
- **Touch Targets:** Minimum 44x44 points
- **Screen Readers:** Meaningful labels and descriptions
- **Keyboard Navigation:** Full functionality without mouse
- **Color Independence:** Never rely solely on color to convey information

### Testing Approach
- Use accessibility scanners
- Test with screen readers
- Test with keyboard only
- Test with high contrast modes

---

## 5. Simplicity

**Purpose:** Remove friction and complexity wherever possible.

### Principles
- **Progressive Disclosure:** Show only what's needed now
- **Minimal Choices:** Reduce decision fatigue (Hick's Law)
- **Clear Defaults:** Smart defaults reduce user effort
- **Obvious Actions:** Make the next step always clear

### Application
- Limit options to 5-7 items per group
- Hide advanced features behind "More" or settings
- Use inline editing instead of modal dialogs when possible
- Provide clear empty states with calls to action

---

## 6. Affordance

**Purpose:** Make interactive elements look interactive.

### Visual Cues
- Buttons should look "pressable" (shadow, elevation, border)
- Links should be underlined or colored differently
- Draggable items should have handles or grip patterns
- Input fields should have clear boundaries

### Anti-Patterns to Avoid
- Flat buttons that look like labels
- Images that look clickable but aren't
- Text that looks like links but isn't
- Hidden gestures without visual hints

---

## Summary Checklist

Before finalizing any design:

- [ ] Is there a clear visual hierarchy?
- [ ] Are patterns consistent throughout?
- [ ] Does every action have immediate feedback?
- [ ] Is it accessible to all users?
- [ ] Is it as simple as possible?
- [ ] Do interactive elements look interactive?
