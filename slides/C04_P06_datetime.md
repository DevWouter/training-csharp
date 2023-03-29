# Date & time
---

## Date & time

Two builtin types for date and time:
* `DateTime`
* `TimeSpan`

---

## `DateTime`

* Time
* Date (must be valid)
* Kind (local, UTC, unspecified)

notes: Fun fact, dates before 1 January 0001 are not valid. Also year 0 never existed. And some dates happend twice.
19 nov 1594 happend twice in Groningen: https://nl.wikipedia.org/wiki/Overgangskalender_van_1594

---

## `TimeSpan`

* Describes duration of time
* Can be negative
* Days, hours, minutes, seconds, milliseconds
* No months or years
