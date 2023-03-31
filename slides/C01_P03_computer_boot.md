<!-- .slide: data-background-image="images/C01/john-smit-hRI8f-2WyDw-unsplash.jpg" -->
# What happens when you press the power button?

---

## Step by step

* CPU executes a hardcoded `JUMP` instruction to the first instructions on a ROM for the BIOS
* BIOS loads bootloader from disk into RAM and `JUMP` to the first instruction in the bootloader
* Bootloader loads OS kernel into RAM and `JUMP` to the first instruction in the OS kernel

notes: 
- The BIOS is the very first application that is always run on the machine.
- BIOS: Basic Input/Output System
