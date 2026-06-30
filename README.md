This project is unofficial, and is not affiliated with the Melonly team.
<br /> Use Melonly @ https://melonly.xyz

` ⚠️ ` Before you begin, this is an active discord experiement.
Meaning you will need to take extra steps to achieve using this widget.

<br/>
For the sake of not wanting to store peoples Melonly API Tokens, this project will not be run pubically by me & it has no functionality to allow for other API Tokens.

## How to create a Widget
> There has been many ways to create a widget at the moment, and there is no straight forward way for it.
> <br /> So here are some tutorials that you could use.
> <br/> - https://gist.github.com/aamiaa/7cdd590e3949cd654758bc90bcb4710b @aamiaa
> <br/> - https://www.rohan.run/writing/discord-widgets
> <br/> - https://chloecinders.com/blog/discord-widgets
> <br/> - https://discord.gg/discord-603970300668805120 (Discord Previews, widget section)

<details>
<summary>MelonWidget Template</summary>

```json
{
  "_type": "discord-widget",
  "version": 2,
  "display_name": "Melonly",
  "surfaces": {
    "widget_bottom": {
      "layout": "widget_bottom_stats",
      "components": {
        "stat_5": {
          "fields": {
            "value": {
              "value_type": "custom_string",
              "presentation_type": "text",
              "value": "Answered Modcalls"
            },
            "label": {
              "value_type": "custom_string",
              "presentation_type": "text",
              "value": "N/A"
            }
          }
        },
        "stat_1": {
          "fields": {
            "value": {
              "value_type": "custom_string",
              "presentation_type": "text",
              "value": "Moderations"
            },
            "label": {
              "value_type": "data",
              "presentation_type": "text",
              "value": "moderations"
            }
          }
        },
        "stat_3": {
          "fields": {
            "value": {
              "value_type": "custom_string",
              "presentation_type": "text",
              "value": "Shifts"
            },
            "label": {
              "value_type": "data",
              "presentation_type": "text",
              "value": "shifts"
            }
          }
        },
        "stat_2": {
          "fields": {
            "value": {
              "value_type": "custom_string",
              "presentation_type": "text",
              "value": "Shift Time"
            },
            "label": {
              "value_type": "data",
              "presentation_type": "text",
              "value": "time"
            }
          }
        },
        "stat_4": {
          "fields": {
            "value": {
              "value_type": "custom_string",
              "presentation_type": "text",
              "value": "Sessions"
            },
            "label": {
              "value_type": "custom_string",
              "presentation_type": "text",
              "value": "N/A"
            }
          }
        },
        "stat_6": {
          "fields": {
            "value": {
              "value_type": "custom_string",
              "presentation_type": "text",
              "value": "Bans"
            },
            "label": {
              "value_type": "custom_string",
              "presentation_type": "text",
              "value": "N/A"
            }
          }
        }
      }
    },
    "add_widget_preview": {
      "layout": "add_widget_preview_hero",
      "components": {
        "hero_image": {
          "fields": {
            "image": {
              "value_type": "data",
              "presentation_type": "image",
              "value": "change this to an image"
            }
          }
        }
      }
    },
    "widget_top": {
      "layout": "widget_top_hero",
      "components": {
        "title": {
          "fields": {
            "text": {
              "value_type": "custom_string",
              "presentation_type": "text",
              "value": "Melonly - Mod Statistics"
            }
          }
        },
        "subtitle_1": {
          "fields": {
            "text": {
              "value_type": "custom_string",
              "presentation_type": "text",
              "value": "melonly.xyz"
            }
          }
        },
        "hero_image": {
          "fields": {
            "image": {
              "value_type": "application_asset",
              "presentation_type": "image",
              "value": "userpanel"
            }
          }
        },
        "subtitle_2": {
          "fields": {
            "text": {
              "value_type": "custom_string",
              "presentation_type": "text",
              "value": "(this is unofficial)"
            }
          }
        }
      }
    },
    "mini_profile": {
      "layout": "mini_profile_contained_stat",
      "components": {
        "stat": {
          "fields": {
            "text": {
              "value_type": "data",
              "presentation_type": "text",
              "value": "time"
            },
            "label": {
              "value_type": "custom_string",
              "presentation_type": "text",
              "value": "Shift Time"
            }
          }
        },
        "contained_image": {
          "fields": {
            "image": {
              "value_type": "application_asset",
              "presentation_type": "image",
              "value": "bfb276c369fb39b537b4b681f65e0571"
            }
          }
        }
      }
    }
  },
  "assets": {
    "userpanel": {
      "asset_type": "image",
      "content_type": "image/webp",
      "image": "data:image/webp;base64,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"
    },
    "bfb276c369fb39b537b4b681f65e0571": {
      "asset_type": "image",
      "content_type": "image/webp",
      "image": "data:image/webp;base64,UklGRtwDAABXRUJQVlA4INADAABQGACdASqAAIAAPm0yl0ikIqIhJRM56IANiUAa3CAGrC+V/Gb8Verb5h7s8cicXsW/VdKz7ZvUV/vXVh8wH66/7H/HeiB2AH9F/w/Wu+gB+0fpg/uH8Hn7aftV7KuaQPoHaumNKnW5ZPvJp9qCQxu945A+MoD8+J8SdPmFYiv+Lt00+s86GcYc56TMR7HiPL5j2pH4emKB1rEdt8+lwZpE0C4ttuKj/jor/zkUQdGlwtYMoGV1HzHFXfA7TH/y1W7RhQh6+GUavN3uQAD++3sFZyiAAABI5rZnA3ICHeEpt9h74fKkB2TA9UdcqTVmsvu2jM/o7NpqFFVa1lFgLH99ykCeAA4nCgdxPz+NR8dmG2SB95Mnv5pwaEGZFyQFNErggMZy+eaGRPjd50f1XXl7hUp0HkFQA2nMpR9/TGZHxz/kEOw3rT6ItA6EY0WXmJWwYlqey0D/kR7y/rIS/QbDhA9ejMfAs7E2SWBPLFRnqWqC0AvrdoByyLThWdeOH8Uf7infoQjAue9jKwszLE9rOsOi4ZEQElxohctvCpWYWTSxRLOQDjTQArXJgY7XWbrpU4LMKgq+l/I9Vbm8n1Y34V0YF+IXJ0JOHLgE2Ft52yr0MsaWHQoaW25SGhwMnpVvNO4KMqCqM2L4UACIolycLIMI+2Aj5rXuCUGbD8os44Iwzd+vfs5bfOHPkhRoOl9w/4ce+qEVh9rML3zE1grE9fbS2XKFmxWY8n1C8c29FlYybHcMiKYJ7D41zF9S0mnjTuhlz6x/22ASkK2KPgBDHiKqW8buIswLqWfthXfwG4A3+dWbV3S9bBMkbDkkLuWQzI/gFkp1F2GS14gVk7mTZa7UFVh74ZOVsP42cFC+0luL+6PuejCLKtpOd4S6v5IjDv1ww9WLFCi+fAQqc4y2UWwnNsdUc2nuFRxQOob3GdVcTN3kcK/KMSakdIwbaaYNuON+YzIrgZxQdil9VHiDMMpIEDNmuiFJ1csC9WXopHG/5hSJuyA0Lnn2G/pK1A4xf+Dq5fYBG9V/8Jfnu+WFT+zSFV56vK7K/IYFazFl4ayd9jg7QRqRwtOlT3ohJ2e0VKw7A6ceHfq3P2/OuJlwGH7Sc9GO5cJMcsW5GQC3JEMkcjimGirh9+MJ2+w1tmz3kNSbqrq3IP5PZHTYC/od9zs9A1xboov5X41yApoZXOVkoMVqwdNIaKJRxIGaX/vbsJv5gW3QDF/9YwOb8yUd6XlL7vkLgiA9M4XHu3fR0Ikj5j89G03mL/B/9ZkZqhMpdOqABKDz7kchwAAAAAAA"
    }
  }
}
```

</details>


## Showcases
(What it looks like your widget board)
<img width="952" height="564" style="border-radius: 12px;" alt="image" src="https://github.com/user-attachments/assets/43160184-1722-4e2c-8cae-efa6d1e6a4b1" />
<br/>
(What it looks like on your mini profile)
<br/>
<img width="302" height="402" alt="image" src="https://github.com/user-attachments/assets/c3aa23d2-0145-4eb3-bd84-38ac1d0e6263" />

<br/>
<br/>
You may be seeing the N/A's which is because I am both lazy, about to run out of melonly api credits and discord forces you to have 6 options.

