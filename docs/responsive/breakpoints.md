# Responsive Breakpoints

Concrete breakpoint values for building responsive applications across all platforms.

---

## Standard Breakpoints

```
┌─────────────────────────────────────────────────────────────────────────┐
│ Name          │ Min Width │ Max Width │ Typical Devices                 │
├───────────────┼───────────┼───────────┼─────────────────────────────────┤
│ Compact       │    0px    │   599px   │ Phone portrait                  │
│ Medium        │   600px   │   839px   │ Phone landscape, small tablet   │
│ Expanded      │   840px   │  1199px   │ Tablet, small desktop           │
│ Large         │  1200px   │  1599px   │ Desktop                         │
│ Extra Large   │  1600px   │     ∞     │ Wide desktop, TV                │
└───────────────┴───────────┴───────────┴─────────────────────────────────┘
```

---

## Visual Reference

```
COMPACT (0-599px):
┌──────────────────┐
│                  │
│    Phone         │
│    Portrait      │
│                  │
│                  │
│                  │
└──────────────────┘
1 column, full-width elements

MEDIUM (600-839px):
┌────────────────────────────┐
│                            │
│     Phone Landscape /      │
│     Small Tablet           │
│                            │
└────────────────────────────┘
1-2 columns, navigation adapts

EXPANDED (840-1199px):
┌─────────────────────────────────────────┐
│                                         │
│          Tablet / Small Desktop         │
│                                         │
│                                         │
└─────────────────────────────────────────┘
2-3 columns, sidebar possible

LARGE (1200-1599px):
┌──────────────────────────────────────────────────────┐
│                                                      │
│                    Desktop                           │
│                                                      │
│                                                      │
└──────────────────────────────────────────────────────┘
Multi-column layouts, full navigation

EXTRA LARGE (1600px+):
┌─────────────────────────────────────────────────────────────────────────┐
│                                                                         │
│                         Wide Desktop / TV                               │
│                                                                         │
│                                                                         │
└─────────────────────────────────────────────────────────────────────────┘
Maximum content width with margins, or multi-pane
```

---

## Uno Platform Implementation

### XAML with VisualStateManager

```xml
<Grid>
    <VisualStateManager.VisualStateGroups>
        <VisualStateGroup>
            <!-- Compact: 0-599px -->
            <VisualState x:Name="Compact">
                <VisualState.StateTriggers>
                    <AdaptiveTrigger MinWindowWidth="0" />
                </VisualState.StateTriggers>
                <VisualState.Setters>
                    <Setter Target="MainPanel.Orientation" Value="Vertical" />
                    <Setter Target="SideNav.Visibility" Value="Collapsed" />
                </VisualState.Setters>
            </VisualState>

            <!-- Medium: 600-839px -->
            <VisualState x:Name="Medium">
                <VisualState.StateTriggers>
                    <AdaptiveTrigger MinWindowWidth="600" />
                </VisualState.StateTriggers>
                <VisualState.Setters>
                    <Setter Target="MainPanel.Orientation" Value="Vertical" />
                    <Setter Target="SideNav.Visibility" Value="Collapsed" />
                </VisualState.Setters>
            </VisualState>

            <!-- Expanded: 840-1199px -->
            <VisualState x:Name="Expanded">
                <VisualState.StateTriggers>
                    <AdaptiveTrigger MinWindowWidth="840" />
                </VisualState.StateTriggers>
                <VisualState.Setters>
                    <Setter Target="MainPanel.Orientation" Value="Horizontal" />
                    <Setter Target="SideNav.Visibility" Value="Visible" />
                </VisualState.Setters>
            </VisualState>

            <!-- Large: 1200px+ -->
            <VisualState x:Name="Large">
                <VisualState.StateTriggers>
                    <AdaptiveTrigger MinWindowWidth="1200" />
                </VisualState.StateTriggers>
                <VisualState.Setters>
                    <Setter Target="MainPanel.Orientation" Value="Horizontal" />
                    <Setter Target="SideNav.Visibility" Value="Visible" />
                    <Setter Target="SideNav.Width" Value="280" />
                </VisualState.Setters>
            </VisualState>
        </VisualStateGroup>
    </VisualStateManager.VisualStateGroups>

    <!-- Content -->
</Grid>
```

