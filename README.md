[![Docker Image CI](https://github.com/ForeverThinking/sailwind-api/actions/workflows/docker-image.yml/badge.svg)](https://github.com/ForeverThinking/sailwind-api/actions/workflows/docker-image.yml)
[![.NET](https://github.com/ForeverThinking/sailwind-api/actions/workflows/dotnet.yml/badge.svg)](https://github.com/ForeverThinking/sailwind-api/actions/workflows/dotnet.yml)

# A Simple API Based Off The Game Sailwind

## Currency
Six endpoints to convert between gold and the three major currencies.

```csharp
POST Currency/GoldToCrowns?gold={value: double}
```

```csharp
POST Currency/GoldToLions?gold={value: double}
```

```csharp
POST Currency/GoldToDragons?gold={value: double}
```

```csharp
POST Currency/CrownsToGold?crowns={value: double}
```

```csharp
POST Currency/LionsToGold?lions={value: double}
```

```csharp
POST Currency/DragonsToGold?dragons={value: double}
```

## Voyage
Two endpoints; one to add a navigation reading (lat, long) and one to retrieve all the readings

```csharp
GET Voyage/GetLocations
```

```csharp
POST Voyage/AddLocation
body { latitude: double, longitude: double}
```
