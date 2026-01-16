# 📁 Models

Bu klasör bot tarafından kullanılan tüm veri modellerini içerir.

## İçerik

| Model | Açıklama |
|-------|----------|
| `CommandModel` | Chat komutları (prefix, command, response) |
| `AutoMessageModel` | Otomatik mesajlar (message, interval) |
| `FilterModel` | Moderasyon filtreleri |
| `FilterSettings` | Filter'a özel ayarlar |
| `FilterConfig` | JSON root object |
| `FilterResult` | Filter kontrol sonucu |
| `BotSettings` | Bot yapılandırması |

## Mimari

```
FilterModel
├── Type: FilterType (enum)
├── Name: string
├── IsEnabled: bool
├── Punishment: PunishmentType (enum)
├── TimeoutDuration: int
└── Settings: FilterSettings
```

## Enum Değerleri

### FilterType
- `BlacklistWords` - Yasaklı kelimeler
- `ExcessCaps` - Aşırı büyük harf
- `ExcessEmotes` - Aşırı emoji
- `Links` - Link kontrolü
- `ExcessSymbols` - Aşırı sembol
- `Repetitions` - Tekrar mesaj

### PunishmentType
- `Ignore` - Sadece logla
- `Warning` - Uyarı gönder
- `Timeout` - Geçici sustur
- `Ban` - Kalıcı ban

---

⚠️ **Kaynak kod özeldir.**
