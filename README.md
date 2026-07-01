
This project is unofficial, and is not affiliated with the Melonly team.
<br /> Use Melonly @ https://melonly.xyz

` ⚠️ ` Before you begin, this is an active discord experiement.
Meaning you will need to take extra steps to achieve using this widget.

## How to create a Widget
For the sake of not wanting to store peoples Melonly API Tokens, this project will not be run publicly by me & it has no functionality to allow for other API Tokens.
So you must create the widget & boot this up for yourself.

> There has been many ways to create a widget at the moment, and there is no straight forward way for it.
> <br /> So here are some tutorials that you could use.
> <br/> - https://gist.github.com/aamiaa/7cdd590e3949cd654758bc90bcb4710b @aamiaa
> <br/> - https://www.rohan.run/writing/discord-widgets
> <br/> - https://chloecinders.com/blog/discord-widgets
> <br/> - https://discord.gg/discord-603970300668805120 (Discord Previews, widget section)
> <br/> - https://github.com/TheCreativeGod/Discord-Widgets-Extension (For dummies, Chrome extension) + You can import using the json "MelonWidget Template" below.
> <br/>
> <br/> **Disclaimer:** If you care about the **discord TOS**, doing these methods could lead you to breaking the TOS. Discord has removed the "safe" way of adding widgets to your profile and creating widgets, meaning to add the widget to your profile & unlocking the create widget button you must break the TOS by using a client like vencord.
> <br/> Eventually/hopefully this will not be the case and widgets will become publicly avaliable for all applications.
> <br/> If you are one of the lucky ones who got access to this experiement early, ignore what I just said.
> <br/>

<br />
<details>
<summary>MelonWidget Template</summary>

