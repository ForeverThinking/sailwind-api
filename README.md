# A Simple API Based Off The Game Sailwind

## Currency
Six endpoints to convert between gold and the three major currencies.

```csharp
POST /GoldToCrowns?gold={value: double}
```

```csharp
POST /GoldToLions?gold={value: double}
```

```csharp
POST /GoldToDragons?gold={value: double}
```

```csharp
POST /CrownsToGold?crowns={value: double}
```

```csharp
POST /LionsToGold?lions={value: double}
```

```csharp
POST /DragonsToGold?dragons={value: double}
```