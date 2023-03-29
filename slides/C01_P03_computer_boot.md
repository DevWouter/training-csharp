<!-- .slide: data-background-image="images/C01/john-smit-hRI8f-2WyDw-unsplash.jpg" -->
# What happens when you press the power button?

---

## Step by step

* CPU executes a hardcoded `JUMP` instruction to the first instructions on a ROM
* CPU starts executing BIOS directly from ROM
* BIOS loads bootloader from disk into RAM
* Bootloader loads OS kernel into RAM and hands over control

notes: The BIOS is the very first application that is always run on the machine.

---

## Terms

* BIOS: Basic Input/Output System
* CPU: Central Processing Unit
* ROM: Read-Only Memory
* RAM: Random Access Memory
* OS: Operating System