```json
{
  "_type": "discord-widget",
  "version": 2,
  "display_name": "Melonly",
  "surfaces": {
    "widget_bottom": {
      "layout": "widget_bottom_collection",
      "components": {
        "item_2": {
          "fields": {
            "description": {
              "value_type": "data",
              "presentation_type": "text",
              "value": "shifts"
            },
            "image": {
              "value_type": "application_asset",
              "presentation_type": "image",
              "value": "glyphs--note-pad-duo"
            },
            "name": {
              "value_type": "custom_string",
              "presentation_type": "text",
              "value": "Shifts"
            }
          }
        },
        "item_3": {
          "fields": {
            "description": {
              "value_type": "data",
              "presentation_type": "text",
              "value": "time"
            },
            "image": {
              "value_type": "application_asset",
              "presentation_type": "image",
              "value": "iconamoon--clock-duotone"
            },
            "name": {
              "value_type": "custom_string",
              "presentation_type": "text",
              "value": "Shift Time"
            }
          }
        },
        "item_1": {
          "fields": {
            "description": {
              "value_type": "data",
              "presentation_type": "text",
              "value": "moderations",
              "fallback": {
                "value_type": "custom_string",
                "presentation_type": "text",
                "value": ""
              }
            },
            "image": {
              "value_type": "application_asset",
              "presentation_type": "image",
              "value": "solar--shield-bold-duotone"
            },
            "name": {
              "value_type": "custom_string",
              "presentation_type": "text",
              "value": "Moderations"
            }
          }
        },
        "item_4": {
          "fields": {
            "description": {
              "value_type": "data",
              "presentation_type": "text",
              "value": "server",
              "fallback": {
                "value_type": "custom_string",
                "presentation_type": "text",
                "value": ""
              }
            },
            "image": {
              "value_type": "application_asset",
              "presentation_type": "image",
              "value": "si--server-duotone"
            },
            "name": {
              "value_type": "custom_string",
              "presentation_type": "text",
              "value": "Server"
            }
          }
        }
      }
    },
    "mini_profile": {
      "layout": "mini_profile_hero_stat",
      "components": {
        "stat": {
          "fields": {
            "text": {
              "value_type": "data",
              "presentation_type": "text",
              "value": "time"
            }
          }
        },
        "hero_image": {
          "fields": {
            "image": {
              "value_type": "application_asset",
              "presentation_type": "image",
              "value": "bfb276c369fb39b537b4b681f65e0571"
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
    }
  },
  "assets": {
    "glyphs--note-pad-duo": {
      "asset_type": "image",
      "content_type": "image/png",
      "image": "data:image/png;base64,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"
    },
    "iconamoon--clock-duotone": {
      "asset_type": "image",
      "content_type": "image/png",
      "image": "data:image/png;base64,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"
    },
    "solar--shield-bold-duotone": {
      "asset_type": "image",
      "content_type": "image/png",
      "image": "data:image/png;base64,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"
    },
    "si--server-duotone": {
      "asset_type": "image",
      "content_type": "image/png",
      "image": "data:image/png;base64,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"
    },
    "bfb276c369fb39b537b4b681f65e0571": {
      "asset_type": "image",
      "content_type": "image/webp",
      "image": "data:image/webp;base64,UklGRtwDAABXRUJQVlA4INADAABQGACdASqAAIAAPm0yl0ikIqIhJRM56IANiUAa3CAGrC+V/Gb8Verb5h7s8cicXsW/VdKz7ZvUV/vXVh8wH66/7H/HeiB2AH9F/w/Wu+gB+0fpg/uH8Hn7aftV7KuaQPoHaumNKnW5ZPvJp9qCQxu945A+MoD8+J8SdPmFYiv+Lt00+s86GcYc56TMR7HiPL5j2pH4emKB1rEdt8+lwZpE0C4ttuKj/jor/zkUQdGlwtYMoGV1HzHFXfA7TH/y1W7RhQh6+GUavN3uQAD++3sFZyiAAABI5rZnA3ICHeEpt9h74fKkB2TA9UdcqTVmsvu2jM/o7NpqFFVa1lFgLH99ykCeAA4nCgdxPz+NR8dmG2SB95Mnv5pwaEGZFyQFNErggMZy+eaGRPjd50f1XXl7hUp0HkFQA2nMpR9/TGZHxz/kEOw3rT6ItA6EY0WXmJWwYlqey0D/kR7y/rIS/QbDhA9ejMfAs7E2SWBPLFRnqWqC0AvrdoByyLThWdeOH8Uf7infoQjAue9jKwszLE9rOsOi4ZEQElxohctvCpWYWTSxRLOQDjTQArXJgY7XWbrpU4LMKgq+l/I9Vbm8n1Y34V0YF+IXJ0JOHLgE2Ft52yr0MsaWHQoaW25SGhwMnpVvNO4KMqCqM2L4UACIolycLIMI+2Aj5rXuCUGbD8os44Iwzd+vfs5bfOHPkhRoOl9w/4ce+qEVh9rML3zE1grE9fbS2XKFmxWY8n1C8c29FlYybHcMiKYJ7D41zF9S0mnjTuhlz6x/22ASkK2KPgBDHiKqW8buIswLqWfthXfwG4A3+dWbV3S9bBMkbDkkLuWQzI/gFkp1F2GS14gVk7mTZa7UFVh74ZOVsP42cFC+0luL+6PuejCLKtpOd4S6v5IjDv1ww9WLFCi+fAQqc4y2UWwnNsdUc2nuFRxQOob3GdVcTN3kcK/KMSakdIwbaaYNuON+YzIrgZxQdil9VHiDMMpIEDNmuiFJ1csC9WXopHG/5hSJuyA0Lnn2G/pK1A4xf+Dq5fYBG9V/8Jfnu+WFT+zSFV56vK7K/IYFazFl4ayd9jg7QRqRwtOlT3ohJ2e0VKw7A6ceHfq3P2/OuJlwGH7Sc9GO5cJMcsW5GQC3JEMkcjimGirh9+MJ2+w1tmz3kNSbqrq3IP5PZHTYC/od9zs9A1xboov5X41yApoZXOVkoMVqwdNIaKJRxIGaX/vbsJv5gW3QDF/9YwOb8yUd6XlL7vkLgiA9M4XHu3fR0Ikj5j89G03mL/B/9ZkZqhMpdOqABKDz7kchwAAAAAAA"
    },
    "userpanel": {
      "asset_type": "image",
      "content_type": "image/webp",
      "image": "data:image/webp;base64,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"
    }
  }
}
```

</details>
<br/>

## Allowing other people to use the widget
> Discord has unfortunately limited the ability for people to use Widgets made by others for now.
Only the owner of an application (or fellow members of the team owning the application) can use it on their profile.
> If you want a group of people to use your widget, just add them to the bots team.

## Showcases
(What it looks like on your widget board)
<br/>
<img width="901" height="543" style="border-radius: 12px;" alt="image" src="https://github.com/user-attachments/assets/526a6c3b-1332-46bf-af0a-b1e228184ed0" />
<br/>
<img width="1061" height="208" alt="image" src="https://github.com/user-attachments/assets/54b712cf-3e6c-4acd-9a26-b089f7be6d76" />
<br/>
<img width="567" height="91" style="border-radius: 12px;"  alt="image" src="https://github.com/user-attachments/assets/d1c16913-019f-463f-a3f7-939119cabd10" />
<br/>
(What it looks like on your mini profile)
<br/>
<img width="301" height="463" alt="image" src="https://github.com/user-attachments/assets/5fe8197c-c1ab-4db8-accf-d8a3b89ecf97" />

## Credits
- Icons provided by [Solar Icons](https://github.com/480-Design/Solar-Icon-Set).

