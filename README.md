# OldPhoneKeyPad – C# Coding Challenge

## Overview
This project is an implementation of an **old mobile phone keypad parser**, where numeric key presses are converted into text based on classic multi-press keypad rules.

The solution is written in **C#** with a strong focus on:
- Clean, readable code
- Robust handling of edge cases
- Automated unit testing

---

## Features
- Converts numeric keypad input into text output
- Supports multi-press character cycling (e.g. `222` → `C`)
- Handles pause between same keys using space (` `)
- Supports backspace (`*`)
- Supports send/termination key (`#`)
- Safely ignores invalid or non-digit characters
- Handles missing `#` or `#` appearing in the middle of input
- Fully covered by automated unit tests

---

## Example Inputs

| Input                         | Output   |
|------------------------------|----------|
| `33#`                        | `E`      |
| `227*#`                      | `B`      |
| `4433555 555666#`            | `HELLO`  |
| `8 88777444666*664#`         | `TURING` |

---

## Project Structure

```text
OldPhoneKeyPad
├── OldPhoneKeyPad
│   ├── OldPhoneKeyPad.cs
│   └── Program.cs
├── TestProject
│   └── OldPhonePadShould.cs
└── OldPhoneKeyPad.sln