### Using Uno Toolkit Responsive Extensions

```xml
<!-- With Uno.Toolkit -->
<Grid Margin="{responsive:Responsive Compact=16, Medium=24, Expanded=32}">
    <StackPanel
        Orientation="{responsive:Responsive Compact=Vertical, Expanded=Horizontal}">
        <!-- Content -->
    </StackPanel>
</Grid>
```

---

## Layout Adaptations by Breakpoint

### Navigation

| Breakpoint | Navigation Pattern |
|------------|-------------------|
| Compact | Bottom navigation (4-5 items) or hamburger |
| Medium | Bottom navigation or rail navigation |
| Expanded | Rail navigation or sidebar (collapsed) |
| Large | Full sidebar navigation |
| Extra Large | Full sidebar + secondary nav |

```
COMPACT:                    EXPANDED:                   LARGE:
┌──────────────────┐        ┌─────────────────────────┐  ┌────────────────────────────┐
│                  │        │ [≡]│                    │  │ Logo    │                  │
│     Content      │        │    │                    │  │ ──────  │                  │
│                  │        │ [●]│     Content        │  │ Home    │     Content      │
│                  │        │    │                    │  │ Items   │                  │
│                  │        │ [□]│                    │  │ Profile │                  │
│                  │        │    │                    │  │ Settings│                  │
├──────────────────┤        │ [◇]│                    │  │         │                  │
│ [●] [□] [◇] [☆] │        └─────────────────────────┘  └────────────────────────────┘
└──────────────────┘        Rail (icons only)           Expanded sidebar
Bottom navigation
```

### Content Layout

| Breakpoint | Columns | Content Width | Margins |
|------------|---------|---------------|---------|
| Compact | 1 | 100% | 16px |
| Medium | 1-2 | 100% | 24px |
| Expanded | 2-3 | 100% | 32px |
| Large | 3-4 | max 1200px | 48px |
| Extra Large | 4-6 | max 1400px | 64px+ |

### Grid Item Sizes

```
CARD GRID ADAPTATION:

Compact (1 column):
┌──────────────────────────────────┐
│             Card 1               │
├──────────────────────────────────┤
│             Card 2               │
├──────────────────────────────────┤
│             Card 3               │
└──────────────────────────────────┘

Medium (2 columns):
┌───────────────┬───────────────┐
│    Card 1     │    Card 2     │
├───────────────┼───────────────┤
│    Card 3     │    Card 4     │
└───────────────┴───────────────┘

Expanded (3 columns):
┌──────────┬──────────┬──────────┐
│  Card 1  │  Card 2  │  Card 3  │
├──────────┼──────────┼──────────┤
│  Card 4  │  Card 5  │  Card 6  │
└──────────┴──────────┴──────────┘

Large (4 columns):
┌────────┬────────┬────────┬────────┐
│ Card 1 │ Card 2 │ Card 3 │ Card 4 │
├────────┼────────┼────────┼────────┤
│ Card 5 │ Card 6 │ Card 7 │ Card 8 │
└────────┴────────┴────────┴────────┘
```

---

## Common Device Sizes Reference

| Device | Width | Height | Breakpoint |
|--------|-------|--------|------------|
| iPhone SE | 375px | 667px | Compact |
| iPhone 14 | 390px | 844px | Compact |
| iPhone 14 Pro Max | 430px | 932px | Compact |
| Pixel 7 | 412px | 915px | Compact |
| iPad Mini | 768px | 1024px | Medium/Expanded |
| iPad Pro 11" | 834px | 1194px | Expanded |
| iPad Pro 12.9" | 1024px | 1366px | Expanded |
| MacBook Air 13" | 1440px | 900px | Large |
| Desktop 1080p | 1920px | 1080px | Extra Large |
| Desktop 4K | 3840px | 2160px | Extra Large |

---

## Testing Checklist

- [ ] Test at each breakpoint boundary (599, 600, 839, 840, 1199, 1200, 1599, 1600)
- [ ] Test portrait and landscape orientations
- [ ] Verify navigation adapts correctly
- [ ] Verify content reflows properly
- [ ] Check touch targets remain adequate on all sizes
- [ ] Verify text remains readable (not too wide)
- [ ] Test with real devices, not just browser resize
