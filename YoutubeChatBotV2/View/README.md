# 🖥️ View

Bu klasör WPF kullanıcı arayüzü bileşenlerini içerir.

## Pencereler

| Dosya | Açıklama |
|-------|----------|
| `Window1.xaml` | Ana uygulama penceresi |
| `CustomMessageBox.xaml` | Özel tema dialog'u |

## Tab Yapısı

```
┌────────────────────────────────────────────────────────┐
│  🤖 Bot Durumu  │  🧩 Komutlar  │  ⏱️ Oto Mesaj  │  🛡️ Moderasyon  │
└────────────────────────────────────────────────────────┘
```

### Bot Durumu
- Kanal linki girişi
- Bot başlat/durdur
- Sistem logları (sol panel)
- Canlı chat (sağ panel)

### Komutlar
- Komut ekleme formu
- Mevcut komutlar listesi
- Düzenle/Sil butonları

### Otomatik Mesajlar
- Mesaj + interval girişi
- Aktif mesajlar listesi
- Düzenle/Sil butonları

### Moderasyon
- 6 filter kartı (2x3 grid)
- Her kart: toggle + ayarlar
- Canlı açma/kapama

## Tema

- Karanlık tema
- Kırmızı accent renk (#FF0000)
- Modern border radius
- Custom styled controls

---

⚠️ **Kaynak kod özeldir.**
