# C# Training

This repository contains the slides and exercises for the C# training.

## Slides

```
cd slides
npm install
npm run start
```

Then you will be able to access the slides at http://localhost:8000

- Press `?` to see all the keys.
- Press `o` to get an overview of all the slides (useful if you need to find a slide).
- Press `s` to open the speaker notes (you might get a pop-up warning).
- Press `f` to enter/exit fullscreen mode
- Press `b` to black-out the screen (useful if you need to hide the slides from the audience so that they focus on you).

Each chapter has its own file. Chapter 1 is `http://localhost:8000/C01.html` and chapter 2 is `http://localhost:8000/02.html` and so on.
The index file `http://localhost:8000/index.html` contains a list of all the chapters.

## Code

In the `src` folder you will find the code for all the demos and exercises.

### Organization

- The `scratch` project is a blank project that you can use to try out things or demonstrate something.
- Projects start with a `C01_` prefix which means that they are part of chapter 1 and thus a project prefixed with `C99` means that they are part of chapter 99.
- After the chapter prefix you can have `D01` for demo (example: `C01_D01` is the first demo of chapter 1).
    - Demos can be postfixed with `P1` which means that the demo was split over multiple projects.
- After the chapter prefix you can have `L01` for lab (example: `C01_L01` is the first lab of chapter 1).
    - There is always one lab that has `P` after it (example: `C01_L01P`) which is the lab that contains the "Problem".
    - If a lab has an `S` after it (example: `C01_L01S`) it means that it is the solution to the problem.
    - If a lab has multiple solved states, it will be postfixed with `P1` behind it (example: `C01_L01S_HelloWorld_P1`). The higher the number, the more advanced the solution is.
- The first chapters will only consist out of `Program.cs` files. Later chapters will have multiple files.
- All labs have comments that explain what the trainee has to do.
- **NOTE**: Don't wait with all the labs until the end of the chapter.

## Docs

In the `docs` folder you will find additional documentation that is not intended to be shown/used during the training itself. 

## Advice

- Learning is done by observing, doing and reflecting.
    - Observing: Show them what you are doing.
    - Doing: Let them do it themselves.
    - Reflecting: Ask (or tell) them what they have learned.
- The trainee should always be able to see what you are doing
    - Share your screen
    - Slow down (how much? It depends, but a safe bet is to keep slowing down until they ask you to speed up)
- Don't depend on the slides or the code too much
    - A teacher should be able to teach without slides or code.