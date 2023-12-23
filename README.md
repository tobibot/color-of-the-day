# color-of-the-day


## Introduction

We have smart outdoor lighting. Our son wanted it to shine in different colors, not just yellow-white. He was allowed to choose a different color for each day of the week, and this is the color that shines outside, controlled via [Home Assistant](https://www.home-assistant.io/). However, since we want to involve our many neighbors and passers-by in the color selection, I want to create a simple website. In the first step, you should be able to participate in the vote for the color of the following day. Participation will be available with scanning a QR-Code.

The project will consist of three parts: A website, a web API, and "some kind of storage".

On the other hand, the value is loaded and applied in Home Assistant via the API.

## Previous color selection

This is the automation script:

```[yaml]
alias: 💡💡💡 Set light of the day 💡💡💡
description: ""
trigger:
  - platform: time
    at: "00:00:00"
condition: []
action:
  - service: input_text.set_value
    data:
      entity_id: input_text.color_of_the_day
      value: |
        {% set color_map = {
            'mon': 'orange',
            'tue': 'magenta',
            'wed': 'yellow',
            'thu': 'green',
            'fri': 'lightblue',
            'sat': 'red',
            'sun': 'darkblue'
          } %}
        {{ color_map[now().strftime('%a').lower()] }}
mode: single
```