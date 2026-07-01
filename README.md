
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
              "value": "time"
            },
            "image": {
              "value_type": "application_asset",
              "presentation_type": "image",
              "value": "solar--clock-square-bold-duotone"
            },
            "name": {
              "value_type": "custom_string",
              "presentation_type": "text",
              "value": "Shift Time"
            }
          }
        },
        "item_3": {
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
        "item_1": {
          "fields": {
            "description": {
              "value_type": "data",
              "presentation_type": "text",
              "value": "shifts"
            },
            "image": {
              "value_type": "application_asset",
              "presentation_type": "image",
              "value": "duo-icons--book"
            },
            "name": {
              "value_type": "custom_string",
              "presentation_type": "text",
              "value": "Shifts"
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
              "value": "solar--server-square-cloud-bold-duotone_1_"
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
        }
      }
    },
    "add_widget_preview": {
      "layout": "add_widget_preview_hero",
      "components": {
        "hero_image": {
          "fields": {
            "image": {
              "value_type": "application_asset",
              "presentation_type": "image",
              "value": "melonly-openapi-logo"
            }
          }
        }
      }
    }
  },
  "assets": {
    "solar--clock-square-bold-duotone": {
      "asset_type": "image",
      "content_type": "image/png",
      "image": "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAGAAAABgCAYAAADimHc4AAAEgklEQVR4nO2dP2/TQBTA3zsHsJgYsyB17MjowkA2usHIWFGEKr4AbISPwIIqBKgjbLCVLQyAx44ZI1gydkIuxHe8V9TSlia+c1zf2X4/ybrXeon8s+/e/fEZQfCKCPCMCPCMCPCMCPCMCPCMCPCMCPBMLQLM4HEfsp8xRL0+5BDP0MRo8j6dOgZBxVSc+t8FMjWgMyqPMRhNewYziCCDfDaF+GqGo5dTOnWhVC7ADIYxHExWcohWweTX6MKuQIMhURPAaD+CfAxXViY4Gp4StyyVCTDJ1kqufieozSr92VqMwnGkL6WYbk+gApYWcHjhIRs0/U53hZ+MCOLRsiKWEmCShwMNegAdRkVqF7+8TiksRSkBXM/nBz/W0Zgb9GfnMYh70ZXru2Xah1ICZmub9+Tin4Yl9L69+UChE84CpNqZT5nqyEkAN7gafm2AMBcFl3dcGmYnAbNkY6Nr2Y4rnB310p0dsMRagNz99rg8BfYCbm7e1y3vZFWFos4afn3zjsJCrARw2qmz708pFCyJ0rdDsMBOwNqjVW1m9ykULFHYe4ffXo0pXIilgM17WvJ+JxT1C9CiX2AngLIfDZL9uKBAT9AiG7ISkCcPhiA4Y9MOFArgyRSdZVsUCo6oON4umtQpFiD5f2ls+gPFAm49THSu1ykUHLEZGyoWkMjgW1kUqBGmr0ewgGIBa5vrlIImFIZEjGBu069fpZh+JOwZwM8UBQWloimlorsUzgXpWEiIKShd/DtUJHScJCUJn6gMBptUtJkC0Dyhuz6m8B8I+8bgC4qCob0CwDyj4j/oCXhORTCIAM9UIoB6wVtU9OkIhq4JGEJgNEUAUzQcgXQsRAQshwjwjAjwjAjwjAjwjAjwjAjwjAjwjAjwjAjwjAjwTKcE0Ik9mhP4SFEwtFPAeRMyRwQmoZUCFM0HG4ABzCMgCa0UwNBTcJeeghsUnk8gElorgGmChFYLYEKX0HoBTMgSOiGACVVCZwQwIUrolACmUELNK+g6J4ApkkACnlNRC50UwCySIAJq4lwJCGNqB95TVAudFsDQwN2/ldR/G2Gu/zM6amFpASZ5sKUDW5rYFBTAFNO32xTOxUJAeItzm0Ila0NFQHlEgGdEgGeqERDmS3qNoKKX9OQ11bJU85qqvKhdmope1JatCspSzVYFsllHaSrZrINp+nCEL4qGIRgrAZKKumOTgjJ2AmTLMmcoBa1wyzLZtM+Zajftk20rnbGp/xkrAYxs3GpP5Ru3MtIfsMcm/z/CWgAj2VAxttnPEY4C5CkowuXuZ5wEMDI4Nx+bsZ+zOAtgpF/wP7Z5/1nKCaC0FA5+rIuEv/DFhzo/4nOEVEd08UtUOydZSgDDDTNARiK6lR1xtgO+P+R2kkMR6nfS9s4ad7IgpE8ZngePHQHkhx/zbPqTcXinY7RPgwtjm7EdVy5EwFl4UgcyHUM060MOMaCJSU6fTp1AxXWtwOMVa3Dmc7Z0kadw/Dnb3hRilRVNplRBLQKE+YgAz4gAz4gAz4gAz4gAz4gAz4gAz/wBLIS3f1e7VskAAAAASUVORK5CYII="
    },
    "solar--shield-bold-duotone": {
      "asset_type": "image",
      "content_type": "image/png",
      "image": "data:image/png;base64,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"
    },
    "duo-icons--book": {
      "asset_type": "image",
      "content_type": "image/png",
      "image": "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAGAAAABgCAYAAADimHc4AAADUElEQVR4nO2du24TQRSGz7GTcJNoKKhNmxJRJEgpSEMB5BWCuJRQwwNAC5QgxDNwaaGIBFSUafET0CCBUBLv8M8iy143eHdG56x3/08a79mVnMjzzf0Uq0JcoQBnKMAZCnCGApyhAGcowBkKcCa7gHD5/lk5HUYSigso5/Fo9dHBT5Qf8kfH+u3lbzzJRlYB4eq9TSlORgi7y2BtrJ9fHSLKgqJkIWzf2elMi/8f6BH65fUBomSyCOhFy18kU09QlCTKMX/j+BrC/nG0/il1TkgX0MfWPyVDL1CUJHo19i+SYS5IF7B1+wYuvUW/vvmAS2MoIBEKcIYCnKEAZ1wExLX/8amjzfUwxOqnOINHvcVcQKz8k42jnTXRNdz2HnsB2/tXJOhFhASYCzje2r/O1j/DXECAAHwti4Ai6C3VsCtBLuHWHpXvQfTdQMJH3DXCXkCOIWgwPBeKyRO3il8EInQwfCzF5BfuamEvAJOwYBLGVxv3giDyHB/tqPwpUYLIQ0S1MBcQKSVgGSqh/jK0CLKHf3oXYetQ1Wf4dbWGIxcB89TdiLWy9U9p0AtWT0CQ97i0FlW5icvSUEBmKMAZCnCGApyhAGd6IEBf4HOEsIXoGEcjDxAsjYuAuBFrmg/gRqwK6qIesfJT8wHt7AX1W3/EXkCuw7hJ8RR/bYS7FqBjHQ4ercRhXN58gO5iUt4TNxGoeJW3UnPYmcdcQM58QBewF5BjCOoQ9gIwCafmA7qEuYBIKQHL0Cb5gK7hImCeuhuxrkEBzlCAMxTgDAU4QwHOUIAzFOCMi4C4EWuaD+ga5gJi5afmA7qEvQAexlUwF5A3H7D6mAtgPqCKvQAOQRXsBWASZj5ghrmASCkBy1DmA1CBHgLm4UaMAlyhAGcowBkKcIYCnKEAZyjAGRcBcSPGfMA/zAXEymc+YIa9AB7GVTAXwHxAFXMBzAdUsRfAIaiCvQBMwswHzDAXECklYBnKfAAq0EPAPNyIUYArFOAMBThDAc74C+ArTA4QNSZdAF/ic4ioMYqSRLkn4GusGpMsINLLXpCh9UcUJQu9mgsyjP1TsgmI9KInZGr5UxQlK+WcwNfZLk12AaQeFOAMBThDAc5QgDMU4AwFOEMBzvwFZ2X4cPE61SUAAAAASUVORK5CYII="
    },
    "solar--server-square-cloud-bold-duotone_1_": {
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
    },
    "melonly-openapi-logo": {
      "asset_type": "image",
      "content_type": "image/png",
      "image": "data:image/png;base64,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"
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
<img width="897" height="733" alt="image" style="border-radius: 12px;" src="https://github.com/user-attachments/assets/7db8f9d9-de4a-4946-a5eb-619a030f37e0" />
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

