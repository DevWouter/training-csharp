// Explain partial keyword (Part 2/2)
//   My personal opinion is that the partial keyword is often (but not always) a bad design choice.
//   It is used to split a class over multiple files and the only reason to do so is because all
//   the code in a single file is too much. In this example we don't split the class over multiple
//   files, but we split the class over multiple snippets. This is because we want to show the what
//   happens.
//
// Part 1: Has all code in one file
// Part 2: Has all code in multiple files

Store shop = new Store(1, "Microsoft");
shop.PrintIntroduction();